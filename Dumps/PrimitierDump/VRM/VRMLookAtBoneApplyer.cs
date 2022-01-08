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
	public class VRMLookAtBoneApplyer : MonoBehaviour, IVRMComponent // TypeDefIndex: 8077
	{
		// Fields
		public bool DrawGizmo; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public OffsetOnTransform LeftEye; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public OffsetOnTransform RightEye; // 0xA8
		[Header] // 0x0000000180037210-0x0000000180037250
		[SerializeField] // 0x0000000180037210-0x0000000180037250
		public CurveMapper HorizontalOuter; // 0x130
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper HorizontalInner; // 0x138
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalDown; // 0x140
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalUp; // 0x148
		private VRMLookAtHead m_head; // 0x150
		private const float SIZE = 0.5f; // Metadata: 0x003A61F2
	
		// Constructors
		public VRMLookAtBoneApplyer(); // 0x0000000180347810-0x0000000180347990
	
		// Methods
		public void OnImported(VRMImporterContext context); // 0x00000001803473E0-0x0000000180347600
		private void OnValidate(); // 0x0000000180347600-0x0000000180347690
		private void Start(); // 0x0000000180347690-0x0000000180347810
		private static void DrawMatrix(Matrix4x4 m, float size); // 0x0000000180347090-0x00000001803472A0
		private void OnDrawGizmos(); // 0x00000001803472A0-0x00000001803473E0
		private void ApplyRotations(float yaw, float pitch); // 0x0000000180346BB0-0x0000000180347090
	}
}
