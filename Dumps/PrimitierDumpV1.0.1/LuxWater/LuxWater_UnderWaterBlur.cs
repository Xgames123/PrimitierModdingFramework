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
	[RequireComponent] // 0x000000018002E610-0x000000018002E660
	public class LuxWater_UnderWaterBlur : MonoBehaviour // TypeDefIndex: 8758
	{
		// Fields
		[LuxWater_HelpBtn] // 0x000000018002E660-0x000000018002E6B0
		[Space] // 0x000000018002E660-0x000000018002E6B0
		public float blurSpread; // 0x18
		public int blurDownSample; // 0x1C
		public int blurIterations; // 0x20
		private Vector2[] m_offsets; // 0x28
		private Material blurMaterial; // 0x30
		private Material blitMaterial; // 0x38
		private LuxWater_UnderWaterRendering waterrendermanager; // 0x40
		private bool doBlur; // 0x48
		private bool initBlur; // 0x49
		private Camera cam; // 0x50
	
		// Constructors
		public LuxWater_UnderWaterBlur(); // 0x000000018047E900-0x000000018047E970
	
		// Methods
		private void OnEnable(); // 0x000000018047E510-0x000000018047E610
		private void OnDisable(); // 0x000000018047E420-0x000000018047E510
		private void GetWaterrendermanagerInstance(); // 0x000000018047E3B0-0x000000018047E420
		private void OnRenderImage(RenderTexture src, RenderTexture dest); // 0x000000018047E610-0x000000018047E900
		private void FourTapCone(RenderTexture source, RenderTexture dest, int iteration); // 0x000000018047E190-0x000000018047E3B0
		private void DownSample(RenderTexture source, RenderTexture dest); // 0x000000018047DFB0-0x000000018047E190
	}
}
