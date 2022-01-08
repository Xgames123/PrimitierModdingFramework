/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class SunController : MonoBehaviour, IGrabbable // TypeDefIndex: 8647
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject handle; // 0x18
	public static bool cycleEnabled; // 0x00
	private static float cycleSpeed; // 0x04
	private static float sunsetStartAngle; // 0x08
	private static float sunsetEndAngle; // 0x0C
	private static float nightIntensityRatio; // 0x10
	private Transform defaultParent; // 0x20
	private bool isGrabbed; // 0x28
	private Light sunlight; // 0x30
	private float defaultAmbient; // 0x38
	private float defaultReflection; // 0x3C
	private float defaultLight; // 0x40

	// Constructors
	public SunController(); // 0x0000000180265240-0x0000000180265250
	static SunController(); // 0x0000000180B55990-0x0000000180B55A20

	// Methods
	private void Start(); // 0x0000000180B55710-0x0000000180B557A0
	private void Update(); // 0x0000000180B557A0-0x0000000180B55990
	public void OnGrab(Grabber grabber); // 0x0000000180B555C0-0x0000000180B556B0
	public void OnRelease(Grabber grabber); // 0x0000000180B556B0-0x0000000180B556F0
	public void OnBond([TupleElementNames] /* 0x000000018002D680-0x000000018002D710 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider); // 0x0000000180265310-0x0000000180265320
	public void SetVisibility(bool isVisible); // 0x0000000180B556F0-0x0000000180B55710
	public void ForceRelease(); // 0x0000000180B554F0-0x0000000180B555C0
}

