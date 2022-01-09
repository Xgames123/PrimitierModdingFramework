/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UniJSON;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x0000000180036EF0-0x0000000180036F30
	public class glTF_VRM_extensions // TypeDefIndex: 8049
	{
		// Fields
		public const string ExtensionName = "VRM"; // Metadata: 0x003A61E5
		public static readonly Utf8String ExtensionNameUtf8; // 0x00
		[JsonSchema] // 0x0000000180036F30-0x0000000180036F60
		public string exporterVersion; // 0x10
		[JsonSchema] // 0x0000000180036F60-0x0000000180036F90
		public string specVersion; // 0x18
		public glTF_VRM_Meta meta; // 0x20
		public glTF_VRM_Humanoid humanoid; // 0x28
		public glTF_VRM_Firstperson firstPerson; // 0x30
		public glTF_VRM_BlendShapeMaster blendShapeMaster; // 0x38
		public glTF_VRM_SecondaryAnimation secondaryAnimation; // 0x40
		public List<glTF_VRM_Material> materialProperties; // 0x48
	
		// Constructors
		public glTF_VRM_extensions(); // 0x000000018055FDC0-0x000000018055FFE0
		static glTF_VRM_extensions(); // 0x000000018055FD30-0x000000018055FDC0
	
		// Methods
		public static bool TryDeserialize(glTFExtension extension, out glTF_VRM_extensions vrm); // 0x000000018055FA30-0x000000018055FD30
	}
}
