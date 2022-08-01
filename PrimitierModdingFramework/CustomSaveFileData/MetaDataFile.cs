using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public class MetaDataFile
	{
		public List<ModMetaData> Mods = new List<ModMetaData>();

	}


	public class ModMetaData
	{
		public string Id;
		public List<SubstanceToIndexMap> SubstanceToIndexMaps = new List<SubstanceToIndexMap>();
		

	}

	public class SubstanceToIndexMap
	{
		public string Name;
		public int Index;
	}

}
