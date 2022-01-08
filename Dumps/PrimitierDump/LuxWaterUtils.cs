/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public static class LuxWaterUtils // TypeDefIndex: 8561
{
	// Nested types
	public struct GersterWavesDescription // TypeDefIndex: 8560
	{
		// Fields
		public Vector3 intensity; // 0x00
		public Vector4 steepness; // 0x0C
		public Vector4 amp; // 0x1C
		public Vector4 freq; // 0x2C
		public Vector4 speed; // 0x3C
		public Vector4 dirAB; // 0x4C
		public Vector4 dirCD; // 0x5C
		public Vector4 secondaryWaveParams; // 0x6C
	}

	// Methods
	public static void GetGersterWavesDescription(ref GersterWavesDescription Description, Material WaterMaterial); // 0x0000000180477860-0x0000000180477A10
	public static Vector3 InternalGetGestnerDisplacement(Vector2 xzVtx, Vector4 intensity, Vector4 steepness, Vector4 amp, Vector4 freq, Vector4 speed, Vector4 dirAB, Vector4 dirCD, float TimeOffset); // 0x0000000180478350-0x00000001804787B0
	public static Vector3 GetGestnerDisplacement(Vector3 WorldPosition, GersterWavesDescription Description, float TimeOffset); // 0x0000000180477E20-0x0000000180478350
	public static Vector3 GetGestnerDisplacementSingle(Vector3 WorldPosition, GersterWavesDescription Description, float TimeOffset); // 0x0000000180477A10-0x0000000180477E20
}

