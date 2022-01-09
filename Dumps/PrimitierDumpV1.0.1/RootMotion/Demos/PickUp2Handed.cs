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
	public abstract class PickUp2Handed : MonoBehaviour // TypeDefIndex: 8337
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int GUIspace; // 0x18
		public InteractionSystem interactionSystem; // 0x20
		public InteractionObject obj; // 0x28
		public Transform pivot; // 0x30
		public Transform holdPoint; // 0x38
		public float pickUpTime; // 0x40
		private float holdWeight; // 0x44
		private float holdWeightVel; // 0x48
		private Vector3 pickUpPosition; // 0x4C
		private Quaternion pickUpRotation; // 0x58
	
		// Properties
		private bool holding { get; } // 0x0000000180778C80-0x0000000180778CB0 
	
		// Constructors
		protected PickUp2Handed(); // 0x0000000180778C70-0x0000000180778C80
	
		// Methods
		private void OnGUI(); // 0x0000000180778690-0x0000000180778820
		protected abstract void RotatePivot();
		private void Start(); // 0x0000000180778AA0-0x0000000180778C70
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000180778820-0x00000001807789C0
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x00000001807789C0-0x0000000180778AA0
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000180778560-0x0000000180778690
		private void LateUpdate(); // 0x0000000180778180-0x0000000180778350
		private void OnDestroy(); // 0x0000000180778350-0x0000000180778560
	}
}
