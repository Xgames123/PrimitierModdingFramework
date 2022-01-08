/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeGenerator : MonoBehaviour // TypeDefIndex: 8628
{
	// Fields
	public static CubeGenerator instance; // 0x00
	public static readonly int[] distances; // 0x08
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform player; // 0x18
	private static GameObject groupedCubePrefab; // 0x10
	private static GameObject groupPrefab; // 0x18
	private static GameObject cubePrefab; // 0x20
	public static readonly int chunkTileCount; // 0x28
	private int generationDistance; // 0x20
	private static int areaBuffer; // 0x2C
	public static HashSet<Vector2Int> generatedChunks; // 0x30
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private static Vector2Int _PlayerChunkPos_k__BackingField; // 0x38
	private static Vector2Int prevPlayerChunkPos; // 0x40
	private static Coroutine prevGeneration; // 0x48
	public static bool autoGenerate; // 0x50
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private static System.EventHandler PlayerChunkChanged; // 0x58

	// Properties
	public int GenerationDistance { get; set; } // 0x000000018030A1D0-0x000000018030A1E0 0x00000001805444F0-0x0000000180544500
	public static Vector2Int PlayerChunkPos { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180544390-0x00000001805443F0 0x0000000180544500-0x0000000180544560

	// Events
	public static event System.EventHandler PlayerChunkChanged {
		add; // 0x0000000180544290-0x0000000180544390
		remove; // 0x00000001805443F0-0x00000001805444F0
	}

	// Nested types
	private enum TreeType // TypeDefIndex: 8626
	{
		Broadleaf = 0,
		Conifer = 1,
		Giant = 2
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _GenerateNearChunks_d__30 : IEnumerator<object> // TypeDefIndex: 8627
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public Vector2Int center; // 0x20
		public CubeGenerator __4__this; // 0x28
		private int _r_5__2; // 0x30
		private int _x_5__3; // 0x34
		private int _y_5__4; // 0x38
		private Vector2Int _pos_5__5; // 0x3C
		private Vector2Int _areaPos_5__6; // 0x44

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _GenerateNearChunks_d__30(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x0000000180B5C340-0x0000000180B5C5F0
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x0000000180B5C5F0-0x0000000180B5C630
	}

	// Constructors
	public CubeGenerator(); // 0x0000000180265240-0x0000000180265250
	static CubeGenerator(); // 0x0000000180544190-0x0000000180544290

	// Methods
	private void Awake(); // 0x000000018053E470-0x000000018053E5A0
	private void Start(); // 0x0000000180543E80-0x0000000180544060
	private void FixedUpdate(); // 0x000000018053ED30-0x000000018053EF40
	private void OnPlayerChunkChanged(); // 0x0000000180543B80-0x0000000180543E80
	public void OnLoad(); // 0x0000000180543A20-0x0000000180543B80
	public static void CancelPrevGeneration(); // 0x000000018053E5A0-0x000000018053E640
	private void DestroyFarChunks(Vector2Int center); // 0x000000018053EB00-0x000000018053ED30
	[IteratorStateMachine] // 0x000000018002D470-0x000000018002D4C0
	public IEnumerator GenerateNearChunks(Vector2Int center); // 0x0000000180540500-0x0000000180540580
	private static bool NearAreasAreGenerated(Vector2Int centerAreaPos); // 0x0000000180543870-0x0000000180543A20
	private static void GenerateChunk(Vector2Int chunkPos); // 0x000000018053EF40-0x000000018053F0F0
	public static void DestroyChunks(List<Vector2Int> destroyChunkPositions); // 0x000000018053E780-0x000000018053EB00
	public static Vector2Int WorldToChunkPos(Vector3 pos); // 0x0000000180544060-0x0000000180544190
	public static Vector3 ChunkToWorldPos(Vector2Int chunkPos); // 0x000000018053E640-0x000000018053E780
	private static void GenerateNewChunk(Vector2Int chunkPos); // 0x0000000180540580-0x00000001805420D0
	private static void GenerateTree(Vector3 spaceCenter, float spaceLength, TreeType treeType); // 0x00000001805432C0-0x0000000180543870
	private static void GenerateSlime(Vector3 spaceCenter, float spaceLength = 0f /* Metadata: 0x003A6CB9 */); // 0x0000000180542E70-0x0000000180543050
	private static void GenerateRedSlime(Vector3 spaceCenter, float spaceLength = 0f /* Metadata: 0x003A6CBD */); // 0x00000001805420D0-0x00000001805422B0
	private static void GenerateMonument(Vector3 pos); // 0x0000000180540390-0x0000000180540500
	private static void GenerateRespawnPoint(Vector3 pos); // 0x00000001805422B0-0x0000000180542410
	public static void GenerateHinge(Vector3 pos, Quaternion rot); // 0x0000000180540120-0x0000000180540390
	public static void GenerateSpring(Vector3 pos, Quaternion rot); // 0x0000000180543050-0x00000001805432C0
	public static void GenerateDrone(Vector3 spaceCenter, float spaceLength = 0f /* Metadata: 0x003A6CC1 */); // 0x000000018053FDE0-0x0000000180540120
	private static void GenerateDroneFactory(Vector3 pos); // 0x000000018053F300-0x000000018053FDE0
	private static void GenerateSavedChunk(List<SaveAndLoad.GroupData> groups); // 0x0000000180542410-0x0000000180542E70
	public static GameObject GenerateCube(Vector3 pos, Vector3 size, Substance substance, float temperature = 293.15f /* Metadata: 0x003A6CC5 */, CubeAppearance.SectionState sectionState =  /* Metadata: 0x003A6CC9 */, CubeAppearance.UVOffset uvOffset = null, string tag = "" /* Metadata: 0x003A6CCD */); // 0x000000018053F0F0-0x000000018053F300
}

