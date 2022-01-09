/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public class LookAtController : MonoBehaviour // TypeDefIndex: 8529
	{
		// Fields
		public LookAtIK ik; // 0x18
		[Header] // 0x0000000180022830-0x0000000180022890
		[Tooltip] // 0x0000000180022830-0x0000000180022890
		public Transform target; // 0x20
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float weight; // 0x28
		public Vector3 offset; // 0x2C
		[Tooltip] // 0x0000000180021D40-0x0000000180021D70
		public float targetSwitchSmoothTime; // 0x38
		[Tooltip] // 0x0000000180022890-0x00000001800228C0
		public float weightSmoothTime; // 0x3C
		[Header] // 0x0000000180021DA0-0x0000000180021E00
		[Tooltip] // 0x0000000180021DA0-0x0000000180021E00
		public bool smoothTurnTowardsTarget; // 0x40
		[Tooltip] // 0x0000000180021E00-0x0000000180021E30
		public float maxRadiansDelta; // 0x44
		[Tooltip] // 0x0000000180021E30-0x0000000180021E60
		public float maxMagnitudeDelta; // 0x48
		[Tooltip] // 0x0000000180021E60-0x0000000180021E90
		public float slerpSpeed; // 0x4C
		[Tooltip] // 0x00000001800228C0-0x00000001800228F0
		public Vector3 pivotOffsetFromRoot; // 0x50
		[Tooltip] // 0x00000001800228F0-0x0000000180022920
		public float minDistance; // 0x5C
		[Header] // 0x0000000180022920-0x00000001800229A0
		[Range] // 0x0000000180022920-0x00000001800229A0
		[Tooltip] // 0x0000000180022920-0x00000001800229A0
		public float maxRootAngle; // 0x60
		private Transform lastTarget; // 0x68
		private float switchWeight; // 0x70
		private float switchWeightV; // 0x74
		private float weightV; // 0x78
		private Vector3 lastPosition; // 0x7C
		private Vector3 dir; // 0x88
		private bool lastSmoothTowardsTarget; // 0x94
	
		// Properties
		private Vector3 pivot { get; } // 0x0000000180772C90-0x0000000180772DA0 
	
		// Constructors
		public LookAtController(); // 0x0000000180772C20-0x0000000180772C90
	
		// Methods
		private void Start(); // 0x0000000180772B50-0x0000000180772C20
		private void LateUpdate(); // 0x0000000180771F40-0x00000001807728C0
		private void ApplyMinDistance(); // 0x0000000180771DD0-0x0000000180771F40
		private void RootRotation(); // 0x00000001807728C0-0x0000000180772B50
	}
}
