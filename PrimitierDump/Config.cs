/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public static class Config // TypeDefIndex: 8585
{
	// Fields
	private static readonly string configDirectoryName; // 0x00
	private static readonly string configFileName; // 0x08
	private static ConfigData data; // 0x10

	// Properties
	public static ConfigData Data { get; set; } // 0x00000001805350D0-0x0000000180535190 0x0000000180535190-0x00000001805351F0

	// Nested types
	[Serializable]
	public class ConfigData // TypeDefIndex: 8584
	{
		// Fields
		public string localeCode; // 0x10
		public bool dayNightCycle; // 0x18
		public bool snap; // 0x19
		public bool avatar; // 0x1A
		public int simulationDistanceLevel; // 0x1C
		public int objectRenderDistanceLevel; // 0x20
		public int terrainRenderDistanceLevel; // 0x24

		// Constructors
		public ConfigData(); // 0x0000000180B46A60-0x0000000180B46AB0
	}

	// Constructors
	static Config(); // 0x0000000180535040-0x00000001805350D0

	// Methods
	private static void Load(); // 0x0000000180534AF0-0x0000000180534EA0
	public static void Save(); // 0x0000000180534EA0-0x0000000180535040
	private static void LimitValues(ConfigData data); // 0x0000000180534990-0x0000000180534AF0
}

