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
	public class LookAtTargetSwitcher : MonoBehaviour // TypeDefIndex: 8071
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<Transform> m_targets; // 0x18
		[Range] // 0x0000000180037160-0x00000001800371A0
		[SerializeField] // 0x0000000180037160-0x00000001800371A0
		private float m_thresholdDegrees; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private VRMLookAtHead m_lookAtHead; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Blinker m_blinker; // 0x30
		private Transform m_lastTarget; // 0x38
	
		// Constructors
		public LookAtTargetSwitcher(); // 0x0000000180339BC0-0x0000000180339C40
	
		// Methods
		private void Reset(); // 0x0000000180339860-0x00000001803398F0
		private float CalcScore(Transform target); // 0x00000001803394B0-0x00000001803395B0
		private Transform ChooseTarget(); // 0x00000001803395B0-0x0000000180339860
		private void Update(); // 0x00000001803398F0-0x0000000180339BC0
	}
}
