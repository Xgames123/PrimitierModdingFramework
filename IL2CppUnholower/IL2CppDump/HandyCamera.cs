/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class HandyCamera : MonoBehaviour // TypeDefIndex: 8580
{
	// Fields
	private static HandyCamera instance; // 0x00
	private bool followMode; // 0x18
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private bool _LookAtMode_k__BackingField; // 0x19
	public GameObject cameraGrip; // 0x20
	public GameObject cameraBody; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Image fade; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject dieText; // 0x38
	private static readonly float bigMonitorDistance; // 0x08
	private static readonly float smallMonitorDistance; // 0x0C
	private static readonly float bigMonitorScale; // 0x10
	private static readonly float lookAtAngle; // 0x14
	private GameObject player; // 0x40
	private bool bigMonitorMode; // 0x48

	// Properties
	public static HandyCamera Instance { get; } // 0x0000000180307780-0x00000001803078B0 
	public bool FollowMode { get; set; } // 0x00000001802A9AD0-0x00000001802A9AE0 0x00000001803078C0-0x0000000180307940
	public bool LookAtMode { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803078B0-0x00000001803078C0 0x0000000180307940-0x0000000180307950

	// Constructors
	public HandyCamera(); // 0x0000000180265240-0x0000000180265250
	static HandyCamera(); // 0x0000000180307700-0x0000000180307780

	// Methods
	private void Start(); // 0x0000000180307190-0x00000001803071D0
	private void Update(); // 0x00000001803071D0-0x0000000180307700
	public void ResetPose(); // 0x0000000180306FD0-0x0000000180307100
	public void SetOverlayColor(Color color); // 0x0000000180307120-0x0000000180307190
	public void SetDieTextActive(bool value); // 0x0000000180307100-0x0000000180307120
}

