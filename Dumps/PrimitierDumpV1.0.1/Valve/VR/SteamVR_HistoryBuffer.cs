/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_HistoryBuffer : SteamVR_RingBuffer<Valve.VR.SteamVR_HistoryStep> // TypeDefIndex: 7369
	{
		// Constructors
		public SteamVR_HistoryBuffer(int size); // 0x0000000180327A80-0x0000000180327AD0
	
		// Methods
		public void Update(Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity); // 0x00000001803277C0-0x0000000180327A80
		public float GetVelocityMagnitudeTrend(int toIndex = -1 /* Metadata: 0x003A58B0 */, int fromIndex = -1 /* Metadata: 0x003A58B4 */); // 0x00000001803276A0-0x00000001803277A0
		public bool IsValid(SteamVR_HistoryStep step); // 0x00000001803277A0-0x00000001803277C0
		public int GetTopVelocity(int forFrames, int addFrames = 0 /* Metadata: 0x003A58B8 */); // 0x00000001803275B0-0x00000001803276A0
		public void GetAverageVelocities(out Vector3 velocity, out Vector3 angularVelocity, int forFrames, int startFrame = -1 /* Metadata: 0x003A58BC */); // 0x0000000180327350-0x00000001803275B0
	}
}
