/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x0000000180035B30-0x0000000180035B60
	public class glTF_VRM_Firstperson // TypeDefIndex: 8036
	{
		// Fields
		[JsonSchema] // 0x0000000180035B60-0x0000000180035BE0
		public int firstPersonBone; // 0x10
		[JsonSchema] // 0x0000000180035BE0-0x0000000180035C10
		public Vector3 firstPersonBoneOffset; // 0x14
		[JsonSchema] // 0x0000000180035C10-0x0000000180035C40
		public List<glTF_VRM_MeshAnnotation> meshAnnotations; // 0x20
		[JsonSchema] // 0x0000000180035C40-0x0000000180035CE0
		public string lookAtTypeName; // 0x28
		[JsonSchema] // 0x0000000180035CE0-0x0000000180035D10
		public glTF_VRM_DegreeMap lookAtHorizontalInner; // 0x30
		[JsonSchema] // 0x0000000180035CE0-0x0000000180035D10
		public glTF_VRM_DegreeMap lookAtHorizontalOuter; // 0x38
		[JsonSchema] // 0x0000000180035CE0-0x0000000180035D10
		public glTF_VRM_DegreeMap lookAtVerticalDown; // 0x40
		[JsonSchema] // 0x0000000180035CE0-0x0000000180035D10
		public glTF_VRM_DegreeMap lookAtVerticalUp; // 0x48
	
		// Properties
		public LookAtType lookAtType { get; set; } // 0x000000018055EE90-0x000000018055EED0 0x000000018055EED0-0x000000018055EF60
	
		// Constructors
		public glTF_VRM_Firstperson(); // 0x000000018055ED40-0x000000018055EE90
	}
}
