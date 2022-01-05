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
	[RequireComponent] // 0x000000018004DEA0-0x000000018004DEF0
	public class HumanBuilderTest : MonoBehaviour // TypeDefIndex: 5931
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material m_material; // 0x18
	
		// Nested types
		private class SkeletonBuilder // TypeDefIndex: 5930
		{
			// Fields
			private Dictionary<HumanBodyBones, Transform> m_skeleton; // 0x10
			private Dictionary<HumanBodyBones, Vector3> m_boneTail; // 0x18
			private Transform m_root; // 0x20
	
			// Properties
			public IDictionary<HumanBodyBones, Transform> Skeleton { get; } // 0x0000000180268FC0-0x0000000180268FD0 
	
			// Constructors
			public SkeletonBuilder(Transform root); // 0x00000001812BA310-0x00000001812BA3D0
	
			// Methods
			private void Add(HumanBodyBones key, Transform parent, Vector3 headPosition, Vector3 tailPosition); // 0x00000001812BA190-0x00000001812BA310
			private void Add(HumanBodyBones key, HumanBodyBones parentKey, Vector3 tailPosition); // 0x00000001812BA0A0-0x00000001812BA190
			public void AddHips(float height, float len); // 0x00000001812B9CC0-0x00000001812B9D30
			public void AddSpine(float len); // 0x00000001812BA060-0x00000001812BA0A0
			public void AddChest(float len); // 0x00000001812B9C20-0x00000001812B9C70
			public void AddNeck(float len); // 0x00000001812BA010-0x00000001812BA060
			public void AddHead(float len); // 0x00000001812B9C70-0x00000001812B9CC0
			public void AddArm(float shoulder, float upper, float lower, float hand); // 0x00000001812B9A20-0x00000001812B9C20
			public void AddLeg(float distance, float upper, float lower, float foot, float toe); // 0x00000001812B9D30-0x00000001812BA010
		}
	
		// Constructors
		public HumanBuilderTest(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void OnEnable(); // 0x00000001812B65D0-0x00000001812B6600
		private void BuildSkeleton(Transform root); // 0x00000001812B5E80-0x00000001812B65D0
	}
}
