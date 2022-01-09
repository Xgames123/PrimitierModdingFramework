/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public struct SubAssetKey : IEquatable<UniGLTF.SubAssetKey> // TypeDefIndex: 5873
	{
		// Fields
		public readonly System.Type Type; // 0x00
		public readonly string Name; // 0x08
	
		// Constructors
		public SubAssetKey(System.Type t, string name); // 0x0000000180BC2E50-0x0000000180BC2ED0
	
		// Methods
		public override string ToString(); // 0x0000000180BC2E10-0x0000000180BC2E50
		public override bool Equals(object obj); // 0x0000000180BC2C20-0x0000000180BC2D30
		public bool Equals(SubAssetKey other); // 0x0000000180BC2D30-0x0000000180BC2DE0
		public static bool operator ==(SubAssetKey l, SubAssetKey r); // 0x0000000180BC2ED0-0x0000000180BC2F70
		public static bool operator !=(SubAssetKey l, SubAssetKey r); // 0x0000000180BC2F70-0x0000000180BC3010
		public override int GetHashCode(); // 0x0000000180BC2DE0-0x0000000180BC2E10
	}
}
