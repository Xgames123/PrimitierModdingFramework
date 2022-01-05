/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class StringExtensions // TypeDefIndex: 5696
	{
		// Fields
		private static string m_unityBasePath; // 0x00
		private static readonly char[] EscapeChars; // 0x08
	
		// Properties
		public static string UnityBasePath { get; } // 0x0000000180BC2AB0-0x0000000180BC2C20 
	
		// Constructors
		static StringExtensions(); // 0x0000000180BC2A30-0x0000000180BC2AB0
	
		// Extension methods
		public static string ToLowerCamelCase(this string lower); // 0x0000000180BC2880-0x0000000180BC28E0
		public static string ToUpperCamelCase(this string lower); // 0x0000000180BC29D0-0x0000000180BC2A30
		public static string AssetPathToFullPath(this string path); // 0x0000000180BC2390-0x0000000180BC2400
		public static bool StartsWithUnityAssetPath(this string path); // 0x0000000180BC27C0-0x0000000180BC2880
		public static string ToUnityRelativePath(this string path); // 0x0000000180BC28E0-0x0000000180BC29D0
		public static string EscapeFilePath(this string path); // 0x0000000180BC2400-0x0000000180BC2520
		public static bool FastStartsWith(this string a, string b); // 0x0000000180BC25F0-0x0000000180BC26A0
		public static bool FastEndsWith(this string a, string b); // 0x0000000180BC2520-0x0000000180BC25F0
	}
}
