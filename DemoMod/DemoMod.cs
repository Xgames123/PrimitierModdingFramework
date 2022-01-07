using PrimitierModdingFramework;
using PrimitierModdingFramework.Debug;
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

		
			
			//for (int i = 0; i < 500; i++)
			//{
			//	SpawnCube();
			//}
			
		}
		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			
		}
		public override void OnUpdate()
		{
			base.OnUpdate();

			if (Input.GetKeyDown(KeyCode.Space))
			{
				HierarchyXmlDumper.DumpCurrentScene();
			}

		}


		private static void SpawnCube()
		{
			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(0, 50, 0);
			cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			
			cube.GetComponent<MeshRenderer>().material.color = UnityEngine.Random.ColorHSV(0, 1, 0, 1, 0, 1);
			cube.AddComponent<Leaf>();
			var cubeBase = cube.AddComponent<CubeBase>();
			var rb = cube.AddComponent<Rigidbody>();

			cubeBase.substance = Substance.Leaf;
			cubeBase.rb = rb;



		}


	}
}
