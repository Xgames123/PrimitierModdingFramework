/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CameraGrip : MonoBehaviour, IGrabbable // TypeDefIndex: 8577
{
	// Fields
	public Camera lens; // 0x18
	private Transform defaultParent; // 0x20

	// Constructors
	public CameraGrip(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180534220-0x0000000180534250
	public void OnGrab(Grabber grabber); // 0x00000001805340B0-0x00000001805341B0
	public void OnRelease(Grabber grabber); // 0x00000001805341B0-0x0000000180534220
	public void OnBond([TupleElementNames] /* 0x000000018002D0E0-0x000000018002D170 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider); // 0x0000000180533FA0-0x00000001805340B0
}

