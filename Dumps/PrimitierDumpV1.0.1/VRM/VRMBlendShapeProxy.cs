/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[DisallowMultipleComponent] // 0x0000000180014D50-0x0000000180014D60
	public class VRMBlendShapeProxy : MonoBehaviour, IVRMComponent // TypeDefIndex: 7998
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public BlendShapeAvatar BlendShapeAvatar; // 0x18
		private BlendShapeMerger m_merger; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetValues_d__8 : IEnumerable<KeyValuePair<BlendShapeKey, float>>, IEnumerator<KeyValuePair<BlendShapeKey, float>> // TypeDefIndex: 7997
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<BlendShapeKey, float> __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public VRMBlendShapeProxy __4__this; // 0x40
			private List<BlendShapeClip> __7__wrap1; // 0x48
	
			// Properties
			KeyValuePair<BlendShapeKey, float> IEnumerator<System.Collections.Generic.KeyValuePair<VRM.BlendShapeKey,System.Single>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054BFE0-0x000000018054C000 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054C040-0x000000018054C090 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetValues_d__8(int __1__state); // 0x000000018054C170-0x000000018054C1A0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x000000018054C090-0x000000018054C120
			private bool MoveNext(); // 0x000000018054BC60-0x000000018054BF40
			private void __m__Finally1(); // 0x000000018054C120-0x000000018054C170
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018054C000-0x000000018054C040
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<KeyValuePair<BlendShapeKey, float>> IEnumerable<KeyValuePair<BlendShapeKey, float>>.GetEnumerator(); // 0x000000018054BF40-0x000000018054BFE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018054BF40-0x000000018054BFE0
		}
	
		// Constructors
		public VRMBlendShapeProxy(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public void OnImported(VRMImporterContext context); // 0x000000018033F4F0-0x000000018033F530
		private void OnDestroy(); // 0x000000018033F4B0-0x000000018033F4F0
		private void Start(); // 0x000000018033F550-0x000000018033F630
		public void ImmediatelySetValue(BlendShapeKey key, float value); // 0x000000018033F470-0x000000018033F4B0
		public void AccumulateValue(BlendShapeKey key, float value); // 0x000000018033F2D0-0x000000018033F310
		public float GetValue(BlendShapeKey key); // 0x000000018033F350-0x000000018033F400
		[IteratorStateMachine] // 0x0000000180035400-0x0000000180035450
		public IEnumerable<KeyValuePair<BlendShapeKey, float>> GetValues(); // 0x000000018033F400-0x000000018033F470
		public void SetValues(IEnumerable<KeyValuePair<BlendShapeKey, float>> values); // 0x000000018033F530-0x000000018033F550
		public void Apply(); // 0x000000018033F310-0x000000018033F350
	}
}
