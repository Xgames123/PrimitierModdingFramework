/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class OffsetEffector : OffsetModifier // TypeDefIndex: 8335
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x30
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 8334
		{
			// Fields
			public FullBodyBipedEffector effectorType; // 0x10
			public float weightMultiplier; // 0x14
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 localPosition; // 0x18
	
			// Constructors
			public EffectorLink(); // 0x0000000180717FE0-0x0000000180717FF0
		}
	
		// Constructors
		public OffsetEffector(); // 0x0000000180776B40-0x0000000180776B50
	
		// Methods
		protected override void Start(); // 0x00000001807769A0-0x0000000180776B40
		protected override void OnModifyOffset(); // 0x0000000180776740-0x00000001807769A0
	}
}
