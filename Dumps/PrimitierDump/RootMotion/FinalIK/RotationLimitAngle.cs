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
	[AddComponentMenu] // 0x0000000180021AF0-0x0000000180021B50
	[HelpURL] // 0x0000000180021AF0-0x0000000180021B50
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 8500
	{
		// Fields
		[Range] // 0x000000018001C5E0-0x000000018001C600
		public float limit; // 0x38
		[Range] // 0x000000018001C5E0-0x000000018001C600
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle(); // 0x000000018077DB90-0x000000018077DBE0
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018077DB10-0x000000018077DB50
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018077DAD0-0x000000018077DB10
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018077DB50-0x000000018077DB90
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x000000018077D620-0x000000018077D660
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018077D660-0x000000018077D8D0
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018077D8D0-0x000000018077DAD0
	}
}
