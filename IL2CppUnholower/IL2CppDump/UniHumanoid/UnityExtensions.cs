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
	public static class UnityExtensions // TypeDefIndex: 5973
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetChildren_d__1 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 5971
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform parent; // 0x28
			public Transform __3__parent; // 0x30
			private IEnumerator __7__wrap1; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetChildren_d__1(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001812BBAE0-0x00000001812BBB80
			private bool MoveNext(); // 0x00000001812BB840-0x00000001812BBA00
			private void __m__Finally1(); // 0x00000001812BBB80-0x00000001812BBBE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001812BBAA0-0x00000001812BBAE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x00000001812BBA00-0x00000001812BBAA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812BBA00-0x00000001812BBAA0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__2 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 5972
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform parent; // 0x28
			public Transform __3__parent; // 0x30
			private IEnumerator __7__wrap1; // 0x38
			private IEnumerator<Transform> __7__wrap2; // 0x40
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Traverse_d__2(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001812BCD00-0x00000001812BCDF0
			private bool MoveNext(); // 0x00000001812BCA10-0x00000001812BCC20
			private void __m__Finally1(); // 0x00000001812BCDF0-0x00000001812BCE50
			private void __m__Finally2(); // 0x00000001812BCE50-0x00000001812BCEA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001812BCCC0-0x00000001812BCD00
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x00000001812BCC20-0x00000001812BCCC0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812BCC20-0x00000001812BCCC0
		}
	
		// Extension methods
		public static Quaternion ReverseX(this Quaternion quaternion); // 0x0000000180BC5EF0-0x0000000180BC5FA0
		[IteratorStateMachine] // 0x000000018004E0C0-0x000000018004E130
		public static IEnumerable<Transform> GetChildren(this Transform parent); // 0x00000001812BDED0-0x00000001812BDF40
		[IteratorStateMachine] // 0x000000018004E130-0x000000018004E1A0
		public static IEnumerable<Transform> Traverse(this Transform parent); // 0x00000001812BDF40-0x00000001812BDFB0
		public static SkeletonBone ToSkeletonBone(this Transform t); // 0x0000000180346130-0x0000000180346210
	}
}
