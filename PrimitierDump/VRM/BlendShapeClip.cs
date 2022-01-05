/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[CreateAssetMenu] // 0x00000001800351B0-0x00000001800351E0
	public class BlendShapeClip : ScriptableObject // TypeDefIndex: 7973
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string BlendShapeName; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public BlendShapePreset Preset; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public BlendShapeBinding[] Values; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public MaterialValueBinding[] MaterialValues; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public bool IsBinary; // 0x38
	
		// Properties
		public BlendShapeKey Key { get; } // 0x0000000180337570-0x0000000180337670 
	
		// Constructors
		public BlendShapeClip(); // 0x00000001803374F0-0x0000000180337570
	}
}
