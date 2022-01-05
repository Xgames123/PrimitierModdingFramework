/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Bond : MonoBehaviour // TypeDefIndex: 8653
{
	// Fields
	private SteamVR_Input_Sources source; // 0x18
	private SteamVR_Action_Boolean action; // 0x20
	private Grabber grabber; // 0x28
	private Collider grabbedCollider; // 0x30
	private bool bondStateDown; // 0x38
	[TupleElementNames] // 0x000000018002D710-0x000000018002D7A0
	private List<ValueTuple<Collider, Collider, Vector3>> contactPoints; // 0x40

	// Constructors
	public Bond(); // 0x0000000180533B30-0x0000000180533BA0

	// Methods
	public void Initialize(SteamVR_Input_Sources _source, SteamVR_Action_Boolean _action, Grabber _grabber, Collider _collider); // 0x0000000180533730-0x0000000180533750
	public void ResetHandTarget(); // 0x0000000180533AC0-0x0000000180533AF0
	private void OnCollisionStay(Collision collision); // 0x0000000180533750-0x0000000180533AC0
	private void Update(); // 0x0000000180533AF0-0x0000000180533B30
	private void FixedUpdate(); // 0x0000000180533600-0x0000000180533730
}

