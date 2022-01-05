/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class PlayerLife : MonoBehaviour // TypeDefIndex: 8659
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private PlayerLifeDisplay playerLifeDisplay; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private PlayerMovement playerMovement; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private VRIK vrik; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Grabber grabberL; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Grabber grabberR; // 0x38
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private static float _MaxLife_k__BackingField; // 0x00
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private static float _Life_k__BackingField; // 0x04
	private float masterDamageMlp; // 0x40
	private float bodyDefense; // 0x44
	private float footDefense; // 0x48
	private float hardness; // 0x4C
	private float volumeMlp; // 0x50
	private bool isDead; // 0x54
	private CapsuleCollider bodyCol; // 0x58
	private Transform mainCamera; // 0x60

	// Properties
	public static float MaxLife { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018048A0D0-0x000000018048A130 0x000000018048A1A0-0x000000018048A210
	public static float Life { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018048A070-0x000000018048A0D0 0x000000018048A130-0x000000018048A1A0

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _FadeAndRevive_d__28 : IEnumerator<object> // TypeDefIndex: 8658
	{
		// Fields
		private int __1__state; // 0x10
		private object __2__current; // 0x18
		public PlayerLife __4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _FadeAndRevive_d__28(int __1__state); // 0x0000000180296FE0-0x0000000180297010

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x0000000180885D80-0x0000000180886060
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x0000000180886060-0x00000001808860A0
	}

	// Constructors
	public PlayerLife(); // 0x000000018048A040-0x000000018048A070
	static PlayerLife(); // 0x000000018048A000-0x000000018048A040

	// Methods
	private void Start(); // 0x0000000180489EC0-0x000000018048A000
	public void ReceiveDamage(float amount, Vector3 colPoint, float damageMlp = 1f /* Metadata: 0x003A6CEE */); // 0x0000000180488F10-0x0000000180489200
	public void Recover(float amount); // 0x0000000180489200-0x0000000180489460
	private void OnCollisionEnter(Collision collision); // 0x0000000180488A70-0x0000000180488F10
	private void ShowDamageText(float damage, float damageMlp); // 0x0000000180489A30-0x0000000180489EC0
	private void Die(); // 0x0000000180488970-0x0000000180488A00
	private void Revive(); // 0x0000000180489460-0x0000000180489A30
	[IteratorStateMachine] // 0x000000018002D7F0-0x000000018002D840
	private IEnumerator FadeAndRevive(); // 0x0000000180488A00-0x0000000180488A70
}

