using PrimitierModdingFramework.Debugging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;

namespace PrimitierModdingFramework.Internals
{
	internal class PMFTypeInjector : PMFSystem
	{

		public override void OnApplicationStart()
		{
			base.OnApplicationStart();


			ClassInjector.RegisterTypeInIl2Cpp<PMFButton>();
			ClassInjector.RegisterTypeInIl2Cpp<InGameDebugTool>();
			

		}

	}
}
