/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018001D450-0x000000018001D4B0
	[HelpURL] // 0x000000018001D450-0x000000018001D4B0
	public class BipedIK : SolverManager // TypeDefIndex: 8377
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK(); // 0x00000001807C1AC0-0x00000001807C1CE0
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x00000001807C1340-0x00000001807C1380
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x00000001807C1300-0x00000001807C1340
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x00000001807C1850-0x00000001807C1890
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x00000001807C0C10-0x00000001807C0C50
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x00000001807C0D90-0x00000001807C0E00
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x00000001807C0EA0-0x00000001807C0F10
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight); // 0x00000001807C1380-0x00000001807C13F0
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight); // 0x00000001807C1470-0x00000001807C14E0
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition); // 0x00000001807C13F0-0x00000001807C1470
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation); // 0x00000001807C14E0-0x00000001807C1550
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x00000001807C0E00-0x00000001807C0EA0
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x00000001807C0F10-0x00000001807C0F80
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes); // 0x00000001807C1580-0x00000001807C15C0
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x00000001807C1550-0x00000001807C1580
		public void SetSpinePosition(Vector3 spinePosition); // 0x00000001807C15C0-0x00000001807C15F0
		public void SetSpineWeight(float weight); // 0x00000001807C15F0-0x00000001807C1620
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal); // 0x00000001807C0D20-0x00000001807C0D90
		public void InitiateBipedIK(); // 0x0000000180363790-0x00000001803637B0
		public void UpdateBipedIK(); // 0x00000001805EA8F0-0x00000001805EA910
		public void SetToDefaults(); // 0x00000001807C1620-0x00000001807C1850
		protected override void FixTransforms(); // 0x00000001807C0C50-0x00000001807C0D20
		protected override void InitiateSolver(); // 0x00000001807C0F80-0x00000001807C1300
		protected override void UpdateSolver(); // 0x00000001807C1890-0x00000001807C1AC0
		public void LogWarning(string message); // 0x00000001807805A0-0x00000001807805D0
	}
}
