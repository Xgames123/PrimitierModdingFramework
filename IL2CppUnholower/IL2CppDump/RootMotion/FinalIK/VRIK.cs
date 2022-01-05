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
	[AddComponentMenu] // 0x000000018001E800-0x000000018001E830
	public class VRIK : IK // TypeDefIndex: 8414
	{
		// Fields
		[ContextMenuItem] // 0x000000018001E830-0x000000018001E8B0
		[Tooltip] // 0x000000018001E830-0x000000018001E8B0
		public References references; // 0x38
		[Tooltip] // 0x000000018001E8B0-0x000000018001E8E0
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 8413
		{
			// Fields
			public Transform root; // 0x10
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform chest; // 0x28
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform neck; // 0x30
			public Transform head; // 0x38
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform leftShoulder; // 0x40
			public Transform leftUpperArm; // 0x48
			public Transform leftForearm; // 0x50
			public Transform leftHand; // 0x58
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform rightShoulder; // 0x60
			public Transform rightUpperArm; // 0x68
			public Transform rightForearm; // 0x70
			public Transform rightHand; // 0x78
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform leftThigh; // 0x80
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform leftCalf; // 0x88
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform leftFoot; // 0x90
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform leftToes; // 0x98
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform rightThigh; // 0xA0
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform rightCalf; // 0xA8
			[Tooltip] // 0x000000018001E970-0x000000018001E9A0
			public Transform rightFoot; // 0xB0
			[Tooltip] // 0x000000018001E940-0x000000018001E970
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get; } // 0x000000018084A9E0-0x000000018084AF00 
			public bool isEmpty { get; } // 0x000000018084A4D0-0x000000018084A9E0 
	
			// Constructors
			public References(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public Transform[] GetTransforms(); // 0x0000000180849D60-0x000000018084A4D0
			public static bool AutoDetectReferences(Transform root, out References references); // 0x0000000180849970-0x0000000180849D60
		}
	
		// Constructors
		public VRIK(); // 0x0000000180720770-0x0000000180720800
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		protected override void OpenUserManual(); // 0x00000001807205A0-0x0000000180720600
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		protected override void OpenScriptReference(); // 0x0000000180720500-0x0000000180720560
		[ContextMenu] // 0x000000018001E8E0-0x000000018001E910
		private void OpenSetupTutorial(); // 0x0000000180720560-0x00000001807205A0
		[ContextMenu] // 0x000000018001E620-0x000000018001E650
		public void AutoDetectReferences(); // 0x0000000180720420-0x0000000180720450
		[ContextMenu] // 0x000000018001E910-0x000000018001E940
		public void GuessHandOrientations(); // 0x0000000180720450-0x0000000180720480
		public override IKSolver GetIKSolver(); // 0x0000000180268310-0x0000000180268320
		protected override void InitiateSolver(); // 0x0000000180720480-0x0000000180720500
		protected override void UpdateSolver(); // 0x0000000180720600-0x0000000180720770
	}
}
