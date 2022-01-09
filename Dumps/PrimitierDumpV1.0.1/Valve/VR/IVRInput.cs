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
	public struct IVRInput // TypeDefIndex: 6601
	{
		// Fields
		internal _SetActionManifestPath SetActionManifestPath; // 0x00
		internal _GetActionSetHandle GetActionSetHandle; // 0x08
		internal _GetActionHandle GetActionHandle; // 0x10
		internal _GetInputSourceHandle GetInputSourceHandle; // 0x18
		internal _UpdateActionState UpdateActionState; // 0x20
		internal _GetDigitalActionData GetDigitalActionData; // 0x28
		internal _GetAnalogActionData GetAnalogActionData; // 0x30
		internal _GetPoseActionDataRelativeToNow GetPoseActionDataRelativeToNow; // 0x38
		internal _GetPoseActionDataForNextFrame GetPoseActionDataForNextFrame; // 0x40
		internal _GetSkeletalActionData GetSkeletalActionData; // 0x48
		internal _GetDominantHand GetDominantHand; // 0x50
		internal _SetDominantHand SetDominantHand; // 0x58
		internal _GetBoneCount GetBoneCount; // 0x60
		internal _GetBoneHierarchy GetBoneHierarchy; // 0x68
		internal _GetBoneName GetBoneName; // 0x70
		internal _GetSkeletalReferenceTransforms GetSkeletalReferenceTransforms; // 0x78
		internal _GetSkeletalTrackingLevel GetSkeletalTrackingLevel; // 0x80
		internal _GetSkeletalBoneData GetSkeletalBoneData; // 0x88
		internal _GetSkeletalSummaryData GetSkeletalSummaryData; // 0x90
		internal _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed; // 0x98
		internal _DecompressSkeletalBoneData DecompressSkeletalBoneData; // 0xA0
		internal _TriggerHapticVibrationAction TriggerHapticVibrationAction; // 0xA8
		internal _GetActionOrigins GetActionOrigins; // 0xB0
		internal _GetOriginLocalizedName GetOriginLocalizedName; // 0xB8
		internal _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo; // 0xC0
		internal _GetActionBindingInfo GetActionBindingInfo; // 0xC8
		internal _ShowActionOrigins ShowActionOrigins; // 0xD0
		internal _ShowBindingsForActionSet ShowBindingsForActionSet; // 0xD8
		internal _GetComponentStateForBinding GetComponentStateForBinding; // 0xE0
		internal _IsUsingLegacyInput IsUsingLegacyInput; // 0xE8
		internal _OpenBindingUI OpenBindingUI; // 0xF0
		internal _GetBindingVariant GetBindingVariant; // 0xF8
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _SetActionManifestPath(IntPtr pchActionManifestPath); // TypeDefIndex: 6569; 0x000000018091F880-0x000000018091FA20
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetActionSetHandle(IntPtr pchActionSetName, ref ulong pHandle); // TypeDefIndex: 6570; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetActionHandle(IntPtr pchActionName, ref ulong pHandle); // TypeDefIndex: 6571; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetInputSourceHandle(IntPtr pchInputSourcePath, ref ulong pHandle); // TypeDefIndex: 6572; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _UpdateActionState([In, Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount); // TypeDefIndex: 6573; 0x0000000180943630-0x0000000180943900
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // TypeDefIndex: 6574; 0x0000000180924130-0x0000000180924470
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // TypeDefIndex: 6575; 0x0000000180924130-0x0000000180924470
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // TypeDefIndex: 6576; 0x0000000180932F20-0x00000001809332D0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // TypeDefIndex: 6577; 0x0000000180925260-0x00000001809255C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize); // TypeDefIndex: 6578; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetDominantHand(ref ETrackedControllerRole peDominantHand); // TypeDefIndex: 6579; 0x000000018092C110-0x000000018092C3E0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _SetDominantHand(ETrackedControllerRole eDominantHand); // TypeDefIndex: 6580; 0x0000000180936480-0x0000000180936740
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetBoneCount(ulong action, ref uint pBoneCount); // TypeDefIndex: 6581; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetBoneHierarchy(ulong action, [In, Out] int[] pParentIndices, uint unIndexArayCount); // TypeDefIndex: 6582; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetBoneName(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize); // TypeDefIndex: 6583; 0x0000000180926BA0-0x0000000180926EE0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount); // TypeDefIndex: 6584; 0x0000000180934B70-0x0000000180934DB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel); // TypeDefIndex: 6585; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount); // TypeDefIndex: 6586; 0x0000000180934B70-0x0000000180934DB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData); // TypeDefIndex: 6587; 0x0000000180930CC0-0x0000000180930FB0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize); // TypeDefIndex: 6588; 0x0000000180925260-0x00000001809255C0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, [In, Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount); // TypeDefIndex: 6589; 0x0000000180922090-0x00000001809223F0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice); // TypeDefIndex: 6590; 0x0000000180943080-0x0000000180943430
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, [In, Out] ulong[] originsOut, uint originOutCount); // TypeDefIndex: 6591; 0x000000018091DF40-0x000000018091E280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude); // TypeDefIndex: 6592; 0x0000000180930160-0x00000001809304A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize); // TypeDefIndex: 6593; 0x0000000180926670-0x0000000180926960
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetActionBindingInfo(ulong action, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref uint punReturnedBindingInfoCount); // TypeDefIndex: 6594; 0x0000000180923AB0-0x0000000180923E10
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle); // TypeDefIndex: 6595; 0x0000000180920780-0x0000000180920930
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _ShowBindingsForActionSet([In, Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight); // TypeDefIndex: 6596; 0x0000000180940D50-0x0000000180941080
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetComponentStateForBinding(IntPtr pchRenderModelName, IntPtr pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState); // TypeDefIndex: 6597; 0x0000000180928F60-0x0000000180929310
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate bool _IsUsingLegacyInput(); // TypeDefIndex: 6598; 0x000000018091F100-0x000000018091F280
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _OpenBindingUI(IntPtr pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, bool bShowOnDesktop); // TypeDefIndex: 6599; 0x0000000180939CB0-0x0000000180939FF0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRInputError _GetBindingVariant(ulong ulDevicePath, StringBuilder pchVariantArray, uint unVariantArraySize); // TypeDefIndex: 6600; 0x0000000180926670-0x0000000180926960
	}
}
