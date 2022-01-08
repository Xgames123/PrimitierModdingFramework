/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro.SpriteAssetUtilities
{
	public class TexturePacker_JsonArray // TypeDefIndex: 6239
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 6234
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x0000000180883170-0x0000000180883500
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 6235
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x0000000180883500-0x00000001808835A0
		}
	
		[Serializable]
		public struct Frame // TypeDefIndex: 6236
		{
			// Fields
			public string filename; // 0x00
			public SpriteFrame frame; // 0x08
			public bool rotated; // 0x18
			public bool trimmed; // 0x19
			public SpriteFrame spriteSourceSize; // 0x1C
			public SpriteSize sourceSize; // 0x2C
			public Vector2 pivot; // 0x34
		}
	
		[Serializable]
		public struct Meta // TypeDefIndex: 6237
		{
			// Fields
			public string app; // 0x00
			public string version; // 0x08
			public string image; // 0x10
			public string format; // 0x18
			public SpriteSize size; // 0x20
			public float scale; // 0x28
			public string smartupdate; // 0x30
		}
	
		[Serializable]
		public class SpriteDataObject // TypeDefIndex: 6238
		{
			// Fields
			public List<Frame> frames; // 0x10
			public Meta meta; // 0x18
	
			// Constructors
			public SpriteDataObject(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public TexturePacker_JsonArray(); // 0x00000001802650F0-0x0000000180265100
	}
}
