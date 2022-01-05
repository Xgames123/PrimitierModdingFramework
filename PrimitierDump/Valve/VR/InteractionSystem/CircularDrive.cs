/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180024880-0x00000001800248D0
	public class CircularDrive : MonoBehaviour // TypeDefIndex: 7385
	{
		// Fields
		[Tooltip] // 0x00000001800248D0-0x0000000180024900
		public Axis_t axisOfRotation; // 0x18
		[Tooltip] // 0x0000000180024900-0x0000000180024930
		public Collider childCollider; // 0x20
		[Tooltip] // 0x0000000180024930-0x0000000180024960
		public LinearMapping linearMapping; // 0x28
		[Tooltip] // 0x0000000180024960-0x0000000180024990
		public bool hoverLock; // 0x30
		[Header] // 0x0000000180024990-0x00000001800249F0
		[Tooltip] // 0x0000000180024990-0x00000001800249F0
		public bool limited; // 0x31
		public Vector2 frozenDistanceMinMaxThreshold; // 0x34
		public UnityEvent onFrozenDistanceThreshold; // 0x40
		[Header] // 0x00000001800249F0-0x0000000180024A50
		[Tooltip] // 0x00000001800249F0-0x0000000180024A50
		public float minAngle; // 0x48
		[Tooltip] // 0x0000000180024A50-0x0000000180024A80
		public bool freezeOnMin; // 0x4C
		[Tooltip] // 0x0000000180024A80-0x0000000180024AB0
		public UnityEvent onMinAngle; // 0x50
		[Header] // 0x0000000180024AB0-0x0000000180024B10
		[Tooltip] // 0x0000000180024AB0-0x0000000180024B10
		public float maxAngle; // 0x58
		[Tooltip] // 0x0000000180024B10-0x0000000180024B40
		public bool freezeOnMax; // 0x5C
		[Tooltip] // 0x0000000180024B40-0x0000000180024B70
		public UnityEvent onMaxAngle; // 0x60
		[Tooltip] // 0x0000000180024B70-0x0000000180024BA0
		public bool forceStart; // 0x68
		[Tooltip] // 0x0000000180024BA0-0x0000000180024BD0
		public float startAngle; // 0x6C
		[Tooltip] // 0x0000000180024BD0-0x0000000180024C00
		public bool rotateGameObject; // 0x70
		[Tooltip] // 0x0000000180024C00-0x0000000180024C30
		public bool debugPath; // 0x71
		[Tooltip] // 0x0000000180024C30-0x0000000180024C60
		public int dbgPathLimit; // 0x74
		[Tooltip] // 0x0000000180024C60-0x0000000180024C90
		public TextMesh debugText; // 0x78
		[Tooltip] // 0x0000000180024C90-0x0000000180024CC0
		public float outAngle; // 0x80
		private Quaternion start; // 0x84
		private Vector3 worldPlaneNormal; // 0x94
		private Vector3 localPlaneNormal; // 0xA0
		private Vector3 lastHandProjected; // 0xAC
		private Color red; // 0xB8
		private Color green; // 0xC8
		private GameObject[] dbgHandObjects; // 0xD8
		private GameObject[] dbgProjObjects; // 0xE0
		private GameObject dbgObjectsParent; // 0xE8
		private int dbgObjectCount; // 0xF0
		private int dbgObjectIndex; // 0xF4
		private bool driving; // 0xF8
		private float minMaxAngularThreshold; // 0xFC
		private bool frozen; // 0x100
		private float frozenAngle; // 0x104
		private Vector3 frozenHandWorldPos; // 0x108
		private Vector2 frozenSqDistanceMinMaxThreshold; // 0x114
		private Hand handHoverLocked; // 0x120
		private Interactable interactable; // 0x128
		private GrabTypes grabbedWithType; // 0x130
	
		// Nested types
		public enum Axis_t // TypeDefIndex: 7383
		{
			XAxis = 0,
			YAxis = 1,
			ZAxis = 2
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _HapticPulses_d__45 : IEnumerator<object> // TypeDefIndex: 7384
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Hand hand; // 0x20
			public float flMagnitude; // 0x28
			public int nCount; // 0x2C
			private int _nRangeMax_5__2; // 0x30
			private ushort _i_5__3; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _HapticPulses_d__45(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029A590-0x000000018029A6F0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029A6F0-0x000000018029A730
		}
	
		// Constructors
		public CircularDrive(); // 0x0000000180589B60-0x0000000180589CA0
	
		// Methods
		private void Freeze(Hand hand); // 0x0000000180588E10-0x0000000180588E90
		private void UnFreeze(); // 0x00000001805897C0-0x00000001805897E0
		private void Awake(); // 0x0000000180587EA0-0x0000000180587EF0
		private void Start(); // 0x0000000180589380-0x00000001805897C0
		private void OnDisable(); // 0x00000001805890D0-0x0000000180589180
		[IteratorStateMachine] // 0x0000000180024CC0-0x0000000180024D10
		private IEnumerator HapticPulses(Hand hand, float flMagnitude, int nCount); // 0x0000000180589040-0x00000001805890D0
		private void OnHandHoverBegin(Hand hand); // 0x0000000180589180-0x00000001805892B0
		private void OnHandHoverEnd(Hand hand); // 0x00000001805892B0-0x0000000180589380
		private void HandHoverUpdate(Hand hand); // 0x0000000180588E90-0x0000000180589040
		private Vector3 ComputeToTransformProjected(Transform xForm); // 0x0000000180588330-0x0000000180588640
		private void DrawDebugPath(Transform xForm, Vector3 toTransformProjected); // 0x0000000180588640-0x0000000180588E10
		private void UpdateLinearMapping(); // 0x0000000180589AD0-0x0000000180589B60
		private void UpdateGameObject(); // 0x0000000180589A10-0x0000000180589AD0
		private void UpdateDebugText(); // 0x0000000180589910-0x0000000180589A10
		private void UpdateAll(); // 0x00000001805897E0-0x0000000180589910
		private void ComputeAngle(Hand hand); // 0x0000000180587EF0-0x0000000180588330
	}
}
