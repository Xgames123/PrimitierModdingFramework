/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public class KerningPair // TypeDefIndex: 6114
	{
		// Fields
		[FormerlySerializedAs] // 0x000000018003BEE0-0x000000018003BF30
		[SerializeField] // 0x000000018003BEE0-0x000000018003BF30
		private uint m_FirstGlyph; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		[FormerlySerializedAs] // 0x000000018003BF30-0x000000018003BF80
		[SerializeField] // 0x000000018003BF30-0x000000018003BF80
		private uint m_SecondGlyph; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		[FormerlySerializedAs] // 0x000000018003BF80-0x000000018003BFB0
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get; set; } // 0x0000000180260E80-0x0000000180260F00 0x00000001802A2B90-0x00000001802A2BA0
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x00000001802A2830-0x00000001802A2840 
		public uint secondGlyph { get; set; } // 0x000000018036C890-0x000000018036C8A0 0x000000018036C8A0-0x000000018036C8B0
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x0000000180313470-0x0000000180313480 
		public bool ignoreSpacingAdjustments { get; } // 0x0000000180338B10-0x0000000180338B20 
	
		// Constructors
		public KerningPair(); // 0x000000018036C800-0x000000018036C830
		public KerningPair(uint left, uint right, float offset); // 0x000000018036C7B0-0x000000018036C800
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x000000018036C830-0x000000018036C890
		static KerningPair(); // 0x000000018036C730-0x000000018036C7B0
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x000000018036C720-0x000000018036C730
	}
}
