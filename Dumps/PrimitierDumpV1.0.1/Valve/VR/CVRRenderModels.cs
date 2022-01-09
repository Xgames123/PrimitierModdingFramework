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
	public class CVRRenderModels // TypeDefIndex: 6660
	{
		// Fields
		private IVRRenderModels FnTable; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetComponentStatePacked(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t_Packed pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6658; 0x0000000180929420-0x0000000180929780
	
		private struct GetComponentStateUnion // TypeDefIndex: 6659
		{
			// Fields
			public IVRRenderModels._GetComponentState pGetComponentState; // 0x00
			public _GetComponentStatePacked pGetComponentStatePacked; // 0x00
		}
	
		// Constructors
		internal CVRRenderModels(IntPtr pInterface); // 0x000000018090E4E0-0x000000018090E650
	
		// Methods
		public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel); // 0x000000018090E2D0-0x000000018090E3A0
		public void FreeRenderModel(IntPtr pRenderModel); // 0x000000018090D270-0x000000018090D420
		public EVRRenderModelError LoadTexture_Async(int textureId, ref IntPtr ppTexture); // 0x000000018090E3D0-0x000000018090E3F0
		public void FreeTexture(IntPtr pTexture); // 0x000000018090D5D0-0x000000018090D780
		public EVRRenderModelError LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D); // 0x000000018090E3A0-0x000000018090E3D0
		public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture); // 0x000000018090E2B0-0x000000018090E2D0
		public void FreeTextureD3D11(IntPtr pD3D11Texture2D); // 0x000000018090D420-0x000000018090D5D0
		public uint GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen); // 0x000000018090E0A0-0x000000018090E0D0
		public uint GetRenderModelCount(); // 0x000000018090DE90-0x000000018090E020
		public uint GetComponentCount(string pchRenderModelName); // 0x000000018090D860-0x000000018090D920
		public uint GetComponentName(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen); // 0x000000018090D920-0x000000018090DA10
		public ulong GetComponentButtonMask(string pchRenderModelName, string pchComponentName); // 0x000000018090D780-0x000000018090D860
		public uint GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen); // 0x000000018090DA10-0x000000018090DB10
		public bool GetComponentStateForDevicePath(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // 0x000000018090DB10-0x000000018090DC20
		public bool GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // 0x000000018090DC20-0x000000018090DE90
		public bool RenderModelHasComponent(string pchRenderModelName, string pchComponentName); // 0x000000018090E3F0-0x000000018090E4E0
		public uint GetRenderModelThumbnailURL(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError); // 0x000000018090E1C0-0x000000018090E2B0
		public uint GetRenderModelOriginalPath(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError); // 0x000000018090E0D0-0x000000018090E1C0
		public string GetRenderModelErrorNameFromEnum(EVRRenderModelError error); // 0x000000018090E020-0x000000018090E0A0
	}
}
