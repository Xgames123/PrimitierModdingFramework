/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Drone : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8600
{
	// Fields
	private static readonly string propellerPath; // 0x00
	private static readonly float maxLoadPerMass; // 0x08
	private static readonly float maxTargetAngleMlp; // 0x0C
	private static readonly Vector3 maxTorque; // 0x10
	private static readonly float chainDestructionDamage; // 0x1C
	private static readonly float movementInterval; // 0x20
	private static readonly float targetDistance; // 0x24
	private static readonly float searchDistance; // 0x28
	private static readonly float minHeightAbovePlayer; // 0x2C
	private static readonly float maxHeightAbovePlayer; // 0x30
	private static readonly float minHeightAboveWater; // 0x34
	private static readonly float maxHeightAboveGround; // 0x38
	private static readonly float noEnergyHeightAboveGround; // 0x3C
	private CubeBase cubeBase; // 0x18
	private Vector3 targetPosition; // 0x20
	private Transform player; // 0x30
	private PidController verticalPosController; // 0x38
	private VectorPidController horizontalPosController; // 0x40
	private VectorPidController angleController; // 0x48
	private GameObject propeller; // 0x50
	private ParticleSystem propellerParticle; // 0x58

	// Constructors
	public Drone(); // 0x0000000180549BC0-0x0000000180549CB0
	static Drone(); // 0x0000000180549A60-0x0000000180549BC0

	// Methods
	private void Start(); // 0x00000001805498C0-0x0000000180549A60
	private void FixedUpdate(); // 0x0000000180548AC0-0x0000000180549340
	private void Move(); // 0x0000000180549490-0x0000000180549770
	private float GetGroundHeight(); // 0x0000000180549340-0x0000000180549490
	private void AddPropeller(); // 0x0000000180548320-0x0000000180548590
	private void OnSplitted(object sender, EventArgs e); // 0x00000001805497D0-0x00000001805498C0
	private void OnDestroy(); // 0x0000000180549770-0x00000001805497D0
	private void ChainDestruction(); // 0x0000000180548590-0x0000000180548870
	private void Explode(); // 0x0000000180548870-0x0000000180548AC0
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
}

