/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Hand : MonoBehaviour // TypeDefIndex: 8656
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Rigidbody playerRigidBody; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform realHand; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float positionSpring; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float positionDamper; // 0x2C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maximumForce; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float rotationSpring; // 0x34
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float rotationDamper; // 0x38
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maximumTorque; // 0x3C
	private ConfigurableJoint bodyJoint; // 0x40

	// Constructors
	public Hand(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Awake(); // 0x0000000180306BA0-0x0000000180306BB0
	private void FixedUpdate(); // 0x0000000180306BB0-0x0000000180306D20
	private void GenerateJoint(); // 0x0000000180306D20-0x0000000180306FD0
}

