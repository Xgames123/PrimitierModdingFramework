/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class DeleteSaveDataButton : MonoBehaviour, IButton // TypeDefIndex: 8681
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro text; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro resultText; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float confirmationTime; // 0x28
	private bool isConfirmationStep; // 0x2C
	private float timer; // 0x30

	// Constructors
	public DeleteSaveDataButton(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void OnPress(); // 0x0000000180547D80-0x0000000180547EA0
	private void Update(); // 0x0000000180547EA0-0x0000000180547F70
	private void DeleteSaveData(); // 0x0000000180547BE0-0x0000000180547D80
}

