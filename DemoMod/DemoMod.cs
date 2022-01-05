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

		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

			//cube.AddComponent<Rigidbody>();

		}


	}
}
