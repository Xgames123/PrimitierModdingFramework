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
	public class Grounding // TypeDefIndex: 8400
	{
		// Fields
		[Tooltip] // 0x000000018001DF80-0x000000018001DFB0
		public LayerMask layers; // 0x10
		[Tooltip] // 0x000000018001DFB0-0x000000018001DFE0
		public float maxStep; // 0x14
		[Tooltip] // 0x000000018001DFE0-0x000000018001E010
		public float heightOffset; // 0x18
		[Tooltip] // 0x000000018001E010-0x000000018001E040
		public float footSpeed; // 0x1C
		[Tooltip] // 0x000000018001E040-0x000000018001E070
		public float footRadius; // 0x20
		[HideInInspector] // 0x000000018001E070-0x000000018001E0C0
		[Tooltip] // 0x000000018001E070-0x000000018001E0C0
		public float footCenterOffset; // 0x24
		[Tooltip] // 0x000000018001E0C0-0x000000018001E0F0
		public float prediction; // 0x28
		[Range] // 0x000000018001E0F0-0x000000018001E150
		[Tooltip] // 0x000000018001E0F0-0x000000018001E150
		public float footRotationWeight; // 0x2C
		[Tooltip] // 0x000000018001E150-0x000000018001E180
		public float footRotationSpeed; // 0x30
		[Range] // 0x000000018001E180-0x000000018001E1E0
		[Tooltip] // 0x000000018001E180-0x000000018001E1E0
		public float maxFootRotationAngle; // 0x34
		[Tooltip] // 0x000000018001E1E0-0x000000018001E210
		public bool rotateSolver; // 0x38
		[Tooltip] // 0x000000018001E210-0x000000018001E240
		public float pelvisSpeed; // 0x3C
		[Range] // 0x000000018001E240-0x000000018001E290
		[Tooltip] // 0x000000018001E240-0x000000018001E290
		public float pelvisDamper; // 0x40
		[Tooltip] // 0x000000018001E290-0x000000018001E2C0
		public float lowerPelvisWeight; // 0x44
		[Tooltip] // 0x000000018001E2C0-0x000000018001E2F0
		public float liftPelvisWeight; // 0x48
		[Tooltip] // 0x000000018001E2F0-0x000000018001E320
		public float rootSphereCastRadius; // 0x4C
		[Tooltip] // 0x000000018001E320-0x000000018001E350
		public bool overstepFallsDown; // 0x50
		[Tooltip] // 0x000000018001E350-0x000000018001E380
		public Quality quality; // 0x54
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Leg[] _legs_k__BackingField; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Pelvis _pelvis_k__BackingField; // 0x60
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _isGrounded_k__BackingField; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Transform _root_k__BackingField; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private RaycastHit _rootHit_k__BackingField; // 0x78
		private bool initiated; // 0xA4
	
		// Properties
		public Leg[] legs { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802BF820-0x00000001802BF890 0x00000001802C6D60-0x00000001802C6D70
		public Pelvis pelvis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		public bool isGrounded { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803133D0-0x00000001803133E0 0x0000000180313A10-0x0000000180313A20
		public Transform root { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802DC790-0x00000001802DC800 0x0000000180422040-0x0000000180422050
		public RaycastHit rootHit { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180864630-0x0000000180864660 0x0000000180864760-0x0000000180864790
		public bool rootGrounded { get; } // 0x00000001808645D0-0x0000000180864630 
		public Vector3 up { get; } // 0x0000000180864660-0x00000001808646D0 
		private bool useRootRotation { get; } // 0x00000001808646D0-0x0000000180864760 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 8397
		{
			Fastest = 0,
			Simple = 1,
			Best = 2
		}
	
		public class Leg // TypeDefIndex: 8398
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private bool _isGrounded_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _IKPosition_k__BackingField; // 0x14
			public Quaternion rotationOffset; // 0x20
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private bool _initiated_k__BackingField; // 0x30
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _heightFromGround_k__BackingField; // 0x34
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _velocity_k__BackingField; // 0x38
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Transform _transform_k__BackingField; // 0x48
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _IKOffset_k__BackingField; // 0x50
			public bool invertFootCenter; // 0x54
			private Grounding grounding; // 0x58
			private float lastTime; // 0x60
			private float deltaTime; // 0x64
			private Vector3 lastPosition; // 0x68
			private Quaternion toHitNormal; // 0x74
			private Quaternion r; // 0x84
			private RaycastHit heelHit; // 0x94
			private Vector3 up; // 0xC0
	
			// Properties
			public bool isGrounded { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802A2940-0x00000001802A2950 0x00000001802A29C0-0x00000001802A29D0
			public Vector3 IKPosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180712F50-0x0000000180712F70 0x00000001807130F0-0x0000000180713100
			public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B730-0x000000018036B740 0x000000018036B860-0x000000018036B870
			public float heightFromGround { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180349570-0x0000000180349580 0x000000018036B520-0x000000018036B530
			public Vector3 velocity { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807109F0-0x0000000180710A10 0x0000000180710A30-0x0000000180710A40
			public Transform transform { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
			public float IKOffset { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180461EB0-0x0000000180461EC0 0x0000000180461FA0-0x0000000180461FB0
			public float stepHeightFromGround { get; } // 0x00000001807130B0-0x00000001807130F0 
			private float rootYOffset { get; } // 0x0000000180712F70-0x00000001807130B0 
	
			// Constructors
			public Leg(); // 0x0000000180712F00-0x0000000180712F50
	
			// Methods
			public void Initiate(Grounding grounding, Transform transform); // 0x0000000180711910-0x00000001807119D0
			public void OnEnable(); // 0x00000001807119D0-0x0000000180711A20
			public void Reset(); // 0x00000001807127C0-0x0000000180712850
			public void Process(); // 0x0000000180711A20-0x00000001807127C0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel); // 0x0000000180710D70-0x00000001807112C0
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel); // 0x0000000180711470-0x0000000180711840
			private Vector3 RotateNormal(Vector3 normal); // 0x0000000180712960-0x0000000180712A20
			private void SetFootToPoint(Vector3 normal, Vector3 point); // 0x0000000180712DE0-0x0000000180712F00
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint); // 0x0000000180712A20-0x0000000180712DE0
			private float GetHeightFromGround(Vector3 hitPoint); // 0x00000001807112C0-0x0000000180711470
			private void RotateFoot(); // 0x0000000180712850-0x0000000180712960
			private Quaternion GetRotationOffsetTarget(); // 0x0000000180711840-0x0000000180711910
		}
	
		public class Pelvis // TypeDefIndex: 8399
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _IKOffset_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _heightOffset_k__BackingField; // 0x1C
			private Grounding grounding; // 0x20
			private Vector3 lastRootPosition; // 0x28
			private float damperF; // 0x34
			private bool initiated; // 0x38
			private float lastTime; // 0x3C
	
			// Properties
			public Vector3 IKOffset { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180713ED0-0x0000000180713EF0 0x0000000180713EF0-0x0000000180713F00
			public float heightOffset { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018045D380-0x000000018045D390 0x000000018045FA50-0x000000018045FA60
	
			// Constructors
			public Pelvis(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Initiate(Grounding grounding); // 0x0000000180713AE0-0x0000000180713B50
			public void Reset(); // 0x0000000180713E50-0x0000000180713ED0
			public void OnEnable(); // 0x0000000180713B50-0x0000000180713BC0
			public void Process(float lowestOffset, float highestOffset, bool isGrounded); // 0x0000000180713BC0-0x0000000180713E50
		}
	
		// Constructors
		public Grounding(); // 0x0000000180864570-0x00000001808645D0
	
		// Methods
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x003A6AC9 */); // 0x0000000180863730-0x0000000180863CB0
		public bool IsValid(ref string errorMessage); // 0x0000000180864160-0x0000000180864260
		public void Initiate(Transform root, Transform[] feet); // 0x0000000180863DC0-0x0000000180864160
		public void Update(); // 0x0000000180864300-0x0000000180864570
		public Vector3 GetLegsPlaneNormal(); // 0x00000001808634A0-0x0000000180863730
		public void Reset(); // 0x0000000180864280-0x0000000180864300
		public void LogWarning(string message); // 0x0000000180864260-0x0000000180864280
		public float GetVerticalOffset(Vector3 p1, Vector3 p2); // 0x0000000180863CB0-0x0000000180863DC0
		public Vector3 Flatten(Vector3 v); // 0x00000001808632A0-0x00000001808633A0
		public Vector3 GetFootCenterOffset(); // 0x00000001808633A0-0x00000001808634A0
	}
}
