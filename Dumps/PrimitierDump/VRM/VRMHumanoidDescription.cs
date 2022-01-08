/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniHumanoid;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMHumanoidDescription : MonoBehaviour // TypeDefIndex: 8050
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Avatar Avatar; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public AvatarDescription Description; // 0x20
	
		// Constructors
		public VRMHumanoidDescription(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public AvatarDescription GetDescription(out bool isCreated); // 0x0000000180343FE0-0x0000000180344060
		private void OnValidate(); // 0x0000000180344060-0x0000000180344100
		private void Reset(); // 0x0000000180344100-0x00000001803441D0
	}
}
