using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebuggingSystem : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}

		public override void OnStart()
		{
			EnableSystem<PMFHelper>();

			ClassInjector.RegisterTypeInIl2Cpp<InGameDebugMenu>();
			ClassInjector.RegisterTypeInIl2Cpp<InGameDebugTool>();
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<InGameDebugToolButton>(typeof(IButton));
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<InGameDebugToolShowButton>(typeof(IButton));
			
		}

		public override void OnSceneLoad()
		{
			InGameDebugTool.Create();
			InGameDebugToolShowButton.Create();
		}



	}
}
