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
	public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 8367
	{
		// Fields
		[Header] // 0x000000018001D060-0x000000018001D090
		public CharacterAnimationBase characterAnimation; // 0x68
		public UserControlThirdPerson userControl; // 0x70
		public CameraController cam; // 0x78
		[Header] // 0x000000018001D090-0x000000018001D0C0
		public MoveMode moveMode; // 0x80
		public bool smoothPhysics; // 0x84
		public float smoothAccelerationTime; // 0x88
		public float linearAccelerationSpeed; // 0x8C
		public float platformFriction; // 0x90
		public float groundStickyEffect; // 0x94
		public float maxVerticalVelocityOnGround; // 0x98
		public float velocityToGroundTangentWeight; // 0x9C
		[Header] // 0x000000018001BDF0-0x000000018001BE20
		public bool lookInCameraDirection; // 0xA0
		public float turnSpeed; // 0xA4
		public float stationaryTurnSpeedMlp; // 0xA8
		[Header] // 0x000000018001D0C0-0x000000018001D0F0
		public float airSpeed; // 0xAC
		public float airControl; // 0xB0
		public float jumpPower; // 0xB4
		public float jumpRepeatDelayTime; // 0xB8
		public bool doubleJumpEnabled; // 0xBC
		public float doubleJumpPowerMlp; // 0xC0
		[Header] // 0x000000018001D0F0-0x000000018001D130
		[SerializeField] // 0x000000018001D0F0-0x000000018001D130
		private LayerMask wallRunLayers; // 0xC4
		public float wallRunMaxLength; // 0xC8
		public float wallRunMinMoveMag; // 0xCC
		public float wallRunMinVelocityY; // 0xD0
		public float wallRunRotationSpeed; // 0xD4
		public float wallRunMaxRotationAngle; // 0xD8
		public float wallRunWeightSpeed; // 0xDC
		[Header] // 0x000000018001D130-0x000000018001D160
		public float crouchCapsuleScaleMlp; // 0xE0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _onGround_k__BackingField; // 0xE4
		public AnimState animState; // 0xE8
		protected Vector3 moveDirection; // 0x100
		private Animator animator; // 0x110
		private Vector3 normal; // 0x118
		private Vector3 platformVelocity; // 0x124
		private Vector3 platformAngularVelocity; // 0x130
		private RaycastHit hit; // 0x13C
		private float jumpLeg; // 0x168
		private float jumpEndTime; // 0x16C
		private float forwardMlp; // 0x170
		private float groundDistance; // 0x174
		private float lastAirTime; // 0x178
		private float stickyForce; // 0x17C
		private Vector3 wallNormal; // 0x180
		private Vector3 moveDirectionVelocity; // 0x18C
		private float wallRunWeight; // 0x198
		private float lastWallRunWeight; // 0x19C
		private Vector3 fixedDeltaPosition; // 0x1A0
		private Quaternion fixedDeltaRotation; // 0x1AC
		private bool fixedFrame; // 0x1BC
		private float wallRunEndTime; // 0x1C0
		private Vector3 gravity; // 0x1C4
		private Vector3 verticalVelocity; // 0x1D0
		private float velocityY; // 0x1DC
		private bool doubleJumped; // 0x1E0
		private bool jumpReleased; // 0x1E1
	
		// Properties
		public bool onGround { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180381520-0x0000000180381530 0x0000000180381640-0x0000000180381650
	
		// Nested types
		[Serializable]
		public enum MoveMode // TypeDefIndex: 8365
		{
			Directional = 0,
			Strafe = 1
		}
	
		public struct AnimState // TypeDefIndex: 8366
		{
			// Fields
			public Vector3 moveDirection; // 0x00
			public bool jump; // 0x0C
			public bool crouch; // 0x0D
			public bool onGround; // 0x0E
			public bool isStrafing; // 0x0F
			public float yVelocity; // 0x10
			public bool doubleJump; // 0x14
		}
	
		// Constructors
		public CharacterThirdPerson(); // 0x0000000180814C40-0x0000000180814D50
	
		// Methods
		protected override void Start(); // 0x00000001808141B0-0x0000000180814320
		private void OnAnimatorMove(); // 0x0000000180813CE0-0x0000000180813D80
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation); // 0x0000000180813C20-0x0000000180813CE0
		private void FixedUpdate(); // 0x0000000180812250-0x0000000180812990
		protected virtual void Update(); // 0x0000000180814320-0x00000001808143E0
		protected virtual void LateUpdate(); // 0x0000000180813570-0x0000000180813650
		private void MoveFixed(Vector3 deltaPosition); // 0x0000000180813650-0x0000000180813C20
		private void WallRun(); // 0x00000001808143E0-0x0000000180814C40
		private bool CanWallRun(); // 0x00000001808121B0-0x0000000180812250
		private Vector3 GetMoveDirection(); // 0x0000000180812B90-0x0000000180812E90
		protected virtual void Rotate(); // 0x0000000180813D80-0x00000001808141B0
		private Vector3 GetForwardDirection(); // 0x0000000180812990-0x0000000180812B90
		protected virtual bool Jump(); // 0x0000000180813370-0x0000000180813570
		private void GroundCheck(); // 0x0000000180812E90-0x0000000180813370
	}
}
