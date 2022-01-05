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

public class TerrainMeshGenerator : MonoBehaviour // TypeDefIndex: 8634
{
	// Fields
	public static TerrainMeshGenerator instance; // 0x00
	public static readonly int[] distances; // 0x08
	private static readonly float quantizationUnit; // 0x10
	public static readonly int tileLength; // 0x14
	private int generationDistance; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform player; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject terrainMeshPrefab; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Material[] materials; // 0x30
	public static Dictionary<Vector2Int, GameObject> generatedAreas; // 0x18
	private static Vector2Int playerAreaPos; // 0x20
	private static Vector2Int prevPlayerAreaPos; // 0x28
	private static Coroutine prevGeneration; // 0x30
	public static bool autoGenerate; // 0x38

	// Properties
	public int GenerationDistance { get; set; } // 0x0000000180268FB0-0x0000000180268FC0 0x0000000180B5B2E0-0x0000000180B5B2F0

	// Nested types
	public enum TerrainMaterial // TypeDefIndex: 8632
	{
		Grass = 0,
		Sand = 1,
		Stone = 2
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _GenerateNearAreas_d__25 : IEnumerator<object> // TypeDefIndex: 8633
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public Vector2Int center; // 0x20
		public TerrainMeshGenerator __4__this; // 0x28
		private int _r_5__2; // 0x30
		private int _x_5__3; // 0x34
		private int _y_5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _GenerateNearAreas_d__25(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x0000000180886300-0x0000000180886490
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x0000000180886490-0x00000001808864D0
	}

	// Constructors
	public TerrainMeshGenerator(); // 0x0000000180265240-0x0000000180265250
	static TerrainMeshGenerator(); // 0x0000000180B5B1E0-0x0000000180B5B2E0

	// Methods
	private void Awake(); // 0x0000000180B594F0-0x0000000180B59620
	private void Start(); // 0x0000000180B5AFD0-0x0000000180B5B0B0
	private void FixedUpdate(); // 0x0000000180B59B10-0x0000000180B59C60
	private void OnPlayerAreaChanged(); // 0x0000000180B5AD70-0x0000000180B5AEC0
	public void OnLoad(); // 0x0000000180B5ACA0-0x0000000180B5AD70
	public static void CancelPrevGeneration(); // 0x0000000180B59620-0x0000000180B596C0
	private void DestroyFarAreas(Vector2Int center); // 0x0000000180B598B0-0x0000000180B59B10
	public static void DestroyAreas(List<Vector2Int> areaPositions); // 0x0000000180B596C0-0x0000000180B598B0
	[IteratorStateMachine] // 0x000000018002D4C0-0x000000018002D510
	private IEnumerator GenerateNearAreas(Vector2Int center); // 0x0000000180B5ABB0-0x0000000180B5AC30
	public static Vector2Int WorldToAreaPos(Vector3 pos); // 0x0000000180B5B0B0-0x0000000180B5B1E0
	public static Vector3 AreaToWorldPos(Vector2Int areaPos); // 0x0000000180B593B0-0x0000000180B594F0
	private void GenerateArea(Vector2Int areaPos); // 0x0000000180B59C60-0x0000000180B5ABB0
	private static int GetLowerLeftVertexIndex(int x, int z); // 0x0000000180B5AC30-0x0000000180B5ACA0
	public static float Quantize(float value); // 0x0000000180B5AEC0-0x0000000180B5AFD0
}

