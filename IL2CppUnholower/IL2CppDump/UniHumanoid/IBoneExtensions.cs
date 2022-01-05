/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public static class IBoneExtensions // TypeDefIndex: 5962
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__0 : IEnumerable<IBone>, IEnumerator<IBone> // TypeDefIndex: 5961
		{
			// Fields
			private int __1__state; // 0x10
			private IBone __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private IBone self; // 0x28
			public IBone __3__self; // 0x30
			private IEnumerator<IBone> __7__wrap1; // 0x38
			private IEnumerator<IBone> __7__wrap2; // 0x40
	
			// Properties
			IBone IEnumerator<UniHumanoid.IBone>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Traverse_d__0(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001812BBF20-0x00000001812BC000
			private bool MoveNext(); // 0x00000001812BBBE0-0x00000001812BBE40
			private void __m__Finally1(); // 0x00000001812BC000-0x00000001812BC050
			private void __m__Finally2(); // 0x00000001812BC050-0x00000001812BC0A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001812BBEE0-0x00000001812BBF20
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<IBone> IEnumerable<IBone>.GetEnumerator(); // 0x00000001812BBE40-0x00000001812BBEE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812BBE40-0x00000001812BBEE0
		}
	
		// Extension methods
		[IteratorStateMachine] // 0x000000018004DFC0-0x000000018004E030
		public static IEnumerable<IBone> Traverse(this IBone self); // 0x00000001812B74D0-0x00000001812B7540
		public static Vector3 CenterOfDescendant(this IBone self); // 0x00000001812B71B0-0x00000001812B74D0
	}
}
