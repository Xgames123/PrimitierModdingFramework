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
	public struct IVRScreenshots // TypeDefIndex: 6560
	{
		// Fields
		internal _RequestScreenshot RequestScreenshot; // 0x00
		internal _HookScreenshot HookScreenshot; // 0x08
		internal _GetScreenshotPropertyType GetScreenshotPropertyType; // 0x10
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename; // 0x18
		internal _UpdateScreenshotProgress UpdateScreenshotProgress; // 0x20
		internal _TakeStereoScreenshot TakeStereoScreenshot; // 0x28
		internal _SubmitScreenshot SubmitScreenshot; // 0x30
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, IntPtr pchPreviewFilename, IntPtr pchVRFilename); // TypeDefIndex: 6553; 0x000000018093C670-0x000000018093C9B0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotError _HookScreenshot([In, Out] EVRScreenshotType[] pSupportedTypes, int numTypes); // TypeDefIndex: 6554; 0x000000018092DA40-0x000000018092DD00
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError); // TypeDefIndex: 6555; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError); // TypeDefIndex: 6556; 0x0000000180934510-0x0000000180934750
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress); // TypeDefIndex: 6557; 0x00000001809439A0-0x0000000180943C90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, IntPtr pchPreviewFilename, IntPtr pchVRFilename); // TypeDefIndex: 6558; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, IntPtr pchSourcePreviewFilename, IntPtr pchSourceVRFilename); // TypeDefIndex: 6559; 0x00000001809217E0-0x0000000180921B20
	}
}
