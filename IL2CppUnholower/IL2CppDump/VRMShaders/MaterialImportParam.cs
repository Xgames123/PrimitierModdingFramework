/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 34: VRMShaders.GLTF.IO.Runtime.dll - Assembly: VRMShaders.GLTF.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5247-5278

namespace VRMShaders
{
	public class MaterialImportParam // TypeDefIndex: 5254
	{
		// Fields
		public readonly string Name; // 0x10
		public readonly string ShaderName; // 0x18
		public readonly Dictionary<string, TextureImportParam> TextureSlots; // 0x20
		public readonly Dictionary<string, float> FloatValues; // 0x28
		public readonly Dictionary<string, Color> Colors; // 0x30
		public readonly Dictionary<string, Vector4> Vectors; // 0x38
		public readonly List<Action<Material>> Actions; // 0x40
	
		// Constructors
		public MaterialImportParam(string name, string shaderName); // 0x00000001808A4F50-0x00000001808A50D0
	}
}
