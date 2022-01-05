/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Scroll : MonoBehaviour, IGrabbable // TypeDefIndex: 8702
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Scrollbar bar; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private BoxCollider col; // 0x20
	private Transform defaultParent; // 0x28
	private Vector3 defaultPosition; // 0x30
	private Quaternion defaultRotation; // 0x3C
	private bool isGrabbed; // 0x4C
	private float scrollValueOnGrab; // 0x50

	// Constructors
	public Scroll(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B52070-0x0000000180B52100
	public void OnGrab(Grabber grabber); // 0x0000000180B51E40-0x0000000180B51F90
	public void OnRelease(Grabber grabber); // 0x0000000180B51F90-0x0000000180B52070
	public void OnBond([TupleElementNames] /* 0x000000018002D8E0-0x000000018002D970 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider); // 0x0000000180265310-0x0000000180265320
	private void Update(); // 0x0000000180B52100-0x0000000180B52220
}

