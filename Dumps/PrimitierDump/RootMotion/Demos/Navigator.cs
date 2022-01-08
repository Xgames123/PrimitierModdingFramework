/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 8376
	{
		// Fields
		[Tooltip] // 0x000000018001D360-0x000000018001D390
		public bool activeTargetSeeking; // 0x10
		[Tooltip] // 0x000000018001D390-0x000000018001D3C0
		public float cornerRadius; // 0x14
		[Tooltip] // 0x000000018001D3C0-0x000000018001D3F0
		public float recalculateOnPathDistance; // 0x18
		[Tooltip] // 0x000000018001D3F0-0x000000018001D420
		public float maxSampleDistance; // 0x1C
		[Tooltip] // 0x000000018001D420-0x000000018001D450
		public float nextPathInterval; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 _normalizedDeltaPosition_k__BackingField; // 0x24
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private State _state_k__BackingField; // 0x30
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180776710-0x0000000180776730 0x0000000180776730-0x0000000180776740
		public State state { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802DFC30-0x00000001802DFC40 0x00000001802E9530-0x00000001802E9540
	
		// Nested types
		public enum State // TypeDefIndex: 8375
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator(); // 0x00000001807766A0-0x0000000180776710
	
		// Methods
		public void Initiate(Transform transform); // 0x0000000180775E90-0x0000000180775F40
		public void Update(Vector3 targetPosition); // 0x0000000180775F80-0x0000000180776400
		private void CalculatePath(Vector3 targetPosition); // 0x0000000180775A40-0x0000000180775C60
		private bool Find(Vector3 targetPosition); // 0x0000000180775C60-0x0000000180775E40
		private void Stop(); // 0x0000000180775F40-0x0000000180775F80
		private float HorDistance(Vector3 p1, Vector3 p2); // 0x0000000180775E40-0x0000000180775E90
		public void Visualize(); // 0x0000000180776400-0x00000001807766A0
	}
}
