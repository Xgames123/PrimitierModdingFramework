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
	public static class MeshIntegratorUtility // TypeDefIndex: 5674
	{
		// Fields
		public const string INTEGRATED_MESH_NAME = "MeshesIntegrated"; // Metadata: 0x003A196F
		public const string INTEGRATED_MESH_BLENDSHAPE_NAME = "MeshesBlendShapeIntegrated"; // Metadata: 0x003A1983
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5670
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MeshIntegrator.SubMesh, Material> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E7030-0x00000001806E7090
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Material _Integrate_b__2_0(MeshIntegrator.SubMesh x); // 0x00000001806E5000-0x00000001806E5010
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateSkinnedMeshRenderer_d__3 : IEnumerable<SkinnedMeshRenderer>, IEnumerator<SkinnedMeshRenderer> // TypeDefIndex: 5671
		{
			// Fields
			private int __1__state; // 0x10
			private SkinnedMeshRenderer __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform root; // 0x28
			public Transform __3__root; // 0x30
			private bool hasBlendShape; // 0x38
			public bool __3__hasBlendShape; // 0x39
			private IEnumerator<Transform> __7__wrap1; // 0x40
	
			// Properties
			SkinnedMeshRenderer IEnumerator<UnityEngine.SkinnedMeshRenderer>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateSkinnedMeshRenderer_d__3(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806DED80-0x00000001806DEE10
			private bool MoveNext(); // 0x00000001806DE9F0-0x00000001806DECA0
			private void __m__Finally1(); // 0x00000001806DEE10-0x00000001806DEE60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DED40-0x00000001806DED80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator(); // 0x00000001806DECA0-0x00000001806DED40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DECA0-0x00000001806DED40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateMeshRenderer_d__4 : IEnumerable<MeshRenderer>, IEnumerator<MeshRenderer> // TypeDefIndex: 5672
		{
			// Fields
			private int __1__state; // 0x10
			private MeshRenderer __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform root; // 0x28
			public Transform __3__root; // 0x30
			private IEnumerator<Transform> __7__wrap1; // 0x38
	
			// Properties
			MeshRenderer IEnumerator<UnityEngine.MeshRenderer>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateMeshRenderer_d__4(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806DE910-0x00000001806DE9A0
			private bool MoveNext(); // 0x00000001806DE570-0x00000001806DE830
			private void __m__Finally1(); // 0x00000001806DE9A0-0x00000001806DE9F0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DE8D0-0x00000001806DE910
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<MeshRenderer> IEnumerable<MeshRenderer>.GetEnumerator(); // 0x00000001806DE830-0x00000001806DE8D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DE830-0x00000001806DE8D0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__5 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 5673
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
			public _Traverse_d__5(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E42D0-0x00000001806E43C0
			private bool MoveNext(); // 0x00000001806E3FA0-0x00000001806E41F0
			private void __m__Finally1(); // 0x00000001806E43C0-0x00000001806E4420
			private void __m__Finally2(); // 0x00000001806E4420-0x00000001806E4470
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E4290-0x00000001806E42D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x00000001806E41F0-0x00000001806E4290
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E41F0-0x00000001806E4290
		}
	
		// Methods
		public static MeshIntegrationResult Integrate(GameObject go, bool onlyBlendShapeRenderers); // 0x0000000180BBB4C0-0x0000000180BBC310
		[IteratorStateMachine] // 0x00000001800270B0-0x0000000180027100
		public static IEnumerable<SkinnedMeshRenderer> EnumerateSkinnedMeshRenderer(Transform root, bool hasBlendShape); // 0x0000000180BBB440-0x0000000180BBB4C0
		[IteratorStateMachine] // 0x0000000180027100-0x0000000180027150
		public static IEnumerable<MeshRenderer> EnumerateMeshRenderer(Transform root); // 0x0000000180BBB3D0-0x0000000180BBB440
		[IteratorStateMachine] // 0x0000000180027150-0x00000001800271A0
		private static IEnumerable<Transform> Traverse(Transform parent); // 0x0000000180BBC310-0x0000000180BBC380
	}
}
