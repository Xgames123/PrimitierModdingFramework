/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class RespawnPointButton : MonoBehaviour, IButton // TypeDefIndex: 8700
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float angularSpeed; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform model; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject text; // 0x28
	private Transform head; // 0x30

	// Constructors
	public RespawnPointButton(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B48670-0x0000000180B486A0
	public void OnPress(); // 0x0000000180B48400-0x0000000180B48670
	private void HideText(); // 0x0000000180485A90-0x0000000180485AC0
	private void Update(); // 0x0000000180B486A0-0x0000000180B487C0
}

