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
	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 8441
	{
		// Fields
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 IKPosition; // 0x10
		[Range] // 0x000000018001F6D0-0x000000018001F730
		[Tooltip] // 0x000000018001F6D0-0x000000018001F730
		public float IKPositionWeight; // 0x1C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x20
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector] // 0x0000000180016550-0x0000000180016580
		[SerializeField] // 0x0000000180016550-0x0000000180016580
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A2B80-0x00000001802A2B90 0x000000018046DF60-0x000000018046DF70
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 8436
		{
			// Fields
			public Transform transform; // 0x10
			[Range] // 0x000000018001BE80-0x000000018001BEA0
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point(); // 0x0000000180713830-0x0000000180713870
	
			// Methods
			public void StoreDefaultLocalState(); // 0x0000000180713FF0-0x0000000180714050
			public void FixTransform(); // 0x0000000180713F00-0x0000000180713FF0
			public void UpdateSolverPosition(); // 0x00000001807140F0-0x0000000180714130
			public void UpdateSolverLocalPosition(); // 0x0000000180714050-0x0000000180714090
			public void UpdateSolverState(); // 0x0000000180714130-0x0000000180714190
			public void UpdateSolverLocalState(); // 0x0000000180714090-0x00000001807140F0
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 8437
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get; set; } // 0x000000018070F6D0-0x000000018070F7B0 0x000000018070F7B0-0x000000018070F820
	
			// Constructors
			public Bone(); // 0x000000018070F640-0x000000018070F6D0
			public Bone(Transform transform); // 0x000000018070F4F0-0x000000018070F590
			public Bone(Transform transform, float weight); // 0x000000018070F590-0x000000018070F640
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x003A6B02 */); // 0x000000018070F2E0-0x000000018070F4F0
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x003A6B06 */); // 0x000000018070EE50-0x000000018070F110
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x003A6B0A */); // 0x000000018070F110-0x000000018070F2E0
			public void SetToSolverPosition(); // 0x000000018070EE10-0x000000018070EE50
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 8438
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node(); // 0x0000000180713830-0x0000000180713870
			public Node(Transform transform); // 0x0000000180713870-0x00000001807138C0
			public Node(Transform transform, float weight); // 0x00000001807137D0-0x0000000180713830
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 8439; 0x000000018070FF10-0x0000000180710080
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 8440; 0x0000000180710AC0-0x0000000180710D70
	
		// Constructors
		protected IKSolver(); // 0x0000000180876E30-0x0000000180876E50
	
		// Methods
		public bool IsValid(); // 0x0000000180876900-0x0000000180876970
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root); // 0x0000000180876790-0x0000000180876900
		public void Update(); // 0x0000000180876DC0-0x0000000180876E30
		public virtual Vector3 GetIKPosition(); // 0x0000000180713ED0-0x0000000180713EF0
		public void SetIKPosition(Vector3 position); // 0x0000000180713EF0-0x0000000180713F00
		public float GetIKPositionWeight(); // 0x000000018045D380-0x000000018045D390
		public void SetIKPositionWeight(float weight); // 0x00000001807F1310-0x00000001807F1340
		public Transform GetRoot(); // 0x00000001802BC110-0x00000001802BC120
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message); // 0x0000000180876970-0x0000000180876990
		public static Transform ContainsDuplicateBone(Bone[] bones); // 0x0000000180876590-0x00000001808766E0
		public static bool HierarchyIsValid(Bone[] bones); // 0x00000001808766E0-0x0000000180876790
		protected static float PreSolveBones(ref Bone[] bones); // 0x0000000180876990-0x0000000180876DC0
	}
}
