/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public class glTF : IEquatable<UniGLTF.glTF> // TypeDefIndex: 5738
	{
		// Fields
		[JsonSchema] // 0x0000000180027770-0x00000001800277A0
		public glTFAssets asset; // 0x10
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFBuffer> buffers; // 0x18
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFBufferView> bufferViews; // 0x20
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFAccessor> accessors; // 0x28
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFTexture> textures; // 0x30
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFTextureSampler> samplers; // 0x38
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFImage> images; // 0x40
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFMaterial> materials; // 0x48
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFMesh> meshes; // 0x50
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFNode> nodes; // 0x58
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFSkin> skins; // 0x60
		[JsonSchema] // 0x00000001800277D0-0x0000000180027850
		public int scene; // 0x68
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<gltfScene> scenes; // 0x70
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFAnimation> animations; // 0x78
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<glTFCamera> cameras; // 0x80
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<string> extensionsUsed; // 0x88
		[JsonSchema] // 0x00000001800277A0-0x00000001800277D0
		public List<string> extensionsRequired; // 0x90
		public glTFExtension extensions; // 0x98
		public glTFExtension extras; // 0xA0
	
		// Properties
		public int[] rootnodes { get; } // 0x0000000180D625D0-0x0000000180D62640 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5736
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<glTFMaterial, bool> __9__12_0; // 0x08
			public static Func<glTFMaterial, string> __9__12_1; // 0x10
			public static Func<glTFMesh, IEnumerable<glTFPrimitives>> __9__15_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001806E70F0-0x00000001806E7150
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetUniqueMaterialName_b__12_0(glTFMaterial x); // 0x00000001806E4F40-0x00000001806E4F70
			internal string _GetUniqueMaterialName_b__12_1(glTFMaterial x); // 0x000000018054DB00-0x000000018054DB20
			internal IEnumerable<glTFPrimitives> _MaterialHasVertexColor_b__15_0(glTFMesh x); // 0x00000001806E5010-0x00000001806E5030
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 5737
		{
			// Fields
			public int materialIndex; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _MaterialHasVertexColor_b__1(glTFPrimitives x); // 0x00000001806E5530-0x00000001806E5560
		}
	
		// Constructors
		public glTF(); // 0x0000000180D62210-0x0000000180D625D0
	
		// Methods
		public int AddBufferView(glTFBufferView view); // 0x0000000180D602E0-0x0000000180D60350
		public ArraySegment<byte> GetViewBytes(int bufferView); // 0x0000000180D60A40-0x0000000180D60B70
		public glTFTextureSampler GetSampler(int index); // 0x0000000180D60630-0x0000000180D60730
		public glTFTextureSampler GetSamplerFromTextureIndex(int textureIndex); // 0x0000000180D604F0-0x0000000180D60630
		public string GetUniqueMaterialName(int index); // 0x0000000180D60730-0x0000000180D60A40
		public bool MaterialHasVertexColor(glTFMaterial material); // 0x0000000180D61F40-0x0000000180D61FC0
		public bool MaterialHasVertexColor(int materialIndex); // 0x0000000180D61FC0-0x0000000180D621D0
		public override string ToString(); // 0x0000000180D621D0-0x0000000180D62210
		public bool Equals(glTF other); // 0x0000000180D60350-0x0000000180D604F0
	}
}
