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
	public static class VRIKCalibrator // TypeDefIndex: 8548
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 8545
		{
			// Fields
			[Tooltip] // 0x00000001800230B0-0x00000001800230E0
			public float scaleMlp; // 0x10
			[Tooltip] // 0x00000001800230E0-0x0000000180023110
			public Vector3 headTrackerForward; // 0x14
			[Tooltip] // 0x0000000180023110-0x0000000180023140
			public Vector3 headTrackerUp; // 0x20
			[Tooltip] // 0x0000000180023140-0x0000000180023170
			public Vector3 bodyTrackerForward; // 0x2C
			[Tooltip] // 0x0000000180023170-0x00000001800231A0
			public Vector3 bodyTrackerUp; // 0x38
			[Tooltip] // 0x00000001800231A0-0x00000001800231D0
			public Vector3 handTrackerForward; // 0x44
			[Tooltip] // 0x00000001800231D0-0x0000000180023200
			public Vector3 handTrackerUp; // 0x50
			[Tooltip] // 0x0000000180023200-0x0000000180023230
			public Vector3 footTrackerForward; // 0x5C
			[Tooltip] // 0x0000000180023230-0x0000000180023260
			public Vector3 footTrackerUp; // 0x68
			[Space] // 0x0000000180023260-0x00000001800232B0
			[Tooltip] // 0x0000000180023260-0x00000001800232B0
			public Vector3 headOffset; // 0x74
			[Tooltip] // 0x00000001800232B0-0x00000001800232E0
			public Vector3 handOffset; // 0x80
			[Tooltip] // 0x00000001800232E0-0x0000000180023310
			public float footForwardOffset; // 0x8C
			[Tooltip] // 0x0000000180023310-0x0000000180023340
			public float footInwardOffset; // 0x90
			[Range] // 0x0000000180023340-0x00000001800239A0
			[Tooltip] // 0x0000000180023340-0x00000001800239A0
			public float footHeadingOffset; // 0x94
			[Range] // 0x000000018001BE80-0x000000018001BEA0
			public float pelvisPositionWeight; // 0x98
			[Range] // 0x000000018001BE80-0x000000018001BEA0
			public float pelvisRotationWeight; // 0x9C
	
			// Constructors
			public Settings(); // 0x000000018084B580-0x000000018084B690
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 8547
		{
			// Fields
			public float scale; // 0x10
			public Target head; // 0x18
			public Target leftHand; // 0x20
			public Target rightHand; // 0x28
			public Target pelvis; // 0x30
			public Target leftFoot; // 0x38
			public Target rightFoot; // 0x40
			public Target leftLegGoal; // 0x48
			public Target rightLegGoal; // 0x50
			public Vector3 pelvisTargetRight; // 0x58
			public float pelvisPositionWeight; // 0x64
			public float pelvisRotationWeight; // 0x68
	
			// Nested types
			[Serializable]
			public class Target // TypeDefIndex: 8546
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target(Transform t); // 0x000000018084FAD0-0x000000018084FB90
	
				// Methods
				public void SetTo(Transform t); // 0x000000018084FA60-0x000000018084FAD0
			}
	
			// Constructors
			public CalibrationData(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, Settings settings); // 0x000000018071ED80-0x000000018071EF30
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018071D430-0x000000018071ED80
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018071BA90-0x000000018071C300
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018071C550-0x000000018071D430
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018071C300-0x000000018071C550
	}
}
