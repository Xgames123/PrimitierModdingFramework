/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001D160-0x000000018001D1B0
	public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 8369
	{
		// Fields
		[SerializeField] // 0x000000018001D1B0-0x000000018001D1F0
		[Tooltip] // 0x000000018001D1B0-0x000000018001D1F0
		private CameraController cameraController; // 0x18
		[SerializeField] // 0x000000018001D1F0-0x000000018001D230
		[Tooltip] // 0x000000018001D1F0-0x000000018001D230
		private float accelerationTime; // 0x20
		[SerializeField] // 0x000000018001D230-0x000000018001D280
		[Tooltip] // 0x000000018001D230-0x000000018001D280
		private float turnTime; // 0x24
		[SerializeField] // 0x000000018001D280-0x000000018001D2D0
		[Tooltip] // 0x000000018001D280-0x000000018001D2D0
		private bool walkByDefault; // 0x28
		[SerializeField] // 0x000000018001D2D0-0x000000018001D320
		[Tooltip] // 0x000000018001D2D0-0x000000018001D320
		private RotationMode rotationMode; // 0x2C
		[SerializeField] // 0x000000018001D320-0x000000018001D360
		[Tooltip] // 0x000000018001D320-0x000000018001D360
		private float moveSpeed; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isGrounded_k__BackingField; // 0x34
		private Animator animator; // 0x38
		private float speed; // 0x40
		private float angleVel; // 0x44
		private float speedVel; // 0x48
		private Vector3 linearTargetDirection; // 0x4C
		private CharacterController characterController; // 0x58
	
		// Properties
		public bool isGrounded { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802DFC20-0x00000001802DFC30 0x00000001807176D0-0x00000001807176E0
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 8368
		{
			Smooth = 0,
			Linear = 1
		}
	
		// Constructors
		public SimpleLocomotion(); // 0x00000001807176B0-0x00000001807176D0
	
		// Methods
		private void Start(); // 0x00000001807175D0-0x0000000180717650
		private void Update(); // 0x0000000180717650-0x00000001807176B0
		private void LateUpdate(); // 0x0000000180716F00-0x0000000180716F40
		private void Rotate(); // 0x0000000180717200-0x00000001807175D0
		private void Move(); // 0x0000000180716F40-0x0000000180717200
		private Vector3 GetInputVector(); // 0x0000000180716E40-0x0000000180716F00
		private Vector3 GetInputVectorRaw(); // 0x0000000180716DC0-0x0000000180716E40
	}
}
