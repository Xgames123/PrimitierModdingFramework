/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class RespawnPoint : MonoBehaviour, ICubeBehavior // TypeDefIndex: 8612
{
	// Fields
	private static readonly string respawnPointButtonPath; // 0x00
	private GameObject button; // 0x18

	// Constructors
	public RespawnPoint(); // 0x0000000180265240-0x0000000180265250
	static RespawnPoint(); // 0x0000000180B48AC0-0x0000000180B48B10

	// Methods
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180265310-0x0000000180265320
	private void Start(); // 0x0000000180B48A60-0x0000000180B48AC0
	private void AddButton(); // 0x0000000180B487C0-0x0000000180B48A00
	private void OnDestroy(); // 0x0000000180B48A00-0x0000000180B48A60
}

