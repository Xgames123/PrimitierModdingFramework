/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class LoadButton : MonoBehaviour, IButton // TypeDefIndex: 8688
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro infoText; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float confirmationTime; // 0x28
	private bool isConfirmationStep; // 0x2C

	// Constructors
	public LoadButton(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void OnPress(); // 0x0000000180476740-0x0000000180476A90
	private void ResetConfirmation(); // 0x0000000180476A90-0x0000000180476B20
}

