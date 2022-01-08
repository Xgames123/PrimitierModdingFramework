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
	public struct IVRRenderModels // TypeDefIndex: 6537
	{
		// Fields
		internal _LoadRenderModel_Async LoadRenderModel_Async; // 0x00
		internal _FreeRenderModel FreeRenderModel; // 0x08
		internal _LoadTexture_Async LoadTexture_Async; // 0x10
		internal _FreeTexture FreeTexture; // 0x18
		internal _LoadTextureD3D11_Async LoadTextureD3D11_Async; // 0x20
		internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async; // 0x28
		internal _FreeTextureD3D11 FreeTextureD3D11; // 0x30
		internal _GetRenderModelName GetRenderModelName; // 0x38
		internal _GetRenderModelCount GetRenderModelCount; // 0x40
		internal _GetComponentCount GetComponentCount; // 0x48
		internal _GetComponentName GetComponentName; // 0x50
		internal _GetComponentButtonMask GetComponentButtonMask; // 0x58
		internal _GetComponentRenderModelName GetComponentRenderModelName; // 0x60
		internal _GetComponentStateForDevicePath GetComponentStateForDevicePath; // 0x68
		internal _GetComponentState GetComponentState; // 0x70
		internal _RenderModelHasComponent RenderModelHasComponent; // 0x78
		internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL; // 0x80
		internal _GetRenderModelOriginalPath GetRenderModelOriginalPath; // 0x88
		internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum; // 0x90
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRRenderModelError _LoadRenderModel_Async(IntPtr pchRenderModelName, ref IntPtr ppRenderModel); // TypeDefIndex: 6518; 0x0000000180921410-0x00000001809216F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _FreeRenderModel(IntPtr pRenderModel); // TypeDefIndex: 6519; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture); // TypeDefIndex: 6520; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _FreeTexture(IntPtr pTexture); // TypeDefIndex: 6521; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D); // TypeDefIndex: 6522; 0x00000001809398C0-0x0000000180939A90
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture); // TypeDefIndex: 6523; 0x000000018091E450-0x000000018091E730
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D); // TypeDefIndex: 6524; 0x0000000180923710-0x00000001809238A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetRenderModelName(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen); // TypeDefIndex: 6525; 0x0000000180924A00-0x0000000180924BD0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetRenderModelCount(); // TypeDefIndex: 6526; 0x00000001809247E0-0x0000000180924960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetComponentCount(IntPtr pchRenderModelName); // TypeDefIndex: 6527; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetComponentName(IntPtr pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen); // TypeDefIndex: 6528; 0x0000000180926BA0-0x0000000180926EE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate ulong _GetComponentButtonMask(IntPtr pchRenderModelName, IntPtr pchComponentName); // TypeDefIndex: 6529; 0x0000000180928710-0x00000001809289F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetComponentRenderModelName(IntPtr pchRenderModelName, IntPtr pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen); // TypeDefIndex: 6530; 0x0000000180928C10-0x0000000180928E20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetComponentStateForDevicePath(IntPtr pchRenderModelName, IntPtr pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6531; 0x0000000180929420-0x0000000180929780
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _GetComponentState(IntPtr pchRenderModelName, IntPtr pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6532; 0x0000000180929420-0x0000000180929780
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _RenderModelHasComponent(IntPtr pchRenderModelName, IntPtr pchComponentName); // TypeDefIndex: 6533; 0x0000000180936020-0x0000000180936300
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetRenderModelThumbnailURL(IntPtr pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError); // TypeDefIndex: 6534; 0x0000000180931660-0x0000000180931870
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate uint _GetRenderModelOriginalPath(IntPtr pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError); // TypeDefIndex: 6535; 0x0000000180931660-0x0000000180931870
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error); // TypeDefIndex: 6536; 0x0000000180925CC0-0x0000000180925E60
	}
}
