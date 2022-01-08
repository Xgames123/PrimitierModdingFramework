/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class HandRig : MonoBehaviour // TypeDefIndex: 5928
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Animator m_animator; // 0x18
		[FormerlySerializedAs] // 0x000000018004DD50-0x000000018004DDB0
		[Range] // 0x000000018004DD50-0x000000018004DDB0
		[SerializeField] // 0x000000018004DD50-0x000000018004DDB0
		public float LeftStretch; // 0x20
		[Range] // 0x000000018004DDB0-0x000000018004DDF0
		[SerializeField] // 0x000000018004DDB0-0x000000018004DDF0
		public float LeftSpread; // 0x24
		[FormerlySerializedAs] // 0x000000018004DDF0-0x000000018004DE60
		[Range] // 0x000000018004DDF0-0x000000018004DE60
		[SerializeField] // 0x000000018004DDF0-0x000000018004DE60
		public float RightStretch; // 0x28
		[Range] // 0x000000018004DE60-0x000000018004DEA0
		[SerializeField] // 0x000000018004DE60-0x000000018004DEA0
		public float RightSpread; // 0x2C
		private HumanPoseHandler m_handler; // 0x30
		private HandPoseModifier m_updater; // 0x38
		private HandPoseModifier.HandPose m_leftHand; // 0x40
		private HandPoseModifier.HandPose m_rightHand; // 0x48
		private HumanPose m_pose; // 0x50
	
		// Properties
		public Animator Animator { get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Constructors
		public HandRig(); // 0x00000001812B5E00-0x00000001812B5E80
	
		// Methods
		private void Reset(); // 0x00000001812B5BC0-0x00000001812B5C00
		public static HumanPoseHandler GetHandler(Animator animator); // 0x00000001812B5A60-0x00000001812B5BC0
		private void Awake(); // 0x00000001812B58B0-0x00000001812B5A60
		private void Update(); // 0x00000001812B5C00-0x00000001812B5E00
	}
}
