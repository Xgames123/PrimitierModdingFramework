/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRChaperoneSetup // TypeDefIndex: 6371
	{
		// Fields
		internal _CommitWorkingCopy CommitWorkingCopy; // 0x00
		internal _RevertWorkingCopy RevertWorkingCopy; // 0x08
		internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize; // 0x10
		internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect; // 0x18
		internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo; // 0x20
		internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo; // 0x28
		internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose; // 0x30
		internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose; // 0x38
		internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize; // 0x40
		internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo; // 0x48
		internal _SetWorkingPerimeter SetWorkingPerimeter; // 0x50
		internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x58
		internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose; // 0x60
		internal _ReloadFromDisk ReloadFromDisk; // 0x68
		internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose; // 0x70
		internal _ExportLiveToBuffer ExportLiveToBuffer; // 0x78
		internal _ImportFromBufferToWorking ImportFromBufferToWorking; // 0x80
		internal _ShowWorkingSetPreview ShowWorkingSetPreview; // 0x88
		internal _HideWorkingSetPreview HideWorkingSetPreview; // 0x90
		internal _RoomSetupStarting RoomSetupStarting; // 0x98
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile); // TypeDefIndex: 6351; 0x000000018091FBA0-0x000000018091FE60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _RevertWorkingCopy(); // TypeDefIndex: 6352; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 6353; 0x0000000180932B10-0x0000000180932CC0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 6354; 0x000000018092F3B0-0x000000018092F550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 6355; 0x000000018092F170-0x000000018092F320
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount); // TypeDefIndex: 6356; 0x000000018092F170-0x000000018092F320
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6357; 0x000000018092F3B0-0x000000018092F550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 6358; 0x000000018092F3B0-0x000000018092F550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ); // TypeDefIndex: 6359; 0x000000018093DA30-0x000000018093DC00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount); // TypeDefIndex: 6360; 0x000000018088F2E0-0x000000018088F5A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetWorkingPerimeter([In, Out] HmdVector2_t[] pPointBuffer, uint unPointCount); // TypeDefIndex: 6361; 0x000000018088F2E0-0x000000018088F5A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6362; 0x00000001809409C0-0x0000000180940B50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose); // TypeDefIndex: 6363; 0x00000001809409C0-0x0000000180940B50
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile); // TypeDefIndex: 6364; 0x000000018093BE00-0x000000018093BF90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose); // TypeDefIndex: 6365; 0x000000018092F3B0-0x000000018092F550
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength); // TypeDefIndex: 6366; 0x0000000180922A10-0x0000000180922EB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _ImportFromBufferToWorking(IntPtr pBuffer, uint nImportFlags); // TypeDefIndex: 6367; 0x0000000180938B00-0x0000000180938DE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _ShowWorkingSetPreview(); // TypeDefIndex: 6368; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _HideWorkingSetPreview(); // TypeDefIndex: 6369; 0x000000018070FF10-0x0000000180710080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _RoomSetupStarting(); // TypeDefIndex: 6370; 0x000000018070FF10-0x0000000180710080
	}
}
