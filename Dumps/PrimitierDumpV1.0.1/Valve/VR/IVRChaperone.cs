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
	public struct IVRChaperone // TypeDefIndex: 6350
	{
		// Fields
		internal _GetCalibrationState GetCalibrationState; // 0x00
		internal _GetPlayAreaSize GetPlayAreaSize; // 0x08
		internal _GetPlayAreaRect GetPlayAreaRect; // 0x10
		internal _ReloadInfo ReloadInfo; // 0x18
		internal _SetSceneColor SetSceneColor; // 0x20
		internal _GetBoundsColor GetBoundsColor; // 0x28
		internal _AreBoundsVisible AreBoundsVisible; // 0x30
		internal _ForceBoundsVisible ForceBoundsVisible; // 0x38
		internal _ResetZeroPose ResetZeroPose; // 0x40
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ChaperoneCalibrationState _GetCalibrationState(); // TypeDefIndex: 6341; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 6342; 0x0000000180932B10-0x0000000180932CC0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 6343; 0x000000018092F3B0-0x000000018092F550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ReloadInfo(); // TypeDefIndex: 6344; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetSceneColor(HmdColor_t color); // TypeDefIndex: 6345; 0x0000000180940170-0x0000000180940480
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor); // TypeDefIndex: 6346; 0x0000000180927470-0x0000000180927790
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _AreBoundsVisible(); // TypeDefIndex: 6347; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ForceBoundsVisible(bool bForce); // TypeDefIndex: 6348; 0x000000018028FC80-0x000000018028FE10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ResetZeroPose(ETrackingUniverseOrigin eTrackingUniverseOrigin); // TypeDefIndex: 6349; 0x000000018093BE00-0x000000018093BF90
	}
}
