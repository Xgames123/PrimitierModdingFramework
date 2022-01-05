/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 34: VRMShaders.GLTF.IO.Runtime.dll - Assembly: VRMShaders.GLTF.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5247-5278

namespace VRMShaders
{
	public class MaterialFactory : IDisposable // TypeDefIndex: 5253
	{
		// Fields
		private Dictionary<string, Material> m_externalMap; // 0x10
		private List<MaterialLoadInfo> m_materials; // 0x18
	
		// Properties
		public IReadOnlyList<MaterialLoadInfo> Materials { get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Nested types
		public struct MaterialLoadInfo // TypeDefIndex: 5249
		{
			// Fields
			public readonly Material Asset; // 0x00
			public readonly bool UseExternal; // 0x08
	
			// Properties
			public bool IsSubAsset { get; } // 0x00000001806A9190-0x00000001806A91A0 
	
			// Constructors
			public MaterialLoadInfo(Material asset, bool useExternal); // 0x0000000180696000-0x0000000180696010
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5250
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueTuple<string, UnityEngine.Object>, ValueTuple<string, Material>> __9__1_0; // 0x08
			public static Func<ValueTuple<string, Material>, bool> __9__1_1; // 0x10
			public static Func<ValueTuple<string, Material>, string> __9__1_2; // 0x18
			public static Func<ValueTuple<string, Material>, Material> __9__1_3; // 0x20
			public static GetTextureAsyncFunc __9__10_0; // 0x28
	
			// Constructors
			static __c(); // 0x00000001808AADF0-0x00000001808AAE50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<string, Material> _.ctor_b__1_0(ValueTuple<string, UnityEngine.Object> kv); // 0x00000001808AAA30-0x00000001808AAAF0
			internal bool _.ctor_b__1_1(ValueTuple<string, Material> kv); // 0x00000001808AAAF0-0x00000001808AAB50
			internal string _.ctor_b__1_2(ValueTuple<string, Material> kv); // 0x000000018054DCB0-0x000000018054DCC0
			internal Material _.ctor_b__1_3(ValueTuple<string, Material> kv); // 0x00000001806E5000-0x00000001806E5010
			internal Task<Texture2D> _LoadAsync_b__10_0(TextureImportParam _); // 0x00000001808AA940-0x00000001808AA9A0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 5251
		{
			// Fields
			public Material material; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Remove_b__0(MaterialLoadInfo x); // 0x00000001808AAD20-0x00000001808AAD90
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _LoadAsync_d__10 : IAsyncStateMachine // TypeDefIndex: 5252
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<Material> __t__builder; // 0x08
			public MaterialFactory __4__this; // 0x20
			public MaterialImportParam param; // 0x28
			public GetTextureAsyncFunc getTexture; // 0x30
			private Material _material_5__2; // 0x38
			private Dictionary<string, TextureImportParam> __7__wrap2; // 0x40
			private KeyValuePair<string, TextureImportParam> _kv_5__4; // 0xD8
			private TaskAwaiter<Texture2D> __u__1; // 0x158
	
			// Methods
			private void MoveNext(); // 0x00000001808A9920-0x00000001808AA830
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001808AA830-0x00000001808AA880
		}
	
		// Constructors
		public MaterialFactory(IEnumerable<ValueTuple<string, UnityEngine.Object>> externalMap); // 0x00000001808A4AB0-0x00000001808A4F50
	
		// Methods
		private void Remove(Material material); // 0x00000001808A4560-0x00000001808A4670
		public void Dispose(); // 0x00000001808A4260-0x00000001808A43B0
		public void TransferOwnership(Func<UnityEngine.Object, bool> take); // 0x00000001808A46C0-0x00000001808A4AB0
		public Material GetMaterial(int index); // 0x00000001808A43B0-0x00000001808A4440
		public async Task<Material> LoadAsync(MaterialImportParam param, GetTextureAsyncFunc getTexture); // 0x00000001808A4440-0x00000001808A4560
		public static void SetTextureOffsetAndScale(Material material, string propertyName, Vector2 offset, Vector2 scale); // 0x00000001808A4670-0x00000001808A46C0
	}
}
