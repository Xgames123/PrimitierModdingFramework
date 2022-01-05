/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[ExecuteAlways] // 0x000000018003C160-0x000000018003C1D0
	[RequireComponent] // 0x000000018003C160-0x000000018003C1D0
	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 6177
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_FontAsset m_fontAsset; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_material; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_isDefaultMaterial; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_padding; // 0x4C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Renderer m_renderer; // 0x50
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public Material material { get; set; } // 0x000000018026BB70-0x000000018026BB80 0x000000018026C000-0x000000018026C080
		public Material sharedMaterial { get; set; } // 0x00000001802684F0-0x0000000180268500 0x000000018026B7A0-0x000000018026B7D0
		public Material fallbackMaterial { get; set; } // 0x0000000180268FE0-0x0000000180268FF0 0x000000018026BE70-0x000000018026BFE0
		public Material fallbackSourceMaterial { get; set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public bool isDefaultMaterial { get; set; } // 0x000000018026BB60-0x000000018026BB70 0x000000018026BFF0-0x000000018026C000
		public float padding { get; set; } // 0x000000018026BD40-0x000000018026BD50 0x000000018026C090-0x000000018026C0A0
		public Renderer renderer { get; } // 0x000000018026BD50-0x000000018026BDE0 
		public MeshFilter meshFilter { get; } // 0x000000018026BB80-0x000000018026BC90 
		public Mesh mesh { get; set; } // 0x000000018026BC90-0x000000018026BD40 0x000000018026C080-0x000000018026C090
		public TMP_Text textComponent { get; } // 0x000000018026BDE0-0x000000018026BE70 
	
		// Constructors
		public TMP_SubMesh(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x000000018026AA60-0x000000018026AE20
		private void OnEnable(); // 0x000000018026B4B0-0x000000018026B790
		private void OnDisable(); // 0x000000018026B3E0-0x000000018026B4B0
		private void OnDestroy(); // 0x000000018026B250-0x000000018026B3E0
		public void DestroySelf(); // 0x000000018026AEE0-0x000000018026AF50
		private Material GetMaterial(Material mat); // 0x000000018026AF50-0x000000018026B120
		private Material CreateMaterialInstance(Material source); // 0x000000018026AE20-0x000000018026AEE0
		private Material GetSharedMaterial(); // 0x000000018026B1B0-0x000000018026B250
		private void SetSharedMaterial(Material mat); // 0x000000018026B7A0-0x000000018026B7D0
		public float GetPaddingForMaterial(); // 0x000000018026B120-0x000000018026B1B0
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x000000018026BAD0-0x000000018026BB60
		public void SetVerticesDirty(); // 0x000000018026B7D0-0x000000018026B8A0
		public void SetMaterialDirty(); // 0x000000018026B790-0x000000018026B7A0
		protected void UpdateMaterial(); // 0x000000018026B8A0-0x000000018026BAD0
	}
}
