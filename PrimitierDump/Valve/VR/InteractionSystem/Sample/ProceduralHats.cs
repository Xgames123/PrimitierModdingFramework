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

namespace Valve.VR.InteractionSystem.Sample
{
	public class ProceduralHats : MonoBehaviour // TypeDefIndex: 7510
	{
		// Fields
		public GameObject[] hats; // 0x18
		public float hatSwitchTime; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _HatSwitcher_d__4 : IEnumerator<object> // TypeDefIndex: 7509
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ProceduralHats __4__this; // 0x20
			private Transform _cam_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _HatSwitcher_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029A730-0x000000018029A940
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029A940-0x000000018029A980
		}
	
		// Constructors
		public ProceduralHats(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180362350-0x0000000180362360
		private void OnEnable(); // 0x00000001803622E0-0x0000000180362350
		[IteratorStateMachine] // 0x0000000180026830-0x0000000180026880
		private IEnumerator HatSwitcher(); // 0x0000000180362270-0x00000001803622E0
		private void ChooseHat(); // 0x0000000180362230-0x0000000180362270
		private void SwitchToHat(int hat); // 0x0000000180362360-0x00000001803623F0
	}
}
