/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[CreateAssetMenu] // 0x0000000180035180-0x00000001800351B0
	public class BlendShapeAvatar : ScriptableObject // TypeDefIndex: 7967
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public List<BlendShapeClip> Clips; // 0x18
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 7965
		{
			// Fields
			public BlendShapeKey key; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _SetClip_b__0(BlendShapeClip x); // 0x000000018054FA00-0x000000018054FA10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 7966
		{
			// Fields
			public BlendShapeKey key; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetClip_b__0(BlendShapeClip x); // 0x000000018054FA00-0x000000018054FA10
		}
	
		// Constructors
		public BlendShapeAvatar(); // 0x0000000180336380-0x00000001803363F0
	
		// Methods
		public void RemoveNullClip(); // 0x00000001803360E0-0x00000001803361F0
		public void CreateDefaultPreset(); // 0x0000000180335A10-0x0000000180335B20
		private void CreateDefaultPreset(BlendShapePreset preset); // 0x0000000180335B20-0x0000000180335DD0
		public void SetClip(BlendShapeKey key, BlendShapeClip clip); // 0x00000001803361F0-0x0000000180336380
		public BlendShapeClip GetClip(BlendShapeKey key); // 0x0000000180335E90-0x0000000180335F90
		public BlendShapeClip GetClip(BlendShapePreset preset); // 0x0000000180335DD0-0x0000000180335E90
		public BlendShapeClip GetClip(string name); // 0x0000000180335F90-0x00000001803360E0
	}
}
