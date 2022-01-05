/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class FPSAiming : MonoBehaviour // TypeDefIndex: 8321
	{
		// Fields
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float aimWeight; // 0x18
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float sightWeight; // 0x1C
		[Range] // 0x000000018001C5E0-0x000000018001C600
		public float maxAngle; // 0x20
		public Vector3 aimOffset; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool animatePhysics; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform gun; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform gunTarget; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private FullBodyBipedIK ik; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private AimIK gunAim; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CameraControllerFPS cam; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Recoil recoil; // 0x60
		[Range] // 0x000000018001C600-0x000000018001C640
		[SerializeField] // 0x000000018001C600-0x000000018001C640
		private float cameraRecoilWeight; // 0x68
		private Vector3 gunTargetDefaultLocalPosition; // 0x6C
		private Quaternion gunTargetDefaultLocalRotation; // 0x78
		private Vector3 camDefaultLocalPosition; // 0x88
		private Vector3 camRelativeToGunTarget; // 0x94
		private bool updateFrame; // 0xA0
	
		// Constructors
		public FPSAiming(); // 0x00000001808218D0-0x0000000180821900
	
		// Methods
		private void Start(); // 0x0000000180821730-0x00000001808218D0
		private void FixedUpdate(); // 0x0000000180820700-0x0000000180820710
		private void LateUpdate(); // 0x0000000180820710-0x0000000180820830
		private void Aiming(); // 0x00000001808204A0-0x0000000180820700
		private void LookDownTheSight(); // 0x0000000180820830-0x00000001808214C0
		private void RotateCharacter(); // 0x00000001808214C0-0x0000000180821730
	}
}
