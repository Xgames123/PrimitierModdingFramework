/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x0000000180036C40-0x0000000180036C70
	public class glTF_VRM_SecondaryAnimationGroup // TypeDefIndex: 8047
	{
		// Fields
		[JsonSchema] // 0x0000000180036C70-0x0000000180036CA0
		public string comment; // 0x10
		[JsonSchema] // 0x0000000180036CA0-0x0000000180036CD0
		public float stiffiness; // 0x18
		[JsonSchema] // 0x0000000180036CD0-0x0000000180036D00
		public float gravityPower; // 0x1C
		[JsonSchema] // 0x0000000180036D00-0x0000000180036D30
		public Vector3 gravityDir; // 0x20
		[JsonSchema] // 0x0000000180036D30-0x0000000180036D60
		public float dragForce; // 0x2C
		[JsonSchema] // 0x0000000180036D60-0x0000000180036D90
		public int center; // 0x30
		[JsonSchema] // 0x0000000180036D90-0x0000000180036DC0
		public float hitRadius; // 0x34
		[ItemJsonSchema] // 0x0000000180036DC0-0x0000000180036E20
		[JsonSchema] // 0x0000000180036DC0-0x0000000180036E20
		public int[] bones; // 0x38
		[ItemJsonSchema] // 0x0000000180036E20-0x0000000180036E80
		[JsonSchema] // 0x0000000180036E20-0x0000000180036E80
		public int[] colliderGroups; // 0x40
	
		// Constructors
		public glTF_VRM_SecondaryAnimationGroup(); // 0x000000018055F920-0x000000018055F980
	}
}
