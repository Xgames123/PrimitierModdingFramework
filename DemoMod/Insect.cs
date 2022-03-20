using PrimitierModdingFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod
{
	public class Insect : MonoBehaviour
	{

		private CubeBase cubeBase;
		
		public Insect(System.IntPtr ptr) : base(ptr)
		{

		}

		private void Start()
		{
			cubeBase = gameObject.GetComponent<CubeBase>();
			

		}

		private void FixedUpdate()
		{

			cubeBase.rb.AddRelativeForce(Vector3.up *(cubeBase.rb.mass * Mathf.Abs(Physics.gravity.y)));

			
		}


		public void OnFragmentInitialized(CubeBase fragmentCubeBase)
		{
			
		}
		public void OnCollideWithCube(CubeBase colCubeBase) 
		{
			
		}


		public static void Generate(Vector3 pos)
		{
			const float BodyThickness = 0.02f;
			const float BodyLength = 0.1f;
			const float WingLength = 0.1f;
			const float WingThickness = 0.01f;
			const float WingXSize = 0.05f;

			var body = ObjectGenerationSystem.GenerateCube(pos, new Vector3(BodyLength, BodyThickness, BodyThickness), Substance.AncientPlastic);

			body.AddComponent<Insect>();

			var wing1 = ObjectGenerationSystem.GenerateCube(pos + new Vector3(0, 0, BodyThickness/2+WingLength/2), new Vector3(WingXSize, WingThickness, WingLength), Substance.DryGrass);
			var wing2 = ObjectGenerationSystem.GenerateCube(pos + new Vector3(0, 0, -(BodyThickness / 2 + WingLength / 2)), new Vector3(WingXSize, WingThickness, WingLength), Substance.DryGrass);
			body.GetComponent<CubeConnector>().Connect(wing1.GetComponent<CubeConnector>());
			body.GetComponent<CubeConnector>().Connect(wing2.GetComponent<CubeConnector>());
		}

	}
}
