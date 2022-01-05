/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_TrackingReferenceManager : MonoBehaviour // TypeDefIndex: 7381
	{
		// Fields
		private Dictionary<uint, TrackingReferenceObject> trackingReferences; // 0x18
	
		// Nested types
		private class TrackingReferenceObject // TypeDefIndex: 7380
		{
			// Fields
			public ETrackedDeviceClass trackedDeviceClass; // 0x10
			public GameObject gameObject; // 0x18
			public SteamVR_RenderModel renderModel; // 0x20
			public SteamVR_TrackedObject trackedObject; // 0x28
	
			// Constructors
			public TrackingReferenceObject(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public SteamVR_TrackingReferenceManager(); // 0x0000000180C757D0-0x0000000180C75840
	
		// Methods
		private void OnEnable(); // 0x0000000180C753B0-0x0000000180C754A0
		private void OnDisable(); // 0x0000000180C752C0-0x0000000180C753B0
		private void OnNewPoses(TrackedDevicePose_t[] poses); // 0x0000000180C754A0-0x0000000180C757D0
	}
}
