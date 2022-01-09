/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class PlayerWaterForce : MonoBehaviour // TypeDefIndex: 8661
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxWaterDrag; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float maxWaterBuoyancy; // 0x1C
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private float _UnderWaterRatio_k__BackingField; // 0x20
	private Rigidbody rb; // 0x28
	private CapsuleCollider bodyCol; // 0x30
	private float defaultDrag; // 0x38

	// Properties
	public float UnderWaterRatio { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803374D0-0x00000001803374E0 0x00000001803374E0-0x00000001803374F0

	// Constructors
	public PlayerWaterForce(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B46CE0-0x0000000180B46D60
	private void FixedUpdate(); // 0x0000000180B46AB0-0x0000000180B46CE0
}

