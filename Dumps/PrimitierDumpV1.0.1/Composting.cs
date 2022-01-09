/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Composting : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8587
{
	// Fields
	private static readonly float updateInterval; // 0x00
	private static readonly float volumeThreshold; // 0x04
	private CubeBase cubeBase; // 0x18

	// Constructors
	public Composting(); // 0x0000000180265240-0x0000000180265250
	static Composting(); // 0x0000000180534940-0x0000000180534990

	// Methods
	private void Start(); // 0x0000000180534810-0x0000000180534940
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180534580-0x00000001805345E0
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
	private void SparseUpdate(); // 0x00000001805345E0-0x0000000180534810
}

