/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class BeamTurret : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8586
{
	// Fields
	private static readonly float attackInterval; // 0x00
	private static readonly float initialBulletSpeed; // 0x04
	private static readonly float shootingRange; // 0x08
	private GameObject beam; // 0x18
	private CapsuleCollider playerBodyCol; // 0x20

	// Constructors
	public BeamTurret(); // 0x0000000180265240-0x0000000180265250
	static BeamTurret(); // 0x0000000180532410-0x0000000180532480

	// Methods
	private void Start(); // 0x0000000180532230-0x0000000180532410
	private void Attack(); // 0x0000000180531B30-0x0000000180531FE0
	private void OnSplitted(object sender, EventArgs e); // 0x0000000180532220-0x0000000180532230
	private void Explode(); // 0x0000000180531FE0-0x0000000180532220
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
}

