/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public struct TMP_LinkInfo // TypeDefIndex: 6219
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int hashCode; // 0x08
		public int linkIdFirstCharacterIndex; // 0x0C
		public int linkIdLength; // 0x10
		public int linkTextfirstCharacterIndex; // 0x14
		public int linkTextLength; // 0x18
		internal char[] linkID; // 0x20
	
		// Methods
		internal void SetLinkID(char[] text, int startIndex, int length); // 0x000000018052E2C0-0x000000018052E390
		public string GetLinkText(); // 0x000000018052E1E0-0x000000018052E2C0
		public string GetLinkID(); // 0x000000018052E130-0x000000018052E1E0
	}
}
