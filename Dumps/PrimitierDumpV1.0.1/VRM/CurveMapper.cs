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
	[Serializable]
	public class CurveMapper // TypeDefIndex: 8070
	{
		// Fields
		public AnimationCurve Curve; // 0x10
		[Range] // 0x00000001800370D0-0x00000001800370F0
		public float CurveXRangeDegree; // 0x18
		[Range] // 0x00000001800370F0-0x0000000180037110
		public float CurveYRangeDegree; // 0x1C
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ToKeys_d__6 : IEnumerable<Keyframe>, IEnumerator<Keyframe> // TypeDefIndex: 8069
		{
			// Fields
			private int __1__state; // 0x10
			private Keyframe __2__current; // 0x14
			private int __l__initialThreadId; // 0x30
			private float[] values; // 0x38
			public float[] __3__values; // 0x40
			private int _i_5__2; // 0x48
	
			// Properties
			Keyframe IEnumerator<UnityEngine.Keyframe>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054D540-0x000000018054D560 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054D5A0-0x000000018054D600 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ToKeys_d__6(int __1__state); // 0x000000018054D600-0x000000018054D630
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018054D330-0x000000018054D4A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018054D560-0x000000018054D5A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Keyframe> IEnumerable<Keyframe>.GetEnumerator(); // 0x000000018054D4A0-0x000000018054D540
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018054D4A0-0x000000018054D540
		}
	
		// Constructors
		public CurveMapper(float xRange, float yRange); // 0x0000000180338D70-0x0000000180338DD0
	
		// Methods
		public void OnValidate(); // 0x0000000180338CE0-0x0000000180338D00
		public void Apply(glTF_VRM_DegreeMap degreeMap); // 0x0000000180338B70-0x0000000180338C90
		[IteratorStateMachine] // 0x0000000180037110-0x0000000180037160
		private IEnumerable<Keyframe> ToKeys(float[] values); // 0x0000000180338D00-0x0000000180338D70
		public float Map(float src); // 0x0000000180338C90-0x0000000180338CE0
	}
}
