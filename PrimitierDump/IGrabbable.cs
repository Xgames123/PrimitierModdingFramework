/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public interface IGrabbable // TypeDefIndex: 8638
{
	// Methods
	void OnGrab(Grabber grabber);
	void OnRelease(Grabber grabber);
	void OnBond([TupleElementNames] /* 0x000000018002D510-0x000000018002D5A0 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider);
}

