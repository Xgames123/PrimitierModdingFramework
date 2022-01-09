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
	[Serializable]
	[ExcludeFromPreset] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 6085
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public Color topLeft; // 0x1C
		public Color topRight; // 0x2C
		public Color bottomLeft; // 0x3C
		public Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x003A1EAE
		private static readonly Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient(); // 0x0000000180371DB0-0x0000000180371E70
		public TMP_ColorGradient(Color color); // 0x0000000180371E70-0x0000000180371EC0
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3); // 0x0000000180371D40-0x0000000180371DB0
		static TMP_ColorGradient(); // 0x0000000180371CF0-0x0000000180371D40
	}
}
