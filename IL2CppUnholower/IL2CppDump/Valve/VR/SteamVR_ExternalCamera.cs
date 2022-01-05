/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_ExternalCamera : MonoBehaviour // TypeDefIndex: 7348
	{
		// Fields
		private SteamVR_Action_Pose cameraPose; // 0x18
		private SteamVR_Input_Sources cameraInputSource; // 0x20
		[Space] // 0x0000000180024160-0x0000000180024170
		public Config config; // 0x24
		public string configPath; // 0x70
		[Tooltip] // 0x0000000180024170-0x00000001800241A0
		public bool autoEnableDisableActionSet; // 0x78
		private FileSystemWatcher watcher; // 0x80
		private Camera cam; // 0x88
		private Transform target; // 0x90
		private GameObject clipQuad; // 0x98
		private Material clipMaterial; // 0xA0
		protected SteamVR_ActionSet activatedActionSet; // 0xA8
		protected SteamVR_Input_Sources activatedInputSource; // 0xB0
		private Material colorMat; // 0xB8
		private Material alphaMat; // 0xC0
		private Camera[] cameras; // 0xC8
		private Rect[] cameraRects; // 0xD0
		private float sceneResolutionScale; // 0xD8
	
		// Nested types
		[Serializable]
		public struct Config // TypeDefIndex: 7347
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float z; // 0x08
			public float rx; // 0x0C
			public float ry; // 0x10
			public float rz; // 0x14
			public float fov; // 0x18
			public float near; // 0x1C
			public float far; // 0x20
			public float sceneResolutionScale; // 0x24
			public float frameSkip; // 0x28
			public float nearOffset; // 0x2C
			public float farOffset; // 0x30
			public float hmdOffset; // 0x34
			public float r; // 0x38
			public float g; // 0x3C
			public float b; // 0x40
			public float a; // 0x44
			public bool disableStandardAssets; // 0x48
		}
	
		// Constructors
		public SteamVR_ExternalCamera(); // 0x0000000180325460-0x0000000180325480
	
		// Methods
		public void ReadConfig(); // 0x00000001803240D0-0x0000000180324950
		public void SetupPose(SteamVR_Action_Pose newCameraPose, SteamVR_Input_Sources newCameraSource); // 0x00000001803253D0-0x0000000180325460
		public void SetupDeviceIndex(int deviceIndex); // 0x0000000180325360-0x00000001803253D0
		private void OnChanged(object source, FileSystemEventArgs e); // 0x0000000180323C00-0x0000000180323C10
		public void AttachToCamera(SteamVR_Camera steamVR_Camera); // 0x0000000180322C70-0x00000001803233E0
		public float GetTargetDistance(); // 0x0000000180323500-0x0000000180323800
		public void RenderNear(); // 0x0000000180324A90-0x0000000180325360
		public void RenderFar(); // 0x0000000180324950-0x0000000180324A90
		private void OnGUI(); // 0x0000000180265310-0x0000000180265320
		private void OnEnable(); // 0x0000000180323DC0-0x00000001803240D0
		private void AutoEnableActionSet(); // 0x00000001803233E0-0x0000000180323500
		private void OnDisable(); // 0x0000000180323C10-0x0000000180323DC0
	}
}
