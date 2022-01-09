/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class JointsAccessor // TypeDefIndex: 5824
	{
		// Nested types
		public delegate ValueTuple<ushort, ushort, ushort, ushort> Getter(int index); // TypeDefIndex: 5821; 0x00000001809A8FE0-0x00000001809A92A0
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5822
		{
			// Fields
			public Byte4[] array; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<ushort, ushort, ushort, ushort> _GetAccessor_b__0(int i); // 0x0000000180D57460-0x0000000180D57510
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 5823
		{
			// Fields
			public UShort4[] array; // 0x10
	
			// Constructors
			public __c__DisplayClass1_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<ushort, ushort, ushort, ushort> _GetAccessor_b__1(int i); // 0x0000000180D576C0-0x0000000180D57770
		}
	
		// Methods
		public static ValueTuple<Getter, int> GetAccessor(glTF gltf, int accessorIndex); // 0x0000000180D24E30-0x0000000180D25110
	}
}
