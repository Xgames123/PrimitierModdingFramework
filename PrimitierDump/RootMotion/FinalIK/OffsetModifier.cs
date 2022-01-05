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
	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 8532
	{
		// Fields
		[Tooltip] // 0x000000018001C550-0x000000018001C580
		public float weight; // 0x18
		[Tooltip] // 0x00000001800229A0-0x00000001800229D0
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000180776E20-0x0000000180776E40 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 8530
		{
			// Fields
			[Tooltip] // 0x0000000180022A20-0x0000000180022A50
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x0000000180022A50-0x0000000180022A80
			public float spring; // 0x14
			[Tooltip] // 0x0000000180022A80-0x0000000180022AB0
			public bool x; // 0x18
			[Tooltip] // 0x0000000180022A80-0x0000000180022AB0
			public bool y; // 0x19
			[Tooltip] // 0x0000000180022A80-0x0000000180022AB0
			public bool z; // 0x1A
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float minX; // 0x1C
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float maxX; // 0x20
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float minY; // 0x24
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float maxY; // 0x28
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float minZ; // 0x2C
			[Tooltip] // 0x0000000180022AB0-0x0000000180022AE0
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation); // 0x0000000180847E60-0x0000000180848050
			private float SpringAxis(float value, float min, float max); // 0x0000000180848050-0x00000001808480D0
			private float Spring(float value, float limit, bool negative); // 0x00000001808480D0-0x0000000180848140
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Initiate_d__8 : IEnumerator<object> // TypeDefIndex: 8531
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifier __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Initiate_d__8(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018084FFD0-0x0000000180850130
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180850130-0x0000000180850170
		}
	
		// Constructors
		protected OffsetModifier(); // 0x0000000180776B40-0x0000000180776B50
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x0000000180777190-0x0000000180777200
		[IteratorStateMachine] // 0x00000001800229D0-0x0000000180022A20
		private IEnumerator Initiate(); // 0x0000000180776F30-0x0000000180776FA0
		private void ModifyOffset(); // 0x0000000180776FA0-0x0000000180777080
		protected void ApplyLimits(OffsetLimits[] limits); // 0x0000000180776E40-0x0000000180776F30
		protected virtual void OnDestroy(); // 0x0000000180777080-0x0000000180777190
	}
}
