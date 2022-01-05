/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[AddComponentMenu] // 0x000000018003C2E0-0x000000018003C3A0
	[DisallowMultipleComponent] // 0x000000018003C2E0-0x000000018003C3A0
	[ExecuteAlways] // 0x000000018003C2E0-0x000000018003C3A0
	[HelpURL] // 0x000000018003C2E0-0x000000018003C3A0
	[RequireComponent] // 0x000000018003C2E0-0x000000018003C3A0
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 6227
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_hasFontAssetChanged; // 0x6C8
		private float m_previousLossyScaleY; // 0x6CC
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Renderer m_renderer; // 0x6D0
		private MeshFilter m_meshFilter; // 0x6D8
		private bool m_isFirstAllocation; // 0x6E0
		private int m_max_characters; // 0x6E4
		private int m_max_numberOfLines; // 0x6E8
		private TMP_SubMesh[] m_subTextObjects; // 0x6F0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private MaskingTypes m_maskType; // 0x6F8
		private Matrix4x4 m_EnvMapMatrix; // 0x6FC
		private Vector3[] m_RectTransformCorners; // 0x740
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x748
		private static ProfilerMarker k_GenerateTextMarker; // 0x00
		private static ProfilerMarker k_SetArraySizesMarker; // 0x08
		private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
		private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
		private static ProfilerMarker k_CharacterLookupMarker; // 0x20
		private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
		private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
		private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
		private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
		private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
		private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
		private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
		private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
		private static ProfilerMarker k_SavePageInfoMarker; // 0x80
		private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
		private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int _SortingLayer; // 0x74C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int _SortingLayerID; // 0x750
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal int _SortingOrder; // 0x754
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Action<TMP_TextInfo> OnPreRenderText; // 0x758
		private bool m_currentAutoSizeMode; // 0x760
	
		// Properties
		public int sortingLayerID { get; set; } // 0x00000001803C3510-0x00000001803C35B0 0x00000001803C3920-0x00000001803C3B00
		public int sortingOrder { get; set; } // 0x00000001803C35B0-0x00000001803C3650 0x00000001803C3B00-0x00000001803C3CE0
		public override bool autoSizeTextContainer { get; set; } // 0x00000001803C3270-0x00000001803C3280 0x00000001803C3790-0x00000001803C3910
		[Obsolete] // 0x000000018003C3A0-0x000000018003C3D0
		public TextContainer textContainer { get; } // 0x0000000180273F80-0x0000000180273F90 
		public new Transform transform { get; } // 0x00000001803C3650-0x00000001803C36F0 
		public Renderer renderer { get; } // 0x00000001803C3470-0x00000001803C3510 
		public override Mesh mesh { get; } // 0x00000001803C33B0-0x00000001803C3470 
		public MeshFilter meshFilter { get; } // 0x00000001803C3290-0x00000001803C33B0 
		public MaskingTypes maskType { get; set; } // 0x00000001803C3280-0x00000001803C3290 0x00000001803C3910-0x00000001803C3920
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x00000001803C31D0-0x00000001803C3270
			remove; // 0x00000001803C36F0-0x00000001803C3790
		}
	
		// Constructors
		public TextMeshPro(); // 0x00000001803C3110-0x00000001803C31D0
		static TextMeshPro(); // 0x00000001803C2C70-0x00000001803C3110
	
		// Methods
		protected override void Awake(); // 0x00000001803AE7A0-0x00000001803AECD0
		protected override void OnEnable(); // 0x00000001803BCCC0-0x00000001803BCEB0
		protected override void OnDisable(); // 0x00000001803BCC10-0x00000001803BCCC0
		protected override void OnDestroy(); // 0x00000001803BCAC0-0x00000001803BCBF0
		protected override void LoadFontAsset(); // 0x00000001803BC270-0x00000001803BCAC0
		private void UpdateEnvMapMatrix(); // 0x00000001803C1C10-0x00000001803C1EE0
		private void SetMask(MaskingTypes maskType); // 0x00000001803C0C80-0x00000001803C0E40
		private void SetMaskCoordinates(Vector4 coords); // 0x00000001803C0A20-0x00000001803C0AC0
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x00000001803C0900-0x00000001803C0A20
		private void EnableMasking(); // 0x00000001803AF300-0x00000001803AF450
		private void DisableMasking(); // 0x00000001803AF1B0-0x00000001803AF300
		private void UpdateMask(); // 0x00000001803C1F20-0x00000001803C2050
		protected override Material GetMaterial(Material mat); // 0x00000001803BBBA0-0x00000001803BBCC0
		protected override Material[] GetMaterials(Material[] mats); // 0x00000001803BBCC0-0x00000001803BBEA0
		protected override void SetSharedMaterial(Material mat); // 0x00000001803C15A0-0x00000001803C15F0
		protected override Material[] GetSharedMaterials(); // 0x00000001803BBEA0-0x00000001803BC060
		protected override void SetSharedMaterials(Material[] materials); // 0x00000001803C15F0-0x00000001803C1A70
		protected override void SetOutlineThickness(float thickness); // 0x00000001803C1230-0x00000001803C1380
		protected override void SetFaceColor(Color32 color); // 0x00000001803C06E0-0x00000001803C0820
		protected override void SetOutlineColor(Color32 color); // 0x00000001803C10F0-0x00000001803C1230
		private void CreateMaterialInstance(); // 0x00000001803AEFA0-0x00000001803AF070
		protected override void SetShaderDepth(); // 0x00000001803C1450-0x00000001803C15A0
		protected override void SetCulling(); // 0x00000001803C0310-0x00000001803C06E0
		private void SetPerspectiveCorrection(); // 0x00000001803C1380-0x00000001803C1450
		internal override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x00000001803BD930-0x00000001803C0310
		public override void ComputeMarginSize(); // 0x00000001803AEE30-0x00000001803AEFA0
		protected override void OnDidApplyAnimationProperties(); // 0x00000001803BCBF0-0x00000001803BCC10
		protected override void OnTransformParentChanged(); // 0x00000001803BD4A0-0x00000001803BD4E0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001803BD2A0-0x00000001803BD4A0
		internal override void InternalUpdate(); // 0x00000001803BC190-0x00000001803BC270
		private void OnPreRenderObject(); // 0x00000001803BCEB0-0x00000001803BD2A0
		protected virtual void GenerateTextMesh(); // 0x00000001803AF470-0x00000001803BB750
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x00000001803BC060-0x00000001803BC110
		private void SetMeshFilters(bool state); // 0x00000001803C0E40-0x00000001803C10F0
		protected override void SetActiveSubMeshes(bool state); // 0x00000001803BD5D0-0x00000001803BD740
		protected void SetActiveSubTextObjectRenderers(bool state); // 0x00000001803BD740-0x00000001803BD8E0
		protected override void DestroySubMeshObjects(); // 0x00000001803AF070-0x00000001803AF1B0
		internal void UpdateSubMeshSortingLayerID(int id); // 0x00000001803C2540-0x00000001803C26A0
		internal void UpdateSubMeshSortingOrder(int order); // 0x00000001803C26A0-0x00000001803C2800
		protected override Bounds GetCompoundBounds(); // 0x00000001803BB750-0x00000001803BBBA0
		private void UpdateSDFScale(float scaleDelta); // 0x00000001803C22E0-0x00000001803C2540
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x00000001803C0BE0-0x00000001803C0C80
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x00000001803C0AC0-0x00000001803C0BE0
		public override void SetVerticesDirty(); // 0x00000001803C1A70-0x00000001803C1C10
		public override void SetLayoutDirty(); // 0x00000001803C0820-0x00000001803C0900
		public override void SetMaterialDirty(); // 0x0000000180269E00-0x0000000180269E20
		public override void SetAllDirty(); // 0x00000001803BD8E0-0x00000001803BD930
		public override void Rebuild(CanvasUpdate update); // 0x00000001803BD4E0-0x00000001803BD5D0
		protected override void UpdateMaterial(); // 0x00000001803C2050-0x00000001803C21B0
		public override void UpdateMeshPadding(); // 0x00000001803C21B0-0x00000001803C22E0
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x003A25EB */, bool forceTextReparsing = false /* Metadata: 0x003A25EC */); // 0x00000001803AF450-0x00000001803AF470
		public override TMP_TextInfo GetTextInfo(string text); // 0x00000001803BC110-0x00000001803BC190
		public override void ClearMesh(bool updateMesh); // 0x00000001803AECD0-0x00000001803AEE30
		public override void UpdateGeometry(Mesh mesh, int index); // 0x00000001803C1F00-0x00000001803C1F20
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001803C2800-0x00000001803C2A40
		public override void UpdateVertexData(); // 0x00000001803C2A40-0x00000001803C2C70
		public void UpdateFontAsset(); // 0x00000001803C1EE0-0x00000001803C1F00
		public void CalculateLayoutInputHorizontal(); // 0x0000000180265310-0x0000000180265320
		public void CalculateLayoutInputVertical(); // 0x0000000180265310-0x0000000180265320
	}
}
