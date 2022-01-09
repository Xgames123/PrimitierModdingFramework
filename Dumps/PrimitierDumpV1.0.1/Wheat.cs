/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Wheat : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8620
{
	// Fields
	public static float seedSize; // 0x00
	private static int seedCount; // 0x04
	private static float stalkThickness; // 0x08
	private static float growthBasicLength; // 0x0C
	private static float stalkMaxLength; // 0x10
	private static float maxTemperature; // 0x14
	private static float exclusiveAreaWidth; // 0x18
	private static float updateInterval; // 0x1C
	[NonSerialized]
	public int initialUpdateCount; // 0x18
	private CubeBase cubeBase; // 0x20

	// Constructors
	public Wheat(); // 0x0000000180265240-0x0000000180265250
	static Wheat(); // 0x0000000180B5F250-0x0000000180B5F320

	// Methods
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180B5E110-0x0000000180B5E1D0
	private void Start(); // 0x0000000180B5F010-0x0000000180B5F1A0
	private void SparseUpdate(); // 0x0000000180B5E1D0-0x0000000180B5F010
	private void Wither(); // 0x0000000180B5F1A0-0x0000000180B5F250
}

