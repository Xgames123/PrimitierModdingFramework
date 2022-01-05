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
	public class VRMLookAtBlendShapeApplyer : MonoBehaviour, IVRMComponent // TypeDefIndex: 8076
	{
		// Fields
		public bool DrawGizmo; // 0x18
		[Header] // 0x0000000180037290-0x00000001800372E0
		[SerializeField] // 0x0000000180037290-0x00000001800372E0
		public CurveMapper Horizontal; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalDown; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public CurveMapper VerticalUp; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public bool m_notSetValueApply; // 0x38
		private VRMLookAtHead m_head; // 0x40
		private VRMBlendShapeProxy m_proxy; // 0x48
	
		// Constructors
		public VRMLookAtBlendShapeApplyer(); // 0x0000000180346A70-0x0000000180346BB0
	
		// Methods
		public void OnImported(VRMImporterContext context); // 0x00000001803468C0-0x0000000180346940
		private void Start(); // 0x0000000180346940-0x0000000180346A70
		private void ApplyRotations(float yaw, float pitch); // 0x00000001803465E0-0x00000001803468C0
	}
}
