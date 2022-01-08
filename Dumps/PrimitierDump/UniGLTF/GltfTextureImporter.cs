/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class GltfTextureImporter // TypeDefIndex: 5881
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5877
		{
			// Fields
			public GltfParser parser; // 0x10
			public int textureIndex; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Task<byte[]> _CreateSRGB_b__0(); // 0x0000000180D57260-0x0000000180D573F0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 5878
		{
			// Fields
			public GltfParser parser; // 0x10
			public int textureIndex; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Task<byte[]> _CreateNormal_b__0(); // 0x0000000180D577D0-0x0000000180D57960
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 5879
		{
			// Fields
			public GltfParser parser; // 0x10
			public int? metallicRoughnessTextureIndex; // 0x18
			public int? occlusionTextureIndex; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Task<byte[]> _CreateStandard_b__0(); // 0x0000000180D57AB0-0x0000000180D57C60
			internal Task<byte[]> _CreateStandard_b__1(); // 0x0000000180D57C60-0x0000000180D57E10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetUnityWrapMode_d__5 : IEnumerable<ValueTuple<SamplerWrapType, TextureWrapMode>>, IEnumerator<ValueTuple<SamplerWrapType, TextureWrapMode>> // TypeDefIndex: 5880
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<SamplerWrapType, TextureWrapMode> __2__current; // 0x14
			private int __l__initialThreadId; // 0x1C
			private glTFTextureSampler sampler; // 0x20
			public glTFTextureSampler __3__sampler; // 0x28
	
			// Properties
			ValueTuple<SamplerWrapType, TextureWrapMode> IEnumerator<(VRMShaders.SamplerWrapType,UnityEngine.TextureWrapMode)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180A65670-0x0000000180A65680 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D53CA0-0x0000000180D53CF0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetUnityWrapMode_d__5(int __1__state); // 0x0000000180D53CF0-0x0000000180D53D20
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D536F0-0x0000000180D53BC0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D53C60-0x0000000180D53CA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<SamplerWrapType, TextureWrapMode>> System.Collections.Generic.IEnumerable<(VRMShaders.SamplerWrapType,UnityEngine.TextureWrapMode)>.GetEnumerator(); // 0x0000000180D53BC0-0x0000000180D53C60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D53BC0-0x0000000180D53C60
		}
	
		// Methods
		public static byte[] ToArray(ArraySegment<byte> bytes); // 0x0000000180D1FAF0-0x0000000180D1FBE0
		public static ValueTuple<SubAssetKey, TextureImportParam> CreateSRGB(GltfParser parser, int textureIndex, Vector2 offset, Vector2 scale); // 0x0000000180D1F040-0x0000000180D1F390
		public static ValueTuple<SubAssetKey, TextureImportParam> CreateNormal(GltfParser parser, int textureIndex, Vector2 offset, Vector2 scale); // 0x0000000180D1ECF0-0x0000000180D1F040
		public static TextureImportParam CreateStandard(GltfParser parser, int? metallicRoughnessTextureIndex, int? occlusionTextureIndex, Vector2 offset, Vector2 scale, float metallicFactor, float roughnessFactor); // 0x0000000180D1F5A0-0x0000000180D1F9E0
		public static SamplerParam CreateSampler(glTF gltf, int index); // 0x0000000180D1F390-0x0000000180D1F5A0
		[IteratorStateMachine] // 0x00000001800297A0-0x00000001800297F0
		public static IEnumerable<ValueTuple<SamplerWrapType, TextureWrapMode>> GetUnityWrapMode(glTFTextureSampler sampler); // 0x0000000180D1F9E0-0x0000000180D1FA50
		public static FilterMode ImportFilterMode(glFilter filterMode); // 0x0000000180D1FA50-0x0000000180D1FAF0
	}
}
