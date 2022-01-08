/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551
[assembly: CompilationRelaxations] // 0x000000018001BD60-0x000000018001BDC0
[assembly: Debuggable] // 0x000000018001BD60-0x000000018001BDC0
[assembly: RuntimeCompatibility] // 0x000000018001BD60-0x000000018001BDC0

namespace RootMotion
{
	public class CameraController : MonoBehaviour // TypeDefIndex: 8271
	{
		// Fields
		public Transform target; // 0x18
		public Transform rotationSpace; // 0x20
		public UpdateMode updateMode; // 0x28
		public bool lockCursor; // 0x2C
		[Header] // 0x000000018001BDC0-0x000000018001BDF0
		public bool smoothFollow; // 0x2D
		public Vector3 offset; // 0x30
		public float followSpeed; // 0x3C
		[Header] // 0x000000018001BDF0-0x000000018001BE20
		public float rotationSensitivity; // 0x40
		public float yMinLimit; // 0x44
		public float yMaxLimit; // 0x48
		public bool rotateAlways; // 0x4C
		public bool rotateOnLeftButton; // 0x4D
		public bool rotateOnRightButton; // 0x4E
		public bool rotateOnMiddleButton; // 0x4F
		[Header] // 0x000000018001BE20-0x000000018001BE50
		public float distance; // 0x50
		public float minDistance; // 0x54
		public float maxDistance; // 0x58
		public float zoomSpeed; // 0x5C
		public float zoomSensitivity; // 0x60
		[Header] // 0x000000018001BE50-0x000000018001BE80
		public LayerMask blockingLayers; // 0x64
		public float blockingRadius; // 0x68
		public float blockingSmoothTime; // 0x6C
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float blockedOffset; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _x_k__BackingField; // 0x74
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _y_k__BackingField; // 0x78
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _distanceTarget_k__BackingField; // 0x7C
		private Vector3 targetDistance; // 0x80
		private Vector3 position; // 0x8C
		private Quaternion rotation; // 0x98
		private Vector3 smoothPosition; // 0xA8
		private Camera cam; // 0xB8
		private bool fixedFrame; // 0xC0
		private float fixedDeltaTime; // 0xC4
		private Quaternion r; // 0xC8
		private Vector3 lastUp; // 0xD8
		private float blockedDistance; // 0xE4
		private float blockedDistanceV; // 0xE8
	
		// Properties
		public float x { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180313850-0x0000000180313860 0x0000000180783AB0-0x0000000180783AC0
		public float y { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807CFDB0-0x00000001807CFDC0 0x0000000180783A80-0x0000000180783A90
		public float distanceTarget { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807CFDA0-0x00000001807CFDB0 0x0000000180783A90-0x0000000180783AA0
		private float zoomAdd { get; } // 0x00000001807CFDC0-0x00000001807CFE20 
	
		// Nested types
		[Serializable]
		public enum UpdateMode // TypeDefIndex: 8270
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
			FixedLateUpdate = 3
		}
	
		// Constructors
		public CameraController(); // 0x00000001807CFCC0-0x00000001807CFDA0
	
		// Methods
		protected virtual void Awake(); // 0x00000001807CF240-0x00000001807CF390
		protected virtual void Update(); // 0x00000001807CFC90-0x00000001807CFCC0
		protected virtual void FixedUpdate(); // 0x00000001807CF390-0x00000001807CF3F0
		protected virtual void LateUpdate(); // 0x00000001807CF3F0-0x00000001807CF460
		public void UpdateInput(); // 0x00000001807CF460-0x00000001807CF620
		public void UpdateTransform(); // 0x00000001807CF620-0x00000001807CF650
		public void UpdateTransform(float deltaTime); // 0x00000001807CF650-0x00000001807CFC90
		private float ClampAngle(float angle, float min, float max); // 0x00000001807CF040-0x00000001807CF080
	}
}
