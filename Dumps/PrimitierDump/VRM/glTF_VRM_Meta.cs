/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[JsonSchema] // 0x00000001800365C0-0x00000001800365F0
	public class glTF_VRM_Meta // TypeDefIndex: 8044
	{
		// Fields
		[JsonSchema] // 0x00000001800365F0-0x0000000180036620
		public string title; // 0x10
		[JsonSchema] // 0x0000000180036620-0x0000000180036650
		public string version; // 0x18
		[JsonSchema] // 0x0000000180036650-0x0000000180036680
		public string author; // 0x20
		[JsonSchema] // 0x0000000180036680-0x00000001800366B0
		public string contactInformation; // 0x28
		[JsonSchema] // 0x00000001800366B0-0x00000001800366E0
		public string reference; // 0x30
		[JsonSchema] // 0x00000001800366E0-0x0000000180036760
		public int texture; // 0x38
		[JsonSchema] // 0x0000000180036760-0x0000000180036810
		public string allowedUserName; // 0x40
		[JsonSchema] // 0x0000000180036810-0x00000001800368B0
		public string violentUssageName; // 0x48
		[JsonSchema] // 0x00000001800368B0-0x0000000180036950
		public string sexualUssageName; // 0x50
		[JsonSchema] // 0x0000000180036950-0x00000001800369F0
		public string commercialUssageName; // 0x58
		[JsonSchema] // 0x00000001800369F0-0x0000000180036A20
		public string otherPermissionUrl; // 0x60
		[JsonSchema] // 0x0000000180036A20-0x0000000180036B30
		public string licenseName; // 0x68
		[JsonSchema] // 0x0000000180036B30-0x0000000180036B60
		public string otherLicenseUrl; // 0x70
	
		// Properties
		public AllowedUser allowedUser { get; set; } // 0x000000018055F4A0-0x000000018055F4E0 0x000000018055F5E0-0x000000018055F670
		public UssageLicense violentUssage { get; set; } // 0x000000018055F5A0-0x000000018055F5E0 0x000000018055F820-0x000000018055F8B0
		public UssageLicense sexualUssage { get; set; } // 0x000000018055F560-0x000000018055F5A0 0x000000018055F790-0x000000018055F820
		public UssageLicense commercialUssage { get; set; } // 0x000000018055F4E0-0x000000018055F520 0x000000018055F670-0x000000018055F700
		public LicenseType licenseType { get; set; } // 0x000000018055F520-0x000000018055F560 0x000000018055F700-0x000000018055F790
	
		// Constructors
		public glTF_VRM_Meta(); // 0x000000018055F410-0x000000018055F4A0
	
		// Methods
		private static UssageLicense FromString(string src); // 0x000000018055F3D0-0x000000018055F410
	}
}
