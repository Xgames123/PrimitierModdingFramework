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

public class FadeManager : MonoBehaviour // TypeDefIndex: 8685
{
	// Fields
	private static FadeManager instance; // 0x00

	// Properties
	public static FadeManager Instance { get; } // 0x0000000180301070-0x0000000180301140 

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _FadeCoroutine_d__4 : IEnumerator<object> // TypeDefIndex: 8684
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public float duration; // 0x20
		public Color endColor; // 0x24
		public Color startColor; // 0x34
		private float _t_5__2; // 0x44

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _FadeCoroutine_d__4(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x00000001808860A0-0x00000001808862C0
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x00000001808862C0-0x0000000180886300
	}

	// Constructors
	public FadeManager(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void Fade(Color startColor, Color endColor, float duration); // 0x0000000180300FC0-0x0000000180301070
	[IteratorStateMachine] // 0x000000018002D890-0x000000018002D8E0
	private IEnumerator FadeCoroutine(Color startColor, Color endColor, float duration); // 0x0000000180300F30-0x0000000180300FC0
}

