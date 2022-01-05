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
	[DefaultExecutionOrder] // 0x00000001800375A0-0x00000001800375C0
	public sealed class VRMSpringBone : MonoBehaviour // TypeDefIndex: 8097
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string m_comment; // 0x18
		[Header] // 0x00000001800375C0-0x0000000180037600
		[SerializeField] // 0x00000001800375C0-0x0000000180037600
		private bool m_drawGizmo; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_gizmoColor; // 0x24
		[Header] // 0x0000000180037600-0x0000000180037660
		[Range] // 0x0000000180037600-0x0000000180037660
		[SerializeField] // 0x0000000180037600-0x0000000180037660
		public float m_stiffnessForce; // 0x34
		[Range] // 0x0000000180037660-0x00000001800376A0
		[SerializeField] // 0x0000000180037660-0x00000001800376A0
		public float m_gravityPower; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 m_gravityDir; // 0x3C
		[Range] // 0x000000018001C600-0x000000018001C640
		[SerializeField] // 0x000000018001C600-0x000000018001C640
		public float m_dragForce; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform m_center; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public List<Transform> RootBones; // 0x58
		private Dictionary<Transform, Quaternion> m_initialLocalRotationMap; // 0x60
		[Header] // 0x00000001800376A0-0x0000000180037700
		[Range] // 0x00000001800376A0-0x0000000180037700
		[SerializeField] // 0x00000001800376A0-0x0000000180037700
		public float m_hitRadius; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public VRMSpringBoneColliderGroup[] ColliderGroups; // 0x70
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public SpringBoneUpdateType m_updateType; // 0x78
		private List<VRMSpringBoneLogic> m_verlet; // 0x80
		private List<SphereCollider> m_colliders; // 0x88
	
		// Nested types
		public enum SpringBoneUpdateType // TypeDefIndex: 8093
		{
			LateUpdate = 0,
			FixedUpdate = 1
		}
	
		private class VRMSpringBoneLogic // TypeDefIndex: 8094
		{
			// Fields
			private Transform m_transform; // 0x10
			private Vector3 m_boneAxis; // 0x18
			private Vector3 m_currentTail; // 0x24
			private readonly float m_length; // 0x30
			private Vector3 m_localDir; // 0x34
			private Vector3 m_prevTail; // 0x40
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private readonly Quaternion _LocalRotation_k__BackingField; // 0x4C
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _Radius_k__BackingField; // 0x5C
	
			// Properties
			public Transform Head { get; } // 0x0000000180268FC0-0x0000000180268FD0 
			public Vector3 Tail { get; } // 0x0000000180552340-0x0000000180552440 
			private Quaternion LocalRotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180552250-0x0000000180552260 
			public float Radius { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180552330-0x0000000180552340 0x0000000180552440-0x0000000180552450
			private Quaternion ParentRotation { get; } // 0x0000000180552260-0x0000000180552330 
	
			// Constructors
			public VRMSpringBoneLogic(Transform center, Transform transform, Vector3 localChildPosition); // 0x00000001805520E0-0x0000000180552250
	
			// Methods
			public void Update(Transform center, float stiffnessForce, float dragForce, Vector3 external, List<VRM.VRMSpringBone.SphereCollider> colliders); // 0x0000000180551C10-0x00000001805520E0
			protected virtual Quaternion ApplyRotation(Vector3 nextTail); // 0x00000001805514D0-0x0000000180551650
			protected virtual Vector3 Collision(List<VRM.VRMSpringBone.SphereCollider> colliders, Vector3 nextTail); // 0x0000000180551650-0x00000001805519F0
			public void DrawGizmo(Transform center, float radius, Color color); // 0x00000001805519F0-0x0000000180551C10
		}
	
		public struct SphereCollider // TypeDefIndex: 8095
		{
			// Fields
			public readonly Vector3 Position; // 0x00
			public readonly float Radius; // 0x0C
	
			// Constructors
			public SphereCollider(Transform transform, VRMSpringBoneColliderGroup.SphereCollider collider); // 0x000000018054A930-0x000000018054A9F0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetChildren_d__19 : IEnumerable<Transform>, IEnumerator<Transform> // TypeDefIndex: 8096
		{
			// Fields
			private int __1__state; // 0x10
			private Transform __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Transform parent; // 0x28
			public Transform __3__parent; // 0x30
			private int _i_5__2; // 0x38
	
			// Properties
			Transform IEnumerator<UnityEngine.Transform>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetChildren_d__19(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018054BAD0-0x000000018054BB50
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018054BBF0-0x000000018054BC30
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Transform> IEnumerable<Transform>.GetEnumerator(); // 0x000000018054BB50-0x000000018054BBF0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018054BB50-0x000000018054BBF0
		}
	
		// Constructors
		public VRMSpringBone(); // 0x0000000180553830-0x0000000180553960
	
		// Methods
		private void Awake(); // 0x0000000180552450-0x0000000180552460
		[ContextMenu] // 0x0000000180037700-0x0000000180037730
		public void Setup(bool force = false /* Metadata: 0x003A6202 */); // 0x0000000180552FE0-0x0000000180553470
		public void SetLocalRotationsIdentity(); // 0x00000001805528D0-0x0000000180552A20
		[IteratorStateMachine] // 0x0000000180037730-0x0000000180037780
		private static IEnumerable<Transform> GetChildren(Transform parent); // 0x0000000180552490-0x0000000180552500
		private void SetupRecursive(Transform center, Transform parent); // 0x0000000180552A20-0x0000000180552FE0
		private void LateUpdate(); // 0x0000000180552500-0x0000000180552530
		private void FixedUpdate(); // 0x0000000180552460-0x0000000180552490
		private void UpdateProcess(float deltaTime); // 0x0000000180553470-0x0000000180553830
		private void OnDrawGizmos(); // 0x0000000180552530-0x00000001805528D0
	}
}
