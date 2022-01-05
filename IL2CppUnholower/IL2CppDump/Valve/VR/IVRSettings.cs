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
	public struct IVRSettings // TypeDefIndex: 6552
	{
		// Fields
		internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum; // 0x00
		internal _SetBool SetBool; // 0x08
		internal _SetInt32 SetInt32; // 0x10
		internal _SetFloat SetFloat; // 0x18
		internal _SetString SetString; // 0x20
		internal _GetBool GetBool; // 0x28
		internal _GetInt32 GetInt32; // 0x30
		internal _GetFloat GetFloat; // 0x38
		internal _GetString GetString; // 0x40
		internal _RemoveSection RemoveSection; // 0x48
		internal _RemoveKeyInSection RemoveKeyInSection; // 0x50
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError); // TypeDefIndex: 6541; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetBool(IntPtr pchSection, IntPtr pchSettingsKey, bool bValue, ref EVRSettingsError peError); // TypeDefIndex: 6542; 0x000000018093CC40-0x000000018093CF70
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetInt32(IntPtr pchSection, IntPtr pchSettingsKey, int nValue, ref EVRSettingsError peError); // TypeDefIndex: 6543; 0x000000018093E160-0x000000018093E480
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetFloat(IntPtr pchSection, IntPtr pchSettingsKey, float flValue, ref EVRSettingsError peError); // TypeDefIndex: 6544; 0x000000018093D660-0x000000018093D990
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _SetString(IntPtr pchSection, IntPtr pchSettingsKey, IntPtr pchValue, ref EVRSettingsError peError); // TypeDefIndex: 6545; 0x00000001809380B0-0x00000001809383D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetBool(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6546; 0x00000001809203E0-0x00000001809206D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate int _GetInt32(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6547; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate float _GetFloat(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6548; 0x000000018092D610-0x000000018092D900
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _GetString(IntPtr pchSection, IntPtr pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError); // TypeDefIndex: 6549; 0x0000000180935C20-0x0000000180935F70
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _RemoveSection(IntPtr pchSection, ref EVRSettingsError peError); // TypeDefIndex: 6550; 0x000000018092B720-0x000000018092B9F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _RemoveKeyInSection(IntPtr pchSection, IntPtr pchSettingsKey, ref EVRSettingsError peError); // TypeDefIndex: 6551; 0x000000018093C0D0-0x000000018093C3B0
	}
}
