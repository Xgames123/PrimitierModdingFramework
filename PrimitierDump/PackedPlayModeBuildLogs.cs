/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 39: Unity.Addressables.dll - Assembly: Unity.Addressables, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5988-6068
[assembly: CompilationRelaxations] // 0x0000000180048600-0x00000001800486A0
[assembly: Debuggable] // 0x0000000180048600-0x00000001800486A0
[assembly: InternalsVisibleTo] // 0x0000000180048600-0x00000001800486A0
[assembly: InternalsVisibleTo] // 0x0000000180048600-0x00000001800486A0
[assembly: RuntimeCompatibility] // 0x0000000180048600-0x00000001800486A0

[Serializable]
public class PackedPlayModeBuildLogs // TypeDefIndex: 5990
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private List<RuntimeBuildLog> m_RuntimeBuildLogs; // 0x10

	// Properties
	public List<RuntimeBuildLog> RuntimeBuildLogs { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90

	// Nested types
	[Serializable]
	public struct RuntimeBuildLog // TypeDefIndex: 5989
	{
		// Fields
		public LogType Type; // 0x00
		public string Message; // 0x08

		// Constructors
		public RuntimeBuildLog(LogType type, string message); // 0x00000001808BA2F0-0x00000001808BA300
	}

	// Constructors
	public PackedPlayModeBuildLogs(); // 0x0000000180B2AE80-0x0000000180B2AEF0
}

