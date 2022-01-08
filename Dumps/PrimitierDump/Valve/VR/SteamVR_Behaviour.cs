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
	public class SteamVR_Behaviour : MonoBehaviour // TypeDefIndex: 7329
	{
		// Fields
		private const string openVRDeviceName = "OpenVR"; // Metadata: 0x003A576D
		public static bool forcingInitialization; // 0x00
		private static SteamVR_Behaviour _instance; // 0x08
		public bool initializeSteamVROnAwake; // 0x18
		public bool doNotDestroy; // 0x19
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public SteamVR_Render steamvr_render; // 0x20
		internal static bool isPlaying; // 0x10
		private static bool initializing; // 0x11
		private Coroutine initializeCoroutine; // 0x28
		private bool loadedOpenVRDeviceSuccess; // 0x30
		protected static int lastFrameCount; // 0x14
	
		// Properties
		public static SteamVR_Behaviour instance { get; } // 0x00000001803FD6A0-0x00000001803FD790 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoInitializeSteamVR_d__15 : IEnumerator<object> // TypeDefIndex: 7328
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_Behaviour __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoInitializeSteamVR_d__15(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180297350-0x00000001802974D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001802974D0-0x0000000180297510
		}
	
		// Constructors
		public SteamVR_Behaviour(); // 0x00000001803FD690-0x00000001803FD6A0
		static SteamVR_Behaviour(); // 0x00000001803FD620-0x00000001803FD690
	
		// Methods
		public static void Initialize(bool forceUnityVRToOpenVR = false /* Metadata: 0x003A576A */); // 0x00000001803FAED0-0x00000001803FB490
		protected void Awake(); // 0x00000001803F9930-0x00000001803F9A30
		public void InitializeSteamVR(bool forceUnityVRToOpenVR = false /* Metadata: 0x003A576B */); // 0x00000001803FACE0-0x00000001803FAED0
		[IteratorStateMachine] // 0x0000000180024070-0x00000001800240C0
		private IEnumerator DoInitializeSteamVR(bool forceUnityVRToOpenVR = false /* Metadata: 0x003A576C */); // 0x00000001803FAB30-0x00000001803FABA0
		private void XRDevice_deviceLoaded(string deviceName); // 0x00000001803FD570-0x00000001803FD620
		private void EnableOpenVR(); // 0x00000001803FABA0-0x00000001803FAC50
		protected void OnEnable(); // 0x00000001803FB770-0x00000001803FB8A0
		protected void OnDisable(); // 0x00000001803FB640-0x00000001803FB770
		protected void OnBeforeRender(); // 0x00000001803FB520-0x00000001803FB640
		protected void PreCull(); // 0x00000001803FB520-0x00000001803FB640
		protected void FixedUpdate(); // 0x00000001803FAC50-0x00000001803FACE0
		protected void LateUpdate(); // 0x00000001803FB490-0x00000001803FB520
		protected void Update(); // 0x00000001803FD4E0-0x00000001803FD570
		protected void OnQuit(VREvent_t vrEvent); // 0x00000001803FB8A0-0x00000001803FB8B0
	}
}
