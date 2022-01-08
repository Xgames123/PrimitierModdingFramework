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

namespace MeshUtility
{
	public static class BoneMeshEraser // TypeDefIndex: 5640
	{
		// Nested types
		private struct ExcludeBoneIndex // TypeDefIndex: 5637
		{
			// Fields
			public readonly bool Bone0; // 0x00
			public readonly bool Bone1; // 0x01
			public readonly bool Bone2; // 0x02
			public readonly bool Bone3; // 0x03
	
			// Constructors
			public ExcludeBoneIndex(bool bone0, bool bone1, bool bone2, bool bone3); // 0x0000000180D50A10-0x0000000180D50A30
		}
	
		[Serializable]
		public struct EraseBone // TypeDefIndex: 5638
		{
			// Fields
			public Transform Bone; // 0x00
			public bool Erase; // 0x08
	
			// Methods
			public override string ToString(); // 0x0000000180D509A0-0x0000000180D50A10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Ancestor_d__5 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 5639
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform t; // 0x28
			public Transform __3__t; // 0x30
			private IEnumerator<Transform> __7__wrap1; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Ancestor_d__5(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180D50E80-0x0000000180D50F10
			private bool MoveNext(); // 0x0000000180D50B80-0x0000000180D50DA0
			private void __m__Finally1(); // 0x0000000180D50F10-0x0000000180D50F60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D50E40-0x0000000180D50E80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x0000000180D50DA0-0x0000000180D50E40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D50DA0-0x0000000180D50E40
		}
	
		// Methods
		private static int ExcludeTriangles(int[] triangles, BoneWeight[] bws, int[] exclude); // 0x00000001810ACE00-0x00000001810AD280
		private static ExcludeBoneIndex AreBoneContains(ref int[] exclude, int boneIndex0, int boneIndex1, int boneIndex2, int boneIndex3); // 0x00000001810ACA80-0x00000001810ACBC0
		public static Mesh CreateErasedMesh(Mesh src, int[] eraseBoneIndices); // 0x00000001810ACBC0-0x00000001810ACE00
	
		// Extension methods
		[IteratorStateMachine] // 0x0000000180026F50-0x0000000180026FC0
		public static IEnumerable<Transform> Ancestor(this Transform t); // 0x00000001810ACA10-0x00000001810ACA80
	}
}
