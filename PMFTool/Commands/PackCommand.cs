using Cocona;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{

	public enum PackFormat
	{
		Zip,
		Pmfm
	}


	public class PackCommand
	{
		[PrimaryCommand]
		public void Pack(
			[Argument(Description = "The path to the directory of the mod you want to pack")]
			string path="",
			[Option(Description = "The directory to put the generated file into")]
			string outputDir="",

			[Option(Description = "The format to generate the package in")]
			PackFormat format=PackFormat.Pmfm)
		{
			
			var config = ConfigFileLoader.LoadMergedConfig();

			if (!File.Exists(config.PrimitierPath))
			{
				ConsoleWriter.WriteLineError($"Could not find primitier exe'{config.PrimitierPath}'");
				return;
			}

			if (path == "")
			{
				path = Environment.CurrentDirectory;
			}
			path = Path.GetFullPath(path);

			if (config.ReleaseBinPath != "")
			{
				path = Path.Combine(path, config.ReleaseBinPath);
			}
			

			if (outputDir != "")
			{
				Directory.CreateDirectory(outputDir);
			}
	

			var extention = ".zip";
			if (format == PackFormat.Pmfm)
				extention = ".pmfm";
			else if (format == PackFormat.Zip)
				extention = ".zip";
			var outputFile = Path.Combine(outputDir, "Packed" + extention);

			
			var stream = File.Create(outputFile);
			var zip = new ZipArchive(stream, ZipArchiveMode.Create, true);


			string[] ignoreFiles = Array.Empty<string>();
			if (format == PackFormat.Pmfm)
			{
				var generatedProxyDllPath = Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "Managed");
				
				if (!Directory.Exists(generatedProxyDllPath))
				{
					ConsoleWriter.WriteLineError($"'{generatedProxyDllPath}' doesn't exist. This could be because MelonLoader is not installed properly");
					return;
				}


				var files = Directory.GetFiles(generatedProxyDllPath);
				ignoreFiles = new string[files.Length];
				for (int i = 0; i < files.Length; i++)
				{
					ignoreFiles[i] = Path.GetFileName(files[i]);
				}

			}


			if(!Directory.Exists(path))
			{
				ConsoleWriter.WriteLineError($"dir '{path}' doesn't exist");
				return;
			}

			
			int PackedFileCount = 0;
			foreach (var file in Directory.GetFiles(path))
			{
				if (file.EndsWith(".pdb") || file.EndsWith(".xml"))
				{
					ConsoleWriter.WriteLineStatus($"Ignoring file '{file}'");
					continue;
				}

				if (format == PackFormat.Pmfm)
				{
					if (ignoreFiles.Contains(Path.GetFileName(file)))
					{
						ConsoleWriter.WriteLineStatus($"Ignoring file '{file}'");
						continue;
					}
				}

				zip.CreateEntryFromFile(file, Path.GetFileName(file));
				ConsoleWriter.WriteLineStatus($"Packing '{file}'");
				PackedFileCount++;
			}
			if (PackedFileCount == 0)
			{
				ConsoleWriter.WriteLineError("There are no files to packed (You are probably in the wrong directory)");
			}

			zip.Dispose();
			stream.Close();

			ConsoleWriter.WriteLineStatus("== Done ==");

		}


	}
}
