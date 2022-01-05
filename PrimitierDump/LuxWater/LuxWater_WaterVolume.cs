/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	public class LuxWater_WaterVolume : MonoBehaviour // TypeDefIndex: 8763
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static TriggerEnter OnEnterWaterVolume; // 0x00
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static TriggerExit OnExitWaterVolume; // 0x08
		[LuxWater_HelpBtn] // 0x000000018002E9E0-0x000000018002EA30
		[Space] // 0x000000018002E9E0-0x000000018002EA30
		public Mesh WaterVolumeMesh; // 0x18
		[Space] // 0x000000018002D020-0x000000018002D040
		public bool SlidingVolume; // 0x20
		public float GridSize; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Camera[] cams; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float waterLevel; // 0x30
		private float[] prevCamsHeight; // 0x38
		private LuxWater_UnderWaterRendering waterrendermanager; // 0x40
		private bool readyToGo; // 0x48
		private int ID; // 0x4C
	
		// Events
		public static event TriggerEnter OnEnterWaterVolume {
			add; // 0x0000000180485130-0x00000001804851F0
			remove; // 0x00000001804852B0-0x0000000180485370
		}
		public static event TriggerExit OnExitWaterVolume {
			add; // 0x00000001804851F0-0x00000001804852B0
			remove; // 0x0000000180485370-0x0000000180485430
		}
	
		// Nested types
		public delegate void TriggerEnter(); // TypeDefIndex: 8761; 0x000000018070FF10-0x0000000180710080
	
		public delegate void TriggerExit(); // TypeDefIndex: 8762; 0x000000018070FF10-0x0000000180710080
	
		// Constructors
		public LuxWater_WaterVolume(); // 0x0000000180485120-0x0000000180485130
	
		// Methods
		private void OnEnable(); // 0x0000000180484A60-0x0000000180484C30
		private void OnDisable(); // 0x0000000180484830-0x0000000180484A60
		private void Register(); // 0x0000000180484FC0-0x0000000180485120
		private void OnBecameVisible(); // 0x0000000180484790-0x0000000180484830
		private void OnBecameInvisible(); // 0x00000001804846F0-0x0000000180484790
		private void FixedUpdate(); // 0x00000001804843A0-0x00000001804846F0
		private void OnTriggerEnter(Collider other); // 0x0000000180484C30-0x0000000180484D70
		private void OnTriggerStay(Collider other); // 0x0000000180484EB0-0x0000000180484FC0
		private void OnTriggerExit(Collider other); // 0x0000000180484D70-0x0000000180484EB0
	}
}
