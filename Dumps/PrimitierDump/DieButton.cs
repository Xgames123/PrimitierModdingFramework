/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class DieButton : MonoBehaviour, IButton // TypeDefIndex: 8682
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float confirmationTime; // 0x20
	private bool isConfirmationStep; // 0x24
	private PlayerLife playerLife; // 0x28

	// Constructors
	public DieButton(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x00000001805482B0-0x0000000180548320
	public void OnPress(); // 0x0000000180547F70-0x0000000180548220
	private void ResetConfirmation(); // 0x0000000180548220-0x00000001805482B0
}

