/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class LuxWater_SetToGerstnerHeight : MonoBehaviour // TypeDefIndex: 8558
{
	// Fields
	public Material WaterMaterial; // 0x18
	public Vector3 Damping; // 0x20
	public float TimeOffset; // 0x2C
	public bool UpdateWaterMaterialPerFrame; // 0x30
	[Space] // 0x000000018002D020-0x000000018002D040
	public bool AddCircleAnim; // 0x31
	public float Radius; // 0x34
	public float Speed; // 0x38
	[Space] // 0x000000018002D020-0x000000018002D040
	public Transform[] ManagedWaterProjectors; // 0x40
	[Header] // 0x0000000180026120-0x0000000180026150
	public float MaxDisp; // 0x48
	private Transform trans; // 0x50
	private LuxWaterUtils.GersterWavesDescription Description; // 0x58
	private bool ObjectIsVisible; // 0xD4
	private Vector3 Offset; // 0xD8

	// Constructors
	public LuxWater_SetToGerstnerHeight(); // 0x000000018047DF40-0x000000018047DFB0

	// Methods
	private void Start(); // 0x000000018047DF10-0x000000018047DF40
	private void OnBecameVisible(); // 0x000000018047DF00-0x000000018047DF10
	private void OnBecameInvisible(); // 0x000000018047DEF0-0x000000018047DF00
	private void LateUpdate(); // 0x000000018047DA60-0x000000018047DEF0
}

