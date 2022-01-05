/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class UnityResourceDestroyer : MonoBehaviour // TypeDefIndex: 5906
	{
		// Fields
		private List<UnityEngine.Object> m_resources; // 0x18
	
		// Properties
		public IList<UnityEngine.Object> Resources { get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5905
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<UnityEngine.Object> __9__4_0; // 0x08
			public static Action<UnityEngine.Object> __9__4_1; // 0x10
	
			// Constructors
			static __c(); // 0x00000001806E6E50-0x00000001806E6EB0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _DestroyResource_b__4_0(UnityEngine.Object o); // 0x00000001806E4630-0x00000001806E4690
			internal void _DestroyResource_b__4_1(UnityEngine.Object o); // 0x00000001806E4690-0x00000001806E46F0
		}
	
		// Constructors
		public UnityResourceDestroyer(); // 0x0000000180BC9B70-0x0000000180BC9BE0
	
		// Methods
		private void OnDestroy(); // 0x0000000180BC9980-0x0000000180BC9B70
		public static Action<UnityEngine.Object> DestroyResource(); // 0x0000000180BC97D0-0x0000000180BC9980
	}
}
