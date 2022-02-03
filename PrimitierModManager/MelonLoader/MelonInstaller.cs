using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager.MelonLoader
{
	public static class MelonInstaller
	{
        private static string Download_MelonLoader = "https://github.com/LavaGang/MelonLoader/releases/download";

        public static WebClient WebClient;
        public static string Status;
        public static string Error;





        private static void Automated_Install(string destination, string selected_version, bool is_x86, bool legacy_version)
        {
            Status = "Downloading MelonLoader...";
            string downloadurl = Download_MelonLoader + "/" + selected_version + "/MelonLoader." + ((!legacy_version && is_x86) ? "x86" : "x64") + ".zip";
            string temp_path = TempFileCache.CreateFile();
           
            if (WebClient == null)
			{
                WebClient = new WebClient();
            }
            
            try { WebClient.DownloadFileAsync(new Uri(downloadurl), temp_path); while (WebClient.IsBusy) { } }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return;
            }

            string repo_hash_url = Download_MelonLoader + "/" + selected_version + "/MelonLoader." + ((!legacy_version && is_x86) ? "x86" : "x64") + ".sha512";
            string repo_hash = null;
            try { repo_hash = WebClient.DownloadString(repo_hash_url); } catch { repo_hash = null; }
            if (string.IsNullOrEmpty(repo_hash))
            {
                Error = "Failed to get SHA512 Hash from Repo!";
                return;
            }

            SHA512Managed sha512 = new SHA512Managed();
            byte[] checksum = sha512.ComputeHash(File.ReadAllBytes(temp_path));
            if ((checksum == null) || (checksum.Length <= 0))
            {
                Error = "Failed to get SHA512 Hash from Temp File!";
                return;
            }
            string file_hash = BitConverter.ToString(checksum).Replace("-", string.Empty);
            if (string.IsNullOrEmpty(file_hash))
            {
                Error = "Failed to get SHA512 Hash from Temp File!";
                return;
            }
            if (!file_hash.Equals(repo_hash))
            {
                Error = ("SHA512 Hash from Temp File does not match Repo Hash!";
                return;
            }
            Status = "Extracting MelonLoader...";
            try
            {
                string MelonLoader_Folder = Path.Combine(destination, "MelonLoader");
                if (Directory.Exists(MelonLoader_Folder))
                {
                    ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                    {
                        try { Directory.Delete(MelonLoader_Folder, true); }
                        catch (Exception ex)
                        {
                            if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                                && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                                throw ex;
                            DialogResult result = MessageBox.Show($"Unable to remove Existing MelonLoader Folder! Make sure the Unity Game is not running or try running the Installer as Administrator.", BuildInfo.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Retry) recurse.Invoke(); else throw ex;
                        }
                    });
                }
                string proxy_path = null;
                if (GetExistingProxyPath(destination, out proxy_path))
                {
                    ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                    {
                        try { File.Delete(proxy_path); }
                        catch (Exception ex)
                        {
                            if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                                && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                                throw ex;
                            DialogResult result = MessageBox.Show($"Unable to remove Existing Proxy Module! Make sure the Unity Game is not running or try running the Installer as Administrator.", BuildInfo.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Retry) recurse.Invoke(); else throw ex;
                        }
                    });
                }
                using FileStream stream = new FileStream(temp_path, FileMode.Open, FileAccess.Read);
                using ZipArchive zip = new ZipArchive(stream);
                int total_entry_count = zip.Entries.Count;
                for (int i = 0; i < total_entry_count; i++)
                {
                    if (Program.Closing)
                        break;
                    int percentage = ((i / total_entry_count) * 100);
                    Program.SetCurrentPercentage(percentage);
                    Program.SetTotalPercentage((50 + (percentage / 2)));
                    ZipArchiveEntry entry = zip.Entries[i];
                    string fullPath = Path.Combine(destination, entry.FullName);
                    if (!fullPath.StartsWith(destination))
                        throw new IOException("Extracting Zip entry would have resulted in a file outside the specified destination directory.");
                    string filename = Path.GetFileName(fullPath);
                    if (filename.Length != 0)
                    {
                        if (!legacy_version && filename.Equals("version.dll"))
                        {
                            foreach (string proxyname in ProxyNames)
                            {
                                string new_proxy_path = Path.Combine(destination, (proxyname + ".dll"));
                                if (File.Exists(new_proxy_path))
                                    continue;
                                fullPath = new_proxy_path;
                                break;
                            }
                        }
                        string directorypath = Path.GetDirectoryName(fullPath);
                        if (!Directory.Exists(directorypath))
                            Directory.CreateDirectory(directorypath);
                        using FileStream targetStream = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Write);
                        using Stream entryStream = entry.Open();
                        ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                        {
                            try { entryStream.CopyTo(targetStream); }
                            catch (Exception ex)
                            {
                                if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                                    && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                                    throw ex;
                                DialogResult result = MessageBox.Show($"Couldn't extract file {filename}! Make sure the Unity Game is not running or try running the Installer as Administrator.", BuildInfo.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                if (result == DialogResult.Retry) recurse.Invoke(); else throw ex;
                            }
                        });
                        continue;
                    }
                    if (entry.Length != 0)
                        throw new IOException("Zip entry name ends in directory separator character but contains data.");
                    if (!Directory.Exists(fullPath))
                        Directory.CreateDirectory(fullPath);
                }
                ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                {
                    try { DowngradeMelonPreferences(destination, legacy_version); }
                    catch (Exception ex)
                    {
                        if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                            && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                            throw ex;
                        DialogResult result = MessageBox.Show($"Unable to Downgrade MelonLoader Preferences! Make sure the Unity Game is not running or try running the Installer as Administrator.", BuildInfo.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry) recurse.Invoke(); else throw ex;
                    }
                });
                ExtraDirectoryChecks(destination);
                ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                {
                    try { ExtraCleanupCheck(destination); }
                    catch (Exception ex)
                    {
                        if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                            && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                            throw ex;
                        DialogResult result = MessageBox.Show($"Couldn't do Extra File Cleanup! Make sure the Unity Game is not running or try running the Installer as Administrator.", BuildInfo.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry) recurse.Invoke(); else throw ex;
                    }
                });
            }
            catch (Exception ex)
            {
                Program.LogError(ex.ToString());
                return;
            }
            if (Program.Closing)
                return;
            TempFileCache.ClearCache();
            Program.OperationSuccess();
            Program.FinishingMessageBox((CurrentOperationName + " was Successful!"), MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
