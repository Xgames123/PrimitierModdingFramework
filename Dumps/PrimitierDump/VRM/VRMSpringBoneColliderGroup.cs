/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[DefaultExecutionOrder] // 0x0000000180037780-0x00000001800377A0
	public class VRMSpringBoneColliderGroup : MonoBehaviour // TypeDefIndex: 8100
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public SphereCollider[] Colliders; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_gizmoColor; // 0x20
	
		// Properties
		public float UniformedLossyScale { get; } // 0x00000001805513F0-0x00000001805514D0 
	
		// Nested types
		[Serializable]
		public class SphereCollider // TypeDefIndex: 8098
		{
			// Fields
			public Vector3 Offset; // 0x10
			[Range] // 0x000000018001BE80-0x000000018001BEA0
			public float Radius; // 0x1C
	
			// Constructors
			public SphereCollider(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Validate_d__6 : IEnumerable<UniGLTF.Validation>, IEnumerator<UniGLTF.Validation> // TypeDefIndex: 8099
		{
			// Fields
			private int __1__state; // 0x10
			private UniGLTF.Validation __2__current; // 0x18
			private int __l__initialThreadId; // 0x30
			public VRMSpringBoneColliderGroup __4__this; // 0x38
	
			// Properties
			UniGLTF.Validation IEnumerator<UniGLTF.Validation>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001805509E0-0x0000000180550A00 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180550DB0-0x0000000180550E00 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Validate_d__6(int __1__state); // 0x000000018054D600-0x000000018054D630
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180550A90-0x0000000180550CD0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180550D70-0x0000000180550DB0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<UniGLTF.Validation> IEnumerable<Validation>.GetEnumerator(); // 0x0000000180550CD0-0x0000000180550D70
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180550CD0-0x0000000180550D70
		}
	
		// Constructors
		public VRMSpringBoneColliderGroup(); // 0x0000000180551300-0x00000001805513F0
	
		// Methods
		private void OnDrawGizmosSelected(); // 0x0000000180551000-0x0000000180551290
		[IteratorStateMachine] // 0x00000001800377A0-0x00000001800377F0
		public IEnumerable<UniGLTF.Validation> Validate(); // 0x0000000180551290-0x0000000180551300
	}
}
