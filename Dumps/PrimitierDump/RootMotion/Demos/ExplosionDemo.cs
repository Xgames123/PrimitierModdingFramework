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
	public class ExplosionDemo : MonoBehaviour // TypeDefIndex: 8315
	{
		// Fields
		public SimpleLocomotion character; // 0x18
		public float forceMlp; // 0x20
		public float upForce; // 0x24
		public float weightFalloffSpeed; // 0x28
		public AnimationCurve weightFalloff; // 0x30
		public AnimationCurve explosionForceByDistance; // 0x38
		public AnimationCurve scale; // 0x40
		private float weight; // 0x48
		private Vector3 defaultScale; // 0x4C
		private Rigidbody r; // 0x58
		private FullBodyBipedIK ik; // 0x60
	
		// Constructors
		public ExplosionDemo(); // 0x0000000180816A00-0x0000000180816A50
	
		// Methods
		private void Start(); // 0x0000000180816370-0x0000000180816410
		private void Update(); // 0x0000000180816410-0x0000000180816A00
		private void SetEffectorWeights(float w); // 0x00000001808162B0-0x0000000180816370
	}
}
