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
	public struct Validation // TypeDefIndex: 5911
	{
		// Fields
		public readonly ErrorLevels ErrorLevel; // 0x00
		public readonly string Message; // 0x08
		public System.Action Extended; // 0x10
	
		// Properties
		public bool CanExport { get; } // 0x0000000180BCEE40-0x0000000180BCEEB0 
	
		// Constructors
		private Validation(ErrorLevels canExport, string message, System.Action extended = null); // 0x0000000180BCEE30-0x0000000180BCEE40
	
		// Methods
		public static Validation Critical(string msg); // 0x0000000180BCEDB0-0x0000000180BCEDD0
		public static Validation Error(string msg, System.Action action = null); // 0x0000000180BCEDD0-0x0000000180BCEDF0
		public static Validation Warning(string msg); // 0x0000000180BCEE10-0x0000000180BCEE30
		public static Validation Info(string msg); // 0x0000000180BCEDF0-0x0000000180BCEE10
		public void AddTo(IList<Validation> dst); // 0x0000000180BCECC0-0x0000000180BCEDB0
	}
}
