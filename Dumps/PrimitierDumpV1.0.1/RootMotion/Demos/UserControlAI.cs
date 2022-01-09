/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class UserControlAI : UserControlThirdPerson // TypeDefIndex: 8370
	{
		// Fields
		public Transform moveTarget; // 0x48
		public float stoppingDistance; // 0x50
		public float stoppingThreshold; // 0x54
		public Navigator navigator; // 0x58
	
		// Constructors
		public UserControlAI(); // 0x000000018071A5C0-0x000000018071A5E0
	
		// Methods
		protected override void Start(); // 0x000000018071A2A0-0x000000018071A300
		protected override void Update(); // 0x000000018071A300-0x000000018071A5C0
		private void OnDrawGizmos(); // 0x000000018071A270-0x000000018071A2A0
	}
}
