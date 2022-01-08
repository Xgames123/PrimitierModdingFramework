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
	public class TextureFactory : IDisposable // TypeDefIndex: 5273
	{
		// Fields
		public readonly Dictionary<string, Texture2D> ExternalMap; // 0x10
		private Dictionary<string, TextureLoadInfo> m_textureCache; // 0x18
	
		// Properties
		public IEnumerable<TextureLoadInfo> Textures { get; } // 0x00000001808A8590-0x00000001808A85E0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5270
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ValueTuple<string, UnityEngine.Object>, ValueTuple<string, Texture2D>> __9__1_0; // 0x08
			public static Func<ValueTuple<string, Texture2D>, bool> __9__1_1; // 0x10
			public static Func<ValueTuple<string, Texture2D>, string> __9__1_2; // 0x18
			public static Func<ValueTuple<string, Texture2D>, Texture2D> __9__1_3; // 0x20
			public static Action<UnityEngine.Object> __9__2_0; // 0x28
			public static Action<UnityEngine.Object> __9__2_1; // 0x30
	
			// Constructors
			static __c(); // 0x00000001808AAD90-0x00000001808AADF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<string, Texture2D> _.ctor_b__1_0(ValueTuple<string, UnityEngine.Object> kv); // 0x00000001808AA9A0-0x00000001808AAA30
			internal bool _.ctor_b__1_1(ValueTuple<string, Texture2D> kv); // 0x00000001808AAB50-0x00000001808AABB0
			internal string _.ctor_b__1_2(ValueTuple<string, Texture2D> kv); // 0x000000018054DCB0-0x000000018054DCC0
			internal Texture2D _.ctor_b__1_3(ValueTuple<string, Texture2D> kv); // 0x00000001806E5000-0x00000001806E5010
			internal void _DestroyResource_b__2_0(UnityEngine.Object o); // 0x00000001808AA880-0x00000001808AA8E0
			internal void _DestroyResource_b__2_1(UnityEngine.Object o); // 0x00000001808AA8E0-0x00000001808AA940
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _GetOrCreateBaseTexture_d__8 : IAsyncStateMachine // TypeDefIndex: 5271
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<TextureLoadInfo> __t__builder; // 0x08
			public TextureFactory __4__this; // 0x20
			public string name; // 0x28
			public GetTextureBytesAsync getTextureBytesAsync; // 0x30
			public RenderTextureReadWrite colorSpace; // 0x38
			public TextureImportParam param; // 0x40
			public bool used; // 0xB8
			private TaskAwaiter<byte[]> __u__1; // 0xC0
	
			// Methods
			private void MoveNext(); // 0x00000001808A89F0-0x00000001808A8E90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001808A8E90-0x00000001808A8EE0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _GetTextureAsync_d__10 : IAsyncStateMachine // TypeDefIndex: 5272
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<Texture2D> __t__builder; // 0x08
			public TextureImportParam param; // 0x20
			public TextureFactory __4__this; // 0x98
			private TaskAwaiter<TextureLoadInfo> __u__1; // 0xA0
			private TextureLoadInfo _baseTexture_5__2; // 0xA8
	
			// Methods
			private void MoveNext(); // 0x00000001808A8EE0-0x00000001808A98D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001808A98D0-0x00000001808A9920
		}
	
		// Constructors
		public TextureFactory(IEnumerable<ValueTuple<string, UnityEngine.Object>> externalMap); // 0x00000001808A8180-0x00000001808A8590
	
		// Methods
		public static Action<UnityEngine.Object> DestroyResource(); // 0x00000001808A7330-0x00000001808A74E0
		public void Dispose(); // 0x00000001808A74E0-0x00000001808A7890
		public void TransferOwnership(Func<UnityEngine.Object, bool> take); // 0x00000001808A7D80-0x00000001808A8180
		private async Task<TextureLoadInfo> GetOrCreateBaseTexture(string name, TextureImportParam param, GetTextureBytesAsync getTextureBytesAsync, RenderTextureReadWrite colorSpace, bool used); // 0x00000001808A7890-0x00000001808A7A30
		public static void SetSampler(Texture2D texture, TextureImportParam param); // 0x00000001808A7BA0-0x00000001808A7D80
		public async Task<Texture2D> GetTextureAsync(TextureImportParam param); // 0x00000001808A7A30-0x00000001808A7BA0
	}
}
