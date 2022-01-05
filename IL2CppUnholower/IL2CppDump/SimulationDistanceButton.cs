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

public class SimulationDistanceButton : MonoBehaviour, IButton // TypeDefIndex: 8704
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Mode mode; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject distanceLimitText; // 0x28
	private static readonly string[] displayTextKey; // 0x00
	private static int distanceLevel; // 0x08

	// Nested types
	private enum Mode // TypeDefIndex: 8703
	{
		Up = 0,
		Down = 1
	}

	// Constructors
	public SimulationDistanceButton(); // 0x0000000180265240-0x0000000180265250
	static SimulationDistanceButton(); // 0x0000000180B52B30-0x0000000180B52CC0

	// Methods
	private void Start(); // 0x0000000180B52590-0x0000000180B526A0
	private void OnLocaleChanged(UnityEngine.Localization.Locale locale); // 0x0000000180B52340-0x0000000180B52430
	public void OnPress(); // 0x0000000180B52430-0x0000000180B52590
	private void UpdateRange(); // 0x0000000180B526A0-0x0000000180B52B30
}

