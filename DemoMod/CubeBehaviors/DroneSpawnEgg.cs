using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CubeBehaviors
{
	public class DroneSpawnEgg : MonoBehaviour, ICustomCubeBehaviour
	{

		public DroneSpawnEgg(System.IntPtr ptr) : base(ptr) {}


		private CubeBase _cubeBase;


		private void Start()
		{
			_cubeBase = GetComponent<CubeBase>();
			
			if (transform.localScale.x >= 0.1f &&
				transform.localScale.y >= 0.1f &&
				transform.localScale.z >= 0.1f)
			{
				_cubeBase.add_Splitted(new System.Action<Il2CppSystem.Object, Il2CppSystem.EventArgs>(OnSplited));
			}
			
		}

		private void OnSplited(Il2CppSystem.Object sender, Il2CppSystem.EventArgs args)
		{
			CubeGenerator.GenerateDrone(transform.position, 0.5f);
		}


		public void OnCollideWithCube(CubeBase colCubeBase)
		{
			
		}

		public void OnFragmentInitialized(CubeBase fragmentCubeBase)
		{
			
		}
	}
}
