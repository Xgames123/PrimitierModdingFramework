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
	public class Inertia : OffsetModifier // TypeDefIndex: 8528
	{
		// Fields
		[Tooltip] // 0x0000000180022690-0x00000001800226C0
		public Body[] bodies; // 0x30
		[Tooltip] // 0x00000001800226C0-0x00000001800226F0
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 8527
		{
			// Fields
			[Tooltip] // 0x00000001800226F0-0x0000000180022720
			public Transform transform; // 0x10
			[Tooltip] // 0x0000000180022720-0x0000000180022750
			public EffectorLink[] effectorLinks; // 0x18
			[Tooltip] // 0x0000000180022750-0x0000000180022780
			public float speed; // 0x20
			[Tooltip] // 0x0000000180022780-0x00000001800227B0
			public float acceleration; // 0x24
			[Range] // 0x00000001800227B0-0x0000000180022800
			[Tooltip] // 0x00000001800227B0-0x0000000180022800
			public float matchVelocity; // 0x28
			[Tooltip] // 0x0000000180022800-0x0000000180022830
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 8526
			{
				// Fields
				[Tooltip] // 0x0000000180022230-0x0000000180022260
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x0000000180022260-0x0000000180022290
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001802650F0-0x0000000180265100
			}
	
			// Constructors
			public Body(); // 0x000000018083DC90-0x000000018083DCB0
	
			// Methods
			public void Reset(); // 0x000000018083D690-0x000000018083D770
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime); // 0x000000018083D770-0x000000018083DC90
		}
	
		// Constructors
		public Inertia(); // 0x00000001807BDCD0-0x00000001807BDCE0
	
		// Methods
		public void ResetBodies(); // 0x00000001807FA510-0x00000001807FA580
		protected override void OnModifyOffset(); // 0x00000001807FA440-0x00000001807FA510
	}
}
