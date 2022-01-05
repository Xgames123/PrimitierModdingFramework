/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	[ExecuteInEditMode] // 0x000000018002E3D0-0x000000018002E430
	[RequireComponent] // 0x000000018002E3D0-0x000000018002E430
	public class LuxWater_CameraDepthMode : MonoBehaviour // TypeDefIndex: 8746
	{
		// Fields
		public bool GrabDepthTexture; // 0x18
		private Camera cam; // 0x20
		private Material CopyDepthMat; // 0x28
		private RenderTextureFormat format; // 0x30
		private Dictionary<Camera, CommandBuffer> m_cmdBuffer; // 0x38
		private bool CamCallBackAdded; // 0x40
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public bool ShowShaderWarning; // 0x41
	
		// Constructors
		public LuxWater_CameraDepthMode(); // 0x00000001804790D0-0x0000000180479140
	
		// Methods
		private void OnEnable(); // 0x0000000180478A40-0x0000000180478C00
		private void OnDisable(); // 0x00000001804787B0-0x0000000180478A40
		private void OnPrecull(Camera camera); // 0x0000000180478C00-0x00000001804790D0
	}
}
