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
	public class MotionAbsorb : OffsetModifier // TypeDefIndex: 8332
	{
		// Fields
		[Tooltip] // 0x000000018001C7B0-0x000000018001C7E0
		public Mode mode; // 0x30
		[Tooltip] // 0x000000018001C7E0-0x000000018001C810
		public Absorber[] absorbers; // 0x38
		[Tooltip] // 0x000000018001C810-0x000000018001C840
		public AnimationCurve falloff; // 0x40
		[Tooltip] // 0x000000018001C840-0x000000018001C870
		public float falloffSpeed; // 0x48
		private float timer; // 0x4C
		private float w; // 0x50
		private Mode initialMode; // 0x54
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 8330
		{
			Position = 0,
			PositionOffset = 1
		}
	
		[Serializable]
		public class Absorber // TypeDefIndex: 8331
		{
			// Fields
			[Tooltip] // 0x000000018001C870-0x000000018001C8A0
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x000000018001C8A0-0x000000018001C8D0
			public float weight; // 0x14
			private Vector3 position; // 0x18
			private Quaternion rotation; // 0x24
			private IKEffector e; // 0x38
	
			// Constructors
			public Absorber(); // 0x000000018083C060-0x000000018083C0A0
	
			// Methods
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode); // 0x000000018083BEF0-0x000000018083C020
			public void UpdateEffectorWeights(float w); // 0x000000018083C020-0x000000018083C060
			public void SetPosition(float w); // 0x000000018083BD50-0x000000018083BE50
			public void SetRotation(float w); // 0x000000018083BE50-0x000000018083BEF0
		}
	
		// Constructors
		public MotionAbsorb(); // 0x0000000180775A20-0x0000000180775A40
	
		// Methods
		protected override void Start(); // 0x00000001807758F0-0x0000000180775A20
		private void OnCollisionEnter(Collision c); // 0x00000001807755E0-0x0000000180775680
		protected override void OnModifyOffset(); // 0x00000001807757A0-0x00000001807758F0
		private void AfterIK(); // 0x0000000180775540-0x00000001807755E0
		protected override void OnDestroy(); // 0x0000000180775680-0x00000001807757A0
	}
}
