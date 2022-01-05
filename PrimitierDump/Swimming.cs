/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Swimming : MonoBehaviour // TypeDefIndex: 8662
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float forceMlp; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxForce; // 0x1C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Rigidbody bodyRb; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Input_Sources source; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean swimAction; // 0x30
	private Rigidbody rb; // 0x38

	// Constructors
	public Swimming(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B55C10-0x0000000180B55C50
	private void FixedUpdate(); // 0x0000000180B55A20-0x0000000180B55C10
}

