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

public class LocaleSelectButton : MonoBehaviour, IButton // TypeDefIndex: 8689
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private LocaleIdentifier localeId; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x28
	private Color32 enabledColor; // 0x30
	private Color32 disabledColor; // 0x34

	// Constructors
	public LocaleSelectButton(); // 0x00000001804771E0-0x0000000180477250

	// Methods
	private void Start(); // 0x00000001804770B0-0x0000000180477140
	private void OnLocaleChanged(UnityEngine.Localization.Locale locale); // 0x0000000180476E40-0x0000000180476E50
	public void OnPress(); // 0x0000000180476E50-0x00000001804770B0
	private void UpdateTextColor(); // 0x0000000180477140-0x00000001804771E0
}

