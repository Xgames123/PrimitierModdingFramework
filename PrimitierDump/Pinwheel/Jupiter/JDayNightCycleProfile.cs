/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	[CreateAssetMenu] // 0x000000018002E350-0x000000018002E380
	public class JDayNightCycleProfile : ScriptableObject // TypeDefIndex: 8734
	{
		// Fields
		private static Dictionary<string, int> propertyRemap; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<JAnimatedProperty> animatedProperties; // 0x18
	
		// Properties
		private static Dictionary<string, int> PropertyRemap { get; set; } // 0x000000018030DF00-0x000000018030E010 0x000000018030E010-0x000000018030E070
		public List<JAnimatedProperty> AnimatedProperties { get; set; } // 0x000000018030DE90-0x000000018030DF00 0x000000018026BFE0-0x000000018026BFF0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 8732
		{
			// Fields
			public JAnimatedProperty p; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _AddProperty_b__0(JAnimatedProperty p0); // 0x0000000180888750-0x00000001808887C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 8733
		{
			// Fields
			public string propertyName; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ContainProperty_b__0(JAnimatedProperty p); // 0x00000001808887C0-0x0000000180888800
		}
	
		// Constructors
		static JDayNightCycleProfile(); // 0x000000018030DE70-0x000000018030DE80
		public JDayNightCycleProfile(); // 0x000000018030DE80-0x000000018030DE90
	
		// Methods
		private static void InitPropertyRemap(); // 0x000000018030DC10-0x000000018030DE70
		public void AddProperty(JAnimatedProperty p, bool setDefaultValue = true /* Metadata: 0x003A6D7E */); // 0x000000018030D390-0x000000018030D5D0
		public void Animate(JSky sky, float t); // 0x000000018030D5D0-0x000000018030D9A0
		private void CheckDefaultProfileAndThrow(JSkyProfile p); // 0x000000018030D9A0-0x000000018030DAE0
		public bool ContainProperty(string propertyName); // 0x000000018030DAE0-0x000000018030DC10
	}
}
