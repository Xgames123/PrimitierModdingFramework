/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class KinematicGrabbableObject : MonoBehaviour, IGrabbable // TypeDefIndex: 8639
{
	// Fields
	private Transform defaultParent; // 0x18

	// Constructors
	public KinematicGrabbableObject(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180476460-0x0000000180476490
	public void OnGrab(Grabber grabber); // 0x0000000180476340-0x0000000180476430
	public void OnRelease(Grabber grabber); // 0x0000000180476430-0x0000000180476460
	public void OnBond([TupleElementNames] /* 0x000000018002D5A0-0x000000018002D630 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider); // 0x0000000180265310-0x0000000180265320
}

