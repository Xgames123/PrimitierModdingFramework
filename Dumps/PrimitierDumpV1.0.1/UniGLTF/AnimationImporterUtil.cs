/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class AnimationImporterUtil // TypeDefIndex: 5790
	{
		// Nested types
		private enum TangentMode // TypeDefIndex: 5786
		{
			Linear = 0,
			Constant = 1,
			Cubicspline = 2
		}
	
		public delegate float[] ReverseFunc(float[] current, float[] last); // TypeDefIndex: 5787; 0x0000000180292A20-0x0000000180292EC0
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 5788
		{
			// Fields
			public IAxisInverter inverter; // 0x10
			public ReverseFunc __9__0; // 0x18
			public ReverseFunc __9__1; // 0x20
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal float[] _ConvertAnimationClip_b__0(float[] values, float[] last); // 0x0000000180D58750-0x0000000180D588C0
			internal float[] _ConvertAnimationClip_b__1(float[] values, float[] last); // 0x0000000180D588C0-0x0000000180D58B50
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5789
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ReverseFunc __9__8_2; // 0x08
			public static Func<string, bool> __9__8_3; // 0x10
			public static Func<string, string> __9__8_4; // 0x18
			public static ReverseFunc __9__8_5; // 0x20
	
			// Constructors
			static __c(); // 0x0000000180D58D90-0x0000000180D58DF0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal float[] _ConvertAnimationClip_b__8_2(float[] values, float[] last); // 0x00000001802D5FD0-0x00000001802D5FE0
			internal bool _ConvertAnimationClip_b__8_3(string x); // 0x0000000180D56950-0x0000000180D56970
			internal string _ConvertAnimationClip_b__8_4(string x); // 0x0000000180D56970-0x0000000180D569B0
			internal float[] _ConvertAnimationClip_b__8_5(float[] values, float[] last); // 0x0000000180D569B0-0x0000000180D56A10
		}
	
		// Methods
		private static TangentMode GetTangentMode(string interpolation); // 0x00000001810AA3C0-0x00000001810AA5C0
		private static void CalculateTanget(List<Keyframe> keyframes, int current); // 0x00000001810A8D90-0x00000001810A9250
		public static Quaternion GetShortest(Quaternion last, Quaternion rot); // 0x00000001810AA310-0x00000001810AA3C0
		public static void SetAnimationCurve(AnimationClip targetClip, string relativePath, string[] propertyNames, float[] input, float[] output, string interpolation, System.Type curveType, ReverseFunc reverse); // 0x00000001810AA990-0x00000001810AB2E0
		public static string RelativePathFrom(List<glTFNode> nodes, glTFNode root, glTFNode target); // 0x00000001810AA5C0-0x00000001810AA680
		private static string RelativePathFrom(List<glTFNode> nodes, glTFNode root, glTFNode target, List<string> path); // 0x00000001810AA680-0x00000001810AA990
		public static AnimationClip ConvertAnimationClip(glTF gltf, glTFAnimation animation, IAxisInverter inverter, glTFNode root = null); // 0x00000001810A9250-0x00000001810AA310
	}
}
