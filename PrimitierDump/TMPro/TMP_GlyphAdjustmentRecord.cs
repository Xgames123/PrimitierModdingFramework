/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 6126
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal uint m_GlyphIndex; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x000000018051D440-0x000000018051D450 0x000000018051D460-0x000000018051D470
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x000000018051D450-0x000000018051D460 0x000000018051D470-0x000000018051D480
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x000000018036C510-0x000000018036C520
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x000000018051D370-0x000000018051D440
	}
}
