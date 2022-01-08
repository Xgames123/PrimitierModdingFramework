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
	public class BodyTilt : OffsetModifier // TypeDefIndex: 8513
	{
		// Fields
		[Tooltip] // 0x0000000180022290-0x00000001800222C0
		public float tiltSpeed; // 0x30
		[Tooltip] // 0x00000001800222C0-0x00000001800222F0
		public float tiltSensitivity; // 0x34
		[Tooltip] // 0x00000001800222F0-0x0000000180022320
		public OffsetPose poseLeft; // 0x38
		[Tooltip] // 0x00000001800222F0-0x0000000180022320
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt(); // 0x00000001807CBC10-0x00000001807CBC30
	
		// Methods
		protected override void Start(); // 0x00000001807CBBC0-0x00000001807CBC10
		protected override void OnModifyOffset(); // 0x00000001807CB9C0-0x00000001807CBBC0
	}
}
