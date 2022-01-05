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
	public class CVRResources // TypeDefIndex: 6664
	{
		// Fields
		private IVRResources FnTable; // 0x10
	
		// Constructors
		internal CVRResources(IntPtr pInterface); // 0x000000018090E830-0x000000018090E940
	
		// Methods
		public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen); // 0x000000018090E750-0x000000018090E830
		public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen); // 0x000000018090E650-0x000000018090E750
	}
}
