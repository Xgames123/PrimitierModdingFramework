/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class WeightsAccessor // TypeDefIndex: 5892
	{
		// Nested types
		public delegate ValueTuple<float, float, float, float> Getter(int index); // TypeDefIndex: 5888; 0x00000001806D96C0-0x00000001806D99E0
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 5889
		{
			// Fields
			public Byte4[] array; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<float, float, float, float> _GetAccessor_b__0(int i); // 0x00000001806E5560-0x00000001806E5650
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_1 // TypeDefIndex: 5890
		{
			// Fields
			public UShort4[] array; // 0x10
	
			// Constructors
			public __c__DisplayClass1_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<float, float, float, float> _GetAccessor_b__1(int i); // 0x00000001806E5650-0x00000001806E5740
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass1_2 // TypeDefIndex: 5891
		{
			// Fields
			public Vector4[] array; // 0x10
	
			// Constructors
			public __c__DisplayClass1_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<float, float, float, float> _GetAccessor_b__2(int i); // 0x00000001806E5740-0x00000001806E57F0
		}
	
		// Methods
		public static ValueTuple<Getter, int> GetAccessor(glTF gltf, int accessorIndex); // 0x0000000180BCEEB0-0x0000000180BCF250
	}
}
