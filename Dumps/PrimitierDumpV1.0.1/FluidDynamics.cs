/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class FluidDynamics : MonoBehaviour, IFixedUpdatable // TypeDefIndex: 8603
{
	// Fields
	private static float airDensity; // 0x00
	private static float waterDensity; // 0x04
	private static readonly float waterForceMlp; // 0x08
	private static readonly float waterAngularDragMlp; // 0x0C
	private static readonly float waterMaxForcePerMass; // 0x10
	private static readonly float minDensity; // 0x14
	private static readonly int bufferCount; // 0x18
	private static float sleepSpeed; // 0x1C
	private static float sleepAngularSpeed; // 0x20
	private static float speedLimit; // 0x24
	private static float angularSpeedLimit; // 0x28
	private const float root3 = 1.7320508f; // Metadata: 0x003A6C4D
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private float _UnderWaterRatio_k__BackingField; // 0x18
	private RigidbodyManager rigidbodyManager; // 0x20
	private CubeConnector cubeConnector; // 0x28
	private Vector3 prevPos; // 0x30
	private Quaternion prevRot; // 0x3C
	private Queue<Vector3> velocityBuffer; // 0x50
	[TupleElementNames] // 0x000000018002D170-0x000000018002D1F0
	private Queue<ValueTuple<Vector3, float>> angularVelocityBuffer; // 0x58
	private Vector3 buoyancyCenter; // 0x60

	// Properties
	public float UnderWaterRatio { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180304A20-0x0000000180304A30 0x0000000180304A30-0x0000000180304A40

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private struct __c__DisplayClass29_0 // TypeDefIndex: 8602
	{
		// Fields
		public float waterLevel; // 0x00
		public FluidDynamics __4__this; // 0x08
		public float maxElementForce; // 0x10
		public float underWaterRatioSum; // 0x14
		public Vector3 buoyancyPosSum; // 0x18
		public int underWaterCount; // 0x24
	}

	// Constructors
	public FluidDynamics(); // 0x0000000180304970-0x0000000180304A20
	static FluidDynamics(); // 0x0000000180304860-0x0000000180304970

	// Methods
	private void OnEnable(); // 0x0000000180303D70-0x0000000180303DD0
	private void OnDisable(); // 0x0000000180303D10-0x0000000180303D70
	public void Initialize(); // 0x0000000180303A60-0x0000000180303CD0
	public void OnFixedUpdate(); // 0x0000000180303DD0-0x0000000180304550
	private void AddLiftAndDrag(Vector3 velocityNormal, float velocitySqrMagnitude, Vector3 wingNormal, float wingArea); // 0x0000000180303330-0x0000000180303A60
	private void AddAngularDrag(); // 0x00000001803021C0-0x0000000180302A90
	private void AddBuoyancy(); // 0x0000000180302A90-0x0000000180303330
	private void OnConnectionChanged(); // 0x0000000180303CD0-0x0000000180303D10
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private void _AddBuoyancy_g__AddElementBuoyancy_29_0(Vector3 pos1, Vector3 pos2, ref __c__DisplayClass29_0 param_0000faa7); // 0x0000000180304550-0x0000000180304860
}

