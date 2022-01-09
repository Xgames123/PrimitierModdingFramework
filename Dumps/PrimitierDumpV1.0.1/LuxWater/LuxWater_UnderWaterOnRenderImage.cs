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
	public class LuxWater_UnderWaterOnRenderImage : MonoBehaviour // TypeDefIndex: 8766
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LuxWater_UnderWaterRendering underWaterRendering; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Camera cam; // 0x20
	
		// Constructors
		public LuxWater_UnderWaterOnRenderImage(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		[ImageEffectOpaque] // 0x0000000180014D50-0x0000000180014D60
		private void OnRenderImage(RenderTexture src, RenderTexture dest); // 0x000000018047E970-0x000000018047E9B0
	}
}
