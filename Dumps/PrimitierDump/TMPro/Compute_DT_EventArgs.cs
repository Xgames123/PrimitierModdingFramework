/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class Compute_DT_EventArgs // TypeDefIndex: 6213
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress); // 0x000000018036B8C0-0x000000018036B900
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors); // 0x000000018036B880-0x000000018036B8C0
	}
}
