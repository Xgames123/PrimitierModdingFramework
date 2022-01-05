/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 8424
	{
		// Fields
		[Tooltip] // 0x000000018001EFD0-0x000000018001F000
		public FullBodyBipedIK ik; // 0x18
		[LargeHeader] // 0x000000018001F000-0x000000018001F080
		[Range] // 0x000000018001F000-0x000000018001F080
		[Tooltip] // 0x000000018001F000-0x000000018001F080
		public float positionWeight; // 0x20
		[Range] // 0x000000018001F080-0x000000018001F0E0
		[Tooltip] // 0x000000018001F080-0x000000018001F0E0
		public float bodyWeight; // 0x24
		[Range] // 0x000000018001F0E0-0x000000018001F140
		[Tooltip] // 0x000000018001F0E0-0x000000018001F140
		public float thighWeight; // 0x28
		[Tooltip] // 0x000000018001F140-0x000000018001F170
		public bool handsPullBody; // 0x2C
		[LargeHeader] // 0x000000018001F170-0x000000018001F1F0
		[Range] // 0x000000018001F170-0x000000018001F1F0
		[Tooltip] // 0x000000018001F170-0x000000018001F1F0
		public float rotationWeight; // 0x30
		[Range] // 0x000000018001F1F0-0x000000018001F250
		[Tooltip] // 0x000000018001F1F0-0x000000018001F250
		public float bodyClampWeight; // 0x34
		[Range] // 0x000000018001F250-0x000000018001F2B0
		[Tooltip] // 0x000000018001F250-0x000000018001F2B0
		public float headClampWeight; // 0x38
		[Range] // 0x000000018001F2B0-0x000000018001F300
		[Tooltip] // 0x000000018001F2B0-0x000000018001F300
		public float bendWeight; // 0x3C
		[Tooltip] // 0x000000018001F300-0x000000018001F330
		public BendBone[] bendBones; // 0x40
		[LargeHeader] // 0x000000018001F330-0x000000018001F3B0
		[Range] // 0x000000018001F330-0x000000018001F3B0
		[Tooltip] // 0x000000018001F330-0x000000018001F3B0
		public float CCDWeight; // 0x48
		[Range] // 0x000000018001F3B0-0x000000018001F410
		[Tooltip] // 0x000000018001F3B0-0x000000018001F410
		public float roll; // 0x4C
		[Range] // 0x000000018001F410-0x000000018001F470
		[Tooltip] // 0x000000018001F410-0x000000018001F470
		public float damper; // 0x50
		[Tooltip] // 0x000000018001F470-0x000000018001F4A0
		public Transform[] CCDBones; // 0x58
		[LargeHeader] // 0x000000018001F4A0-0x000000018001F520
		[Range] // 0x000000018001F4A0-0x000000018001F520
		[Tooltip] // 0x000000018001F4A0-0x000000018001F520
		public float postStretchWeight; // 0x60
		[Tooltip] // 0x000000018001F520-0x000000018001F550
		public float maxStretch; // 0x64
		[Tooltip] // 0x000000018001F550-0x000000018001F580
		public float stretchDamper; // 0x68
		[Tooltip] // 0x000000018001F580-0x000000018001F5B0
		public bool fixHead; // 0x6C
		[Tooltip] // 0x000000018001F5B0-0x000000018001F5E0
		public Transform[] stretchBones; // 0x70
		[LargeHeader] // 0x000000018001F5E0-0x000000018001F610
		public Vector3 chestDirection; // 0x78
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float chestDirectionWeight; // 0x84
		public Transform[] chestBones; // 0x88
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
		private Vector3 offset; // 0x98
		private Vector3 headToBody; // 0xA4
		private Vector3 shoulderCenterToHead; // 0xB0
		private Vector3 headToLeftThigh; // 0xBC
		private Vector3 headToRightThigh; // 0xC8
		private Vector3 leftShoulderPos; // 0xD4
		private Vector3 rightShoulderPos; // 0xE0
		private float shoulderDist; // 0xEC
		private float leftShoulderDist; // 0xF0
		private float rightShoulderDist; // 0xF4
		private Quaternion chestRotation; // 0xF8
		private Quaternion headRotationRelativeToRoot; // 0x108
		private Quaternion[] ccdDefaultLocalRotations; // 0x118
		private Vector3 headLocalPosition; // 0x120
		private Quaternion headLocalRotation; // 0x12C
		private Vector3[] stretchLocalPositions; // 0x140
		private Quaternion[] stretchLocalRotations; // 0x148
		private Vector3[] chestLocalPositions; // 0x150
		private Quaternion[] chestLocalRotations; // 0x158
		private int bendBonesCount; // 0x160
		private int ccdBonesCount; // 0x164
		private int stretchBonesCount; // 0x168
		private int chestBonesCount; // 0x16C
	
		// Nested types
		[Serializable]
		public class BendBone // TypeDefIndex: 8423
		{
			// Fields
			[Tooltip] // 0x000000018001F610-0x000000018001F640
			public Transform transform; // 0x10
			[Range] // 0x000000018001F640-0x000000018001F690
			[Tooltip] // 0x000000018001F640-0x000000018001F690
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone(); // 0x000000018070CCC0-0x000000018070CD00
			public BendBone(Transform transform, float weight); // 0x000000018070CD00-0x000000018070CD60
	
			// Methods
			public void StoreDefaultLocalState(); // 0x000000018070CC80-0x000000018070CCC0
			public void FixTransforms(); // 0x000000018070CC40-0x000000018070CC80
		}
	
		// Constructors
		public FBBIKHeadEffector(); // 0x000000018081BBB0-0x000000018081BD30
	
		// Methods
		private void Start(); // 0x000000018081B7C0-0x000000018081BBB0
		private void OnStoreDefaultLocalState(); // 0x000000018081A800-0x000000018081AE70
		private void OnFixTransforms(); // 0x0000000180819760-0x0000000180819CE0
		private void OnPreRead(); // 0x0000000180819EE0-0x000000018081A800
		private void SpineBend(); // 0x000000018081B3F0-0x000000018081B7C0
		private void CCDPass(); // 0x0000000180817DF0-0x0000000180818270
		private void Iterate(int iteration); // 0x0000000180818520-0x0000000180819270
		private void OnPostUpdate(); // 0x0000000180819CE0-0x0000000180819EE0
		private void ChestDirection(); // 0x0000000180818270-0x0000000180818520
		private void PostStretching(); // 0x000000018081AE70-0x000000018081B290
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset); // 0x0000000180819270-0x0000000180819400
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance); // 0x000000018081B290-0x000000018081B3F0
		private void OnDestroy(); // 0x0000000180819400-0x0000000180819760
	}
}
