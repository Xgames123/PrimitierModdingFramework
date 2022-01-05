/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	[Serializable]
	public class BipedReferences // TypeDefIndex: 8281
	{
		// Fields
		public Transform root; // 0x10
		public Transform pelvis; // 0x18
		public Transform leftThigh; // 0x20
		public Transform leftCalf; // 0x28
		public Transform leftFoot; // 0x30
		public Transform rightThigh; // 0x38
		public Transform rightCalf; // 0x40
		public Transform rightFoot; // 0x48
		public Transform leftUpperArm; // 0x50
		public Transform leftForearm; // 0x58
		public Transform leftHand; // 0x60
		public Transform rightUpperArm; // 0x68
		public Transform rightForearm; // 0x70
		public Transform rightHand; // 0x78
		public Transform head; // 0x80
		public Transform[] spine; // 0x88
		public Transform[] eyes; // 0x90
	
		// Properties
		public virtual bool isFilled { get; } // 0x00000001807CB580-0x00000001807CB9C0 
		public bool isEmpty { get; } // 0x00000001807CB560-0x00000001807CB580 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 8280
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get; } // 0x000000018070CBD0-0x000000018070CBE0 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes); // 0x000000018070CBC0-0x000000018070CBD0
		}
	
		// Constructors
		public BipedReferences(); // 0x00000001807CB500-0x00000001807CB560
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot); // 0x00000001807C9C10-0x00000001807CA090
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x003A69F7 */); // 0x00000001807C84B0-0x00000001807C8940
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x00000001807C81B0-0x00000001807C84B0
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x00000001807C8A80-0x00000001807C96B0
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams); // 0x00000001807C7C90-0x00000001807C81B0
		public static bool SetupError(BipedReferences references, ref string errorMessage); // 0x00000001807CAE40-0x00000001807CAF80
		public static bool SetupWarning(BipedReferences references, ref string warningMessage); // 0x00000001807CAF80-0x00000001807CB070
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm); // 0x00000001807CA090-0x00000001807CA180
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x00000001807C7900-0x00000001807C7A10
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x00000001807C7B00-0x00000001807C7C90
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms); // 0x00000001807C8940-0x00000001807C8A80
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform); // 0x00000001807C7A10-0x00000001807C7B00
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage); // 0x00000001807CA180-0x00000001807CA7D0
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage); // 0x00000001807CA7D0-0x00000001807CABB0
		private static bool SpineError(BipedReferences references, ref string errorMessage); // 0x00000001807CB070-0x00000001807CB500
		private static bool SpineWarning(BipedReferences references, ref string warningMessage); // 0x0000000180295620-0x0000000180295630
		private static bool EyesError(BipedReferences references, ref string errorMessage); // 0x00000001807C96B0-0x00000001807C98D0
		private static bool EyesWarning(BipedReferences references, ref string warningMessage); // 0x0000000180295620-0x0000000180295630
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage); // 0x00000001807CABB0-0x00000001807CAE40
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage); // 0x00000001807C98D0-0x00000001807C9B50
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation); // 0x00000001807C9B50-0x00000001807C9C10
	}
}
