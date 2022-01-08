using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

namespace DemoMod
{
    public class DemoMod : PrimitierMod
    {
		private InGameDebugTool _InGameDebugTool;

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);
			_InGameDebugTool = null;


		}

		public override void OnRegisterCustomTypes()
		{
			base.OnRegisterCustomTypes();
			ClassInjector.RegisterTypeInIl2Cpp<InGameDebugTool>();
		}


		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			
		}
		public override void OnUpdate()
		{
			base.OnUpdate();

			DebugTools.Update(LoggerInstance);
			
		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();
			if (PlayerHelper.CameraRig != null && _InGameDebugTool == null)
			{
				_InGameDebugTool = InGameDebugTool.Spawn(PlayerHelper.CameraRig.position);
			}



		}



	}
}
