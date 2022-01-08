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
	[Serializable]
	public class InteractionLookAt // TypeDefIndex: 8473
	{
		// Fields
		[Tooltip] // 0x0000000180020A00-0x0000000180020A30
		public LookAtIK ik; // 0x10
		[Tooltip] // 0x0000000180020A30-0x0000000180020A60
		public float lerpSpeed; // 0x18
		[Tooltip] // 0x0000000180020A60-0x0000000180020A90
		public float weightSpeed; // 0x1C
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt(); // 0x0000000180768EA0-0x0000000180768EC0
	
		// Methods
		public void Look(Transform target, float time); // 0x00000001807687D0-0x0000000180768970
		public void OnFixTransforms(); // 0x0000000180768970-0x0000000180768A10
		public void Update(); // 0x0000000180768C20-0x0000000180768EA0
		public void SolveSpine(); // 0x0000000180768AF0-0x0000000180768C20
		public void SolveHead(); // 0x0000000180768A10-0x0000000180768AF0
	}
}
