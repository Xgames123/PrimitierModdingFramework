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
	public struct CCDIKJob : IAnimationJob // TypeDefIndex: 8418
	{
		// Fields
		public TransformSceneHandle _target; // 0x00
		public PropertySceneHandle _IKPositionWeight; // 0x08
		public PropertySceneHandle _maxIterations; // 0x10
		public PropertySceneHandle _tolerance; // 0x18
		public PropertySceneHandle _XY; // 0x20
		public PropertySceneHandle _useRotationLimits; // 0x28
		private NativeArray<TransformStreamHandle> bones; // 0x30
		private NativeArray<PropertySceneHandle> boneWeights; // 0x40
		private NativeArray<float> boneSqrMags; // 0x50
		private float chainSqrMag; // 0x60
		private Vector3 lastLocalDirection; // 0x64
		private NativeArray<Quaternion> limitDefaultLocalRotationArray; // 0x70
		private NativeArray<Vector3> limitAxisArray; // 0x80
		private NativeArray<int> hingeFlags; // 0x90
		private NativeArray<PropertySceneHandle> hingeMinArray; // 0xA0
		private NativeArray<PropertySceneHandle> hingeMaxArray; // 0xB0
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray; // 0xC0
		private NativeArray<Quaternion> hingeLastRotations; // 0xD0
		private NativeArray<float> hingeLastAngles; // 0xE0
		private NativeArray<int> angleFlags; // 0xF0
		private NativeArray<Vector3> angleSecondaryAxisArray; // 0x100
		private NativeArray<PropertySceneHandle> angleLimitArray; // 0x110
		private NativeArray<PropertySceneHandle> angleTwistLimitArray; // 0x120
	
		// Methods
		public void Setup(Animator animator, Transform[] bones, Transform target); // 0x00000001807CD5B0-0x00000001807CDAD0
		private void SetUpRotationLimits(Animator animator, Transform[] bones); // 0x00000001807CCD10-0x00000001807CD5B0
		private void DisposeRotationLimits(); // 0x00000001807CC3F0-0x00000001807CC530
		public void ProcessRootMotion(AnimationStream stream); // 0x0000000180265310-0x0000000180265320
		public void ProcessAnimation(AnimationStream stream); // 0x00000001807CCB10-0x00000001807CCB50
		private void Update(AnimationStream s); // 0x00000001807CE850-0x00000001807CEE90
		private void Read(AnimationStream s); // 0x00000001807CCB50-0x00000001807CCD10
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits); // 0x00000001807CDCE0-0x00000001807CE850
		private Vector3 GetLocalDirection(AnimationStream s); // 0x00000001807CC5B0-0x00000001807CC790
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection); // 0x00000001807CC790-0x00000001807CC7F0
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits); // 0x00000001807CC7F0-0x00000001807CCB10
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition); // 0x00000001807CDAD0-0x00000001807CDCE0
		public void Dispose(); // 0x00000001807CC530-0x00000001807CC5B0
	}
}
