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
	public class VRIKCalibrationController : MonoBehaviour // TypeDefIndex: 8358
	{
		// Fields
		[Tooltip] // 0x000000018001CC90-0x000000018001CCC0
		public VRIK ik; // 0x18
		[Tooltip] // 0x000000018001CCC0-0x000000018001CCF0
		public VRIKCalibrator.Settings settings; // 0x20
		[Tooltip] // 0x000000018001CCF0-0x000000018001CD20
		public Transform headTracker; // 0x28
		[Tooltip] // 0x000000018001CD20-0x000000018001CD50
		public Transform bodyTracker; // 0x30
		[Tooltip] // 0x000000018001CD50-0x000000018001CD80
		public Transform leftHandTracker; // 0x38
		[Tooltip] // 0x000000018001CD80-0x000000018001CDB0
		public Transform rightHandTracker; // 0x40
		[Tooltip] // 0x000000018001CDB0-0x000000018001CDE0
		public Transform leftFootTracker; // 0x48
		[Tooltip] // 0x000000018001CDE0-0x000000018001CE10
		public Transform rightFootTracker; // 0x50
		[Header] // 0x000000018001CE10-0x000000018001CE40
		public VRIKCalibrator.CalibrationData data; // 0x58
	
		// Constructors
		public VRIKCalibrationController(); // 0x000000018071BA30-0x000000018071BA90
	
		// Methods
		private void LateUpdate(); // 0x000000018071B6E0-0x000000018071BA30
	}
}
