/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public static class TMP_DefaultControls // TypeDefIndex: 6097
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x003A1EEA
		private const float kThickHeight = 30f; // Metadata: 0x003A1EEE
		private const float kThinHeight = 20f; // Metadata: 0x003A1EF2
		private static Vector2 s_TextElementSize; // 0x00
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static Color s_DefaultSelectableColor; // 0x18
		private static Color s_TextColor; // 0x28
	
		// Nested types
		public struct Resources // TypeDefIndex: 6096
		{
			// Fields
			public Sprite standard; // 0x00
			public Sprite background; // 0x08
			public Sprite inputField; // 0x10
			public Sprite knob; // 0x18
			public Sprite checkmark; // 0x20
			public Sprite dropdown; // 0x28
			public Sprite mask; // 0x30
		}
	
		// Constructors
		static TMP_DefaultControls(); // 0x0000000180373F40-0x0000000180374060
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x0000000180373AD0-0x0000000180373B70
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x0000000180373B70-0x0000000180373C30
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x0000000180373CD0-0x0000000180373D70
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x0000000180373C30-0x0000000180373CD0
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x0000000180373E50-0x0000000180373F40
		private static void SetLayerRecursively(GameObject go, int layer); // 0x0000000180373D70-0x0000000180373E50
		public static GameObject CreateScrollbar(Resources resources); // 0x0000000180373710-0x0000000180373A20
		public static GameObject CreateButton(Resources resources); // 0x0000000180371FD0-0x0000000180372260
		public static GameObject CreateText(Resources resources); // 0x0000000180373A20-0x0000000180373AD0
		public static GameObject CreateInputField(Resources resources); // 0x00000001803730D0-0x0000000180373710
		public static GameObject CreateDropdown(Resources resources); // 0x0000000180372260-0x00000001803730D0
	}
}
