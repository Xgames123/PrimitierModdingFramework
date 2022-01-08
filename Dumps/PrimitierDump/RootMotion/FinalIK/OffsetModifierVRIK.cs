/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 8534
	{
		// Fields
		[Tooltip] // 0x000000018001C550-0x000000018001C580
		public float weight; // 0x18
		[Tooltip] // 0x0000000180022AE0-0x0000000180022B10
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000180776E20-0x0000000180776E40 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Initiate_d__7 : IEnumerator<object> // TypeDefIndex: 8533
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifierVRIK __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Initiate_d__7(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018084FE30-0x000000018084FF90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018084FF90-0x000000018084FFD0
		}
	
		// Constructors
		protected OffsetModifierVRIK(); // 0x0000000180776B40-0x0000000180776B50
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x0000000180776DB0-0x0000000180776E20
		[IteratorStateMachine] // 0x0000000180022B10-0x0000000180022B60
		private IEnumerator Initiate(); // 0x0000000180776B50-0x0000000180776BC0
		private void ModifyOffset(); // 0x0000000180776BC0-0x0000000180776CA0
		protected virtual void OnDestroy(); // 0x0000000180776CA0-0x0000000180776DB0
	}
}
