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
	[AddComponentMenu] // 0x000000018001EE90-0x000000018001EF10
	[RequireComponent] // 0x000000018001EE90-0x000000018001EF10
	public class CCDIKJ : MonoBehaviour // TypeDefIndex: 8417
	{
		// Fields
		[Tooltip] // 0x000000018001EA20-0x000000018001EA50
		public Transform target; // 0x18
		[Range] // 0x000000018001EF10-0x000000018001EF70
		[Tooltip] // 0x000000018001EF10-0x000000018001EF70
		public float weight; // 0x20
		[Tooltip] // 0x000000018001EF70-0x000000018001EFA0
		public float tolerance; // 0x24
		[Tooltip] // 0x000000018001ED10-0x000000018001ED40
		public int maxIterations; // 0x28
		[Tooltip] // 0x000000018001EDE0-0x000000018001EE10
		public bool useRotationLimits; // 0x2C
		[Tooltip] // 0x000000018001EE10-0x000000018001EE40
		public bool XY; // 0x2D
		[Tooltip] // 0x000000018001EFA0-0x000000018001EFD0
		public Transform[] bones; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x38
		private Animator animator; // 0x40
		private PlayableGraph graph; // 0x48
		private AnimationScriptPlayable IKPlayable; // 0x58
		private CCDIKJob job; // 0x68
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018030F460-0x000000018030F470 0x000000018030F6E0-0x000000018030F6F0
	
		// Constructors
		public CCDIKJ(); // 0x00000001807CC390-0x00000001807CC3F0
	
		// Methods
		private void OnEnable(); // 0x00000001807CBCB0-0x00000001807CC210
		private void Update(); // 0x00000001807CC210-0x00000001807CC390
		private void OnDisable(); // 0x00000001807CBC30-0x00000001807CBCB0
	}
}
