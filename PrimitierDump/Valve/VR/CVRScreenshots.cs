/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRScreenshots // TypeDefIndex: 6663
	{
		// Fields
		private IVRScreenshots FnTable; // 0x10
	
		// Constructors
		internal CVRScreenshots(IntPtr pInterface); // 0x000000018090ECE0-0x000000018090EE00
	
		// Methods
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename); // 0x000000018090E9A0-0x000000018090EAB0
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes); // 0x000000018090E970-0x000000018090E9A0
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError); // 0x000000018090E3D0-0x000000018090E3F0
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError); // 0x000000018090E940-0x000000018090E970
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress); // 0x000000018090ECC0-0x000000018090ECE0
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename); // 0x000000018090EBC0-0x000000018090ECC0
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename); // 0x000000018090EAB0-0x000000018090EBC0
	}
}
