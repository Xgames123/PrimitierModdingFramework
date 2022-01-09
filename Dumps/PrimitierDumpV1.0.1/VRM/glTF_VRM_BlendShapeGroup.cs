/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x0000000180035750-0x0000000180035790
	public class glTF_VRM_BlendShapeGroup // TypeDefIndex: 8030
	{
		// Fields
		[JsonSchema] // 0x0000000180035790-0x00000001800357C0
		public string name; // 0x10
		[JsonSchema] // 0x00000001800357C0-0x0000000180035970
		public string presetName; // 0x18
		[JsonSchema] // 0x0000000180035970-0x00000001800359A0
		public List<glTF_VRM_BlendShapeBind> binds; // 0x20
		[JsonSchema] // 0x00000001800359A0-0x00000001800359D0
		public List<glTF_VRM_MaterialValueBind> materialValues; // 0x28
		[JsonSchema] // 0x00000001800359D0-0x0000000180035A00
		public bool isBinary; // 0x30
	
		// Constructors
		public glTF_VRM_BlendShapeGroup(); // 0x000000018055EC00-0x000000018055ECB0
	}
}
