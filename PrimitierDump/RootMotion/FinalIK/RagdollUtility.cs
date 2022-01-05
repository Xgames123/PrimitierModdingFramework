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
	[RequireComponent] // 0x0000000180021960-0x00000001800219B0
	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 8498
	{
		// Fields
		[Tooltip] // 0x00000001800219B0-0x00000001800219E0
		public IK ik; // 0x18
		[Tooltip] // 0x00000001800219E0-0x0000000180021A10
		public float ragdollToAnimationTime; // 0x20
		[Tooltip] // 0x0000000180021A10-0x0000000180021A40
		public bool applyIkOnRagdoll; // 0x24
		[Tooltip] // 0x0000000180021A40-0x0000000180021A70
		public float applyVelocity; // 0x28
		[Tooltip] // 0x0000000180021A70-0x0000000180021AA0
		public float applyAngularVelocity; // 0x2C
		private Animator animator; // 0x30
		private Rigidbone[] rigidbones; // 0x38
		private Child[] children; // 0x40
		private bool enableRagdollFlag; // 0x48
		private AnimatorUpdateMode animatorUpdateMode; // 0x4C
		private IK[] allIKComponents; // 0x50
		private bool[] fixTransforms; // 0x58
		private float ragdollWeight; // 0x60
		private float ragdollWeightV; // 0x64
		private bool fixedFrame; // 0x68
		private bool[] disabledIKComponents; // 0x70
	
		// Properties
		private bool isRagdoll { get; } // 0x000000018077BCB0-0x000000018077BD20 
		private bool ikUsed { get; } // 0x000000018077BB60-0x000000018077BCB0 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 8495
		{
			// Fields
			public Rigidbody r; // 0x10
			public Transform t; // 0x18
			public Collider collider; // 0x20
			public Joint joint; // 0x28
			public Rigidbody c; // 0x30
			public bool updateAnchor; // 0x38
			public Vector3 deltaPosition; // 0x3C
			public Quaternion deltaRotation; // 0x48
			public float deltaTime; // 0x58
			public Vector3 lastPosition; // 0x5C
			public Quaternion lastRotation; // 0x68
	
			// Constructors
			public Rigidbone(Rigidbody r); // 0x000000018084B2C0-0x000000018084B440
	
			// Methods
			public void RecordVelocity(); // 0x000000018084AF00-0x000000018084B040
			public void WakeUp(float velocityWeight, float angularVelocityWeight); // 0x000000018084B040-0x000000018084B2C0
		}
	
		public class Child // TypeDefIndex: 8496
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child(Transform transform); // 0x000000018083EE70-0x000000018083EEE0
	
			// Methods
			public void FixTransform(float weight); // 0x000000018083EC50-0x000000018083EE10
			public void StoreLocalState(); // 0x000000018083EE10-0x000000018083EE70
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DisableRagdollSmooth_d__21 : IEnumerator<object> // TypeDefIndex: 8497
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RagdollUtility __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DisableRagdollSmooth_d__21(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018084FB90-0x000000018084FDF0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018084FDF0-0x000000018084FE30
		}
	
		// Constructors
		public RagdollUtility(); // 0x000000018077BA90-0x000000018077BB60
	
		// Methods
		public void EnableRagdoll(); // 0x000000018077A9B0-0x000000018077AA30
		public void DisableRagdoll(); // 0x000000018077A870-0x000000018077A9B0
		public void Start(); // 0x000000018077B210-0x000000018077B6A0
		[IteratorStateMachine] // 0x0000000180021AA0-0x0000000180021AF0
		private IEnumerator DisableRagdollSmooth(); // 0x000000018077A800-0x000000018077A870
		private void Update(); // 0x000000018077B700-0x000000018077BA90
		private void FixedUpdate(); // 0x000000018077AAA0-0x000000018077AB30
		private void LateUpdate(); // 0x000000018077AB30-0x000000018077AC70
		private void AfterLastIK(); // 0x000000018077A7D0-0x000000018077A800
		private void AfterAnimation(); // 0x000000018077A700-0x000000018077A7D0
		private void OnFinalPose(); // 0x000000018077AD90-0x000000018077AE70
		private void RagdollEnabler(); // 0x000000018077AE70-0x000000018077B1B0
		private void RecordVelocities(); // 0x000000018077B1B0-0x000000018077B210
		private void StoreLocalState(); // 0x000000018077B6A0-0x000000018077B700
		private void FixTransforms(float weight); // 0x000000018077AA30-0x000000018077AAA0
		private void OnDestroy(); // 0x000000018077AC70-0x000000018077AD90
	}
}
