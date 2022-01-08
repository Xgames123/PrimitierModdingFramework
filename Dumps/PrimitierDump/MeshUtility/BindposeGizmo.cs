/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	[DisallowMultipleComponent] // 0x0000000180014D50-0x0000000180014D60
	public class BindposeGizmo : MonoBehaviour // TypeDefIndex: 5636
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Mesh m_target; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float[] m_boneWeights; // 0x20
		[Range] // 0x0000000180026F10-0x0000000180026F50
		[SerializeField] // 0x0000000180026F10-0x0000000180026F50
		private float m_gizmoSize; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_meshGizmoColor; // 0x2C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_bindGizmoColor; // 0x3C
	
		// Constructors
		public BindposeGizmo(); // 0x00000001810AC820-0x00000001810AC870
	
		// Methods
		private void Reset(); // 0x00000001810AC780-0x00000001810AC820
		private void OnDrawGizmos(); // 0x00000001810AC0D0-0x00000001810AC780
	}
}
