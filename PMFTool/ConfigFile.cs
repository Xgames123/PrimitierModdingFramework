using Newtonsoft.Json;
using PMFTool.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public record struct Alias
	{
		public Alias(string name, string value, RunMode? runMode=null)
		{
			Name = name;
			Value = value;
			RunMode = runMode;
		}

		[JsonProperty(Required = Required.Always)] public string Name;
		[JsonProperty(Required = Required.Always)] public string Value;
		[JsonProperty(Required = Required.DisallowNull)] public RunMode? RunMode=null;

	}

	public class ConfigFile
	{

		[JsonProperty(Required = Required.DisallowNull)] public string PrimitierPath = "";

		[JsonProperty(Required = Required.DisallowNull)] public List<Alias> Aliases = new List<Alias>();


	}
}
