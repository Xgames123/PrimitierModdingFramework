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
	[Serializable]
	public class Constraints // TypeDefIndex: 8384
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public bool IsValid(); // 0x0000000180815520-0x0000000180815580
		public void Initiate(Transform transform); // 0x00000001808154B0-0x0000000180815520
		public void Update(); // 0x0000000180815580-0x0000000180815950
	}
}
