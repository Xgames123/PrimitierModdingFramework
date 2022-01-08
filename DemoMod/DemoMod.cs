using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

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
			
			if (Input.GetKeyUp(KeyCode.A))
			{
				CubeGenerator.GenerateCube(PlayerHelper.CameraRig.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf);
			}

			
		}



	}
}
