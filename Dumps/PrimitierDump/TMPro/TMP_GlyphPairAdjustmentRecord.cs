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
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 6127
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x000000018051D6A0-0x000000018051D6C0 0x000000018051D6E0-0x000000018051D6F0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x000000018051D6C0-0x000000018051D6E0 0x000000018051D6F0-0x000000018051D700
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x00000001802684E0-0x00000001802684F0 0x000000018046DF90-0x000000018046DFA0
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x000000018051D480-0x000000018051D4D0
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x000000018051D4D0-0x000000018051D6A0
	}
}
