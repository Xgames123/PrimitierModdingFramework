/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class TerrainDistanceButton : MonoBehaviour, IButton // TypeDefIndex: 8709
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Mode mode; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x20
	private static readonly string[] displayTextKey; // 0x00
	private static int distanceLevel; // 0x08

	// Nested types
	private enum Mode // TypeDefIndex: 8708
	{
		Up = 0,
		Down = 1
	}

	// Constructors
	public TerrainDistanceButton(); // 0x0000000180265240-0x0000000180265250
	static TerrainDistanceButton(); // 0x0000000180B566B0-0x0000000180B56840

	// Methods
	private void Start(); // 0x0000000180B56380-0x0000000180B56490
	private void OnLocaleChanged(UnityEngine.Localization.Locale locale); // 0x0000000180B56130-0x0000000180B56220
	public void OnPress(); // 0x0000000180B56220-0x0000000180B56380
	private void UpdateRange(); // 0x0000000180B56490-0x0000000180B566B0
}

