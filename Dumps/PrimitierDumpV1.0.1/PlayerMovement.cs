/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;
using Valve.VR;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class PlayerMovement : MonoBehaviour // TypeDefIndex: 8660
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Input_Sources leftHand; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Input_Sources rightHand; // 0x1C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Vector2 direction; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private SteamVR_Action_Boolean click; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform cameraTransform; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform neck; // 0x38
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private VRIK vrik; // 0x40
	public static float baseSpeed; // 0x00
	private static readonly float jumpPower; // 0x04
	private static readonly float groundMovePowerMlp; // 0x08
	private static readonly float airMovePowerMlp; // 0x0C
	private static readonly float maxGroundMovePower; // 0x10
	private static readonly float maxAirMovePower; // 0x14
	private static readonly float groundMoveMaxHeight; // 0x18
	private static readonly float airMoveMaxHeight; // 0x1C
	private static readonly float jumpCoolTime; // 0x20
	private static readonly float stepAngle; // 0x24
	private static readonly float switchSpeed; // 0x28
	private static readonly float fullTiltThreshold; // 0x2C
	private static readonly float movingThreshold; // 0x30
	private static readonly float touchpadMaxPoint; // 0x34
	private static readonly float footFrictionOnStop; // 0x38
	private static readonly float footFrictionOnMove; // 0x3C
	private Rigidbody rb; // 0x48
	private CapsuleCollider bodyCol; // 0x50
	private UnityEngine.SphereCollider footCol; // 0x58
	private PlayerWaterForce waterForce; // 0x60
	private float jumpTimer; // 0x68
	private bool prevRightHandClick; // 0x6C
	private Vector2 prevRightHandDirection; // 0x70

	// Constructors
	public PlayerMovement(); // 0x0000000180265240-0x0000000180265250
	static PlayerMovement(); // 0x000000018048BE70-0x000000018048BFF0

	// Methods
	private void Start(); // 0x000000018048BC50-0x000000018048BCF0
	private void FixedUpdate(); // 0x000000018048A210-0x000000018048A960
	private void Move(Vector2 axis); // 0x000000018048B3D0-0x000000018048BAA0
	private void Jump(); // 0x000000018048AD80-0x000000018048B020
	private bool IsGrounded(out RaycastHit hit); // 0x000000018048AC10-0x000000018048AD80
	private void InputDirection(); // 0x000000018048A960-0x000000018048AC10
	private void SwitchStandAndHover(bool isHover); // 0x000000018048BCF0-0x000000018048BE70
	private void MoveCollider(); // 0x000000018048B020-0x000000018048B3D0
	public void ResetIK(); // 0x000000018048BAA0-0x000000018048BC50
}

