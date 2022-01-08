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
	public class UserControlThirdPerson : MonoBehaviour // TypeDefIndex: 8372
	{
		// Fields
		public bool walkByDefault; // 0x18
		public bool canCrouch; // 0x19
		public bool canJump; // 0x1A
		public State state; // 0x1C
		protected Transform cam; // 0x40
	
		// Nested types
		public struct State // TypeDefIndex: 8371
		{
			// Fields
			public Vector3 move; // 0x00
			public Vector3 lookPos; // 0x0C
			public bool crouch; // 0x18
			public bool jump; // 0x19
			public int actionIndex; // 0x1C
		}
	
		// Constructors
		public UserControlThirdPerson(); // 0x000000018071ABB0-0x000000018071ABC0
	
		// Methods
		protected virtual void Start(); // 0x000000018071A850-0x000000018071A880
		protected virtual void Update(); // 0x000000018071A880-0x000000018071ABB0
	}
}
