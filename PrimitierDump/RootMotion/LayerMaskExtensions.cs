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
	public static class LayerMaskExtensions // TypeDefIndex: 8289
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer); // 0x0000000180771480-0x00000001807714C0
		public static LayerMask Create(params /* 0x0000000180014D50-0x0000000180014D60 */ string[] layerNames); // 0x00000001807714C0-0x00000001807714D0
		public static LayerMask Create(params /* 0x0000000180014D50-0x0000000180014D60 */ int[] layerNumbers); // 0x00000001807714D0-0x0000000180771550
		public static LayerMask NamesToMask(params /* 0x0000000180014D50-0x0000000180014D60 */ string[] layerNames); // 0x00000001807719D0-0x0000000180771A70
		public static LayerMask LayerNumbersToMask(params /* 0x0000000180014D50-0x0000000180014D60 */ int[] layerNumbers); // 0x00000001807714D0-0x0000000180771550
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original); // 0x0000000180771550-0x0000000180771570
		public static LayerMask AddToMask(this LayerMask original, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] layerNames); // 0x0000000180771440-0x0000000180771480
		public static LayerMask RemoveFromMask(this LayerMask original, params /* 0x0000000180014D50-0x0000000180014D60 */ string[] layerNames); // 0x0000000180771A70-0x0000000180771AD0
		public static string[] MaskToNames(this LayerMask original); // 0x0000000180771570-0x0000000180771680
		public static int[] MaskToNumbers(this LayerMask original); // 0x0000000180771680-0x0000000180771770
		public static string MaskToString(this LayerMask original); // 0x0000000180771890-0x00000001807719D0
		public static string MaskToString(this LayerMask original, string delimiter); // 0x0000000180771770-0x0000000180771890
	}
}
