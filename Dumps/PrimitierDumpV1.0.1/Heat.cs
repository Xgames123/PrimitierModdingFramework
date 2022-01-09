/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Heat : MonoBehaviour // TypeDefIndex: 8604
{
	// Fields
	public const float airTemperature = 293.15f; // Metadata: 0x003A6C51
	[NonSerialized]
	public bool isBurning; // 0x18
	[NonSerialized]
	public float burnedRatio; // 0x1C
	private static float transferSpeedMlp; // 0x00
	private static float airTransferSpeedMlp; // 0x04
	private static float waterTransferSpeedMlp; // 0x08
	private static float combustionHeatMlp; // 0x0C
	private static float combustionHeatReleaseRatio; // 0x10
	private static float fireRadiusMlp; // 0x14
	private static float fireRangeOffset; // 0x18
	private static float interval; // 0x1C
	private static float emissionTemperature; // 0x20
	private static float emissionMlp; // 0x24
	private float capacity; // 0x20
	private float quantity; // 0x24
	private bool isIgnited; // 0x28
	private CubeBase cubeBase; // 0x30
	private CubeConnector cubeConnector; // 0x38
	private FluidDynamics fluidDynamics; // 0x40
	private List<Heat> neighbors; // 0x48
	private RigidbodyManager rigidbodyManager; // 0x50

	// Properties
	public float Conductivity { get; private set; } // 0x00000001803093A0-0x00000001803093D0 0x00000001803093E0-0x0000000180309410
	public float Temperature { get; private set; } // 0x00000001803093D0-0x00000001803093E0 0x0000000180309410-0x0000000180309420

	// Constructors
	public Heat(); // 0x0000000180309330-0x00000001803093A0
	static Heat(); // 0x0000000180309230-0x0000000180309330

	// Methods
	public void Initialize(float temperature, bool isBurning, float burnedRatio); // 0x0000000180308000-0x0000000180308210
	public void UpdateCapacity(float temperature); // 0x00000001803091D0-0x0000000180309230
	private void SparseUpdate(); // 0x00000001803083E0-0x0000000180308CF0
	private void TransferHeat(Heat otherHeat); // 0x0000000180308FE0-0x00000001803091D0
	private void TransferHeatWithEnvironment(); // 0x0000000180308E80-0x0000000180308FE0
	private void Burn(); // 0x00000001803079A0-0x0000000180307FD0
	private void OnConnectionChanged(); // 0x0000000180308210-0x00000001803083E0
	public float GetCelsiusTemperature(); // 0x0000000180307FD0-0x0000000180307FF0
	public void AddHeat(float quantity); // 0x0000000180307950-0x0000000180307960
	public void AddHeat(float quantity, float temperatureLimit); // 0x0000000180307960-0x00000001803079A0
	private void SwitchBurning(); // 0x0000000180308CF0-0x0000000180308E80
	public void Ignite(); // 0x0000000180307FF0-0x0000000180308000
}

