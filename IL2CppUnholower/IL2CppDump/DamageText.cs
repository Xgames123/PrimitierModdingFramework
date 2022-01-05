/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class DamageText : MonoBehaviour // TypeDefIndex: 8599
{
	// Fields
	public float lifetime; // 0x18
	public float speed; // 0x1C
	public TextMeshPro lookAtCameraText; // 0x20
	public TextMeshPro lookAtPlayerText; // 0x28
	private float currentTime; // 0x30

	// Constructors
	public DamageText(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void Initialize(float damage, float damageMlp, bool firstPersonEnabled = true /* Metadata: 0x003A6C4B */, bool thirdPersonEnabled = true /* Metadata: 0x003A6C4C */); // 0x0000000180547430-0x0000000180547800
	private void Update(); // 0x0000000180547910-0x0000000180547AF0
	private void UpdateTextColor(TextMeshPro tm); // 0x0000000180547800-0x0000000180547910
}

