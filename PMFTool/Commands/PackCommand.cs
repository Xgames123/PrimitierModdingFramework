using Cocona;
using PMFTool.Validators;
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
			[Argument(Description = "The path to the directory with the dll files of the mod you want to pack or an alias if you have setup one")]
			string path,
			[Option(Description = "The directory to put the generated file into")]
			string outputDir,

			[Option(Description = "The format to generate the package in")]
			PackFormat format=PackFormat.Pmfm,

			[Option(Description = "The path to the PMFToolConfig.json file")]
			string config="PMFToolConfig.json")
		{
			var configClass = ConfigFileLoader.Load(config);

			path = AliasSolver.Solve(path, RunMode.Release, configClass);


		
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
				var generatedProxyDllPath = Path.Combine(Path.GetDirectoryName(configClass.PrimitierPath), "MelonLoader", "Managed");
				
				var files = Directory.GetFiles(generatedProxyDllPath);
				ignoreFiles = new string[files.Length];
				for (int i = 0; i < files.Length; i++)
				{
					ignoreFiles[i] = Path.GetFileName(files[i]);
					ConsoleWriter.WriteLineStatus($"Ignoring file '{ignoreFiles[i]}'");
				}

			}



			foreach (var file in Directory.GetFiles(path))
			{
				if (file.EndsWith(".pdb") || file.EndsWith(".xml"))
				{
					continue;
				}

				if (format == PackFormat.Pmfm)
				{
					if (ignoreFiles.Contains(Path.GetFileName(file)))
					{
						continue;
					}
				}

				zip.CreateEntryFromFile(file, Path.GetFileName(file));
				ConsoleWriter.WriteLineStatus($"Packing '{file}'");
			}

			zip.Dispose();
			stream.Close();

			ConsoleWriter.WriteLineStatus("== Done ==");

		}


	}
}
