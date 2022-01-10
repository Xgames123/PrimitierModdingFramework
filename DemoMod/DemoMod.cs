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
		

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);

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




			


		}



	}
}
