/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 8499
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Quaternion defaultLocalRotation; // 0x24
		private bool initiated; // 0x34
		private bool applicationQuit; // 0x35
		private bool defaultLocalRotationSet; // 0x36
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x00000001807806C0-0x00000001807806E0 
		public Vector3 crossAxis { get; } // 0x0000000180780650-0x00000001807806C0 
	
		// Constructors
		protected RotationLimit(); // 0x0000000180780610-0x0000000180780650
	
		// Methods
		public void SetDefaultLocalRotation(); // 0x00000001807805D0-0x0000000180780610
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed); // 0x0000000180780290-0x00000001807803B0
		public bool Apply(); // 0x000000018077FFE0-0x0000000180780160
		public void Disable(); // 0x0000000180780260-0x0000000180780290
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake(); // 0x0000000180780160-0x0000000180780260
		private void LateUpdate(); // 0x0000000180780430-0x00000001807805A0
		public void LogWarning(string message); // 0x00000001807805A0-0x00000001807805D0
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x0000000180714E40-0x0000000180714F10
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x00000001807158A0-0x0000000180715A80
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal); // 0x00000001807803B0-0x0000000180780430
	}
}
