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
	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 8539
	{
		// Fields
		[Tooltip] // 0x0000000180022B60-0x0000000180022B90
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 8538
		{
			// Fields
			[Tooltip] // 0x0000000180022B90-0x0000000180022BC0
			public Transform[] raycastFrom; // 0x10
			[Tooltip] // 0x0000000180022BC0-0x0000000180022BF0
			public Transform raycastTo; // 0x18
			[Range] // 0x0000000180022BF0-0x0000000180022C50
			[Tooltip] // 0x0000000180022BF0-0x0000000180022C50
			public float raycastRadius; // 0x20
			[Tooltip] // 0x0000000180022C50-0x0000000180022C80
			public EffectorLink[] effectors; // 0x28
			[Tooltip] // 0x0000000180022C80-0x0000000180022CB0
			public float smoothTimeIn; // 0x30
			[Tooltip] // 0x0000000180022CB0-0x0000000180022CE0
			public float smoothTimeOut; // 0x34
			[Tooltip] // 0x0000000180022CE0-0x0000000180022D10
			public LayerMask layers; // 0x38
			private Vector3 offset; // 0x3C
			private Vector3 offsetTarget; // 0x48
			private Vector3 offsetV; // 0x54
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 8537
			{
				// Fields
				[Tooltip] // 0x0000000180022D10-0x0000000180022D40
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x0000000180022D40-0x0000000180022D70
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001802650F0-0x0000000180265100
			}
	
			// Constructors
			public Avoider(); // 0x000000018083CC50-0x000000018083CC70
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight); // 0x000000018083C8C0-0x000000018083CC50
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver); // 0x000000018083C410-0x000000018083C5F0
			private Vector3 Raycast(Vector3 from, Vector3 to); // 0x000000018083C5F0-0x000000018083C8C0
		}
	
		// Constructors
		public PenetrationAvoidance(); // 0x0000000180776B40-0x0000000180776B50
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000180778100-0x0000000180778180
	}
}
