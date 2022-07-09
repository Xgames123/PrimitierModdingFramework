using Newtonsoft.Json;
using PrimitierModdingFramework;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CubeBehaviors
{
	public class SaveFileTestingObject : MonoBehaviour, ICustomCubeBehaviour
	{
		public Color value;

		private CubeBase cubeBase;
		private void Start()
		{
			GetComponent<MeshRenderer>().material.color = value;
			cubeBase = GetComponent<CubeBase>();
		}
		private void OnDestroy()
		{
			CustomWorldDataSystem.StoreCubeBehaviourData(cubeBase, nameof(SaveFileTestingObject), JsonConvert.SerializeObject(value));
		}

		public void OnCollideWithCube(CubeBase colCubeBase)
		{
			
		}

		public void OnFragmentInitialized(CubeBase fragmentCubeBase)
		{
			
		}

	
	}
}
