/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[ExecuteAlways] // 0x000000018003C1D0-0x000000018003C240
	[RequireComponent] // 0x000000018003C1D0-0x000000018003C240
	public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 6178
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_FontAsset m_fontAsset; // 0xD8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_SpriteAsset m_spriteAsset; // 0xE0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_material; // 0xE8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_sharedMaterial; // 0xF0
		private Material m_fallbackMaterial; // 0xF8
		private Material m_fallbackSourceMaterial; // 0x100
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_isDefaultMaterial; // 0x108
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_padding; // 0x10C
		private Mesh m_mesh; // 0x110
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextMeshProUGUI m_TextComponent; // 0x118
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x120
		private bool m_materialDirty; // 0x121
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int m_materialReferenceIndex; // 0x124
		private Transform m_RootCanvasTransform; // 0x128
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x000000018026A6D0-0x000000018026A6E0 0x000000018026AA50-0x000000018026AA60
		public override Texture mainTexture { get; } // 0x000000018026A310-0x000000018026A3E0 
		public override Material material { get; set; } // 0x000000018026A450-0x000000018026A600 0x000000018026A940-0x000000018026AA30
		public Material sharedMaterial { get; set; } // 0x00000001802696B0-0x00000001802696C0 0x0000000180269EE0-0x0000000180269F20
		public Material fallbackMaterial { get; set; } // 0x000000018026A2D0-0x000000018026A2E0 0x000000018026A780-0x000000018026A910
		public Material fallbackSourceMaterial { get; set; } // 0x000000018026A2E0-0x000000018026A2F0 0x000000018026A910-0x000000018026A920
		public override Material materialForRendering { get; } // 0x000000018026A3E0-0x000000018026A450 
		public bool isDefaultMaterial { get; set; } // 0x000000018026A300-0x000000018026A310 0x000000018026A930-0x000000018026A940
		public float padding { get; set; } // 0x000000018026A6C0-0x000000018026A6D0 0x000000018026AA40-0x000000018026AA50
		public Mesh mesh { get; set; } // 0x000000018026A600-0x000000018026A6C0 0x000000018026AA30-0x000000018026AA40
		public TMP_Text textComponent { get; } // 0x000000018026A6E0-0x000000018026A780 
	
		// Constructors
		public TMP_SubMeshUI(); // 0x0000000180265320-0x0000000180265330
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x0000000180269050-0x0000000180269450
		protected override void OnEnable(); // 0x0000000180269CE0-0x0000000180269D50
		protected override void OnDisable(); // 0x0000000180269C20-0x0000000180269CE0
		protected override void OnDestroy(); // 0x0000000180269A00-0x0000000180269C20
		protected override void OnTransformParentChanged(); // 0x0000000180269D50-0x0000000180269DB0
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001802696C0-0x00000001802697F0
		public float GetPaddingForMaterial(); // 0x00000001802697F0-0x0000000180269890
		public float GetPaddingForMaterial(Material mat); // 0x0000000180269890-0x0000000180269920
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018026A240-0x000000018026A2D0
		public override void SetAllDirty(); // 0x0000000180265310-0x0000000180265320
		public override void SetVerticesDirty(); // 0x0000000180269F20-0x000000018026A000
		public override void SetLayoutDirty(); // 0x0000000180265310-0x0000000180265320
		public override void SetMaterialDirty(); // 0x0000000180269E20-0x0000000180269E60
		public void SetPivotDirty(); // 0x0000000180269E60-0x0000000180269EE0
		private Transform GetRootCanvasTransform(); // 0x0000000180269920-0x00000001802699D0
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000180265310-0x0000000180265320
		protected override void UpdateGeometry(); // 0x0000000180265310-0x0000000180265320
		public override void Rebuild(CanvasUpdate update); // 0x0000000180269DB0-0x0000000180269DF0
		public void RefreshMaterial(); // 0x0000000180269E00-0x0000000180269E20
		protected override void UpdateMaterial(); // 0x000000018026A000-0x000000018026A240
		public override void RecalculateClipping(); // 0x0000000180269DF0-0x0000000180269E00
		private Material GetMaterial(); // 0x00000001802696B0-0x00000001802696C0
		private Material GetMaterial(Material mat); // 0x0000000180269510-0x00000001802696B0
		private Material CreateMaterialInstance(Material source); // 0x0000000180269450-0x0000000180269510
		private Material GetSharedMaterial(); // 0x00000001802699D0-0x0000000180269A00
		private void SetSharedMaterial(Material mat); // 0x0000000180269EE0-0x0000000180269F20
	}
}
