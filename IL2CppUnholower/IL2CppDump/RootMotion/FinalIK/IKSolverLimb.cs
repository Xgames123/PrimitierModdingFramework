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
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 8455
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float maintainRotationWeight; // 0xB0
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float bendModifierWeight; // 0xB4
		public Transform bendGoal; // 0xB8
		private bool maintainBendFor1Frame; // 0xC0
		private bool maintainRotationFor1Frame; // 0xC1
		private Quaternion defaultRootRotation; // 0xC4
		private Quaternion parentDefaultRotation; // 0xD4
		private Quaternion bone3RotationBeforeSolve; // 0xE4
		private Quaternion maintainRotation; // 0xF4
		private Quaternion bone3DefaultRotation; // 0x104
		private Vector3 _bendNormal; // 0x114
		private Vector3 animationNormal; // 0x120
		private AxisDirection[] axisDirectionsLeft; // 0x130
		private AxisDirection[] axisDirectionsRight; // 0x138
	
		// Properties
		private AxisDirection[] axisDirections { get; } // 0x00000001807EFD00-0x00000001807EFD20 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 8453
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 8454
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis); // 0x000000018070CBE0-0x000000018070CC40
		}
	
		// Constructors
		public IKSolverLimb(); // 0x00000001807EFC10-0x00000001807EFC80
		public IKSolverLimb(AvatarIKGoal goal); // 0x00000001807EFC80-0x00000001807EFD00
	
		// Methods
		public void MaintainRotation(); // 0x00000001807EF2D0-0x00000001807EF320
		public void MaintainBend(); // 0x00000001807EF280-0x00000001807EF2D0
		protected override void OnInitiateVirtual(); // 0x00000001807EF320-0x00000001807EF730
		protected override void OnUpdateVirtual(); // 0x00000001807EF800-0x00000001807EF910
		protected override void OnPostSolveVirtual(); // 0x00000001807EF730-0x00000001807EF800
		private void StoreAxisDirections(ref AxisDirection[] axisDirections); // 0x00000001807EF910-0x00000001807EFC10
		private Vector3 GetModifiedBendNormal(); // 0x00000001807EE570-0x00000001807EF280
	}
}
