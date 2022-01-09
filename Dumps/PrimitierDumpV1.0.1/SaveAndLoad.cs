/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class SaveAndLoad : MonoBehaviour // TypeDefIndex: 8671
{
	// Fields
	private static readonly string mapFileDirectoryName; // 0x00
	private static readonly string mapFileName; // 0x08
	private static readonly int versionLength; // 0x10
	private static readonly int floatToIntAccuracy; // 0x14
	private static readonly int[] oldestSupportVersion; // 0x18
	public static LoadState loadState; // 0x20
	public static Vector3 playerPos; // 0x24
	public static float playerAngle; // 0x30
	public static Vector3 respawnPos; // 0x34
	public static float respawnAngle; // 0x40
	public static Vector3 cameraPos; // 0x44
	public static Quaternion cameraRot; // 0x50
	public static Dictionary<Vector2Int, List<GroupData>> chunkDict; // 0x60

	// Nested types
	public enum LoadState // TypeDefIndex: 8664
	{
		Initial = 0,
		Parsed = 1,
		NoSaveData = 2,
		Loaded = 3,
		Generated = 4
	}

	[Serializable]
	public class SaveData // TypeDefIndex: 8665
	{
		// Fields
		public int[] version; // 0x10
		public int seed; // 0x18
		public Vector3 playerPos; // 0x1C
		public float playerAngle; // 0x28
		public float playerMaxLife; // 0x2C
		public float playerLife; // 0x30
		public Vector3 respawnPos; // 0x34
		public float respawnAngle; // 0x40
		public Vector3 cameraPos; // 0x44
		public Quaternion cameraRot; // 0x50
		public List<ChunkData> chunks; // 0x60
		public List<SaveAndLoad.TerrainData> terrains; // 0x68

		// Constructors
		public SaveData(); // 0x0000000180885310-0x00000001808853C0
	}

	[Serializable]
	public class ChunkData // TypeDefIndex: 8666
	{
		// Fields
		public int x; // 0x10
		public int z; // 0x14
		public List<GroupData> groups; // 0x18

		// Constructors
		public ChunkData(); // 0x0000000180885160-0x00000001808851D0
	}

	[Serializable]
	public class TerrainData // TypeDefIndex: 8667
	{
		// Fields
		public int x; // 0x10
		public int z; // 0x14
		public bool generated; // 0x18
		public int[] heightMap; // 0x20
		public int[] materialMap; // 0x28

		// Constructors
		public TerrainData(); // 0x00000001802650F0-0x0000000180265100
	}

	[Serializable]
	public class GroupData // TypeDefIndex: 8668
	{
		// Fields
		public Vector3 pos; // 0x10
		public Quaternion rot; // 0x1C
		public List<CubeData> cubes; // 0x30

		// Constructors
		public GroupData(); // 0x00000001808852A0-0x0000000180885310
	}

	[Serializable]
	public class CubeData // TypeDefIndex: 8669
	{
		// Fields
		public Vector3 pos; // 0x10
		public Quaternion rot; // 0x1C
		public Vector3 scale; // 0x2C
		public float lifeRatio; // 0x38
		public CubeConnector.Anchor anchor; // 0x3C
		public Substance substance; // 0x40
		public List<int> connections; // 0x48
		public float temperature; // 0x50
		public bool isBurning; // 0x54
		public float burnedRatio; // 0x58
		public CubeAppearance.SectionState sectionState; // 0x5C
		public CubeAppearance.UVOffset uvOffset; // 0x60
		public List<string> behaviors; // 0x68
		public List<string> states; // 0x70

		// Constructors
		public CubeData(); // 0x00000001808851D0-0x00000001808852A0
	}

	[Serializable]
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class __c // TypeDefIndex: 8670
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Converter<float, int> __9__21_0; // 0x08
		public static Converter<int, float> __9__23_0; // 0x10

		// Constructors
		static __c(); // 0x0000000180888860-0x00000001808888C0
		public __c(); // 0x00000001802650F0-0x0000000180265100

		// Methods
		internal int _Save_b__21_0(float x); // 0x00000001808886D0-0x0000000180888750
		internal float _Load_b__23_0(int x); // 0x0000000180888660-0x00000001808886D0
	}

	// Constructors
	public SaveAndLoad(); // 0x0000000180265240-0x0000000180265250
	static SaveAndLoad(); // 0x0000000180B4D1C0-0x0000000180B4D320

	// Methods
	public static string GetSaveDirectory(); // 0x0000000180B4AA60-0x0000000180B4AAD0
	public static void Store(ICollection<Vector2Int> chunkPositions); // 0x0000000180B4C580-0x0000000180B4D1C0
	public static void Save(); // 0x0000000180B4BA90-0x0000000180B4C580
	public static SaveData Parse(); // 0x0000000180B4B590-0x0000000180B4BA90
	public static void Load(SaveData saveData); // 0x0000000180B4AAD0-0x0000000180B4B2E0
	public static void DeleteTemporaryData(); // 0x0000000180B4A850-0x0000000180B4AA60
	public static void DeleteSaveData(); // 0x0000000180B4A790-0x0000000180B4A850
	private static byte[] Compress(string str); // 0x0000000180B4A2C0-0x0000000180B4A530
	private static string Decompress(byte[] bytes); // 0x0000000180B4A530-0x0000000180B4A790
	private static int[] ParseVersion(string version); // 0x0000000180B4B330-0x0000000180B4B590
	private static int CompareVersion(int[] a, int[] b); // 0x0000000180B4A100-0x0000000180B4A2C0
	private static T[] SerializeMap<T>(T[,] map);
	private static T[,] DeserializeMap<T>(T[] map);
	private void OnApplicationQuit(); // 0x0000000180B4B2E0-0x0000000180B4B330
}

