/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class LoadingSequence : MonoBehaviour // TypeDefIndex: 8641
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Grabber grabberL; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Grabber grabberR; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform cameraRig; // 0x28
	private static LoadingSequence instance; // 0x00

	// Properties
	public static LoadingSequence Instance { get; } // 0x0000000180476D70-0x0000000180476E40 

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _Load_d__7 : IEnumerator<object> // TypeDefIndex: 8640
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public LoadingSequence __4__this; // 0x20
		public TextMeshPro infoText; // 0x28
		public GameObject[] enableObjects; // 0x30
		public GameObject[] destroyObjects; // 0x38
		private SaveAndLoad.SaveData _saveData_5__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _Load_d__7(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x00000001808864D0-0x0000000180887640
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x0000000180887640-0x0000000180887680
	}

	// Constructors
	public LoadingSequence(); // 0x0000000180265240-0x0000000180265250

	// Methods
	public void StartLoading(TextMeshPro infoText, GameObject[] destroyObjects, GameObject[] enableObjects); // 0x0000000180476CC0-0x0000000180476D70
	[IteratorStateMachine] // 0x000000018002D630-0x000000018002D680
	private IEnumerator Load(TextMeshPro infoText, GameObject[] destroyObjects, GameObject[] enableObjects); // 0x0000000180476C20-0x0000000180476CC0
	public Vector3 CalcInitialSpawnPoint(); // 0x0000000180476B20-0x0000000180476C20
}

