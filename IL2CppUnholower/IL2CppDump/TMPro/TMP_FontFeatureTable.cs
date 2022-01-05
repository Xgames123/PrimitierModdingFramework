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
	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 6123
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6122
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> __9__6_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180884F90-0x0000000180884FF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal uint _SortGlyphPairAdjustmentRecords_b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x0000000180884BF0-0x0000000180884C10
			internal uint _SortGlyphPairAdjustmentRecords_b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x0000000180884C10-0x0000000180884C30
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x000000018051CBA0-0x000000018051CC50
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x000000018051C960-0x000000018051CBA0
	}
}
