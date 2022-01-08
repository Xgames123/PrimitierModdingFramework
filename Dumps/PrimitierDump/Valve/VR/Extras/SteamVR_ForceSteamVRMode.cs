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

namespace Valve.VR.Extras
{
	public class SteamVR_ForceSteamVRMode : MonoBehaviour // TypeDefIndex: 7536
	{
		// Fields
		public GameObject vrCameraPrefab; // 0x18
		public GameObject[] disableObjectsOnLoad; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 7535
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_ForceSteamVRMode __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__2(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029CC90-0x000000018029CEB0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029CEB0-0x000000018029CEF0
		}
	
		// Constructors
		public SteamVR_ForceSteamVRMode(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		[IteratorStateMachine] // 0x0000000180026A60-0x0000000180026AB0
		private IEnumerator Start(); // 0x0000000180325DF0-0x0000000180325E60
	}
}
