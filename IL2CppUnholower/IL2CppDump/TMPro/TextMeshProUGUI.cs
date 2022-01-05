/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[AddComponentMenu] // 0x000000018003C3D0-0x000000018003C4C0
	[DisallowMultipleComponent] // 0x000000018003C3D0-0x000000018003C4C0
	[ExecuteAlways] // 0x000000018003C3D0-0x000000018003C4C0
	[HelpURL] // 0x000000018003C3D0-0x000000018003C4C0
	[RequireComponent] // 0x000000018003C3D0-0x000000018003C4C0
	[RequireComponent] // 0x000000018003C3D0-0x000000018003C4C0
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6230
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_hasFontAssetChanged; // 0x6C8
		protected TMP_SubMeshUI[] m_subTextObjects; // 0x6D0
		private float m_previousLossyScaleY; // 0x6D8
		private Vector3[] m_RectTransformCorners; // 0x6E0
		private CanvasRenderer m_canvasRenderer; // 0x6E8
		private Canvas m_canvas; // 0x6F0
		private float m_CanvasScaleFactor; // 0x6F8
		private bool m_isFirstAllocation; // 0x6FC
		private int m_max_characters; // 0x700
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_baseMaterial; // 0x708
		private bool m_isScrollRegionSet; // 0x710
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector4 m_maskOffset; // 0x714
		private Matrix4x4 m_EnvMapMatrix; // 0x724
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x764
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
		private bool m_isRebuildingLayout; // 0x765
		private Coroutine m_DelayedGraphicRebuild; // 0x768
		private Coroutine m_DelayedMaterialRebuild; // 0x770
		private Rect m_ClipRect; // 0x778
		private bool m_ValidRect; // 0x788
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Action<TMP_TextInfo> OnPreRenderText; // 0x790
	
		// Properties
		public override Material materialForRendering { get; } // 0x000000018061F4C0-0x000000018061F530 
		public override bool autoSizeTextContainer { get; set; } // 0x00000001803C3270-0x00000001803C3280 0x000000018061F5D0-0x000000018061F660
		public override Mesh mesh { get; } // 0x0000000180287EA0-0x0000000180287EB0 
		public new CanvasRenderer canvasRenderer { get; } // 0x000000018061F410-0x000000018061F4B0 
		public Vector4 maskOffset { get; set; } // 0x000000018061F4B0-0x000000018061F4C0 0x000000018061F660-0x000000018061F690
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018061F370-0x000000018061F410
			remove; // 0x000000018061F530-0x000000018061F5D0
		}
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DelayedGraphicRebuild_d__89 : IEnumerator<object> // TypeDefIndex: 6228
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DelayedGraphicRebuild_d__89(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180883A60-0x0000000180883B20
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180883B20-0x0000000180883B60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DelayedMaterialRebuild_d__90 : IEnumerator<object> // TypeDefIndex: 6229
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TextMeshProUGUI __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DelayedMaterialRebuild_d__90(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180883B60-0x0000000180883C20
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180883C20-0x0000000180883C60
		}
	
		// Constructors
		public TextMeshProUGUI(); // 0x000000018061F2C0-0x000000018061F370
		static TextMeshProUGUI(); // 0x000000018061EE20-0x000000018061F2C0
	
		// Methods
		protected override void Awake(); // 0x0000000180609AB0-0x0000000180609EA0
		protected override void OnEnable(); // 0x0000000180618C60-0x0000000180618F00
		protected override void OnDisable(); // 0x0000000180618AB0-0x0000000180618C60
		protected override void OnDestroy(); // 0x00000001806188E0-0x0000000180618A70
		protected override void LoadFontAsset(); // 0x0000000180618040-0x00000001806187A0
		private Canvas GetCanvas(); // 0x0000000180617020-0x00000001806171A0
		private void UpdateEnvMapMatrix(); // 0x000000018061D910-0x000000018061DBE0
		private void EnableMasking(); // 0x000000018060A650-0x000000018060A890
		private void DisableMasking(); // 0x0000000180265310-0x0000000180265320
		private void UpdateMask(); // 0x000000018061DC80-0x000000018061E1E0
		protected override Material GetMaterial(Material mat); // 0x00000001806175F0-0x0000000180617750
		protected override Material[] GetMaterials(Material[] mats); // 0x0000000180617750-0x0000000180617930
		protected override void SetSharedMaterial(Material mat); // 0x00000001803C15A0-0x00000001803C15F0
		protected override Material[] GetSharedMaterials(); // 0x0000000180617A60-0x0000000180617C20
		protected override void SetSharedMaterials(Material[] materials); // 0x000000018061D050-0x000000018061D5D0
		protected override void SetOutlineThickness(float thickness); // 0x000000018061CBF0-0x000000018061CE00
		protected override void SetFaceColor(Color32 color); // 0x000000018061C700-0x000000018061C840
		protected override void SetOutlineColor(Color32 color); // 0x000000018061CAB0-0x000000018061CBF0
		protected override void SetShaderDepth(); // 0x000000018061CED0-0x000000018061D050
		protected override void SetCulling(); // 0x000000018061C2F0-0x000000018061C700
		private void SetPerspectiveCorrection(); // 0x000000018061CE00-0x000000018061CED0
		private void SetMeshArrays(int size); // 0x000000018061CA20-0x000000018061CAB0
		internal override int SetArraySizes(UnicodeChar[] unicodeChars); // 0x0000000180619830-0x000000018061C2F0
		public override void ComputeMarginSize(); // 0x0000000180609FF0-0x000000018060A160
		protected override void OnDidApplyAnimationProperties(); // 0x0000000180618A70-0x0000000180618AB0
		protected override void OnCanvasHierarchyChanged(); // 0x00000001806187A0-0x00000001806188E0
		protected override void OnTransformParentChanged(); // 0x0000000180619580-0x00000001806195D0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001806191C0-0x0000000180619580
		internal override void InternalUpdate(); // 0x0000000180617F60-0x0000000180618040
		private void OnPreRenderCanvas(); // 0x0000000180618F00-0x00000001806191C0
		protected virtual void GenerateTextMesh(); // 0x000000018060A940-0x0000000180616CF0
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x0000000180617C20-0x0000000180617CD0
		protected override void SetActiveSubMeshes(bool state); // 0x00000001806196C0-0x0000000180619830
		protected override void DestroySubMeshObjects(); // 0x000000018060A510-0x000000018060A650
		protected override Bounds GetCompoundBounds(); // 0x00000001806171A0-0x00000001806175F0
		internal override Rect GetCanvasSpaceClippingRect(); // 0x0000000180616CF0-0x0000000180617020
		private void UpdateSDFScale(float scaleDelta); // 0x000000018061E480-0x000000018061E7A0
		public void CalculateLayoutInputHorizontal(); // 0x0000000180265310-0x0000000180265320
		public void CalculateLayoutInputVertical(); // 0x0000000180265310-0x0000000180265320
		public override void SetVerticesDirty(); // 0x000000018061D5D0-0x000000018061D6B0
		public override void SetLayoutDirty(); // 0x000000018061C840-0x000000018061C930
		public override void SetMaterialDirty(); // 0x000000018061C930-0x000000018061CA20
		public override void SetAllDirty(); // 0x00000001803BD8E0-0x00000001803BD930
		[IteratorStateMachine] // 0x000000018003C4C0-0x000000018003C510
		private IEnumerator DelayedGraphicRebuild(); // 0x000000018060A430-0x000000018060A4A0
		[IteratorStateMachine] // 0x000000018003C510-0x000000018003C560
		private IEnumerator DelayedMaterialRebuild(); // 0x000000018060A4A0-0x000000018060A510
		public override void Rebuild(CanvasUpdate update); // 0x00000001806195D0-0x00000001806196C0
		private void UpdateSubObjectPivot(); // 0x000000018061E7A0-0x000000018061E8D0
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x0000000180617930-0x0000000180617A60
		protected override void UpdateMaterial(); // 0x000000018061E1E0-0x000000018061E350
		public override void RecalculateClipping(); // 0x0000000180269DF0-0x0000000180269E00
		public override void Cull(Rect clipRect, bool validRect); // 0x000000018060A160-0x000000018060A430
		internal override void UpdateCulling(); // 0x000000018061D6B0-0x000000018061D910
		public override void UpdateMeshPadding(); // 0x000000018061E350-0x000000018061E480
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000180617E80-0x0000000180617F60
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000180617DC0-0x0000000180617E80
		public override void ForceMeshUpdate(bool ignoreActiveState = false /* Metadata: 0x003A25ED */, bool forceTextReparsing = false /* Metadata: 0x003A25EE */); // 0x000000018060A890-0x000000018060A940
		public override TMP_TextInfo GetTextInfo(string text); // 0x0000000180617CD0-0x0000000180617DC0
		public override void ClearMesh(); // 0x0000000180609EA0-0x0000000180609FF0
		public override void UpdateGeometry(Mesh mesh, int index); // 0x000000018061DBE0-0x000000018061DC80
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x000000018061EB70-0x000000018061EE20
		public override void UpdateVertexData(); // 0x000000018061E8D0-0x000000018061EB70
		public void UpdateFontAsset(); // 0x00000001803C1EE0-0x00000001803C1F00
	}
}
