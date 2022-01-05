/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class TMP_TextParsingUtilities // TypeDefIndex: 6202
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x003A238F
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x003A2413
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x00000001803A4AE0-0x00000001803A4B40 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x00000001803A4A80-0x00000001803A4AE0
		public TMP_TextParsingUtilities(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static int GetHashCode(string s); // 0x00000001803A4810-0x00000001803A48C0
		public static int GetHashCodeCaseSensitive(string s); // 0x00000001803A47B0-0x00000001803A4810
		public static char ToLowerASCIIFast(char c); // 0x00000001803A4960-0x00000001803A49C0
		public static char ToUpperASCIIFast(char c); // 0x00000001803A4A20-0x00000001803A4A80
		public static uint ToUpperASCIIFast(uint c); // 0x00000001803A49C0-0x00000001803A4A20
		public static uint ToLowerASCIIFast(uint c); // 0x00000001803A4900-0x00000001803A4960
		public static bool IsHighSurrogate(uint c); // 0x00000001803A48C0-0x00000001803A48E0
		public static bool IsLowSurrogate(uint c); // 0x00000001803A48E0-0x00000001803A4900
		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate); // 0x00000001803A47A0-0x00000001803A47B0
	}
}
