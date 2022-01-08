/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRM;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class VrmWindEffect : MonoBehaviour // TypeDefIndex: 8574
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float forceMlp; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxForce; // 0x1C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform head; // 0x20
	private VRMSpringBone[] springBones; // 0x28
	private Vector3[] defaultGravityDirs; // 0x30
	private float[] defaultGravityPowers; // 0x38

	// Constructors
	public VrmWindEffect(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B5DA70-0x0000000180B5DC00
	private void Update(); // 0x0000000180B5DC00-0x0000000180B5E110
}

