/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public class KerningTable // TypeDefIndex: 6119
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 6115
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AddKerningPair_b__0(KerningPair item); // 0x0000000180884E10-0x0000000180884E40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 6116
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item); // 0x0000000180884E10-0x0000000180884E40
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 6117
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _RemoveKerningPair_b__0(KerningPair item); // 0x0000000180884E40-0x0000000180884E80
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 6118
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KerningPair, uint> __9__7_0; // 0x08
			public static Func<KerningPair, uint> __9__7_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180884F30-0x0000000180884F90
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal uint _SortKerningPairs_b__7_0(KerningPair s); // 0x0000000180884C50-0x0000000180884C70
			internal uint _SortKerningPairs_b__7_1(KerningPair s); // 0x0000000180884C70-0x0000000180884C90
		}
	
		// Constructors
		public KerningTable(); // 0x000000018036D0C0-0x000000018036D130
	
		// Methods
		public void AddKerningPair(); // 0x000000018036CA30-0x000000018036CB90
		public int AddKerningPair(uint first, uint second, float offset); // 0x000000018036CB90-0x000000018036CD00
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x000000018036C8B0-0x000000018036CA30
		public void RemoveKerningPair(int left, int right); // 0x000000018036CD00-0x000000018036CE20
		public void RemoveKerningPair(int index); // 0x000000018036CE20-0x000000018036CE80
		public void SortKerningPairs(); // 0x000000018036CE80-0x000000018036D0C0
	}
}
