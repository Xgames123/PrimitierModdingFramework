/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public static class TMPro_ExtensionMethods // TypeDefIndex: 6214
	{
		// Extension methods
		public static int[] ToIntArray(this string text); // 0x00000001803AD380-0x00000001803AD430
		public static string ArrayToString(this char[] chars); // 0x00000001803ACC60-0x00000001803ACD10
		public static string IntToString(this int[] unicodes); // 0x00000001803AD040-0x00000001803AD0E0
		internal static string UintToString(this List<uint> unicodes); // 0x00000001803AD430-0x00000001803AD510
		public static string IntToString(this int[] unicodes, int start, int length); // 0x00000001803ACF30-0x00000001803AD040
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x00000001803ACEF0-0x00000001803ACF30
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x00000001803ACD40-0x00000001803ACD70
		public static bool Compare(this Color a, Color b); // 0x0000000180264A30-0x0000000180264A70
		public static bool CompareRGB(this Color a, Color b); // 0x00000001803ACD10-0x00000001803ACD40
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x00000001803AD140-0x00000001803AD230
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x00000001803AD140-0x00000001803AD230
		public static Color32 Tint(this Color32 c1, float tint); // 0x00000001803AD230-0x00000001803AD380
		public static Color MinAlpha(this Color c1, Color c2); // 0x00000001803AD0E0-0x00000001803AD140
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x00000001803ACD70-0x00000001803ACE10
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x00000001803ACE10-0x00000001803ACEF0
	}
}
