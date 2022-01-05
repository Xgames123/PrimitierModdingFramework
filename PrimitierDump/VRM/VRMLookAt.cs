/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Obsolete] // 0x00000001800371E0-0x0000000180037210
	public class VRMLookAt : MonoBehaviour // TypeDefIndex: 8075
	{
		// Fields
		public bool DrawGizmo; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public bool UseUpdate; // 0x19
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform Target; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public OffsetOnTransform LeftEye; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public OffsetOnTransform RightEye; // 0xB0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public OffsetOnTransform Head; // 0x138
		[Header] // 0x0000000180037210-0x0000000180037250
		[SerializeField] // 0x0000000180037210-0x0000000180037250
		public CurveMapper HorizontalOuter; // 0x1C0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper HorizontalInner; // 0x1C8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalDown; // 0x1D0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalUp; // 0x1D8
		private const float SIZE = 0.5f; // Metadata: 0x003A61EE
		[Header] // 0x0000000180037250-0x0000000180037290
		[SerializeField] // 0x0000000180037250-0x0000000180037290
		public float Yaw; // 0x1E0
		public float Pitch; // 0x1E4
	
		// Properties
		public Matrix4x4 YawMatrix { get; } // 0x000000018034B380-0x000000018034B4E0 
	
		// Constructors
		public VRMLookAt(); // 0x000000018034B1F0-0x000000018034B380
	
		// Methods
		public Texture2D CreateThumbnail(); // 0x000000018034A480-0x000000018034A5D0
		private void CreateThumbnail(Camera camera, Texture2D dst); // 0x000000018034A030-0x000000018034A480
		public void LookFace(Transform t); // 0x000000018034A9F0-0x000000018034AC50
		public void CopyTo(GameObject _dst, Dictionary<Transform, Transform> map); // 0x0000000180349DD0-0x000000018034A030
		private void Reset(); // 0x000000018034AFB0-0x000000018034B1F0
		private void OnValidate(); // 0x000000018034AF20-0x000000018034AFB0
		public void GetBones(); // 0x000000018034A5D0-0x000000018034A7F0
		private void Awake(); // 0x0000000180349D90-0x0000000180349DD0
		private static void DrawMatrix(Matrix4x4 m, float size); // 0x0000000180347090-0x00000001803472A0
		private void OnDrawGizmos(); // 0x000000018034ADB0-0x000000018034AF20
		private static Matrix4x4 LookAtMatrixFromWorld(Vector3 from, Vector3 target); // 0x0000000180348120-0x0000000180348550
		private static Matrix4x4 LookAtMatrix(Vector3 up_vector, Vector3 localPosition); // 0x0000000180348550-0x0000000180348790
		private static Matrix4x4 LookAtMatrix(Matrix4x4 m, Vector3 target); // 0x0000000180348790-0x0000000180348A70
		private void LateUpdate(); // 0x000000018034A7F0-0x000000018034A9F0
		public void LookWorldPosition(Vector3 targetPosition); // 0x000000018034AC50-0x000000018034ADB0
		private void ApplyRotations(float yaw, float pitch); // 0x0000000180349770-0x0000000180349D90
	}
}
