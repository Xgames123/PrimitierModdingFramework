/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public struct AimIKJob : IAnimationJob // TypeDefIndex: 8416
	{
		// Fields
		public TransformSceneHandle _target; // 0x00
		public TransformSceneHandle _poleTarget; // 0x08
		public TransformStreamHandle _transform; // 0x10
		public PropertySceneHandle _IKPositionWeight; // 0x1C
		public PropertySceneHandle _poleWeight; // 0x24
		public PropertySceneHandle _axisX; // 0x2C
		public PropertySceneHandle _axisY; // 0x34
		public PropertySceneHandle _axisZ; // 0x3C
		public PropertySceneHandle _poleAxisX; // 0x44
		public PropertySceneHandle _poleAxisY; // 0x4C
		public PropertySceneHandle _poleAxisZ; // 0x54
		public PropertySceneHandle _clampWeight; // 0x5C
		public PropertySceneHandle _clampSmoothing; // 0x64
		public PropertySceneHandle _maxIterations; // 0x6C
		public PropertySceneHandle _tolerance; // 0x74
		public PropertySceneHandle _XY; // 0x7C
		public PropertySceneHandle _useRotationLimits; // 0x84
		private NativeArray<TransformStreamHandle> bones; // 0x90
		private NativeArray<PropertySceneHandle> boneWeights; // 0xA0
		private Vector3 lastLocalDirection; // 0xB0
		private float step; // 0xBC
		private NativeArray<Quaternion> limitDefaultLocalRotationArray; // 0xC0
		private NativeArray<Vector3> limitAxisArray; // 0xD0
		private NativeArray<int> hingeFlags; // 0xE0
		private NativeArray<PropertySceneHandle> hingeMinArray; // 0xF0
		private NativeArray<PropertySceneHandle> hingeMaxArray; // 0x100
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray; // 0x110
		private NativeArray<Quaternion> hingeLastRotations; // 0x120
		private NativeArray<float> hingeLastAngles; // 0x130
		private NativeArray<int> angleFlags; // 0x140
		private NativeArray<Vector3> angleSecondaryAxisArray; // 0x150
		private NativeArray<PropertySceneHandle> angleLimitArray; // 0x160
		private NativeArray<PropertySceneHandle> angleTwistLimitArray; // 0x170
	
		// Methods
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform); // 0x00000001807BC080-0x00000001807BC830
		private void SetUpRotationLimits(Animator animator, Transform[] bones); // 0x00000001807BB7D0-0x00000001807BC080
		private void DisposeRotationLimits(); // 0x00000001807BA2D0-0x00000001807BA410
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000180265310-0x0000000180265320
		public void ProcessAnimation(AnimationStream stream); // 0x00000001807BAB20-0x00000001807BAB60
		private void Update(AnimationStream s); // 0x00000001807BC830-0x00000001807BD6C0
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis); // 0x00000001807BAB60-0x00000001807BB7D0
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition); // 0x00000001807BA480-0x00000001807BA5E0
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis); // 0x00000001807BA5E0-0x00000001807BA9C0
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis); // 0x00000001807BA9C0-0x00000001807BAAB0
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection); // 0x00000001807BAAB0-0x00000001807BAB20
		public void Dispose(); // 0x00000001807BA410-0x00000001807BA480
	}
}
