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
	public class HandPoser : Poser // TypeDefIndex: 8493
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser(); // 0x0000000180824270-0x0000000180824280
	
		// Methods
		public override void AutoMapping(); // 0x0000000180864790-0x0000000180864850
		protected override void InitiatePoser(); // 0x00000001808649A0-0x00000001808649F0
		protected override void FixPoserTransforms(); // 0x0000000180864850-0x00000001808649A0
		protected override void UpdatePoser(); // 0x0000000180864BA0-0x0000000180865020
		protected void StoreDefaultState(); // 0x00000001808649F0-0x0000000180864BA0
	}
}
