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
	public class CVRSettings // TypeDefIndex: 6662
	{
		// Fields
		private IVRSettings FnTable; // 0x10
	
		// Constructors
		internal CVRSettings(IntPtr pInterface); // 0x000000018090F840-0x000000018090F970
	
		// Methods
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError); // 0x000000018090F100-0x000000018090F180
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError); // 0x000000018090F430-0x000000018090F530
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError); // 0x000000018090F630-0x000000018090F730
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError); // 0x000000018090F530-0x000000018090F630
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError); // 0x000000018090F730-0x000000018090F840
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // 0x000000018090EE00-0x000000018090EF00
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // 0x000000018090F000-0x000000018090F100
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // 0x000000018090EF00-0x000000018090F000
		public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError); // 0x000000018090F180-0x000000018090F280
		public void RemoveSection(string pchSection, ref EVRSettingsError peError); // 0x000000018090F370-0x000000018090F430
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError); // 0x000000018090F280-0x000000018090F370
	}
}
