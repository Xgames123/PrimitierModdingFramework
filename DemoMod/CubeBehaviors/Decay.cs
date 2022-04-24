using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CubeBehaviors
{
	public class Decay : MonoBehaviour, ICustomCubeBehaviour
	{

		private CubeBase cubeBase;

		private int _tickCount = 0;

		public Decay(System.IntPtr ptr) : base(ptr)
		{

		}

		private void Start()
		{
			cubeBase = GetComponent<CubeBase>();
		}

		private void FixedUpdate()
		{
			_tickCount++;
			if (_tickCount > 10)
			{
				_tickCount = 0;
				Tick();
			}
		}
		private void Tick()
		{
			
			cubeBase.ChangeScale(cubeBase.transform.localScale - new Vector3(0.001f, 0.001f, 0.001f));
			
			if (cubeBase.transform.localScale.magnitude < 0.1f)
			{
				cubeBase.ChangeSubstance(Substance.Stone);
				Destroy(this);
			}

			cubeBase.heat.AddHeat(10000);

		
		}


		public void OnFragmentInitialized(CubeBase fragmentCubeBase)
		{

		}
		public void OnCollideWithCube(CubeBase colCubeBase)
		{

		}
	}
}
