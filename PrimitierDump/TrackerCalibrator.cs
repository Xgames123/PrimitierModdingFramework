/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class TrackerCalibrator : MonoBehaviour // TypeDefIndex: 8648
{
	// Fields
	public SteamVR_Action_Pose pose; // 0x18
	public SteamVR_Action_Boolean calibAction; // 0x20
	public VRIK ik; // 0x28
	public Transform headTarget; // 0x30
	public Transform pelvisTarget; // 0x38
	public Transform leftFootTarget; // 0x40
	public Transform rightFootTarget; // 0x48
	public Transform stabilizedPelvisTarget; // 0x50
	public Transform stabilizedLeftFootTarget; // 0x58
	public Transform stabilizedRightFootTarget; // 0x60
	public Transform cameraRig; // 0x68
	private Transform headRef; // 0x70
	private Transform pelvisRef; // 0x78
	private Transform leftFootRef; // 0x80
	private Transform rightFootRef; // 0x88
	private bool calibrated; // 0x90
	private const float pelvisOffset = 0.1f; // Metadata: 0x003A6CE9

	// Constructors
	public TrackerCalibrator(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180B5BD90-0x0000000180B5C1B0
	private void Update(); // 0x0000000180B5C1B0-0x0000000180B5C340
	private void Calibrate(); // 0x0000000180B5B620-0x0000000180B5BD90
}

