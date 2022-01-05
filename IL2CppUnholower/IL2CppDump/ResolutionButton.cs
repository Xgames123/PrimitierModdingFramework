/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class ResolutionButton : MonoBehaviour, IButton // TypeDefIndex: 8698
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Mode mode; // 0x18
	private static readonly Vector2Int[] resolutions; // 0x00

	// Nested types
	private enum Mode // TypeDefIndex: 8697
	{
		Up = 0,
		Down = 1
	}

	// Constructors
	public ResolutionButton(); // 0x0000000180265240-0x0000000180265250
	static ResolutionButton(); // 0x0000000180B48210-0x0000000180B48340

	// Methods
	public void OnPress(); // 0x0000000180B47E40-0x0000000180B48210
}

