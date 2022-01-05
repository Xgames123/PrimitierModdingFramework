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
	[Serializable]
	public class glTFAnimation // TypeDefIndex: 5746
	{
		// Fields
		public string name; // 0x10
		[JsonSchema] // 0x0000000180027A10-0x0000000180027A40
		public List<glTFAnimationChannel> channels; // 0x18
		[JsonSchema] // 0x0000000180027A10-0x0000000180027A40
		public List<glTFAnimationSampler> samplers; // 0x20
		public glTFExtension extensions; // 0x28
		public glTFExtension extras; // 0x30
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 5745
		{
			// Fields
			public int nodeIndex; // 0x10
			public glTFAnimationTarget.AnimationProperties property; // 0x14
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AddChannelAndGetSampler_b__0(glTFAnimationChannel x); // 0x00000001806E6850-0x00000001806E68A0
		}
	
		// Constructors
		public glTFAnimation(); // 0x0000000180D5C690-0x0000000180D5C750
	
		// Methods
		[Obsolete] // 0x0000000180027900-0x0000000180027910
		public int AddChannelAndGetSampler(int nodeIndex, glTFAnimationTarget.AnimationPropertys property); // 0x0000000180D5C650-0x0000000180D5C690
		public int AddChannelAndGetSampler(int nodeIndex, glTFAnimationTarget.AnimationProperties property); // 0x0000000180D5C430-0x0000000180D5C650
	}
}
