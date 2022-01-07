using PrimitierModdingFramework;
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

			var list = GameObject.FindObjectsOfType<CubeBase>();
			for (int i = 0; i < list.Count; i++)
			{
				LoggerInstance.Msg("cubeBase");
				LoggerInstance.Msg("name:"+list[i].name);
				LoggerInstance.Msg("parent:" + list[i].transform.parent.name);
			} 
			
			//for (int i = 0; i < 500; i++)
			//{
			//	SpawnCube();
			//}
			
		}
		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			LoggerInstance.Msg("logging test");
			
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
