/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class GltfTextureEnumerator // TypeDefIndex: 5835
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateTexturesForMaterial_d__0 : IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>>, IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> // TypeDefIndex: 5832
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<SubAssetKey, TextureImportParam> __2__current; // 0x18
			private int __l__initialThreadId; // 0xA0
			private GltfParser parser; // 0xA8
			public GltfParser __3__parser; // 0xB0
			private int i; // 0xB8
			public int __3__i; // 0xBC
			private glTFMaterial _m_5__2; // 0xC0
			private int? _metallicRoughnessTexture_5__3; // 0xC8
	
			// Properties
			ValueTuple<SubAssetKey, TextureImportParam> IEnumerator<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054B790-0x000000018054B7F0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D53640-0x0000000180D536F0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateTexturesForMaterial_d__0(int __1__state); // 0x000000018054BA90-0x000000018054BAD0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D53050-0x0000000180D53550
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D53600-0x0000000180D53640
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> System.Collections.Generic.IEnumerable<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.GetEnumerator(); // 0x0000000180D53550-0x0000000180D53600
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D53550-0x0000000180D53600
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5833
		{
			// Fields
			public HashSet<SubAssetKey> used; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _EnumerateAllTexturesDistinct_b__0(ValueTuple<SubAssetKey, TextureImportParam> kv); // 0x0000000180D573F0-0x0000000180D57460
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateAllTexturesDistinct_d__1 : IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>>, IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> // TypeDefIndex: 5834
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<SubAssetKey, TextureImportParam> __2__current; // 0x18
			private int __l__initialThreadId; // 0xA0
			private GltfParser parser; // 0xA8
			public GltfParser __3__parser; // 0xB0
			private Func<ValueTuple<SubAssetKey, TextureImportParam>, bool> _add_5__2; // 0xB8
			private int _i_5__3; // 0xC0
			private IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> __7__wrap3; // 0xC8
	
			// Properties
			ValueTuple<SubAssetKey, TextureImportParam> IEnumerator<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054B790-0x000000018054B7F0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D52EB0-0x0000000180D52F60 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateAllTexturesDistinct_d__1(int __1__state); // 0x000000018054BA90-0x000000018054BAD0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180D52F60-0x0000000180D52FF0
			private bool MoveNext(); // 0x0000000180D52950-0x0000000180D52DD0
			private void __m__Finally1(); // 0x0000000180D52FF0-0x0000000180D53050
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D52E70-0x0000000180D52EB0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> System.Collections.Generic.IEnumerable<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.GetEnumerator(); // 0x0000000180D52DD0-0x0000000180D52E70
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D52DD0-0x0000000180D52E70
		}
	
		// Methods
		[IteratorStateMachine] // 0x0000000180029260-0x00000001800292B0
		public static IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>> EnumerateTexturesForMaterial(GltfParser parser, int i); // 0x0000000180D1EA10-0x0000000180D1EA90
		[IteratorStateMachine] // 0x00000001800292B0-0x0000000180029300
		public static IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>> EnumerateAllTexturesDistinct(GltfParser parser); // 0x0000000180D1E9A0-0x0000000180D1EA10
	}
}
