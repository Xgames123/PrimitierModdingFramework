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
	[AddComponentMenu] // 0x0000000180021C30-0x0000000180021C90
	[HelpURL] // 0x0000000180021C30-0x0000000180021C90
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 8505
	{
		// Fields
		[Range] // 0x000000018001C5E0-0x000000018001C600
		public float twistLimit; // 0x38
		[HideInInspector] // 0x0000000180016550-0x0000000180016580
		[SerializeField] // 0x0000000180016550-0x0000000180016580
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline(); // 0x0000000180714E30-0x0000000180714E40
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x0000000180714D90-0x0000000180714DD0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x0000000180714D50-0x0000000180714D90
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x0000000180714DF0-0x0000000180714E30
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x0000000180714950-0x0000000180714990
		public void SetSpline(Keyframe[] keyframes); // 0x0000000180714DD0-0x0000000180714DF0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x0000000180714990-0x0000000180714A60
		public Quaternion LimitSwing(Quaternion rotation); // 0x0000000180714A60-0x0000000180714D50
	}
}
