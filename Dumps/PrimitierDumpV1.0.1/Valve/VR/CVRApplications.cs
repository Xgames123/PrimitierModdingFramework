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
	public class CVRApplications // TypeDefIndex: 6649
	{
		// Fields
		private IVRApplications FnTable; // 0x10
	
		// Constructors
		internal CVRApplications(IntPtr pInterface); // 0x0000000180904200-0x0000000180904390
	
		// Methods
		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary); // 0x0000000180902A00-0x0000000180902AD0
		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath); // 0x0000000180903F90-0x0000000180904050
		public bool IsApplicationInstalled(string pchAppKey); // 0x00000001809039A0-0x0000000180903A60
		public uint GetApplicationCount(); // 0x0000000180902C50-0x0000000180902DE0
		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // 0x0000000180902DE0-0x0000000180902E10
		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // 0x0000000180902E10-0x0000000180902E40
		public EVRApplicationError LaunchApplication(string pchAppKey); // 0x0000000180903B40-0x0000000180903C00
		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys); // 0x0000000180903DD0-0x0000000180903ED0
		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs); // 0x0000000180903A60-0x0000000180903B40
		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey); // 0x0000000180903C00-0x0000000180903CC0
		public bool CancelApplicationLaunch(string pchAppKey); // 0x0000000180902AD0-0x0000000180902B90
		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey); // 0x00000001809038D0-0x00000001809039A0
		public uint GetApplicationProcessId(string pchAppKey); // 0x0000000180902E70-0x0000000180902F30
		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error); // 0x00000001809032C0-0x0000000180903340
		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError); // 0x0000000180903010-0x0000000180903100
		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // 0x0000000180902F30-0x0000000180903010
		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError); // 0x0000000180903100-0x00000001809031E0
		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch); // 0x0000000180904050-0x0000000180904120
		public bool GetApplicationAutoLaunch(string pchAppKey); // 0x0000000180902B90-0x0000000180902C50
		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType); // 0x0000000180904120-0x0000000180904200
		public bool GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // 0x00000001809035B0-0x0000000180903690
		public bool GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer); // 0x00000001809031E0-0x00000001809032C0
		public uint GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer); // 0x0000000180903340-0x0000000180903420
		public uint GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs); // 0x0000000180902E40-0x0000000180902E70
		public EVRApplicationError GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen); // 0x00000001809038A0-0x00000001809038D0
		public EVRSceneApplicationState GetSceneApplicationState(); // 0x0000000180903710-0x00000001809038A0
		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey); // 0x0000000180903ED0-0x0000000180903F90
		public string GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state); // 0x0000000180903690-0x0000000180903710
		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory); // 0x0000000180903CC0-0x0000000180903DD0
		public uint GetCurrentSceneProcessId(); // 0x0000000180903420-0x00000001809035B0
	}
}
