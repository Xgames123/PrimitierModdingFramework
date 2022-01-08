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
	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 8525
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip] // 0x0000000180022320-0x0000000180022350
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip] // 0x0000000180022350-0x0000000180022380
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 8520
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
			protected float crossFader { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109B0-0x00000001807109C0 0x0000000180710A10-0x0000000180710A20
			protected float timer { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B100-0x000000018036B110 0x000000018036B600-0x000000018036B610
			protected Vector3 force { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109C0-0x00000001807109E0 0x0000000180710A20-0x0000000180710A30
			protected Vector3 point { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109F0-0x0000000180710A10 0x0000000180710A30-0x0000000180710A40
	
			// Constructors
			protected Offset(); // 0x00000001807103D0-0x00000001807103E0
	
			// Methods
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x00000001807139B0-0x0000000180713AE0
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight); // 0x00000001807138C0-0x00000001807139B0
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 8522
		{
			// Fields
			[Tooltip] // 0x0000000180022430-0x0000000180022460
			public int forceDirCurveIndex; // 0x50
			[Tooltip] // 0x0000000180022460-0x0000000180022490
			public int upDirCurveIndex; // 0x54
			[Tooltip] // 0x0000000180022600-0x0000000180022630
			public PositionOffsetLink[] offsetLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 8521
			{
				// Fields
				[Tooltip] // 0x00000001800224C0-0x00000001800224F0
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip] // 0x00000001800224F0-0x0000000180022520
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink(); // 0x00000001802650F0-0x0000000180265100
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader); // 0x0000000180848EC0-0x0000000180848FD0
				public void CrossFadeStart(); // 0x000000018083F340-0x000000018083F360
			}
	
			// Constructors
			public PositionOffset(); // 0x0000000180714930-0x0000000180714950
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x0000000180714490-0x00000001807146B0
			protected override void CrossFadeStart(); // 0x0000000180714430-0x0000000180714490
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x00000001807146B0-0x0000000180714930
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 8524
		{
			// Fields
			[Tooltip] // 0x0000000180022520-0x0000000180022550
			public int curveIndex; // 0x50
			[Tooltip] // 0x0000000180022550-0x0000000180022580
			public RotationOffsetLink[] offsetLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 8523
			{
				// Fields
				[Tooltip] // 0x0000000180022580-0x00000001800225B0
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				[Range] // 0x0000000180022630-0x0000000180022690
				[Tooltip] // 0x0000000180022630-0x0000000180022690
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink(); // 0x000000018084B540-0x000000018084B580
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader); // 0x000000018084B440-0x000000018084B530
				public void CrossFadeStart(); // 0x000000018084B530-0x000000018084B540
			}
	
			// Constructors
			public RotationOffset(); // 0x00000001807103D0-0x00000001807103E0
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x0000000180715AE0-0x0000000180715C00
			protected override void CrossFadeStart(); // 0x0000000180715A80-0x0000000180715AE0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x0000000180715C00-0x0000000180715F00
		}
	
		// Constructors
		public HitReactionVRIK(); // 0x00000001807BDCD0-0x00000001807BDCE0
	
		// Methods
		protected override void OnModifyOffset(); // 0x00000001808667B0-0x00000001808668A0
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x0000000180866510-0x00000001808667B0
	}
}
