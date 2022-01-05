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
	[ExecuteInEditMode] // 0x0000000180024340-0x00000001800243D0
	[RequireComponent] // 0x0000000180024340-0x00000001800243D0
	public class SteamVR_PlayArea : MonoBehaviour // TypeDefIndex: 7360
	{
		// Fields
		public float borderThickness; // 0x18
		public float wireframeHeight; // 0x1C
		public bool drawWireframeWhenSelectedOnly; // 0x20
		public bool drawInGame; // 0x21
		public Size size; // 0x24
		public Color color; // 0x28
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector3[] vertices; // 0x38
	
		// Nested types
		public enum Size // TypeDefIndex: 7358
		{
			Calibrated = 0,
			_400x300 = 1,
			_300x225 = 2,
			_200x150 = 3
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _UpdateBounds_d__14 : IEnumerator<object> // TypeDefIndex: 7359
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_PlayArea __4__this; // 0x20
			private CVRChaperone _chaperone_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _UpdateBounds_d__14(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029E6F0-0x000000018029E810
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029E810-0x000000018029E850
		}
	
		// Constructors
		public SteamVR_PlayArea(); // 0x0000000180C6B070-0x0000000180C6B0B0
	
		// Methods
		public static bool GetBounds(Size size, ref HmdQuad_t pRect); // 0x0000000180C6ABF0-0x0000000180C6AF00
		public void BuildMesh(); // 0x0000000180C69D60-0x0000000180C6A870
		private void OnDrawGizmos(); // 0x0000000180C6AF10-0x0000000180C6AF20
		private void OnDrawGizmosSelected(); // 0x0000000180C6AF00-0x0000000180C6AF10
		public void DrawWireframe(); // 0x0000000180C6A870-0x0000000180C6ABF0
		public void OnEnable(); // 0x0000000180C6AF20-0x0000000180C6B000
		[IteratorStateMachine] // 0x00000001800243D0-0x0000000180024420
		private IEnumerator UpdateBounds(); // 0x0000000180C6B000-0x0000000180C6B070
	}
}
