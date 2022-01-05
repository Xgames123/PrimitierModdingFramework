/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF.Zip;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class GltfParser // TypeDefIndex: 5802
	{
		// Fields
		public string Json; // 0x10
		public glTF GLTF; // 0x18
		public IStorage Storage; // 0x20
		private string m_targetPath; // 0x28
	
		// Properties
		public string TargetPath { get; set; } // 0x0000000180268FD0-0x0000000180268FE0 0x0000000180D17C30-0x0000000180D17CA0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5801
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CentralDirectoryFileHeader, bool> __9__8_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180D58C70-0x0000000180D58CD0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Parse_b__8_0(CentralDirectoryFileHeader x); // 0x0000000180D56E50-0x0000000180D56EC0
		}
	
		// Constructors
		public GltfParser(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public void ParsePath(string path); // 0x0000000180D17190-0x0000000180D171D0
		public virtual void Parse(string path, byte[] bytes); // 0x0000000180D171D0-0x0000000180D17550
		public void ParseGlb(byte[] bytes); // 0x0000000180D16850-0x0000000180D16BF0
		public virtual void ParseJson(string json, IStorage storage); // 0x0000000180D16BF0-0x0000000180D17190
		private void FixMeshNameUnique(); // 0x0000000180D15F80-0x0000000180D162A0
		private void RenameImageFromTexture(int i); // 0x0000000180D17600-0x0000000180D177B0
		public static string PrepareUri(string uri); // 0x0000000180D17550-0x0000000180D17600
		private void FixTextureNameUnique(); // 0x0000000180D163D0-0x0000000180D16850
		public void FixMaterialNameUnique(); // 0x0000000180D15D90-0x0000000180D15F80
		private void FixNodeName(); // 0x0000000180D162A0-0x0000000180D163D0
		private void RestoreOlderVersionValues(); // 0x0000000180D177B0-0x0000000180D17C30
		public static void AppendImageExtension(glTFImage texture, string extension); // 0x0000000180D15D40-0x0000000180D15D90
	}
}
