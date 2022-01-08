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
	public class BvhBone : IBone // TypeDefIndex: 5942
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _SkeletonLocalPosition_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private IBone _Parent_k__BackingField; // 0x28
		private List<IBone> _children; // 0x30
	
		// Properties
		public string Name { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public Vector3 SkeletonLocalPosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807203F0-0x0000000180720410 0x0000000180720410-0x0000000180720420
		public IBone Parent { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public IList<IBone> Children { get; } // 0x00000001802684F0-0x0000000180268500 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__19 : IEnumerable<BvhBone>, IEnumerator<BvhBone> // TypeDefIndex: 5941
		{
			// Fields
			private int __1__state; // 0x10
			private BvhBone __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public BvhBone __4__this; // 0x28
			private IEnumerator<IBone> __7__wrap1; // 0x30
			private IEnumerator<IBone> __7__wrap2; // 0x38
	
			// Properties
			BvhBone IEnumerator<UniHumanoid.BvhBone>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Traverse_d__19(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001812BC3E0-0x00000001812BC4C0
			private bool MoveNext(); // 0x00000001812BC0A0-0x00000001812BC300
			private void __m__Finally1(); // 0x00000001812BC4C0-0x00000001812BC510
			private void __m__Finally2(); // 0x00000001812BC510-0x00000001812BC560
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001812BC3A0-0x00000001812BC3E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<BvhBone> IEnumerable<BvhBone>.GetEnumerator(); // 0x00000001812BC300-0x00000001812BC3A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812BC300-0x00000001812BC3A0
		}
	
		// Constructors
		public BvhBone(string name, Vector3 position); // 0x00000001812AD8D0-0x00000001812AD970
	
		// Methods
		public override string ToString(); // 0x00000001812AD820-0x00000001812AD860
		public void Build(Transform t); // 0x00000001812AD270-0x00000001812AD5A0
		public void Build(BvhNode node); // 0x00000001812AD5A0-0x00000001812AD820
		[IteratorStateMachine] // 0x000000018004DEF0-0x000000018004DF40
		public IEnumerable<BvhBone> Traverse(); // 0x00000001812AD860-0x00000001812AD8D0
	}
}
