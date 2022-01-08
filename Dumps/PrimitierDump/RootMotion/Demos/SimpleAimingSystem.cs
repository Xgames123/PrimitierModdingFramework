/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class SimpleAimingSystem : MonoBehaviour // TypeDefIndex: 8299
	{
		// Fields
		[Tooltip] // 0x000000018001BF10-0x000000018001BF40
		public AimPoser aimPoser; // 0x18
		[Tooltip] // 0x000000018001BF40-0x000000018001BF70
		public AimIK aim; // 0x20
		[Tooltip] // 0x000000018001BF70-0x000000018001BFA0
		public LookAtIK lookAt; // 0x28
		[Tooltip] // 0x000000018001BFA0-0x000000018001BFD0
		public Animator animator; // 0x30
		[Tooltip] // 0x000000018001BFD0-0x000000018001C000
		public float crossfadeTime; // 0x38
		[Tooltip] // 0x000000018001C000-0x000000018001C030
		public float minAimDistance; // 0x3C
		private AimPoser.Pose aimPose; // 0x40
		private AimPoser.Pose lastPose; // 0x48
	
		// Constructors
		public SimpleAimingSystem(); // 0x0000000180716DA0-0x0000000180716DC0
	
		// Methods
		private void Start(); // 0x0000000180716D60-0x0000000180716DA0
		private void LateUpdate(); // 0x0000000180716800-0x0000000180716950
		private void Pose(); // 0x0000000180716B30-0x0000000180716D60
		private void LimitAimTarget(); // 0x0000000180716950-0x0000000180716B30
		private void DirectCrossFade(string state, float target); // 0x0000000180716770-0x0000000180716800
	}
}
