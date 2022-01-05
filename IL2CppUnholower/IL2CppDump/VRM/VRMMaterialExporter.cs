/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;
using VRMShaders;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMMaterialExporter : MaterialExporter // TypeDefIndex: 8062
	{
		// Fields
		private static readonly string[] TAGS; // 0x00
	
		// Constructors
		public VRMMaterialExporter(); // 0x00000001802686E0-0x00000001802686F0
		static VRMMaterialExporter(); // 0x000000018034C470-0x000000018034C540
	
		// Methods
		protected override glTFMaterial CreateMaterial(Material m); // 0x000000018034BD10-0x000000018034C070
		private static glTFMaterial Export_VRMUnlitTexture(Material m); // 0x000000018034C320-0x000000018034C390
		private static glTFMaterial Export_VRMUnlitTransparent(Material m); // 0x000000018034C400-0x000000018034C470
		private static glTFMaterial Export_VRMUnlitCutout(Material m); // 0x000000018034C2B0-0x000000018034C320
		private static glTFMaterial Export_VRMUnlitTransparentZWrite(Material m); // 0x000000018034C390-0x000000018034C400
		private static glTFMaterial Export_VRMMToon(Material m); // 0x000000018034C070-0x000000018034C2B0
		public static glTF_VRM_Material CreateFromMaterial(Material m, TextureExporter textureExporter); // 0x000000018034B4E0-0x000000018034BD10
	}
}
