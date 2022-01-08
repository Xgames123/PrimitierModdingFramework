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
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 8381
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get; } // 0x0000000180814F90-0x0000000180814FF0 
	
		// Constructors
		public ConstraintPositionOffset(); // 0x00000001802650F0-0x0000000180265100
		public ConstraintPositionOffset(Transform transform); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public override void UpdateConstraint(); // 0x0000000180814D50-0x0000000180814F90
	}
}
