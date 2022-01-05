/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	public class JTakeScreenshot : MonoBehaviour // TypeDefIndex: 8745
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private KeyCode hotKey; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string fileNamePrefix; // 0x20
	
		// Properties
		public KeyCode HotKey { get; set; } // 0x0000000180268FB0-0x0000000180268FC0 0x00000001802AC1A0-0x00000001802AC1B0
		public string FileNamePrefix { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _CrTakeScreenshot_d__10 : IEnumerator<object> // TypeDefIndex: 8744
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public JTakeScreenshot __4__this; // 0x20
			private Texture2D _texture_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _CrTakeScreenshot_d__10(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001808853C0-0x0000000180885B40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180885B40-0x0000000180885B80
		}
	
		// Constructors
		public JTakeScreenshot(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Reset(); // 0x0000000180315E50-0x0000000180315EB0
		private void Update(); // 0x0000000180315EB0-0x0000000180315F30
		[IteratorStateMachine] // 0x000000018002E380-0x000000018002E3D0
		private IEnumerator CrTakeScreenshot(); // 0x0000000180315DE0-0x0000000180315E50
	}
}
