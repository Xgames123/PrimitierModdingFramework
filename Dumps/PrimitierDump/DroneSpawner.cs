/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class DroneSpawner : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8601
{
	// Fields
	private static readonly float interval; // 0x00
	private static readonly float spawnAreaScale; // 0x04
	private static readonly Vector3 spawnPosOffset; // 0x08
	private static readonly Vector3 necessarySpace; // 0x14
	private static readonly float searchRadius; // 0x20
	private static readonly int maxNearDrones; // 0x24
	private Transform player; // 0x18
	private GameObject spawnAreaEffect; // 0x20
	private ConstraintSource constraintSource; // 0x28

	// Constructors
	public DroneSpawner(); // 0x0000000180265240-0x0000000180265250
	static DroneSpawner(); // 0x0000000180300700-0x0000000180300830

	// Methods
	private void Start(); // 0x0000000180300630-0x0000000180300700
	private void SparseUpdate(); // 0x00000001802FFDF0-0x00000001803000D0
	private int CountNearDrones(); // 0x00000001802FFC20-0x00000001802FFD90
	private void Spawn(); // 0x00000001803000D0-0x0000000180300630
	private void AddSpawnAreaEffect(); // 0x00000001802FF8B0-0x00000001802FFC20
	private void OnDestroy(); // 0x00000001802FFD90-0x00000001802FFDF0
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
}

