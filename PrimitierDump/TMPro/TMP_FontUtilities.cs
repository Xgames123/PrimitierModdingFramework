/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public static class TMP_FontUtilities // TypeDefIndex: 6120
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018051D180-0x000000018051D270
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018051D270-0x000000018051D370
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x000000018051CF20-0x000000018051D180
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x000000018051CE20-0x000000018051CF20
	}
}
