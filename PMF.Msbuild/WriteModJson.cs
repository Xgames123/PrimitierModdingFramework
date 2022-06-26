using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;

namespace PMF.Msbuild
{
	public class WriteModJson : Task
	{
		/// <summary>
		/// Path were to write the mod.json
		/// </summary>
		[Required]
		public string Path { private get; set; }

		[Required]
		public string DisplayName { private get; set; }
		public string Authors { private get; set; } = "";
		public string Description { private get; set; } = "";
		public string Version { private get; set; } = "1.0";

		private const string TemplateModJson = "{'DisplayName':'DISPLAY_NAME','Authors':'AUTHORS','Description':'DESCRIPTION','Version':'VERSION'}";

		public override bool Execute()
		{
			var output = TemplateModJson.Replace("DISPLAY_NAME", DisplayName).Replace("AUTHORS", Authors).Replace("DESCRIPTION", Description).Replace("VERSION", "V"+Version);

			try
			{
				File.WriteAllText(Path, output);
			}catch(Exception e)
			{
				Log.LogError("Can not write {Path} file. (Auto generating Mod.json can be disabled by setting AutoGenerateModJson to false) Exception: {e}", Path, e);
				return false;
			}
			

			return true;
		}
	}
}
