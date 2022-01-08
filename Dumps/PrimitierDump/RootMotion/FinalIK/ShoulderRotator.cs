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
	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 8544
	{
		// Fields
		[Tooltip] // 0x0000000180023050-0x0000000180023080
		public float weight; // 0x18
		[Tooltip] // 0x0000000180023080-0x00000001800230B0
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator(); // 0x0000000180716750-0x0000000180716770
	
		// Methods
		private void Start(); // 0x0000000180716660-0x0000000180716750
		private void RotateShoulders(); // 0x0000000180716560-0x0000000180716660
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset); // 0x0000000180716040-0x0000000180716560
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain); // 0x0000000180715F00-0x0000000180715F40
		private void OnDestroy(); // 0x0000000180715F40-0x0000000180716040
	}
}
