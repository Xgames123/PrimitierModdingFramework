/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeConnector : MonoBehaviour // TypeDefIndex: 8591
{
	// Fields
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private HashSet<CubeConnector> _Connections_k__BackingField; // 0x18
	public Anchor anchor; // 0x20
	[NonSerialized]
	public UnityEvent ConnectionChangeEvent; // 0x28

	// Properties
	public HashSet<CubeConnector> Connections { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0

	// Nested types
	public enum Anchor // TypeDefIndex: 8590
	{
		Free = 0,
		Temporary = 1,
		Permanent = 2
	}

	// Constructors
	public CubeConnector(); // 0x000000018053CF60-0x000000018053D000

	// Methods
	public void Connect(CubeConnector other); // 0x000000018053BDB0-0x000000018053C390
	public void Disconnect(); // 0x000000018053C390-0x000000018053CD00
	public List<CubeConnector> GetGroupMembers(); // 0x000000018053CD00-0x000000018053CF60
}

