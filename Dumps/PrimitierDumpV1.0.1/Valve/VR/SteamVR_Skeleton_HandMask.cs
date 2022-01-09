/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public class SteamVR_Skeleton_HandMask // TypeDefIndex: 7324
	{
		// Fields
		public bool palm; // 0x10
		public bool thumb; // 0x11
		public bool index; // 0x12
		public bool middle; // 0x13
		public bool ring; // 0x14
		public bool pinky; // 0x15
		public bool[] values; // 0x18
		public static readonly SteamVR_Skeleton_HandMask fullMask; // 0x00
	
		// Constructors
		public SteamVR_Skeleton_HandMask(); // 0x0000000180C71610-0x0000000180C716F0
		static SteamVR_Skeleton_HandMask(); // 0x0000000180C71500-0x0000000180C71610
	
		// Methods
		public void SetFinger(int i, bool value); // 0x0000000180C714C0-0x0000000180C71500
		public bool GetFinger(int i); // 0x0000000180C713F0-0x0000000180C71430
		public void Reset(); // 0x0000000180C71430-0x0000000180C714C0
		protected void Apply(); // 0x0000000180C712F0-0x0000000180C713F0
	}
}
