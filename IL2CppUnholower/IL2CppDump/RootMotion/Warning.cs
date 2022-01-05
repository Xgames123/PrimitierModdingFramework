/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public static class Warning // TypeDefIndex: 8296
	{
		// Fields
		public static bool logged; // 0x00
	
		// Nested types
		public delegate void Logger(string message); // TypeDefIndex: 8295; 0x00000001808478C0-0x0000000180847D30
	
		// Methods
		public static void Log(string message, Logger logger, bool logInEditMode = false /* Metadata: 0x003A6A64 */); // 0x00000001807208B0-0x0000000180720940
		public static void Log(string message, Transform context, bool logInEditMode = false /* Metadata: 0x003A6A65 */); // 0x0000000180720800-0x00000001807208B0
	}
}
