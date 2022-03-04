using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public class ConfigFile
	{

		[JsonProperty(Required = Required.DisallowNull)] public string PrimitierPath = "";



	}
}
