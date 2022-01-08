/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public static class TMP_MaterialManager // TypeDefIndex: 6154
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 6148
		{
			// Fields
			public long fallbackID; // 0x10
			public Material sourceMaterial; // 0x18
			internal int sourceMaterialCRC; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x00000001802650F0-0x0000000180265100
		}
	
		private class MaskingMaterial // TypeDefIndex: 6149
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 6150
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetBaseMaterial_b__0(MaskingMaterial item); // 0x0000000180884EB0-0x0000000180884F30
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 6151
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AddMaskingMaterial_b__0(MaskingMaterial item); // 0x0000000180884C90-0x0000000180884D10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 6152
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _RemoveStencilMaterial_b__0(MaskingMaterial item); // 0x0000000180884D10-0x0000000180884D90
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 6153
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ReleaseBaseMaterial_b__0(MaskingMaterial item); // 0x0000000180884D90-0x0000000180884E10
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x0000000180531580-0x0000000180531710
	
		// Methods
		private static void OnPreRender(); // 0x0000000180530540-0x00000001805305D0
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x0000000180530120-0x0000000180530540
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x0000000180530EA0-0x0000000180531130
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x000000018052F080-0x000000018052F220
		public static Material SetStencil(Material material, int stencilID); // 0x0000000180531470-0x0000000180531580
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x000000018052E4F0-0x000000018052E780
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x0000000180531300-0x0000000180531470
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x00000001805305D0-0x0000000180530CA0
		public static void ClearMaterials(); // 0x000000018052E9F0-0x000000018052EBF0
		public static int GetStencilID(GameObject obj); // 0x000000018052FCB0-0x0000000180530120
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x000000018052FA80-0x000000018052FCB0
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x000000018052EEE0-0x000000018052F080
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex); // 0x000000018052F220-0x000000018052F580
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x000000018052F580-0x000000018052FA80
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x000000018052E390-0x000000018052E4F0
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x0000000180531130-0x0000000180531300
		public static void CleanupFallbackMaterials(); // 0x000000018052E780-0x000000018052E9F0
		public static void ReleaseFallbackMaterial(Material fallbackMaterial); // 0x0000000180530CA0-0x0000000180530EA0
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x000000018052EBF0-0x000000018052EEE0
	}
}
