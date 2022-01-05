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
	public class SteamVR_LoadLevel : MonoBehaviour // TypeDefIndex: 7354
	{
		// Fields
		private static SteamVR_LoadLevel _active; // 0x00
		public string levelName; // 0x18
		public string internalProcessPath; // 0x20
		public string internalProcessArgs; // 0x28
		public bool loadAdditive; // 0x30
		public bool loadAsync; // 0x31
		public Texture loadingScreen; // 0x38
		public Texture progressBarEmpty; // 0x40
		public Texture progressBarFull; // 0x48
		public float loadingScreenWidthInMeters; // 0x50
		public float progressBarWidthInMeters; // 0x54
		public float loadingScreenDistance; // 0x58
		public Transform loadingScreenTransform; // 0x60
		public Transform progressBarTransform; // 0x68
		public Texture front; // 0x70
		public Texture back; // 0x78
		public Texture left; // 0x80
		public Texture right; // 0x88
		public Texture top; // 0x90
		public Texture bottom; // 0x98
		public Color backgroundColor; // 0xA0
		public bool showGrid; // 0xB0
		public float fadeOutTime; // 0xB4
		public float fadeInTime; // 0xB8
		public float postLoadSettleTime; // 0xBC
		public float loadingScreenFadeInTime; // 0xC0
		public float loadingScreenFadeOutTime; // 0xC4
		private float fadeRate; // 0xC8
		private float alpha; // 0xCC
		private AsyncOperation async; // 0xD0
		private RenderTexture renderTexture; // 0xD8
		private ulong loadingScreenOverlayHandle; // 0xE0
		private ulong progressBarOverlayHandle; // 0xE8
		public bool autoTriggerOnEnable; // 0xF0
	
		// Properties
		public static bool loading { get; } // 0x0000000180C67750-0x0000000180C677E0 
		public static float progress { get; } // 0x0000000180C678D0-0x0000000180C67A00 
		public static Texture progressTexture { get; } // 0x0000000180C677E0-0x0000000180C678D0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _LoadLevel_d__45 : IEnumerator<object> // TypeDefIndex: 7353
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_LoadLevel __4__this; // 0x20
			private CVROverlay _overlay_5__2; // 0x28
			private bool _fadedForeground_5__3; // 0x30
			private CVRCompositor _compositor_5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _LoadLevel_d__45(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029AA80-0x000000018029BAC0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029BAC0-0x000000018029BB00
		}
	
		// Constructors
		public SteamVR_LoadLevel(); // 0x0000000180C676D0-0x0000000180C67750
		static SteamVR_LoadLevel(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		private void OnEnable(); // 0x0000000180C66EA0-0x0000000180C66EC0
		public void Trigger(); // 0x0000000180C67420-0x0000000180C67570
		public static void Begin(string levelName, bool showGrid = false /* Metadata: 0x003A57A5 */, float fadeOutTime = 0.5f /* Metadata: 0x003A57A6 */, float r = 0f /* Metadata: 0x003A57AA */, float g = 0f /* Metadata: 0x003A57AE */, float b = 0f /* Metadata: 0x003A57B2 */, float a = 1f /* Metadata: 0x003A57B6 */); // 0x0000000180C66840-0x0000000180C66970
		private void OnGUI(); // 0x0000000180C66EC0-0x0000000180C67420
		private void Update(); // 0x0000000180C67570-0x0000000180C676D0
		[IteratorStateMachine] // 0x0000000180024230-0x0000000180024280
		private IEnumerator LoadLevel(); // 0x0000000180C66E30-0x0000000180C66EA0
		private ulong GetOverlayHandle(string overlayName, Transform transform, float widthInMeters = 1f /* Metadata: 0x003A57BA */); // 0x0000000180C66970-0x0000000180C66E30
	}
}
