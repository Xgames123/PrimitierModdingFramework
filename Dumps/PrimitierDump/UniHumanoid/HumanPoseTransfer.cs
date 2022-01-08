/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class HumanPoseTransfer : MonoBehaviour // TypeDefIndex: 5959
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public HumanPoseTransferSourceType SourceType; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Avatar Avatar; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public HumanPoseTransfer Source; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public HumanPoseClip PoseClip; // 0x30
		private HumanPoseHandler m_handler; // 0x38
		private HumanPose m_pose; // 0x40
		private int m_lastFrameCount; // 0x68
	
		// Nested types
		public enum HumanPoseTransferSourceType // TypeDefIndex: 5958
		{
			None = 0,
			HumanPoseTransfer = 1,
			HumanPoseClip = 2
		}
	
		// Constructors
		public HumanPoseTransfer(); // 0x00000001812B71A0-0x00000001812B71B0
	
		// Methods
		public HumanPose CreatePose(); // 0x00000001812B6700-0x00000001812B67E0
		public void SetPose(HumanPose pose); // 0x00000001812B6AF0-0x00000001812B6BA0
		public static void SetPose(Avatar avatar, Transform transform, HumanPose pose); // 0x00000001812B6A60-0x00000001812B6AF0
		public static void SetTPose(Avatar avatar, Transform transform); // 0x00000001812B6BA0-0x00000001812B6CC0
		private void Reset(); // 0x00000001812B69C0-0x00000001812B6A60
		[ContextMenu] // 0x000000018004DF90-0x000000018004DFC0
		private void SetTPose(); // 0x00000001812B6CC0-0x00000001812B6E40
		public void OnEnable(); // 0x00000001812B6910-0x00000001812B69C0
		public void Setup(); // 0x00000001812B6E40-0x00000001812B6F00
		public bool GetPose(int frameCount, ref HumanPose pose); // 0x00000001812B67E0-0x00000001812B6910
		private void Update(); // 0x00000001812B6F00-0x00000001812B71A0
	}
}
