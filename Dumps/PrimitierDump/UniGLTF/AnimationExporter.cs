/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class AnimationExporter // TypeDefIndex: 5785
	{
		// Nested types
		public class InputOutputValues // TypeDefIndex: 5783
		{
			// Fields
			public float[] Input; // 0x10
			public float[] Output; // 0x18
	
			// Constructors
			public InputOutputValues(); // 0x00000001802650F0-0x0000000180265100
		}
	
		public class AnimationWithSampleCurves // TypeDefIndex: 5784
		{
			// Fields
			public glTFAnimation Animation; // 0x10
			public Dictionary<int, InputOutputValues> SamplerMap; // 0x18
	
			// Constructors
			public AnimationWithSampleCurves(); // 0x0000000180D50060-0x0000000180D500D0
		}
	}
}
