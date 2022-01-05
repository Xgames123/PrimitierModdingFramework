/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class ToggleButton : MonoBehaviour, IButton // TypeDefIndex: 8710
{
	// Fields
	private static readonly Color32 enabledColor; // 0x00
	private static readonly Color32 disabledColor; // 0x04
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SpriteRenderer icon; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private UnityEvent<bool> OnValueChanged; // 0x20
	private bool state; // 0x28

	// Constructors
	public ToggleButton(); // 0x0000000180265240-0x0000000180265250
	static ToggleButton(); // 0x0000000180B5B590-0x0000000180B5B620

	// Methods
	public void OnPress(); // 0x0000000180B5B3B0-0x0000000180B5B4C0
	public void SwitchState(bool state); // 0x0000000180B5B4C0-0x0000000180B5B590
}

