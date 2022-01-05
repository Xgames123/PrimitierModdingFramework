/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMFirstPersonCameraManager : MonoBehaviour // TypeDefIndex: 8020
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CameraWithRawImage m_topLeft; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CameraWithRawImage m_topRight; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CameraWithRawImage m_bottomRight; // 0x28
		[Header] // 0x0000000180035650-0x00000001800356A0
		[SerializeField] // 0x0000000180035650-0x00000001800356A0
		private Camera m_firstPersonCamera; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Camera[] m_thirdPersonCameras; // 0x38
	
		// Nested types
		[Serializable]
		private class CameraWithRawImage // TypeDefIndex: 8019
		{
			// Fields
			public Camera Camera; // 0x10
			public RenderTexture Texture; // 0x18
			public RawImage Image; // 0x20
	
			// Constructors
			public CameraWithRawImage(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public VRMFirstPersonCameraManager(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Reset(); // 0x00000001803420B0-0x00000001803421C0
		private void Update(); // 0x00000001803423E0-0x0000000180342470
		private void SetupRenderTarget(CameraWithRawImage cameraWithImage, int w, int h); // 0x00000001803421C0-0x0000000180342370
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _Reset_b__6_0(Camera x); // 0x0000000180342370-0x00000001803423E0
	}
}
