/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	public class LuxWater_Projector : MonoBehaviour // TypeDefIndex: 8754
	{
		// Fields
		[Space] // 0x000000018002D020-0x000000018002D040
		public ProjectorType Type; // 0x18
		[NonSerialized]
		public static List<LuxWater_Projector> FoamProjectors; // 0x00
		[NonSerialized]
		public static List<LuxWater_Projector> NormalProjectors; // 0x08
		[NonSerialized]
		public Renderer m_Rend; // 0x20
		[NonSerialized]
		public Material m_Mat; // 0x28
		private bool added; // 0x30
		private Vector3 origPos; // 0x34
	
		// Nested types
		public enum ProjectorType // TypeDefIndex: 8753
		{
			FoamProjector = 0,
			NormalProjector = 1
		}
	
		// Constructors
		public LuxWater_Projector(); // 0x0000000180265240-0x0000000180265250
		static LuxWater_Projector(); // 0x000000018047D5D0-0x000000018047D670
	
		// Methods
		private void Update(); // 0x000000018047D5A0-0x000000018047D5D0
		private void OnEnable(); // 0x000000018047D3E0-0x000000018047D5A0
		private void OnDisable(); // 0x000000018047D300-0x000000018047D3E0
	}
}
