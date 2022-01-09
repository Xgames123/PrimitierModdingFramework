/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class SubstanceParameters : ScriptableObject // TypeDefIndex: 8716
{
	// Fields
	public List<Param> param; // 0x18

	// Nested types
	[Serializable]
	public class Param // TypeDefIndex: 8715
	{
		// Fields
		public string displayNameKey; // 0x10
		public string material; // 0x18
		public string sectionMaterialH; // 0x20
		public string sectionMaterialV; // 0x28
		public string collisionSound; // 0x30
		public float defaultPitch; // 0x38
		public bool changePitch; // 0x3C
		public float thicknessThreshold; // 0x40
		public float density; // 0x44
		public float stiffness; // 0x48
		public float strength; // 0x4C
		public float hardness; // 0x50
		public float specificHeatCapacity; // 0x54
		public float thermalConductivity; // 0x58
		public bool isFlammable; // 0x5C
		public float flashPoint; // 0x60
		public float kindlingPoint; // 0x64
		public float combustionHeat; // 0x68
		public float combustionSpeed; // 0x6C
		public bool isEdible; // 0x70
		public float recovery; // 0x74
		public float softeningPoint; // 0x78

		// Constructors
		public Param(); // 0x00000001802650F0-0x0000000180265100
	}

	// Constructors
	public SubstanceParameters(); // 0x0000000180B55480-0x0000000180B554F0
}

