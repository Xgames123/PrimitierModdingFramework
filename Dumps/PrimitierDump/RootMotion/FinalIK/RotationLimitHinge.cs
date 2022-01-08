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
	[AddComponentMenu] // 0x0000000180021B50-0x0000000180021BB0
	[HelpURL] // 0x0000000180021B50-0x0000000180021BB0
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 8501
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public float zeroAxisDisplayOffset; // 0x44
		private Quaternion lastRotation; // 0x48
		private float lastAngle; // 0x58
	
		// Constructors
		public RotationLimitHinge(); // 0x000000018077E050-0x000000018077E0B0
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018077DFD0-0x000000018077E010
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018077DF90-0x000000018077DFD0
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018077E010-0x000000018077E050
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x000000018077DBE0-0x000000018077DC20
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018077DF40-0x000000018077DF90
		private Quaternion LimitHinge(Quaternion rotation); // 0x000000018077DC20-0x000000018077DF40
	}
}
