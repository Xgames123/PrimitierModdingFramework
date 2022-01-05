/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	[RequireComponent] // 0x000000018002E990-0x000000018002E9E0
	public class LuxWater_UnderwaterRenderingSlave : MonoBehaviour // TypeDefIndex: 8760
	{
		// Fields
		private LuxWater_UnderWaterRendering waterrendermanager; // 0x18
		private bool readyToGo; // 0x20
		private static CommandBuffer cb_MaskSlave; // 0x00
		private CameraEvent cameraEvent; // 0x24
		public Camera cam; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LuxWater_UnderWaterOnRenderImage underWaterOnRenderImage; // 0x30
	
		// Constructors
		public LuxWater_UnderwaterRenderingSlave(); // 0x0000000180483E30-0x0000000180483E40
	
		// Methods
		private void OnEnable(); // 0x0000000180483C10-0x0000000180483D20
		private void OnDisable(); // 0x0000000180483B50-0x0000000180483C10
		private void GetWaterrendermanager(); // 0x0000000180483AA0-0x0000000180483B50
		private void OnPreCull(); // 0x0000000180483D20-0x0000000180483D90
		private void Update(); // 0x0000000180483D90-0x0000000180483E30
	}
}
