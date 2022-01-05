using PrimitierModdingFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod
{
    public class DemoMod : PrimitierMod
    {

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);

			
			for (int i = 0; i < 200; i++)
			{
				SpawnCube();
			}
			
		}

		private static void SpawnCube()
		{
			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(0, 5, 0);
			cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			
			cube.GetComponent<MeshRenderer>().material.color = UnityEngine.Random.ColorHSV(0, 1, 0, 1, 0, 1);

			cube.AddComponent<Rigidbody>();
		}


	}
}
