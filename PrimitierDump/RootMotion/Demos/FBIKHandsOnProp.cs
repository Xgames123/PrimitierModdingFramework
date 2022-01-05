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
	public class FBIKHandsOnProp : MonoBehaviour // TypeDefIndex: 8320
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool leftHanded; // 0x20
	
		// Constructors
		public FBIKHandsOnProp(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x000000018081FB90-0x000000018081FC80
		private void OnPreRead(); // 0x0000000180820400-0x00000001808204A0
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand); // 0x000000018081FC80-0x00000001808202E0
		private void OnDestroy(); // 0x00000001808202E0-0x0000000180820400
	}
}
