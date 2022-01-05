/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMLookAtHead : MonoBehaviour, IVRMComponent // TypeDefIndex: 8079
	{
		// Fields
		public bool DrawGizmo; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public UpdateType UpdateType; // 0x1C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform Target; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform Head; // 0x28
		[Header] // 0x00000001800372E0-0x0000000180037330
		[SerializeField] // 0x00000001800372E0-0x0000000180037330
		private float m_yaw; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_pitch; // 0x34
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Action<float, float> YawPitchChanged; // 0x38
	
		// Properties
		public Matrix4x4 YawMatrix { get; } // 0x0000000180349580-0x00000001803496C0 
		public float Yaw { get; } // 0x00000001803496C0-0x00000001803496D0 
		public float Pitch { get; } // 0x0000000180349570-0x0000000180349580 
	
		// Events
		public event Action<float, float> YawPitchChanged {
			add; // 0x00000001803494D0-0x0000000180349570
			remove; // 0x00000001803496D0-0x0000000180349770
		}
	
		// Constructors
		public VRMLookAtHead(); // 0x00000001803494B0-0x00000001803494D0
	
		// Methods
		public Texture2D CreateThumbnail(); // 0x0000000180347B00-0x0000000180347C50
		private void CreateThumbnail(Camera camera, Texture2D dst); // 0x0000000180347C50-0x0000000180348090
		public void LookFace(Transform t); // 0x0000000180348A70-0x0000000180348CD0
		private void Awake(); // 0x0000000180347990-0x0000000180347B00
		public void OnImported(VRMImporterContext context); // 0x0000000180349070-0x00000001803493B0
		private static Matrix4x4 LookAtMatrixFromWorld(Vector3 from, Vector3 target); // 0x0000000180348120-0x0000000180348550
		private static Matrix4x4 LookAtMatrix(Vector3 up_vector, Vector3 localPosition); // 0x0000000180348550-0x0000000180348790
		private static Matrix4x4 LookAtMatrix(Matrix4x4 m, Vector3 target); // 0x0000000180348790-0x0000000180348A70
		public void RaiseYawPitchChanged(float yaw, float pitch); // 0x00000001803493B0-0x0000000180349420
		private void Update(); // 0x0000000180349420-0x00000001803494B0
		private void LateUpdate(); // 0x0000000180348090-0x0000000180348120
		public void LookWorldPosition(); // 0x0000000180348E70-0x0000000180349070
		public void LookWorldPosition(Vector3 targetPosition, out float yaw, out float pitch); // 0x0000000180348CD0-0x0000000180348E70
	}
}
