/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	public static class MeshExtensions // TypeDefIndex: 5659
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 5658
		{
			// Fields
			public Matrix4x4 m; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Vector3 _ApplyMatrix_b__0(Vector3 x); // 0x00000001806E57F0-0x00000001806E5840
			internal Vector3 _ApplyMatrix_b__1(Vector3 x); // 0x00000001806E5840-0x00000001806E5890
			internal Vector4 _ApplyMatrix_b__2(Vector4 x); // 0x00000001806E5890-0x00000001806E5940
		}
	
		// Extension methods
		public static Mesh Copy(this Mesh src, bool copyBlendShape); // 0x0000000180BBA660-0x0000000180BBA940
		public static void ApplyRotationAndScale(this Mesh src, Matrix4x4 m); // 0x0000000180BBA5B0-0x0000000180BBA660
		public static void ApplyMatrix(this Mesh src, Matrix4x4 m); // 0x0000000180BBA300-0x0000000180BBA5B0
	}
}
