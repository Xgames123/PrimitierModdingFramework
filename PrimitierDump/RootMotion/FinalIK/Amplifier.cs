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
	public class Amplifier : OffsetModifier // TypeDefIndex: 8512
	{
		// Fields
		[Tooltip] // 0x00000001800220E0-0x0000000180022110
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 8511
		{
			// Fields
			[Tooltip] // 0x0000000180022110-0x0000000180022140
			public Transform transform; // 0x10
			[Tooltip] // 0x0000000180022140-0x0000000180022170
			public Transform relativeTo; // 0x18
			[Tooltip] // 0x0000000180022170-0x00000001800221A0
			public EffectorLink[] effectorLinks; // 0x20
			[Tooltip] // 0x00000001800221A0-0x00000001800221D0
			public float verticalWeight; // 0x28
			[Tooltip] // 0x00000001800221D0-0x0000000180022200
			public float horizontalWeight; // 0x2C
			[Tooltip] // 0x0000000180022200-0x0000000180022230
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 8510
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
			public Body(); // 0x000000018070D410-0x000000018070D430
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime); // 0x000000018070CDC0-0x000000018070D410
			private static Vector3 Multiply(Vector3 v1, Vector3 v2); // 0x000000018070CD60-0x000000018070CDC0
		}
	
		// Constructors
		public Amplifier(); // 0x00000001807BDCD0-0x00000001807BDCE0
	
		// Methods
		protected override void OnModifyOffset(); // 0x00000001807BDB80-0x00000001807BDCD0
	}
}
