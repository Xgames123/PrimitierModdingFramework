/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class StatusText : MonoBehaviour // TypeDefIndex: 8617
{
	// Fields
	public TextMeshPro lookAtCameraText; // 0x18
	public TextMeshPro lookAtPlayerText; // 0x20
	private static float lifetime; // 0x00
	private string text; // 0x28
	private Color color; // 0x30
	private CubeBase cubeBase; // 0x40
	private float currentTime; // 0x48

	// Constructors
	public StatusText(); // 0x0000000180265240-0x0000000180265250
	static StatusText(); // 0x0000000180B550C0-0x0000000180B55100

	// Methods
	public void Initialize(CubeBase cubeBase); // 0x0000000180B549A0-0x0000000180B54B60
	public void Refresh(); // 0x0000000180B54B60-0x0000000180B54D10
	private void Update(); // 0x0000000180B54D10-0x0000000180B550C0
}

