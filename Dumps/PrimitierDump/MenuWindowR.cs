/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class MenuWindowR : MonoBehaviour // TypeDefIndex: 8691
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Input_Sources source; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean menuAction; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Grabber grabber; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject window; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro nameText; // 0x38
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro valueText; // 0x40
	private Collider targetCollider; // 0x48
	private Collider prevTargetCollider; // 0x50
	private CubeBase status; // 0x58

	// Constructors
	public MenuWindowR(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180485B70-0x0000000180485BA0
	private void Update(); // 0x0000000180485BA0-0x00000001804864A0
}

