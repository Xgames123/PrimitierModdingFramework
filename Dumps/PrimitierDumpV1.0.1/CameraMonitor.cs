/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CameraMonitor : MonoBehaviour // TypeDefIndex: 8578
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Camera sourceCamera; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private RenderTexture targetTexture; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform frontMonitor; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform backMonitor; // 0x30

	// Constructors
	public CameraMonitor(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void OnPostRender(); // 0x0000000180534250-0x0000000180534430
}

