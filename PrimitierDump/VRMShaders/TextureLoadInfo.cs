/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 34: VRMShaders.GLTF.IO.Runtime.dll - Assembly: VRMShaders.GLTF.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5247-5278

namespace VRMShaders
{
	public struct TextureLoadInfo // TypeDefIndex: 5269
	{
		// Fields
		public readonly Texture2D Texture; // 0x00
		public readonly TextureLoadFlags Flags; // 0x08
	
		// Properties
		public bool IsUsed { get; } // 0x00000001808A8970-0x00000001808A89F0 
		public bool IsExternal { get; } // 0x00000001808A88C0-0x00000001808A8940 
		public bool IsSubAsset { get; } // 0x00000001808A8940-0x00000001808A8970 
	
		// Constructors
		public TextureLoadInfo(Texture2D texture, bool used, bool isExternal); // 0x00000001808A88A0-0x00000001808A88C0
	}
}
