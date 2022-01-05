/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public class glTF_KHR_texture_transform // TypeDefIndex: 5713
	{
		// Fields
		public const string ExtensionName = "KHR_texture_transform"; // Metadata: 0x003A19DF
		public static readonly Utf8String ExtensionNameUt8; // 0x00
		[JsonSchema] // 0x0000000180027620-0x0000000180027650
		public float[] offset; // 0x10
		public float rotation; // 0x18
		[JsonSchema] // 0x0000000180027620-0x0000000180027650
		public float[] scale; // 0x20
		[ItemJsonSchema] // 0x0000000180027650-0x0000000180027680
		public int texCoord; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DeserializeFloat2_d__6 : IEnumerable<float>, IEnumerator<float> // TypeDefIndex: 5712
		{
			// Fields
			private int __1__state; // 0x10
			private float __2__current; // 0x14
			private int __l__initialThreadId; // 0x18
			private JsonNode json; // 0x20
			public JsonNode __3__json; // 0x30
			private IEnumerator<JsonNode> __7__wrap1; // 0x40
	
			// Properties
			float IEnumerator<System.Single>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018030D160-0x000000018030D170 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DE410-0x00000001806DE460 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DeserializeFloat2_d__6(int __1__state); // 0x00000001806DE540-0x00000001806DE570
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806DE460-0x00000001806DE4F0
			private bool MoveNext(); // 0x00000001806DE150-0x00000001806DE330
			private void __m__Finally1(); // 0x00000001806DE4F0-0x00000001806DE540
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DE3D0-0x00000001806DE410
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<float> IEnumerable<float>.GetEnumerator(); // 0x00000001806DE330-0x00000001806DE3D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DE330-0x00000001806DE3D0
		}
	
		// Constructors
		public glTF_KHR_texture_transform(); // 0x0000000180D61E90-0x0000000180D61F40
		static glTF_KHR_texture_transform(); // 0x0000000180D61E00-0x0000000180D61E90
	
		// Methods
		[IteratorStateMachine] // 0x0000000180027680-0x00000001800276D0
		private static IEnumerable<float> DeserializeFloat2(JsonNode json); // 0x0000000180D61350-0x0000000180D613C0
		private static glTF_KHR_texture_transform Deserialize(JsonNode json); // 0x0000000180D613C0-0x0000000180D61890
		public static bool TryGet(glTFTextureInfo info, out glTF_KHR_texture_transform t); // 0x0000000180D61AD0-0x0000000180D61E00
		public static void Serialize(glTFTextureInfo info, ValueTuple<float, float> offset, ValueTuple<float, float> scale); // 0x0000000180D61890-0x0000000180D61AD0
	}
}
