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
	public class Interp // TypeDefIndex: 8287
	{
		// Constructors
		public Interp(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static float Float(float t, InterpolationMode mode); // 0x00000001807703B0-0x00000001807709C0
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode); // 0x0000000180771200-0x00000001807712C0
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed); // 0x0000000180770D20-0x0000000180770DB0
		private static float None(float t, float b, float c); // 0x0000000180770DB0-0x0000000180770DC0
		private static float InOutCubic(float t, float b, float c); // 0x0000000180770BA0-0x0000000180770BD0
		private static float InOutQuintic(float t, float b, float c); // 0x0000000180770BD0-0x0000000180770C20
		private static float InQuintic(float t, float b, float c); // 0x0000000180770CB0-0x0000000180770CD0
		private static float InQuartic(float t, float b, float c); // 0x0000000180770C90-0x0000000180770CB0
		private static float InCubic(float t, float b, float c); // 0x00000001807709F0-0x0000000180770A10
		private static float InQuadratic(float t, float b, float c); // 0x0000000180770C80-0x0000000180770C90
		private static float OutQuintic(float t, float b, float c); // 0x0000000180771150-0x00000001807711C0
		private static float OutQuartic(float t, float b, float c); // 0x00000001807710F0-0x0000000180771150
		private static float OutCubic(float t, float b, float c); // 0x0000000180770E90-0x0000000180770ED0
		private static float OutInCubic(float t, float b, float c); // 0x0000000180771070-0x00000001807710B0
		private static float OutInQuartic(float t, float b, float c); // 0x00000001807710B0-0x00000001807710F0
		private static float BackInCubic(float t, float b, float c); // 0x0000000180770340-0x0000000180770370
		private static float BackInQuartic(float t, float b, float c); // 0x0000000180770370-0x00000001807703B0
		private static float OutBackCubic(float t, float b, float c); // 0x0000000180770DC0-0x0000000180770E00
		private static float OutBackQuartic(float t, float b, float c); // 0x0000000180770E00-0x0000000180770E50
		private static float OutElasticSmall(float t, float b, float c); // 0x0000000180770F40-0x0000000180770FB0
		private static float OutElasticBig(float t, float b, float c); // 0x0000000180770ED0-0x0000000180770F40
		private static float InElasticSmall(float t, float b, float c); // 0x0000000180770A70-0x0000000180770AD0
		private static float InElasticBig(float t, float b, float c); // 0x0000000180770A10-0x0000000180770A70
		private static float InSine(float t, float b, float c); // 0x0000000180770CD0-0x0000000180770D20
		private static float OutSine(float t, float b, float c); // 0x00000001807711C0-0x0000000180771200
		private static float InOutSine(float t, float b, float c); // 0x0000000180770C20-0x0000000180770C80
		private static float InElastic(float t, float b, float c); // 0x0000000180770AD0-0x0000000180770BA0
		private static float OutElastic(float t, float b, float c); // 0x0000000180770FB0-0x0000000180771070
		private static float InBack(float t, float b, float c); // 0x00000001807709C0-0x00000001807709F0
		private static float OutBack(float t, float b, float c); // 0x0000000180770E50-0x0000000180770E90
	}
}
