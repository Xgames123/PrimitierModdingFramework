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
	public class VRIKRootController : MonoBehaviour // TypeDefIndex: 8549
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _pelvisTargetRight_k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807203F0-0x0000000180720410 0x0000000180720410-0x0000000180720420
	
		// Constructors
		public VRIKRootController(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x000000018071F7D0-0x000000018071F8C0
		public void Calibrate(); // 0x000000018071FA80-0x000000018071FCD0
		public void Calibrate(VRIKCalibrator.CalibrationData data); // 0x000000018071F8C0-0x000000018071FA80
		private void OnPreUpdate(); // 0x000000018071FDD0-0x00000001807203F0
		private void OnDestroy(); // 0x000000018071FCD0-0x000000018071FDD0
	}
}
