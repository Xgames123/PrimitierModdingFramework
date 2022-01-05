/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 48: VRMShaders.VRM.IO.Runtime.dll - Assembly: VRMShaders.VRM.IO.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6921-6929

namespace UniGLTF.ShaderPropExporter
{
	public static class PreShaderPropExporter // TypeDefIndex: 6923
	{
		// Fields
		public static readonly string[] VRMExtensionShaders; // 0x00
		private static Dictionary<string, ShaderProps> m_shaderPropMap; // 0x08
	
		// Properties
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> Standard { get; } // 0x00000001808EF6C0-0x00000001808EFE90 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> UniGLTF_UniUnlit { get; } // 0x00000001808EFE90-0x00000001808F01C0 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> Unlit_Color { get; } // 0x00000001808F01C0-0x00000001808F02C0 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> Unlit_Texture { get; } // 0x00000001808F02C0-0x00000001808F03C0 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> Unlit_Transparent { get; } // 0x00000001808F0500-0x00000001808F0600 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> Unlit_Transparent_Cutout { get; } // 0x00000001808F03C0-0x00000001808F0500 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> VRM_MToon { get; } // 0x00000001808F0600-0x00000001808F11D0 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> VRM_UnlitCutout { get; } // 0x00000001808F11D0-0x00000001808F1310 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> VRM_UnlitTexture { get; } // 0x00000001808F1310-0x00000001808F1410 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> VRM_UnlitTransparent { get; } // 0x00000001808F1510-0x00000001808F1610 
		[PreExportShader] // 0x0000000180014D50-0x0000000180014D60
		private static KeyValuePair<string, ShaderProps> VRM_UnlitTransparentZWrite { get; } // 0x00000001808F1410-0x00000001808F1510 
	
		// Constructors
		static PreShaderPropExporter(); // 0x00000001808EF5A0-0x00000001808EF6C0
	
		// Methods
		public static ShaderProps GetPropsForSupportedShader(string shaderName); // 0x00000001808EF230-0x00000001808EF5A0
	}
}
