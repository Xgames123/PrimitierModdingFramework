/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class UpdateManager : MonoBehaviour // TypeDefIndex: 8714
{
	// Fields
	private static HashSet<IFixedUpdatable> components; // 0x00
	private static List<IFixedUpdatable> addedList; // 0x08
	private static List<IFixedUpdatable> removedList; // 0x10

	// Constructors
	public UpdateManager(); // 0x0000000180265240-0x0000000180265250
	static UpdateManager(); // 0x0000000180B5CD80-0x0000000180B5CE70

	// Methods
	private void FixedUpdate(); // 0x0000000180B5C850-0x0000000180B5CCF0
	public static void Add(IFixedUpdatable component); // 0x0000000180B5C7C0-0x0000000180B5C850
	public static void Remove(IFixedUpdatable component); // 0x0000000180B5CCF0-0x0000000180B5CD80
}

