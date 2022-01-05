/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	[Serializable]
	public class glTFAnimationTarget // TypeDefIndex: 5742
	{
		// Fields
		[JsonSchema] // 0x0000000180027650-0x0000000180027680
		public int node; // 0x10
		[JsonSchema] // 0x0000000180027850-0x0000000180027900
		public string path; // 0x18
		public glTFExtension extensions; // 0x20
		public glTFExtension extras; // 0x28
		public const string PATH_TRANSLATION = "translation"; // Metadata: 0x003A1A6B
		public const string PATH_EULER_ROTATION = "rotation"; // Metadata: 0x003A1A7A
		public const string PATH_ROTATION = "rotation"; // Metadata: 0x003A1A86
		public const string PATH_SCALE = "scale"; // Metadata: 0x003A1A92
		public const string PATH_WEIGHT = "weights"; // Metadata: 0x003A1A9B
		public const string NOT_IMPLEMENTED = "NotImplemented"; // Metadata: 0x003A1AA6
	
		// Nested types
		public enum Interpolations // TypeDefIndex: 5739
		{
			LINEAR = 0,
			STEP = 1,
			CUBICSPLINE = 2
		}
	
		[Obsolete] // 0x0000000180027910-0x0000000180027940
		public enum AnimationPropertys // TypeDefIndex: 5740
		{
			Translation = 0,
			EulerRotation = 1,
			Rotation = 2,
			Scale = 3,
			Weight = 4,
			BlendShape = 5,
			NotImplemented = 6
		}
	
		public enum AnimationProperties // TypeDefIndex: 5741
		{
			Translation = 0,
			EulerRotation = 1,
			Rotation = 2,
			Scale = 3,
			Weight = 4,
			BlendShape = 5,
			NotImplemented = 6
		}
	
		// Constructors
		public glTFAnimationTarget(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		[Obsolete] // 0x0000000180027900-0x0000000180027910
		internal static AnimationProperties AnimationPropertysToAnimationProperties(AnimationPropertys property); // 0x0000000180D5BE90-0x0000000180D5C020
		[Obsolete] // 0x0000000180027900-0x0000000180027910
		public static string GetPathName(AnimationPropertys property); // 0x0000000180D5C410-0x0000000180D5C430
		public static string GetPathName(AnimationProperties property); // 0x0000000180D5C320-0x0000000180D5C410
		public static AnimationProperties GetAnimationProperty(string path); // 0x0000000180D5C020-0x0000000180D5C130
		[Obsolete] // 0x0000000180027900-0x0000000180027910
		public static int GetElementCount(AnimationPropertys property); // 0x0000000180D5C260-0x0000000180D5C280
		public static int GetElementCount(AnimationProperties property); // 0x0000000180D5C280-0x0000000180D5C320
		public static int GetElementCount(string path); // 0x0000000180D5C130-0x0000000180D5C260
	}
}
