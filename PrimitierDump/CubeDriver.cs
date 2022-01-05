/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeDriver : MonoBehaviour // TypeDefIndex: 8592
{
	// Fields
	private CubeBase cubeBase; // 0x18
	private Rigidbody touchingRigidbody; // 0x20

	// Constructors
	public CubeDriver(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x000000018053E430-0x000000018053E470
	public Collider SearchFastestCol(float searchRadius, float speedThreshold, Substance ignoreSubstance); // 0x000000018053DD40-0x000000018053E040
	public CubeBase SearchNearestCube(float searchRadius, List<Substance> substances, float maxVolume = 1F / 0F /* Metadata: 0x003A6C3F */); // 0x000000018053E040-0x000000018053E300
	public void JumpToEscape(Vector3 enemyPos, float jumpPower, float collisionSearchRadius); // 0x000000018053D330-0x000000018053D990
	public void JumpToward(Vector3 target, float jumpPower, float minJumpAngle); // 0x000000018053D990-0x000000018053DD40
	public void Stabilize(float torque); // 0x000000018053E300-0x000000018053E430
	public bool IsGrounded(); // 0x000000018053D000-0x000000018053D330
}

