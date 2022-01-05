/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class ControllerHintsExample : MonoBehaviour // TypeDefIndex: 7516
	{
		// Fields
		private Coroutine buttonHintCoroutine; // 0x18
		private Coroutine textHintCoroutine; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TestButtonHints_d__5 : IEnumerator<object> // TypeDefIndex: 7514
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Valve.VR.InteractionSystem.Hand hand; // 0x20
			private int _actionIndex_5__2; // 0x28
			private ISteamVR_Action_In _action_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TestButtonHints_d__5(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029D9E0-0x000000018029DD10
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029DD10-0x000000018029DD50
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TestTextHints_d__6 : IEnumerator<object> // TypeDefIndex: 7515
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Valve.VR.InteractionSystem.Hand hand; // 0x20
			private int _actionIndex_5__2; // 0x28
			private ISteamVR_Action_In _action_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TestTextHints_d__6(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029DFD0-0x000000018029E260
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029E260-0x000000018029E2A0
		}
	
		// Constructors
		public ControllerHintsExample(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public void ShowButtonHints(Valve.VR.InteractionSystem.Hand hand); // 0x000000018058F160-0x000000018058F1F0
		public void ShowTextHints(Valve.VR.InteractionSystem.Hand hand); // 0x000000018058F1F0-0x000000018058F280
		public void DisableHints(); // 0x000000018058EFD0-0x000000018058F160
		[IteratorStateMachine] // 0x00000001800268D0-0x0000000180026920
		private IEnumerator TestButtonHints(Valve.VR.InteractionSystem.Hand hand); // 0x000000018058F280-0x000000018058F2F0
		[IteratorStateMachine] // 0x0000000180026920-0x0000000180026970
		private IEnumerator TestTextHints(Valve.VR.InteractionSystem.Hand hand); // 0x000000018058F2F0-0x000000018058F360
	}
}
