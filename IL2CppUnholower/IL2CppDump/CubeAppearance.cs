/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeAppearance : MonoBehaviour // TypeDefIndex: 8623
{
	// Fields
	public static readonly float uvScale; // 0x00
	[NonSerialized]
	public SectionState sectionState; // 0x18
	[NonSerialized]
	public UVOffset uvOffset; // 0x20
	private MeshFilter meshFilter; // 0x28
	private MeshRenderer meshRenderer; // 0x30
	private MaterialPropertyBlock block; // 0x38
	private Color[] defaultColors; // 0x40
	private bool converted; // 0x48

	// Nested types
	[Flags] // 0x0000000180014D50-0x0000000180014D60
	public enum SectionState // TypeDefIndex: 8621
	{
		Right = 1,
		Left = 2,
		Top = 4,
		Bottom = 8,
		Front = 16,
		Back = 32
	}

	[Serializable]
	public class UVOffset // TypeDefIndex: 8622
	{
		// Fields
		public Vector2 right; // 0x10
		public Vector2 left; // 0x18
		public Vector2 top; // 0x20
		public Vector2 bottom; // 0x28
		public Vector2 front; // 0x30
		public Vector2 back; // 0x38

		// Constructors
		public UVOffset(); // 0x00000001802650F0-0x0000000180265100
		public UVOffset(UVOffset src); // 0x0000000180B5C710-0x0000000180B5C7C0
	}

	// Constructors
	public CubeAppearance(); // 0x0000000180536BA0-0x0000000180536C00
	static CubeAppearance(); // 0x0000000180536B60-0x0000000180536BA0

	// Methods
	public void Initialize(SectionState sectionState, UVOffset uvOffset, string sectionMaterialH, string sectionMaterialV); // 0x0000000180535610-0x00000001805357C0
	public void UpdateDefaultColors(); // 0x0000000180535CF0-0x0000000180535E00
	public void UpdateUV(); // 0x0000000180535E00-0x0000000180536B60
	public void SetTexture(string textureName); // 0x0000000180535A50-0x0000000180535B80
	public void SetColor(Color color); // 0x00000001805358C0-0x0000000180535960
	public void TintColor(Color color, float ratio); // 0x0000000180535B80-0x0000000180535CF0
	public void SetEmissionColor(Color color); // 0x0000000180535960-0x0000000180535A50
	private void ConvertToMultiMaterialCube(); // 0x00000001805352A0-0x0000000180535610
	public void ChangeSubmeshMaterial(Material material, int meshIndex); // 0x00000001805351F0-0x00000001805352A0
	public static UVOffset RandomOffset(); // 0x00000001805357C0-0x00000001805358C0
}

