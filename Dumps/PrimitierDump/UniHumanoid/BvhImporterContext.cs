/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class BvhImporterContext // TypeDefIndex: 5967
	{
		// Fields
		private string m_path; // 0x10
		public string Source; // 0x18
		public Bvh Bvh; // 0x20
		public GameObject Root; // 0x28
		public List<Transform> Nodes; // 0x30
		public AnimationClip Animation; // 0x38
		public AvatarDescription AvatarDescription; // 0x40
		public Avatar Avatar; // 0x48
		public Mesh Mesh; // 0x50
		public Material Material; // 0x58
	
		// Properties
		public string Path { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x00000001812AE990-0x00000001812AE9C0
	
		// Constructors
		public BvhImporterContext(); // 0x00000001812AE920-0x00000001812AE990
	
		// Methods
		[Obsolete] // 0x000000018004E090-0x000000018004E0C0
		public void Parse(); // 0x00000001812AE860-0x00000001812AE8C0
		public void Parse(string path); // 0x00000001812AE8C0-0x00000001812AE920
		public void Load(); // 0x00000001812ADF00-0x00000001812AE860
		private static Transform BuildHierarchy(Transform parent, BvhNode node, float toMeter); // 0x00000001812ADBF0-0x00000001812ADE60
		public void Destroy(bool destroySubAssets); // 0x00000001812ADE60-0x00000001812ADF00
	}
}
