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
	public class AnimationWarping : OffsetModifier // TypeDefIndex: 8309
	{
		// Fields
		[Tooltip] // 0x000000018001C140-0x000000018001C170
		public Animator animator; // 0x30
		[Tooltip] // 0x000000018001C170-0x000000018001C1A0
		public EffectorMode effectorMode; // 0x38
		[Space] // 0x000000018001C1A0-0x000000018001C1F0
		[Tooltip] // 0x000000018001C1A0-0x000000018001C1F0
		public Warp[] warps; // 0x40
		private EffectorMode lastMode; // 0x48
	
		// Nested types
		[Serializable]
		public struct Warp // TypeDefIndex: 8307
		{
			// Fields
			[Tooltip] // 0x000000018001C1F0-0x000000018001C220
			public int animationLayer; // 0x00
			[Tooltip] // 0x000000018001C220-0x000000018001C250
			public string animationState; // 0x08
			[Tooltip] // 0x000000018001C250-0x000000018001C280
			public AnimationCurve weightCurve; // 0x10
			[Tooltip] // 0x000000018001C280-0x000000018001C2B0
			public Transform warpFrom; // 0x18
			[Tooltip] // 0x000000018001C2B0-0x000000018001C2E0
			public Transform warpTo; // 0x20
			[Tooltip] // 0x000000018001C2E0-0x000000018001C310
			public FullBodyBipedEffector effector; // 0x28
		}
	
		[Serializable]
		public enum EffectorMode // TypeDefIndex: 8308
		{
			PositionOffset = 0,
			Position = 1
		}
	
		// Constructors
		public AnimationWarping(); // 0x00000001807BDCD0-0x00000001807BDCE0
	
		// Methods
		protected override void Start(); // 0x00000001807BE480-0x00000001807BE4A0
		public float GetWarpWeight(int warpIndex); // 0x00000001807BDCE0-0x00000001807BDF80
		protected override void OnModifyOffset(); // 0x00000001807BE030-0x00000001807BE480
		private void OnDisable(); // 0x00000001807BDF80-0x00000001807BE030
	}
}
