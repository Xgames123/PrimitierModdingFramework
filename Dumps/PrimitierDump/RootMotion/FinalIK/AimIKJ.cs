/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018001E9A0-0x000000018001EA20
	[RequireComponent] // 0x000000018001E9A0-0x000000018001EA20
	public class AimIKJ : MonoBehaviour // TypeDefIndex: 8415
	{
		// Fields
		[Tooltip] // 0x000000018001EA20-0x000000018001EA50
		public Transform target; // 0x18
		[Tooltip] // 0x000000018001EA50-0x000000018001EA80
		public Transform poleTarget; // 0x20
		[Tooltip] // 0x000000018001EA80-0x000000018001EAB0
		public Transform aimTransform; // 0x28
		[Space] // 0x000000018001EAB0-0x000000018001EB00
		[Tooltip] // 0x000000018001EAB0-0x000000018001EB00
		public float axisX; // 0x30
		[Tooltip] // 0x000000018001EB00-0x000000018001EB30
		public float axisY; // 0x34
		[Tooltip] // 0x000000018001EB30-0x000000018001EB60
		public float axisZ; // 0x38
		[Space] // 0x000000018001EB60-0x000000018001EBB0
		[Tooltip] // 0x000000018001EB60-0x000000018001EBB0
		public float poleAxisX; // 0x3C
		[Tooltip] // 0x000000018001EBB0-0x000000018001EBE0
		public float poleAxisY; // 0x40
		[Tooltip] // 0x000000018001EBE0-0x000000018001EC10
		public float poleAxisZ; // 0x44
		[Range] // 0x000000018001EC10-0x000000018001EC80
		[Space] // 0x000000018001EC10-0x000000018001EC80
		[Tooltip] // 0x000000018001EC10-0x000000018001EC80
		public float weight; // 0x48
		[Range] // 0x000000018001EC80-0x000000018001ECE0
		[Tooltip] // 0x000000018001EC80-0x000000018001ECE0
		public float poleWeight; // 0x4C
		[Tooltip] // 0x000000018001ECE0-0x000000018001ED10
		public float tolerance; // 0x50
		[Tooltip] // 0x000000018001ED10-0x000000018001ED40
		public int maxIterations; // 0x54
		[Range] // 0x000000018001ED40-0x000000018001ED90
		[Tooltip] // 0x000000018001ED40-0x000000018001ED90
		public float clampWeight; // 0x58
		[Range] // 0x000000018001ED90-0x000000018001EDE0
		[Tooltip] // 0x000000018001ED90-0x000000018001EDE0
		public int clampSmoothing; // 0x5C
		[Tooltip] // 0x000000018001EDE0-0x000000018001EE10
		public bool useRotationLimits; // 0x60
		[Tooltip] // 0x000000018001EE10-0x000000018001EE40
		public bool XY; // 0x61
		[Space] // 0x000000018001EE40-0x000000018001EE90
		[Tooltip] // 0x000000018001EE40-0x000000018001EE90
		public Transform[] bones; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x70
		private Animator animator; // 0x78
		private PlayableGraph graph; // 0x80
		private AnimationScriptPlayable IKPlayable; // 0x90
		private AimIKJob job; // 0xA0
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018042B150-0x000000018042B160 0x000000018042B3B0-0x000000018042B3C0
		public Vector3 axis { get; set; } // 0x00000001807BA210-0x00000001807BA230 0x00000001807BA250-0x00000001807BA290
		public Vector3 poleAxis { get; set; } // 0x00000001807BA230-0x00000001807BA250 0x00000001807BA290-0x00000001807BA2D0
	
		// Constructors
		public AimIKJ(); // 0x00000001807BA190-0x00000001807BA210
	
		// Methods
		private void OnEnable(); // 0x00000001807B94D0-0x00000001807B9DA0
		private void Update(); // 0x00000001807B9DA0-0x00000001807BA190
		private void OnDisable(); // 0x00000001807B9450-0x00000001807B94D0
	}
}
