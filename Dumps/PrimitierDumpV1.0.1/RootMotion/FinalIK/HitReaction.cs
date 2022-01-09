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
	public class HitReaction : OffsetModifier // TypeDefIndex: 8519
	{
		// Fields
		[Tooltip] // 0x0000000180022320-0x0000000180022350
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip] // 0x0000000180022350-0x0000000180022380
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get; } // 0x0000000180866C30-0x0000000180866D00 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 8514
		{
			// Fields
			[Tooltip] // 0x0000000180022380-0x00000001800223B0
			public string name; // 0x10
			[Tooltip] // 0x00000001800223B0-0x00000001800223E0
			public Collider collider; // 0x18
			[SerializeField] // 0x00000001800223E0-0x0000000180022430
			[Tooltip] // 0x00000001800223E0-0x0000000180022430
			private float crossFadeTime; // 0x20
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _crossFader_k__BackingField; // 0x24
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _timer_k__BackingField; // 0x28
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _force_k__BackingField; // 0x2C
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _point_k__BackingField; // 0x38
			private float length; // 0x44
			private float crossFadeSpeed; // 0x48
			private float lastTime; // 0x4C
	
			// Properties
			public bool inProgress { get; } // 0x00000001807109E0-0x00000001807109F0 
			protected float crossFader { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109B0-0x00000001807109C0 0x0000000180710A10-0x0000000180710A20
			protected float timer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B100-0x000000018036B110 0x000000018036B600-0x000000018036B610
			protected Vector3 force { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109C0-0x00000001807109E0 0x0000000180710A20-0x0000000180710A30
			protected Vector3 point { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109F0-0x0000000180710A10 0x0000000180710A30-0x0000000180710A40
	
			// Constructors
			protected HitPoint(); // 0x00000001807103D0-0x00000001807103E0
	
			// Methods
			public void Hit(Vector3 force, Vector3 point); // 0x0000000180710890-0x00000001807109B0
			public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x00000001807107C0-0x0000000180710890
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 8516
		{
			// Fields
			[Tooltip] // 0x0000000180022430-0x0000000180022460
			public AnimationCurve offsetInForceDirection; // 0x50
			[Tooltip] // 0x0000000180022460-0x0000000180022490
			public AnimationCurve offsetInUpDirection; // 0x58
			[Tooltip] // 0x0000000180022490-0x00000001800224C0
			public EffectorLink[] effectorLinks; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 8515
			{
				// Fields
				[Tooltip] // 0x00000001800224C0-0x00000001800224F0
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001800224F0-0x0000000180022520
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader); // 0x000000018083EEE0-0x000000018083F030
				public void CrossFadeStart(); // 0x000000018083F340-0x000000018083F360
			}
	
			// Constructors
			public HitPointEffector(); // 0x00000001807103D0-0x00000001807103E0
	
			// Methods
			protected override float GetLength(); // 0x0000000180710440-0x0000000180710590
			protected override void CrossFadeStart(); // 0x00000001807103E0-0x0000000180710440
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x0000000180710590-0x00000001807107C0
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 8518
		{
			// Fields
			[Tooltip] // 0x0000000180022520-0x0000000180022550
			public AnimationCurve aroundCenterOfMass; // 0x50
			[Tooltip] // 0x0000000180022550-0x0000000180022580
			public BoneLink[] boneLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 8517
			{
				// Fields
				[Tooltip] // 0x0000000180022580-0x00000001800225B0
				public Transform bone; // 0x10
				[Range] // 0x00000001800225B0-0x0000000180022600
				[Tooltip] // 0x00000001800225B0-0x0000000180022600
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink(); // 0x000000018083DDD0-0x000000018083DE10
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader); // 0x000000018083DCB0-0x000000018083DDC0
				public void CrossFadeStart(); // 0x000000018083DDC0-0x000000018083DDD0
			}
	
			// Constructors
			public HitPointBone(); // 0x00000001807103D0-0x00000001807103E0
	
			// Methods
			protected override float GetLength(); // 0x00000001807100E0-0x0000000180710180
			protected override void CrossFadeStart(); // 0x0000000180710080-0x00000001807100E0
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x0000000180710180-0x00000001807103D0
		}
	
		// Constructors
		public HitReaction(); // 0x00000001807BDCD0-0x00000001807BDCE0
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000180866B30-0x0000000180866C30
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x00000001808668A0-0x0000000180866B30
	}
}
