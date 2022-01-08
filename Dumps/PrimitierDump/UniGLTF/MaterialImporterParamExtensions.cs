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
	public static class MaterialImporterParamExtensions // TypeDefIndex: 5842
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _EnumerateSubAssetKeyValue_d__0 : IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>>, IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> // TypeDefIndex: 5841
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<SubAssetKey, TextureImportParam> __2__current; // 0x18
			private int __l__initialThreadId; // 0xA0
			private MaterialImportParam param; // 0xA8
			public MaterialImportParam __3__param; // 0xB0
			private Dictionary<string, TextureImportParam> __7__wrap1; // 0xB8
	
			// Properties
			ValueTuple<SubAssetKey, TextureImportParam> IEnumerator<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054B790-0x000000018054B7F0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DF340-0x00000001806DF3F0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _EnumerateSubAssetKeyValue_d__0(int __1__state); // 0x000000018054BA90-0x000000018054BAD0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806DF3F0-0x00000001806DF480
			private bool MoveNext(); // 0x00000001806DEE60-0x00000001806DF260
			private void __m__Finally1(); // 0x00000001806DF480-0x00000001806DF4D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806DF300-0x00000001806DF340
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<SubAssetKey, TextureImportParam>> System.Collections.Generic.IEnumerable<(UniGLTF.SubAssetKey,VRMShaders.TextureImportParam)>.GetEnumerator(); // 0x00000001806DF260-0x00000001806DF300
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DF260-0x00000001806DF300
		}
	
		// Extension methods
		[IteratorStateMachine] // 0x0000000180029300-0x0000000180029360
		public static IEnumerable<ValueTuple<SubAssetKey, TextureImportParam>> EnumerateSubAssetKeyValue(this MaterialImportParam param); // 0x0000000180BB6690-0x0000000180BB6700
	}
}
