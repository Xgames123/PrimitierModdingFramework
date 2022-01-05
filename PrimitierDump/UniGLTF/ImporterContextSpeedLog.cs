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
	public class ImporterContextSpeedLog // TypeDefIndex: 5820
	{
		// Fields
		public List<KeyElapsed> m_speedReports; // 0x10
	
		// Nested types
		public struct KeyElapsed // TypeDefIndex: 5817
		{
			// Fields
			public string Key; // 0x00
			public TimeSpan Elapsed; // 0x08
	
			// Constructors
			public KeyElapsed(string key, TimeSpan elapsed); // 0x0000000180494FD0-0x0000000180494FE0
		}
	
		public struct MeasureScope : IDisposable // TypeDefIndex: 5818
		{
			// Fields
			private System.Action m_onDispose; // 0x00
	
			// Constructors
			public MeasureScope(System.Action onDispose); // 0x00000001802D7C80-0x00000001802D7C90
	
			// Methods
			public void Dispose(); // 0x0000000180D50AB0-0x0000000180D50AD0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 5819
		{
			// Fields
			public ImporterContextSpeedLog __4__this; // 0x10
			public string key; // 0x18
			public Stopwatch sw; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _MeasureTime_b__0(); // 0x0000000180D57E10-0x0000000180D57EA0
		}
	
		// Constructors
		public ImporterContextSpeedLog(); // 0x0000000180D23090-0x0000000180D23100
	
		// Methods
		public IDisposable MeasureTime(string key); // 0x0000000180D22F90-0x0000000180D23090
		public string GetSpeedLog(); // 0x0000000180D22C90-0x0000000180D22F90
	}
}
