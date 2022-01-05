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
	[Serializable]
	public struct MaterialValueBinding : IEquatable<VRM.MaterialValueBinding> // TypeDefIndex: 7972
	{
		// Fields
		public string MaterialName; // 0x00
		public string ValueName; // 0x08
		public Vector4 TargetValue; // 0x10
		public Vector4 BaseValue; // 0x20
	
		// Methods
		public bool Equals(MaterialValueBinding other); // 0x000000018033B9F0-0x000000018033BB00
		public override bool Equals(object obj); // 0x000000018033B940-0x000000018033B9F0
		public override int GetHashCode(); // 0x000000018033BB00-0x000000018033BBA0
	}
}
