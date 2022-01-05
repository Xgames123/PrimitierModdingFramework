/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867
[assembly: CompilationRelaxations] // 0x000000018003C5B0-0x000000018003C610
[assembly: Debuggable] // 0x000000018003C5B0-0x000000018003C610
[assembly: RuntimeCompatibility] // 0x000000018003C5B0-0x000000018003C610

namespace Valve.VR
{
	public struct IVRApplications // TypeDefIndex: 6340
	{
		// Fields
		internal _AddApplicationManifest AddApplicationManifest; // 0x00
		internal _RemoveApplicationManifest RemoveApplicationManifest; // 0x08
		internal _IsApplicationInstalled IsApplicationInstalled; // 0x10
		internal _GetApplicationCount GetApplicationCount; // 0x18
		internal _GetApplicationKeyByIndex GetApplicationKeyByIndex; // 0x20
		internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId; // 0x28
		internal _LaunchApplication LaunchApplication; // 0x30
		internal _LaunchTemplateApplication LaunchTemplateApplication; // 0x38
		internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType; // 0x40
		internal _LaunchDashboardOverlay LaunchDashboardOverlay; // 0x48
		internal _CancelApplicationLaunch CancelApplicationLaunch; // 0x50
		internal _IdentifyApplication IdentifyApplication; // 0x58
		internal _GetApplicationProcessId GetApplicationProcessId; // 0x60
		internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum; // 0x68
		internal _GetApplicationPropertyString GetApplicationPropertyString; // 0x70
		internal _GetApplicationPropertyBool GetApplicationPropertyBool; // 0x78
		internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64; // 0x80
		internal _SetApplicationAutoLaunch SetApplicationAutoLaunch; // 0x88
		internal _GetApplicationAutoLaunch GetApplicationAutoLaunch; // 0x90
		internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType; // 0x98
		internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType; // 0xA0
		internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes; // 0xA8
		internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType; // 0xB0
		internal _GetApplicationLaunchArguments GetApplicationLaunchArguments; // 0xB8
		internal _GetStartingApplication GetStartingApplication; // 0xC0
		internal _GetSceneApplicationState GetSceneApplicationState; // 0xC8
		internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck; // 0xD0
		internal _GetSceneApplicationStateNameFromEnum GetSceneApplicationStateNameFromEnum; // 0xD8
		internal _LaunchInternalProcess LaunchInternalProcess; // 0xE0
		internal _GetCurrentSceneProcessId GetCurrentSceneProcessId; // 0xE8
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _AddApplicationManifest(IntPtr pchApplicationManifestFullPath, bool bTemporary); // TypeDefIndex: 6310; 0x000000018091EB80-0x000000018091ED30
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _RemoveApplicationManifest(IntPtr pchApplicationManifestFullPath); // TypeDefIndex: 6311; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsApplicationInstalled(IntPtr pchAppKey); // TypeDefIndex: 6312; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetApplicationCount(); // TypeDefIndex: 6313; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6314; 0x0000000180924A00-0x0000000180924BD0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6315; 0x0000000180924A00-0x0000000180924BD0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _LaunchApplication(IntPtr pchAppKey); // TypeDefIndex: 6316; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _LaunchTemplateApplication(IntPtr pchTemplateAppKey, IntPtr pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys); // TypeDefIndex: 6317; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _LaunchApplicationFromMimeType(IntPtr pchMimeType, IntPtr pchArgs); // TypeDefIndex: 6318; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _LaunchDashboardOverlay(IntPtr pchAppKey); // TypeDefIndex: 6319; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _CancelApplicationLaunch(IntPtr pchAppKey); // TypeDefIndex: 6320; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, IntPtr pchAppKey); // TypeDefIndex: 6321; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetApplicationProcessId(IntPtr pchAppKey); // TypeDefIndex: 6322; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error); // TypeDefIndex: 6323; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetApplicationPropertyString(IntPtr pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError); // TypeDefIndex: 6324; 0x0000000180925260-0x00000001809255C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetApplicationPropertyBool(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 6325; 0x0000000180924E60-0x0000000180925150
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _GetApplicationPropertyUint64(IntPtr pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // TypeDefIndex: 6326; 0x00000001809256D0-0x00000001809259C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _SetApplicationAutoLaunch(IntPtr pchAppKey, bool bAutoLaunch); // TypeDefIndex: 6327; 0x000000018091EB80-0x000000018091ED30
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetApplicationAutoLaunch(IntPtr pchAppKey); // TypeDefIndex: 6328; 0x000000018091F660-0x000000018091F800
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(IntPtr pchAppKey, IntPtr pchMimeType); // TypeDefIndex: 6329; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetDefaultApplicationForMimeType(IntPtr pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6330; 0x0000000180925A70-0x0000000180925C40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetApplicationSupportedMimeTypes(IntPtr pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer); // TypeDefIndex: 6331; 0x0000000180925A70-0x0000000180925C40
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetApplicationsThatSupportMimeType(IntPtr pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer); // TypeDefIndex: 6332; 0x0000000180925F10-0x00000001809260E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs); // TypeDefIndex: 6333; 0x0000000180924A00-0x0000000180924BD0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // TypeDefIndex: 6334; 0x0000000180935690-0x0000000180935A20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRSceneApplicationState _GetSceneApplicationState(); // TypeDefIndex: 6335; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(IntPtr pchAppKey); // TypeDefIndex: 6336; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state); // TypeDefIndex: 6337; 0x0000000180925CC0-0x0000000180925E60
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRApplicationError _LaunchInternalProcess(IntPtr pchBinaryPath, IntPtr pchArguments, IntPtr pchWorkingDirectory); // TypeDefIndex: 6338; 0x000000018091E7F0-0x000000018091EAE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetCurrentSceneProcessId(); // TypeDefIndex: 6339; 0x00000001809247E0-0x0000000180924960
	}
}
