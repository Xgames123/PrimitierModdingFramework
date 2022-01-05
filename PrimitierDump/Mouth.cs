/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Mouth : MonoBehaviour // TypeDefIndex: 8657
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private MouthController mouthController; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private PlayerLife playerLife; // 0x20
	private float openRange; // 0x28
	private float eatRange; // 0x2C
	private int interval; // 0x30
	private float maxVolume; // 0x34
	private int frame; // 0x38

	// Constructors
	public Mouth(); // 0x0000000180486D90-0x0000000180486DC0

	// Methods
	private void FixedUpdate(); // 0x0000000180486910-0x0000000180486930
	private void SparseUpdate(); // 0x0000000180486930-0x0000000180486D90
}

