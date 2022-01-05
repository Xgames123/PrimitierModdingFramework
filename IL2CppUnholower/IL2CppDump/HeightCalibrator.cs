/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class HeightCalibrator : MonoBehaviour // TypeDefIndex: 8566
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean calibAction; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean calibActionAlt; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform headTarget; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro infoText; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject titleMenu; // 0x38
	private static float heightOffset; // 0x00
	private float avatarHeight; // 0x40
	private bool isCalibrated; // 0x44

	// Properties
	public static float HeightOffset { get; set; } // 0x0000000180309A50-0x0000000180309AE0 0x0000000180309AE0-0x0000000180309B30

	// Constructors
	public HeightCalibrator(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void Initialize(); // 0x00000001803095C0-0x00000001803097A0
	private void Update(); // 0x0000000180309840-0x0000000180309A50
	private void Calibrate(); // 0x0000000180309420-0x00000001803095C0
	private void ShowTitleMenu(); // 0x00000001803097A0-0x0000000180309840
}

