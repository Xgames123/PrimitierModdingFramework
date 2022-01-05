/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	public struct BlendShapeBinding : IEquatable<VRM.BlendShapeBinding> // TypeDefIndex: 7971
	{
		// Fields
		public string RelativePath; // 0x00
		public int Index; // 0x08
		public float Weight; // 0x0C
	
		// Methods
		public override string ToString(); // 0x00000001803370D0-0x0000000180337180
		public bool Equals(BlendShapeBinding other); // 0x0000000180336F60-0x0000000180336FC0
		public override bool Equals(object obj); // 0x0000000180336FC0-0x0000000180337070
		public override int GetHashCode(); // 0x0000000180337070-0x00000001803370D0
	}
}
