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
	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 8383
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get; } // 0x0000000180815320-0x0000000180815370 
	
		// Constructors
		public ConstraintRotationOffset(); // 0x00000001802650F0-0x0000000180265100
		public ConstraintRotationOffset(Transform transform); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public override void UpdateConstraint(); // 0x0000000180815140-0x0000000180815320
	}
}
