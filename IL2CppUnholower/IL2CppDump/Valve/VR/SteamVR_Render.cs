/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Render : MonoBehaviour // TypeDefIndex: 7362
	{
		// Fields
		public SteamVR_ExternalCamera externalCamera; // 0x18
		public string externalCameraConfigPath; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static EVREye _eye_k__BackingField; // 0x00
		private static bool isQuitting; // 0x04
		private SteamVR_Camera[] cameras; // 0x28
		public TrackedDevicePose_t[] poses; // 0x30
		public TrackedDevicePose_t[] gamePoses; // 0x38
		private static bool _pauseRendering; // 0x05
		private WaitForEndOfFrame waitForEndOfFrame; // 0x40
		private bool? doesPathExist; // 0x48
		private float sceneResolutionScale; // 0x4C
		private float timeScale; // 0x50
		private EVRScreenshotType[] screenshotTypes; // 0x58
	
		// Properties
		public static EVREye eye { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180C70640-0x0000000180C70680 0x0000000180C70720-0x0000000180C70760
		public static SteamVR_Render instance { get; } // 0x0000000180C70680-0x0000000180C706E0 
		public static bool pauseRendering { get; set; } // 0x0000000180C706E0-0x0000000180C70720 0x0000000180C70760-0x0000000180C707F0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _RenderLoop_d__24 : IEnumerator<object> // TypeDefIndex: 7361
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_Render __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _RenderLoop_d__24(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029BB00-0x000000018029BD50
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029BD50-0x000000018029BD90
		}
	
		// Constructors
		public SteamVR_Render(); // 0x0000000180C70520-0x0000000180C70640
	
		// Methods
		private void OnApplicationQuit(); // 0x0000000180C6EDD0-0x0000000180C6EE40
		public static void Add(SteamVR_Camera vrcam); // 0x0000000180C6E5C0-0x0000000180C6E670
		public static void Remove(SteamVR_Camera vrcam); // 0x0000000180C6FB90-0x0000000180C6FCD0
		public static SteamVR_Camera Top(); // 0x0000000180C6FEB0-0x0000000180C6FF80
		private void AddInternal(SteamVR_Camera vrcam); // 0x0000000180C6E350-0x0000000180C6E5C0
		private void RemoveInternal(SteamVR_Camera vrcam); // 0x0000000180C6F9B0-0x0000000180C6FB90
		private SteamVR_Camera TopInternal(); // 0x0000000180C6FE60-0x0000000180C6FEB0
		[IteratorStateMachine] // 0x0000000180024420-0x0000000180024470
		private IEnumerator RenderLoop(); // 0x0000000180C6FDF0-0x0000000180C6FE60
		private bool CheckExternalCamera(); // 0x0000000180C6E670-0x0000000180C6EC70
		private void RenderExternalCamera(); // 0x0000000180C6FCD0-0x0000000180C6FDF0
		private void OnInputFocus(bool hasFocus); // 0x0000000180C6F570-0x0000000180C6F690
		private string GetScreenshotFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames screenshotPropertyFilename); // 0x0000000180C6EC70-0x0000000180C6EDD0
		private void OnRequestScreenshot(VREvent_t vrEvent); // 0x0000000180C6F690-0x0000000180C6F930
		private void OnEnable(); // 0x0000000180C6F1D0-0x0000000180C6F570
		private void OnSteamVRInitialized(bool success); // 0x0000000180C6F930-0x0000000180C6F9B0
		private void OnDisable(); // 0x0000000180C6EF40-0x0000000180C6F1D0
		public void UpdatePoses(); // 0x0000000180C6FF80-0x0000000180C70080
		private void OnBeforeRender(); // 0x0000000180C6EE40-0x0000000180C6EF40
		private void Update(); // 0x0000000180C70080-0x0000000180C70520
	}
}
