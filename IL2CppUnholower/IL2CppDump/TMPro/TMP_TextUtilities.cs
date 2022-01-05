/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public static class TMP_TextUtilities // TypeDefIndex: 6208
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x003A24A7
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x003A252B
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 6207
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x0000000180882EB0-0x0000000180882ED0
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x00000001803A9D50-0x00000001803A9DB0
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x00000001803A8CC0-0x00000001803A8E90
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x00000001803A8E90-0x00000001803A9110
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A7070-0x00000001803A7310
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x00000001803A6620-0x00000001803A6B70
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x00000001803A9580-0x00000001803A9790
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x00000001803A4D60-0x00000001803A50A0
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x00000001803A6B70-0x00000001803A7070
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A5A40-0x00000001803A6620
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A7FC0-0x00000001803A8CC0
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A50A0-0x00000001803A52C0
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A52C0-0x00000001803A5A40
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803A7310-0x00000001803A7FC0
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x00000001803A9790-0x00000001803A9960
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x00000001803A9960-0x00000001803A9B40
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x00000001803A9380-0x00000001803A9580
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x00000001803A4B40-0x00000001803A4D60
		public static char ToLowerFast(char c); // 0x00000001803A9C30-0x00000001803A9C90
		public static char ToUpperFast(char c); // 0x00000001803A9CF0-0x00000001803A9D50
		internal static uint ToUpperASCIIFast(uint c); // 0x00000001803A9C90-0x00000001803A9CF0
		public static int GetHashCode(string s); // 0x00000001803A9110-0x00000001803A91C0
		public static int GetSimpleHashCode(string s); // 0x00000001803A47B0-0x00000001803A4810
		public static uint GetSimpleHashCodeLowercase(string s); // 0x00000001803A91C0-0x00000001803A9270
		public static int HexToInt(char hex); // 0x00000001803A9270-0x00000001803A9380
		public static int StringHexToInt(string s); // 0x00000001803A9B40-0x00000001803A9C30
	}
}
