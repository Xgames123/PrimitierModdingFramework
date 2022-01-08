/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class PlayerLifeDisplay : MonoBehaviour // TypeDefIndex: 8695
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro dieText; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform gauge; // 0x20
	private float forwardOffset; // 0x28
	private float displayTime; // 0x2C
	private float disappearTime; // 0x30
	private Transform mainCamera; // 0x38
	private float displayTimer; // 0x40

	// Constructors
	public PlayerLifeDisplay(); // 0x00000001804883D0-0x00000001804883F0

	// Methods
	private void Start(); // 0x0000000180488280-0x0000000180488300
	private void Update(); // 0x0000000180488300-0x00000001804883D0
	public void DisplayInFrontOfPlayer(); // 0x0000000180488110-0x0000000180488260
	public void SetDieTextActive(bool value); // 0x0000000180488260-0x0000000180488280
}

