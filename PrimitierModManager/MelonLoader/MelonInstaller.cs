using MelonLoader;
using MelonLoader.Tomlyn;
using MelonLoader.Tomlyn.Model;
using MelonLoader.Tomlyn.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager.MelonLoader
{
    public static class MelonLoaderVersions
	{
        public static readonly string V0_5_3 = "v0.5.3";


    }
    

	public static class MelonInstaller
	{
        public static string MelonLoaderUpdateSourceUri = "https://github.com/LavaGang/MelonLoader/releases/download";
        private static string[] s_proxyNames = { "version", "winmm", "winhttp" };
        private static WebClient s_webClient;

        public static string Status;
        public static string Error;



        public static void Uninstall(string destination)
        {
            Status = "";
            Error = "";

            Status = "Uninstalling MelonLoader...";
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

                            Error = $"Unable to remove Existing MelonLoader Folder! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                            return;
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

                            Error = $"Unable to remove Existing Proxy Module! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                            return;
                        }
                    });
                }
                ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                {
                    try { ExtraCleanupCheck(destination); }
                    catch (Exception ex)
                    {
                        if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                            && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                            throw ex;

                        Error = $"Couldn't do Extra File Cleanup! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                        return;
                    }
                });

                ExtraCleanupCheck(destination);

				//Remove Mods/Plugins folder

				try
				{
                    Directory.Delete(Path.Combine(destination, "Mods"), true);
                    Directory.Delete(Path.Combine(destination, "Plugins"), true);
                    Directory.Delete(Path.Combine(destination, "UserData"), true);
                    Directory.Delete(Path.Combine(destination, "UserLibs"), true);
                }
                catch (Exception ex)
				{

				}


            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return;
            }
        }



        public static void Install(string destination, string selected_version, bool is_x86, bool legacy_version)
        {


            Status = "";
            Error = "";

            Status = "Downloading MelonLoader...";
            string downloadurl = MelonLoaderUpdateSourceUri + "/" + selected_version + "/MelonLoader." + ((!legacy_version && is_x86) ? "x86" : "x64") + ".zip";
            string temp_path = TempFileCache.CreateFile();
           
            if (s_webClient == null)
			{
                s_webClient = new WebClient();
            }
            
            try { s_webClient.DownloadFileAsync(new Uri(downloadurl), temp_path); while (s_webClient.IsBusy) { } }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return;
            }

            string repo_hash_url = MelonLoaderUpdateSourceUri + "/" + selected_version + "/MelonLoader." + ((!legacy_version && is_x86) ? "x86" : "x64") + ".sha512";
            string repo_hash = null;
            try { repo_hash = s_webClient.DownloadString(repo_hash_url); } catch { repo_hash = null; }
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
                Error = "SHA512 Hash from Temp File does not match Repo Hash!";
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
                            Error = $"Unable to remove Existing MelonLoader Folder! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                            return;
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

                            Error = $"Unable to remove Existing Proxy Module! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                            return;
                        }
                    });
                }
                using FileStream stream = new FileStream(temp_path, FileMode.Open, FileAccess.Read);
                using ZipArchive zip = new ZipArchive(stream);
                int total_entry_count = zip.Entries.Count;
                for (int i = 0; i < total_entry_count; i++)
                {


                    ZipArchiveEntry entry = zip.Entries[i];
                    string fullPath = Path.Combine(destination, entry.FullName);
                    if (!fullPath.StartsWith(destination))
                        throw new IOException("Extracting Zip entry would have resulted in a file outside the specified destination directory.");
                    string filename = Path.GetFileName(fullPath);
                    if (filename.Length != 0)
                    {
                        if (!legacy_version && filename.Equals("version.dll"))
                        {
                            foreach (string proxyname in s_proxyNames)
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

                                Error = $"Couldn't extract file {filename}! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                                return;
                            }
                        });
                        continue;
                    }
                    if (entry.Length != 0)
                        throw new IOException("Zip entry name ends in directory separator character but contains data.");
                    if (!Directory.Exists(fullPath))
                        Directory.CreateDirectory(fullPath);
                }

                ExtraDirectoryChecks(destination);
                ThreadHandler.RecursiveFuncRun(delegate (ThreadHandler.RecursiveFuncRecurse recurse)
                {
                    try { ExtraCleanupCheck(destination); }
                    catch (Exception ex)
                    {
                        if (!ex.GetType().IsAssignableFrom(typeof(UnauthorizedAccessException))
                            && !ex.GetType().IsAssignableFrom(typeof(IOException)))
                            throw ex;

                        Error = $"Couldn't do Extra File Cleanup! Make sure the Unity Game is not running or try running the Installer as Administrator.";
                        return;
                    }
                });
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return;
            }

            TempFileCache.ClearCache();
        }


        private static bool GetExistingProxyPath(string destination, out string proxy_path)
        {
            proxy_path = null;
            foreach (string proxy in s_proxyNames)
            {
                string new_proxy_path = Path.Combine(destination, (proxy + ".dll"));
                if (!File.Exists(new_proxy_path))
                    continue;
                FileVersionInfo fileinfo = FileVersionInfo.GetVersionInfo(new_proxy_path);
                if (fileinfo == null)
                    continue;
                if (!string.IsNullOrEmpty(fileinfo.LegalCopyright) && fileinfo.LegalCopyright.Contains("Microsoft"))
                    continue;
                proxy_path = new_proxy_path;
                break;
            }
            return !string.IsNullOrEmpty(proxy_path);
        }

        private static void ExtraDirectoryChecks(string destination)
        {
            string pluginsDirectory = Path.Combine(destination, "Plugins");
            if (!Directory.Exists(pluginsDirectory))
                Directory.CreateDirectory(pluginsDirectory);
            string modsDirectory = Path.Combine(destination, "Mods");
            if (!Directory.Exists(modsDirectory))
                Directory.CreateDirectory(modsDirectory);
            string userdataDirectory = Path.Combine(destination, "UserData");
            if (!Directory.Exists(userdataDirectory))
                Directory.CreateDirectory(userdataDirectory);
        }
        private static void ExtraCleanupCheck(string destination)
        {
            string main_dll = Path.Combine(destination, "MelonLoader.dll");
            if (File.Exists(main_dll))
                File.Delete(main_dll);
            main_dll = Path.Combine(destination, "Mods", "MelonLoader.dll");
            if (File.Exists(main_dll))
                File.Delete(main_dll);
            main_dll = Path.Combine(destination, "Plugins", "MelonLoader.dll");
            if (File.Exists(main_dll))
                File.Delete(main_dll);
            main_dll = Path.Combine(destination, "UserData", "MelonLoader.dll");
            if (File.Exists(main_dll))
                File.Delete(main_dll);
            string main2_dll = Path.Combine(destination, "MelonLoader.ModHandler.dll");
            if (File.Exists(main2_dll))
                File.Delete(main2_dll);
            main2_dll = Path.Combine(destination, "Mods", "MelonLoader.ModHandler.dll");
            if (File.Exists(main2_dll))
                File.Delete(main2_dll);
            main2_dll = Path.Combine(destination, "Plugins", "MelonLoader.ModHandler.dll");
            if (File.Exists(main2_dll))
                File.Delete(main2_dll);
            main2_dll = Path.Combine(destination, "UserData", "MelonLoader.ModHandler.dll");
            if (File.Exists(main2_dll))
                File.Delete(main2_dll);
            string logs_path = Path.Combine(destination, "Logs");
            if (Directory.Exists(logs_path))
                Directory.Delete(logs_path, true);
        }

    }
}
