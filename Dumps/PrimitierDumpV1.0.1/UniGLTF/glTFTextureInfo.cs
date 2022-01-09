/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public abstract class glTFTextureInfo : IglTFTextureinfo // TypeDefIndex: 5760
	{
		// Fields
		[JsonSchema] // 0x0000000180027940-0x0000000180027970
		public int index; // 0x10
		[JsonSchema] // 0x0000000180027650-0x0000000180027680
		public int texCoord; // 0x14
		public glTFExtension extensions; // 0x18
		public glTFExtension extras; // 0x20
	
		// Properties
		public abstract glTFTextureTypes TextureType { get; }
	
		// Constructors
		protected glTFTextureInfo(); // 0x0000000180D5BC60-0x0000000180D5BC70
	}
}
