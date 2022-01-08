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
	public class TMP_ResourceManager // TypeDefIndex: 6158
	{
		// Fields
		private static readonly TMP_ResourceManager s_instance; // 0x00
		private static TMP_Settings s_TextSettings; // 0x08
		private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18
	
		// Constructors
		static TMP_ResourceManager(); // 0x0000000180265000-0x00000001802650F0
		public TMP_ResourceManager(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		internal static TMP_Settings GetTextSettings(); // 0x0000000180264D00-0x0000000180264E30
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x0000000180264BD0-0x0000000180264D00
		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset); // 0x0000000180264F60-0x0000000180265000
		internal static void RebuildFontAssetCache(int instanceID); // 0x0000000180264E30-0x0000000180264F60
	}
}
