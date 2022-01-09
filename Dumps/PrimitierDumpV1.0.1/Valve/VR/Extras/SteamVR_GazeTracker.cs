/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.Extras
{
	public class SteamVR_GazeTracker : MonoBehaviour // TypeDefIndex: 7537
	{
		// Fields
		public bool isInGaze; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private GazeEventHandler GazeOn; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private GazeEventHandler GazeOff; // 0x28
		public float gazeInCutoff; // 0x30
		public float gazeOutCutoff; // 0x34
		protected Transform hmdTrackedObject; // 0x38
	
		// Events
		public event GazeEventHandler GazeOn {
			add; // 0x0000000180327170-0x0000000180327210
			remove; // 0x00000001803272B0-0x0000000180327350
		}
		public event GazeEventHandler GazeOff {
			add; // 0x00000001803270D0-0x0000000180327170
			remove; // 0x0000000180327210-0x00000001803272B0
		}
	
		// Constructors
		public SteamVR_GazeTracker(); // 0x00000001803270B0-0x00000001803270D0
	
		// Methods
		public virtual void OnGazeOn(GazeEventArgs gazeEventArgs); // 0x0000000180326CE0-0x0000000180326D00
		public virtual void OnGazeOff(GazeEventArgs gazeEventArgs); // 0x0000000180326CC0-0x0000000180326CE0
		protected virtual void Update(); // 0x0000000180326D00-0x00000001803270B0
	}
}
