/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class TabSwitchButton : MonoBehaviour, IButton // TypeDefIndex: 8707
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject targetTab; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SpriteRenderer icon; // 0x20
	private Color32 enabledColor; // 0x28
	private Color32 disabledColor; // 0x2C
	private static List<TabSwitchButton> tabSwitchButtons; // 0x00

	// Constructors
	public TabSwitchButton(); // 0x0000000180B560C0-0x0000000180B56130
	static TabSwitchButton(); // 0x0000000180B56050-0x0000000180B560C0

	// Methods
	private void Start(); // 0x0000000180B55F20-0x0000000180B56000
	public void OnPress(); // 0x0000000180B55C50-0x0000000180B55F20
	private void SwitchColor(bool enabled); // 0x0000000180B56000-0x0000000180B56050
}

