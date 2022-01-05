/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;
using VRM;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class FaceController : MonoBehaviour // TypeDefIndex: 8563
{
	// Fields
	public SteamVR_Input_Sources source; // 0x18
	public SteamVR_Action_Vector2 action; // 0x20
	public float blendShapeStrength; // 0x28
	private VRMBlendShapeProxy face; // 0x30
	private Blinker blinker; // 0x38
	public string shapeL; // 0x40
	public string shapeR; // 0x48
	public string shapeU; // 0x50

	// Constructors
	public FaceController(); // 0x0000000180300EC0-0x0000000180300F30

	// Methods
	private void Start(); // 0x0000000180300B40-0x0000000180300BE0
	private void Update(); // 0x0000000180300BE0-0x0000000180300EC0
}

