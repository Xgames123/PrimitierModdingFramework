/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public static class TerrainGenerator // TypeDefIndex: 8631
{
	// Fields
	public static int worldSeed; // 0x00
	private static readonly RandomEx areaRandom; // 0x08
	public static readonly int areaTileCount; // 0x10
	public static readonly float startPosHeight; // 0x14
	public static readonly float waterLevel; // 0x18
	public static readonly Vector2Int respawnPointTilePos; // 0x1C
	private static readonly float perlinPersistence; // 0x24
	private static readonly int areaBuffer; // 0x28
	private static readonly int maxRiverLength; // 0x2C
	private static readonly float sqrt2; // 0x30
	public static Dictionary<Vector2Int, TerrainData> terrainDict; // 0x38

	// Nested types
	public class TerrainData // TypeDefIndex: 8630
	{
		// Fields
		public bool generated; // 0x10
		public float[,] heightMap; // 0x18
		public int[,] materialMap; // 0x20

		// Constructors
		public TerrainData(); // 0x00000001802650F0-0x0000000180265100
	}

	// Constructors
	static TerrainGenerator(); // 0x0000000180B591F0-0x0000000180B593B0

	// Methods
	public static float GetTileHeight(Vector2Int globalTilePos); // 0x0000000180B58380-0x0000000180B585E0
	public static void SetTileHeight(Vector2Int globalTilePos, float value); // 0x0000000180B58F80-0x0000000180B591F0
	private static int CalcAreaSeed(Vector2Int areaPos); // 0x0000000180B56840-0x0000000180B56900
	private static void Initialize(Vector2Int areaPos); // 0x0000000180B585E0-0x0000000180B58CD0
	private static void Generate(Vector2Int areaPos); // 0x0000000180B580A0-0x0000000180B58380
	public static TerrainData CompleteGeneration(Vector2Int areaPos); // 0x0000000180B56D80-0x0000000180B57840
	private static float PerlinNoise(Vector2 vector2, int noiseID); // 0x0000000180B58EC0-0x0000000180B58F80
	private static float OctavePerlinNoise(Vector2 vector2, int minOctave, int maxOctave, int noiseID); // 0x0000000180B58CD0-0x0000000180B58EC0
	private static float CalcHeight(Vector2 pos); // 0x0000000180B56B20-0x0000000180B56D80
	private static void GenerateRiver(Vector2Int areaPos); // 0x0000000180B57840-0x0000000180B580A0
	private static Vector2 CalcGradient(Vector2Int tilePos); // 0x0000000180B56900-0x0000000180B56B20
}

