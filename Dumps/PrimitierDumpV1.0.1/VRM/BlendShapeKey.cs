/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[IsReadOnly] // 0x0000000180014D50-0x0000000180014D60
	public struct BlendShapeKey : IEquatable<VRM.BlendShapeKey>, IComparable<VRM.BlendShapeKey> // TypeDefIndex: 7976
	{
		// Fields
		private static readonly Dictionary<BlendShapePreset, string> PresetNameCacheDictionary; // 0x00
		private static readonly string UnknownPresetPrefix; // 0x08
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private readonly string _Name_k__BackingField; // 0x00
		public readonly BlendShapePreset Preset; // 0x08
		private readonly string m_id; // 0x10
	
		// Properties
		public string Name { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B6C10-0x00000001802B6C20 
	
		// Constructors
		private BlendShapeKey(string name, BlendShapePreset preset); // 0x0000000180337B40-0x0000000180337D30
		static BlendShapeKey(); // 0x0000000180337AA0-0x0000000180337B40
	
		// Methods
		public static BlendShapeKey CreateFromPreset(BlendShapePreset preset); // 0x0000000180337770-0x00000001803377D0
		public static BlendShapeKey CreateFromClip(BlendShapeClip clip); // 0x00000001803376B0-0x0000000180337770
		public static BlendShapeKey CreateUnknown(string name); // 0x00000001803377D0-0x0000000180337800
		public override string ToString(); // 0x0000000180337A10-0x0000000180337AA0
		public bool Equals(BlendShapeKey other); // 0x0000000180337800-0x0000000180337830
		public override bool Equals(object obj); // 0x0000000180337830-0x00000001803378D0
		public override int GetHashCode(); // 0x00000001803378D0-0x0000000180337900
		public bool Match(BlendShapeClip clip); // 0x0000000180337900-0x0000000180337A10
		public int CompareTo(BlendShapeKey other); // 0x0000000180337670-0x00000001803376B0
	}
}
