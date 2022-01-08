/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class RedSlime : MonoBehaviour, ICubeBehavior, IDamageSource // TypeDefIndex: 8611
{
	// Fields
	private CubeDriver driver; // 0x18
	private CubeBase cubeBase; // 0x20
	private Transform player; // 0x28
	private int frame; // 0x30
	private float jumpTimer; // 0x34
	private bool isInheritable; // 0x38
	private float forceMlp; // 0x3C
	private static readonly float referenceVolume; // 0x00
	private static readonly int updateInterval; // 0x04
	private static readonly float searchRadius; // 0x08
	private static readonly float jumpPower; // 0x0C
	private static readonly float eatJumpAngle; // 0x10
	private static readonly float torque; // 0x14
	private static readonly float jumpCoolTime; // 0x18
	private static readonly float forceMlpExp; // 0x1C
	private static readonly float recoveryMlp; // 0x20
	private static readonly float attackJumpAngle; // 0x24
	private static readonly List<Substance> edibleSubstances; // 0x28

	// Constructors
	public RedSlime(); // 0x0000000180265240-0x0000000180265250
	static RedSlime(); // 0x0000000180B47BA0-0x0000000180B47D60

	// Methods
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180B475A0-0x0000000180B47610
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180B47280-0x0000000180B475A0
	private void Start(); // 0x0000000180B47B00-0x0000000180B47BA0
	private void OnScaleChanged(); // 0x0000000180B47610-0x0000000180B47720
	private void FixedUpdate(); // 0x0000000180B47110-0x0000000180B47280
	private void SparseUpdate(); // 0x0000000180B47720-0x0000000180B47B00
	public float CalcDamage(float impulse); // 0x0000000180B47100-0x0000000180B47110
}

