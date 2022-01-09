/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public class GenericPoser : Poser // TypeDefIndex: 8492
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 8491
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map(Transform bone, Transform target); // 0x0000000180713750-0x00000001807137D0
	
			// Methods
			public void StoreDefaultState(); // 0x000000018070E270-0x000000018070E2D0
			public void FixTransform(); // 0x0000000180713540-0x00000001807135A0
			public void Update(float localRotationWeight, float localPositionWeight); // 0x00000001807135A0-0x0000000180713750
		}
	
		// Constructors
		public GenericPoser(); // 0x0000000180824270-0x0000000180824280
	
		// Methods
		[ContextMenu] // 0x0000000180021930-0x0000000180021960
		public override void AutoMapping(); // 0x0000000180823CA0-0x0000000180823FA0
		protected override void InitiatePoser(); // 0x00000001808240D0-0x00000001808240E0
		protected override void UpdatePoser(); // 0x0000000180824160-0x0000000180824270
		protected override void FixPoserTransforms(); // 0x0000000180823FA0-0x0000000180824020
		private void StoreDefaultState(); // 0x00000001808240E0-0x0000000180824160
		private Transform GetTargetNamed(string tName, Transform[] array); // 0x0000000180824020-0x00000001808240D0
	}
}
