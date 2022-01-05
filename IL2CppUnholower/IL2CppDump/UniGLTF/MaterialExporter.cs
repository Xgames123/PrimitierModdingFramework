/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class MaterialExporter : IMaterialExporter // TypeDefIndex: 5840
	{
		// Constructors
		public MaterialExporter(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public virtual glTFMaterial ExportMaterial(Material m, TextureExporter textureExporter); // 0x0000000180BB51D0-0x0000000180BB5370
		private static void Export_Color(Material m, TextureExporter textureManager, glTFMaterial material); // 0x0000000180BB5370-0x0000000180BB55C0
		private static void Export_OcclusionMetallicRoughness(Material m, TextureExporter textureManager, glTFMaterial material); // 0x0000000180BB5A90-0x0000000180BB5E70
		private static void Export_Normal(Material m, TextureExporter textureManager, glTFMaterial material); // 0x0000000180BB5960-0x0000000180BB5A90
		private static void Export_Emission(Material m, TextureExporter textureManager, glTFMaterial material); // 0x0000000180BB55C0-0x0000000180BB5810
		private static void Export_MainTextureTransform(Material m, glTFTextureInfo textureInfo); // 0x0000000180BB5810-0x0000000180BB5960
		private static void Export_TextureTransform(Material m, glTFTextureInfo textureInfo, string propertyName); // 0x0000000180BB6050-0x0000000180BB6190
		protected virtual glTFMaterial CreateMaterial(Material m); // 0x0000000180BB4D50-0x0000000180BB51D0
		private static glTFMaterial Export_UnlitColor(Material m); // 0x0000000180BB6310-0x0000000180BB63E0
		private static glTFMaterial Export_UnlitTexture(Material m); // 0x0000000180BB64F0-0x0000000180BB65C0
		private static glTFMaterial Export_UnlitTransparent(Material m); // 0x0000000180BB65C0-0x0000000180BB6690
		private static glTFMaterial Export_UnlitCutout(Material m); // 0x0000000180BB63E0-0x0000000180BB64F0
		private glTFMaterial Export_UniUnlit(Material m); // 0x0000000180BB6190-0x0000000180BB6310
		private static glTFMaterial Export_Standard(Material m); // 0x0000000180BB5E70-0x0000000180BB6050
	}
}
