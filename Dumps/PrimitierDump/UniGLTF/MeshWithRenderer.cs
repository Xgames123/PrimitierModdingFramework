/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public struct MeshWithRenderer // TypeDefIndex: 5863
	{
		// Fields
		public readonly Mesh Mesh; // 0x00
		public readonly Renderer Renderer; // 0x08
		public readonly Transform[] UniqueBones; // 0x10
		private readonly int[] JointIndexMap; // 0x18
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetBindPoses_d__6 : IEnumerable<Matrix4x4>, IEnumerator<Matrix4x4> // TypeDefIndex: 5861
		{
			// Fields
			private int __1__state; // 0x10
			private Matrix4x4 __2__current; // 0x14
			private int __l__initialThreadId; // 0x54
			public MeshWithRenderer __4__this; // 0x58
			public MeshWithRenderer __3____4__this; // 0x78
			private HashSet<int> _used_5__2; // 0x98
			private int _i_5__3; // 0xA0
	
			// Properties
			Matrix4x4 IEnumerator<UnityEngine.Matrix4x4>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DFE00-0x00000001806DFE30 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DFE70-0x00000001806DFED0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetBindPoses_d__6(int __1__state); // 0x00000001806DFED0-0x00000001806DFF00
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806DFBE0-0x00000001806DFD60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DFE30-0x00000001806DFE70
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Matrix4x4> IEnumerable<Matrix4x4>.GetEnumerator(); // 0x00000001806DFD60-0x00000001806DFE00
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DFD60-0x00000001806DFE00
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _FromNodes_d__7 : IEnumerable<MeshWithRenderer>, IEnumerator<MeshWithRenderer> // TypeDefIndex: 5862
		{
			// Fields
			private int __1__state; // 0x10
			private MeshWithRenderer __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			private IEnumerable<Transform> nodes; // 0x40
			public IEnumerable<Transform> __3__nodes; // 0x48
			private IEnumerator<Transform> __7__wrap1; // 0x50
	
			// Properties
			MeshWithRenderer IEnumerator<UniGLTF.MeshWithRenderer>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054BFE0-0x000000018054C000 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DFAB0-0x00000001806DFB00 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _FromNodes_d__7(int __1__state); // 0x000000018054C170-0x000000018054C1A0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806DFB00-0x00000001806DFB90
			private bool MoveNext(); // 0x00000001806DF780-0x00000001806DF9D0
			private void __m__Finally1(); // 0x00000001806DFB90-0x00000001806DFBE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DFA70-0x00000001806DFAB0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<MeshWithRenderer> IEnumerable<MeshWithRenderer>.GetEnumerator(); // 0x00000001806DF9D0-0x00000001806DFA70
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DF9D0-0x00000001806DFA70
		}
	
		// Constructors
		public MeshWithRenderer(Transform x); // 0x0000000180BBE610-0x0000000180BBE900
	
		// Methods
		public int GetJointIndex(int index); // 0x0000000180BBE3E0-0x0000000180BBE420
		[IteratorStateMachine] // 0x0000000180029630-0x0000000180029680
		public IEnumerable<Matrix4x4> GetBindPoses(); // 0x0000000180BBE360-0x0000000180BBE3E0
		[IteratorStateMachine] // 0x0000000180029680-0x00000001800296D0
		public static IEnumerable<MeshWithRenderer> FromNodes(IEnumerable<Transform> nodes); // 0x0000000180BBE2F0-0x0000000180BBE360
		public bool IsSameMeshAndMaterials(MeshWithRenderer other); // 0x0000000180BBE5C0-0x0000000180BBE610
		public bool IsSameMeshAndMaterials(Mesh mesh, Material[] materials); // 0x0000000180BBE420-0x0000000180BBE5C0
	}
}
