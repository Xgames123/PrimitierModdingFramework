/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct JsonDiff // TypeDefIndex: 5597
	{
		// Fields
		public JsonPointer Path; // 0x00
		public JsonDiffType DiffType; // 0x10
		public string Msg; // 0x18
	
		// Methods
		public static JsonDiff Create(JsonNode node, JsonDiffType diffType, string msg); // 0x0000000180D25110-0x0000000180D252F0
		public override string ToString(); // 0x0000000180D252F0-0x0000000180D25400
	}
}
