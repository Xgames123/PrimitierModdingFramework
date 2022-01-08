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
	[AddComponentMenu] // 0x0000000180021BB0-0x0000000180021C10
	[HelpURL] // 0x0000000180021BB0-0x0000000180021C10
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 8504
	{
		// Fields
		[Range] // 0x000000018001C5E0-0x000000018001C600
		public float twistLimit; // 0x38
		[Range] // 0x0000000180021C10-0x0000000180021C30
		public int smoothIterations; // 0x3C
		[HideInInspector] // 0x0000000180016550-0x0000000180016580
		[SerializeField] // 0x0000000180016550-0x0000000180016580
		public LimitPoint[] points; // 0x40
		[HideInInspector] // 0x0000000180016550-0x0000000180016580
		[SerializeField] // 0x0000000180016550-0x0000000180016580
		public Vector3[] P; // 0x48
		[HideInInspector] // 0x0000000180016550-0x0000000180016580
		[SerializeField] // 0x0000000180016550-0x0000000180016580
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 8502
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get; } // 0x00000001808495D0-0x0000000180849610 
			public Vector3 a { get; } // 0x0000000180849500-0x0000000180849540 
			public Vector3 b { get; } // 0x0000000180849540-0x0000000180849580 
			public Vector3 c { get; } // 0x0000000180849580-0x00000001808495C0 
			public bool isValid { get; } // 0x00000001808495C0-0x00000001808495D0 
	
			// Constructors
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c); // 0x0000000180849370-0x0000000180849500
	
			// Methods
			public void Calculate(); // 0x00000001808490F0-0x0000000180849370
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 8503
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint(); // 0x00000001808444E0-0x0000000180844520
		}
	
		// Constructors
		public RotationLimitPolygonal(); // 0x000000018077FF70-0x000000018077FFE0
	
		// Methods
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018077ECA0-0x000000018077ECE0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018077EC60-0x000000018077ECA0
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018077FDD0-0x000000018077FE10
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x000000018077E0B0-0x000000018077E0F0
		public void SetLimitPoints(LimitPoint[] points); // 0x000000018077F250-0x000000018077F2D0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018077E850-0x000000018077E940
		private void Start(); // 0x000000018077FB00-0x000000018077FDD0
		public void ResetToDefault(); // 0x000000018077EDF0-0x000000018077F250
		public void BuildReachCones(); // 0x000000018077E0F0-0x000000018077E660
		private Vector3[] SmoothPoints(); // 0x000000018077F2D0-0x000000018077FB00
		private float GetScalar(int k); // 0x000000018077E800-0x000000018077E850
		private Vector3 PointToTangentPlane(Vector3 p, float r); // 0x000000018077ECE0-0x000000018077EDF0
		private Vector3 TangentPointToSphere(Vector3 q, float r); // 0x000000018077FE10-0x000000018077FF70
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018077E940-0x000000018077EC60
		private int GetReachCone(Vector3 L); // 0x000000018077E660-0x000000018077E800
	}
}
