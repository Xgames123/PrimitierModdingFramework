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
	[JsonSchema] // 0x0000000180035D10-0x0000000180035D40
	public class glTF_VRM_HumanoidBone // TypeDefIndex: 8038
	{
		// Fields
		[JsonSchema] // 0x0000000180035D40-0x00000001800361B0
		public string bone; // 0x10
		[JsonSchema] // 0x00000001800361B0-0x00000001800361F0
		public int node; // 0x18
		[JsonSchema] // 0x00000001800361F0-0x0000000180036220
		public bool useDefaultValues; // 0x1C
		[JsonSchema] // 0x0000000180036220-0x00000001800362A0
		public Vector3 min; // 0x20
		[JsonSchema] // 0x00000001800362A0-0x0000000180036320
		public Vector3 max; // 0x2C
		[JsonSchema] // 0x0000000180036320-0x00000001800363A0
		public Vector3 center; // 0x38
		[JsonSchema] // 0x00000001800363A0-0x00000001800363E0
		public float axisLength; // 0x44
	
		// Properties
		public VRMBone vrmBone { get; set; } // 0x000000018055EF80-0x000000018055EFC0 0x000000018055EFC0-0x000000018055F050
	
		// Constructors
		public glTF_VRM_HumanoidBone(); // 0x000000018055EF60-0x000000018055EF80
	}
}
