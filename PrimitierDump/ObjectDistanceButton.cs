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

public class ObjectDistanceButton : MonoBehaviour, IButton // TypeDefIndex: 8694
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
	private enum Mode // TypeDefIndex: 8693
	{
		Up = 0,
		Down = 1
	}

	// Constructors
	public ObjectDistanceButton(); // 0x0000000180265240-0x0000000180265250
	static ObjectDistanceButton(); // 0x00000001804875D0-0x0000000180487760

	// Methods
	private void Start(); // 0x00000001804871A0-0x00000001804872B0
	private void OnLocaleChanged(UnityEngine.Localization.Locale locale); // 0x0000000180486F50-0x0000000180487040
	public void OnPress(); // 0x0000000180487040-0x00000001804871A0
	private void UpdateRange(); // 0x00000001804872B0-0x00000001804875D0
}

