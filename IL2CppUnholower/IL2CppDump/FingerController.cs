/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class FingerController : MonoBehaviour // TypeDefIndex: 8564
{
	// Fields
	public SteamVR_Action_Single action; // 0x18
	public float[] defaultGripRate; // 0x20
	public float[] maxGripRate; // 0x28
	private Animator animator; // 0x30
	private float leftGrip; // 0x38
	private float rightGrip; // 0x3C
	private readonly HumanBodyBones[] leftBones; // 0x40
	private readonly HumanBodyBones[] rightBones; // 0x48
	private Vector3[] leftBoneRots; // 0x50
	private Vector3[] rightBoneRots; // 0x58
	private Transform[] leftBoneTransforms; // 0x60
	private Transform[] rightBoneTransforms; // 0x68

	// Constructors
	public FingerController(); // 0x00000001803017A0-0x00000001803020A0

	// Methods
	private void Start(); // 0x0000000180301150-0x0000000180301370
	private void Update(); // 0x0000000180301370-0x00000001803017A0
	private float Calibrate(float grip, float defaultGripRate, float maxGripRate); // 0x0000000180301140-0x0000000180301150
}

