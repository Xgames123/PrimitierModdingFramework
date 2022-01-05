/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRHeadsetView // TypeDefIndex: 6517
	{
		// Fields
		internal _SetHeadsetViewSize SetHeadsetViewSize; // 0x00
		internal _GetHeadsetViewSize GetHeadsetViewSize; // 0x08
		internal _SetHeadsetViewMode SetHeadsetViewMode; // 0x10
		internal _GetHeadsetViewMode GetHeadsetViewMode; // 0x18
		internal _SetHeadsetViewCropped SetHeadsetViewCropped; // 0x20
		internal _GetHeadsetViewCropped GetHeadsetViewCropped; // 0x28
		internal _GetHeadsetViewAspectRatio GetHeadsetViewAspectRatio; // 0x30
		internal _SetHeadsetViewBlendRange SetHeadsetViewBlendRange; // 0x38
		internal _GetHeadsetViewBlendRange GetHeadsetViewBlendRange; // 0x40
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetHeadsetViewSize(uint nWidth, uint nHeight); // TypeDefIndex: 6508; 0x000000018093DDA0-0x000000018093E070
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 6509; 0x000000018092DE40-0x000000018092DFE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetHeadsetViewMode(uint eHeadsetViewMode); // TypeDefIndex: 6510; 0x0000000180710AC0-0x0000000180710D70
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetHeadsetViewMode(); // TypeDefIndex: 6511; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetHeadsetViewCropped(bool bCropped); // TypeDefIndex: 6512; 0x000000018028FC80-0x000000018028FE10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetHeadsetViewCropped(); // TypeDefIndex: 6513; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate float _GetHeadsetViewAspectRatio(); // TypeDefIndex: 6514; 0x000000018092B1C0-0x000000018092B340
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetHeadsetViewBlendRange(float flStartPct, float flEndPct); // TypeDefIndex: 6515; 0x000000018093DA30-0x000000018093DC00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct); // TypeDefIndex: 6516; 0x000000018092B720-0x000000018092B9F0
	}
}
