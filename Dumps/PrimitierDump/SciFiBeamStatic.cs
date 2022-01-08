/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class SciFiBeamStatic : MonoBehaviour // TypeDefIndex: 8555
{
	// Fields
	[Header] // 0x000000018002CFC0-0x000000018002CFF0
	public GameObject beamLineRendererPrefab; // 0x18
	public GameObject beamStartPrefab; // 0x20
	public GameObject beamEndPrefab; // 0x28
	private GameObject beamStart; // 0x30
	private GameObject beamEnd; // 0x38
	private GameObject beam; // 0x40
	private LineRenderer line; // 0x48
	[Header] // 0x000000018002CFF0-0x000000018002D020
	public bool alwaysOn; // 0x50
	public bool beamCollides; // 0x51
	public float beamLength; // 0x54
	public float beamEndOffset; // 0x58
	public float textureScrollSpeed; // 0x5C
	public float textureLengthScale; // 0x60

	// Constructors
	public SciFiBeamStatic(); // 0x0000000180B4EC70-0x0000000180B4EC90

	// Methods
	private void Start(); // 0x0000000180265310-0x0000000180265320
	private void OnEnable(); // 0x0000000180B4E950-0x0000000180B4E960
	private void OnDisable(); // 0x0000000180B4E800-0x0000000180B4E950
	private void FixedUpdate(); // 0x0000000180B4E290-0x0000000180B4E800
	public void SpawnBeam(); // 0x0000000180B4E960-0x0000000180B4EC70
	public void RemoveBeam(); // 0x0000000180B4E800-0x0000000180B4E950
}

