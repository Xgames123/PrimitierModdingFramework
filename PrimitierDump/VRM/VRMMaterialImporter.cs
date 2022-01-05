/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;
using VRMShaders;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMMaterialImporter // TypeDefIndex: 8067
	{
		// Fields
		private readonly glTF_VRM_extensions m_vrm; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 8063
		{
			// Fields
			public glTF_VRM_Material vrmMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _TryCreateParam_b__0(Material material); // 0x000000018054F6D0-0x000000018054F700
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_1 // TypeDefIndex: 8064
		{
			// Fields
			public KeyValuePair<string, bool> kv; // 0x10
	
			// Constructors
			public __c__DisplayClass2_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _TryCreateParam_b__1(Material material); // 0x000000018054F900-0x000000018054F950
			internal void _TryCreateParam_b__2(Material material); // 0x000000018054F950-0x000000018054F9A0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_2 // TypeDefIndex: 8065
		{
			// Fields
			public KeyValuePair<string, string> kv; // 0x10
	
			// Constructors
			public __c__DisplayClass2_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _TryCreateParam_b__3(Material material); // 0x000000018054F9A0-0x000000018054FA00
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateAllTexturesDistinct_d__4 : IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>>, IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> // TypeDefIndex: 8066
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<SubAssetKey, TextureImportParam> __2__current; // 0x18
			private int __l__initialThreadId; // 0xA0
			public VRMMaterialImporter __4__this; // 0xA8
			private GltfParser parser; // 0xB0
			public GltfParser __3__parser; // 0xB8
			private HashSet<SubAssetKey> _used_5__2; // 0xC0
			private int _i_5__3; // 0xC8
			private IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> __7__wrap3; // 0xD0
	
			// Properties
			ValueTuple<SubAssetKey, TextureImportParam> IEnumerator<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054B790-0x000000018054B7F0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054B830-0x000000018054B8E0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateAllTexturesDistinct_d__4(int __1__state); // 0x000000018054BA90-0x000000018054BAD0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x000000018054B8E0-0x000000018054B9D0
			private bool MoveNext(); // 0x000000018054ADF0-0x000000018054B6E0
			private void __m__Finally1(); // 0x000000018054B9D0-0x000000018054BA30
			private void __m__Finally2(); // 0x000000018054BA30-0x000000018054BA90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018054B7F0-0x000000018054B830
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> System.Collections.Generic.IEnumerable<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.GetEnumerator(); // 0x000000018054B6E0-0x000000018054B790
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018054B6E0-0x000000018054B790
		}
	
		// Constructors
		public VRMMaterialImporter(glTF_VRM_extensions vrm); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public bool TryCreateParam(GltfParser parser, int i, out MaterialImportParam param); // 0x000000018034C630-0x000000018034D6F0
		public MaterialImportParam GetMaterialParam(GltfParser parser, int i); // 0x000000018034C5C0-0x000000018034C630
		[IteratorStateMachine] // 0x0000000180037080-0x00000001800370D0
		public IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>> EnumerateAllTexturesDistinct(GltfParser parser); // 0x000000018034C540-0x000000018034C5C0
	}
}
