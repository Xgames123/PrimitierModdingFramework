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
	public class LookTarget : MonoBehaviour // TypeDefIndex: 8072
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform Target; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 m_offset; // 0x20
		[Range] // 0x00000001800371A0-0x00000001800371E0
		[SerializeField] // 0x00000001800371A0-0x00000001800371E0
		private float m_distance; // 0x2C
		public OffsetOnTransform m_offsetTransform; // 0x30
	
		// Constructors
		public LookTarget(); // 0x0000000180339F80-0x0000000180339FC0
	
		// Methods
		private void Update(); // 0x0000000180339C40-0x0000000180339F80
	}
}
