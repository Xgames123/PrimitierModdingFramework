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
	public class CVRInput // TypeDefIndex: 6666
	{
		// Fields
		private IVRInput FnTable; // 0x10
	
		// Constructors
		internal CVRInput(IntPtr pInterface); // 0x000000018090A830-0x000000018090A9A0
	
		// Methods
		public EVRInputError SetActionManifestPath(string pchActionManifestPath); // 0x000000018090A680-0x000000018090A740
		public EVRInputError GetActionSetHandle(string pchActionSetName, ref ulong pHandle); // 0x0000000180909F80-0x000000018090A050
		public EVRInputError GetActionHandle(string pchActionName, ref ulong pHandle); // 0x0000000180909E70-0x0000000180909F40
		public EVRInputError GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle); // 0x000000018090A2B0-0x000000018090A380
		public EVRInputError UpdateActionState(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t); // 0x000000018090A800-0x000000018090A830
		public EVRInputError GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // 0x000000018090A260-0x000000018090A290
		public EVRInputError GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // 0x000000018090A050-0x000000018090A080
		public EVRInputError GetPoseActionDataRelativeToNow(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // 0x000000018090A410-0x000000018090A440
		public EVRInputError GetPoseActionDataForNextFrame(ulong action, ETrackingUniverseOrigin eOrigin, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice); // 0x000000018090A3E0-0x000000018090A410
		public EVRInputError GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize); // 0x000000018090A440-0x000000018090A470
		public EVRInputError GetDominantHand(ref ETrackedControllerRole peDominantHand); // 0x000000018090A290-0x000000018090A2B0
		public EVRInputError SetDominantHand(ETrackedControllerRole eDominantHand); // 0x000000018090A740-0x000000018090A760
		public EVRInputError GetBoneCount(ulong action, ref uint pBoneCount); // 0x000000018090A0B0-0x000000018090A0E0
		public EVRInputError GetBoneHierarchy(ulong action, int[] pParentIndices); // 0x000000018090A0E0-0x000000018090A110
		public EVRInputError GetBoneName(ulong action, int nBoneIndex, StringBuilder pchBoneName, uint unNameBufferSize); // 0x000000018090A110-0x000000018090A140
		public EVRInputError GetSkeletalReferenceTransforms(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalReferencePose eReferencePose, VRBoneTransform_t[] pTransformArray); // 0x000000018090A4F0-0x000000018090A530
		public EVRInputError GetSkeletalTrackingLevel(ulong action, ref EVRSkeletalTrackingLevel pSkeletalTrackingLevel); // 0x000000018090A560-0x000000018090A590
		public EVRInputError GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, VRBoneTransform_t[] pTransformArray); // 0x000000018090A4B0-0x000000018090A4F0
		public EVRInputError GetSkeletalSummaryData(ulong action, EVRSummaryType eSummaryType, ref VRSkeletalSummaryData_t pSkeletalSummaryData); // 0x000000018090A530-0x000000018090A560
		public EVRInputError GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize); // 0x000000018090A470-0x000000018090A4B0
		public EVRInputError DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, EVRSkeletalTransformSpace eTransformSpace, VRBoneTransform_t[] pTransformArray); // 0x0000000180909DF0-0x0000000180909E30
		public EVRInputError TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice); // 0x000000018090A7D0-0x000000018090A800
		public EVRInputError GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, ulong[] originsOut); // 0x0000000180909F40-0x0000000180909F80
		public EVRInputError GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize, int unStringSectionsToInclude); // 0x000000018090A380-0x000000018090A3B0
		public EVRInputError GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize); // 0x000000018090A3B0-0x000000018090A3E0
		public EVRInputError GetActionBindingInfo(ulong action, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref uint punReturnedBindingInfoCount); // 0x0000000180909E30-0x0000000180909E70
		public EVRInputError ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle); // 0x000000018090A760-0x000000018090A790
		public EVRInputError ShowBindingsForActionSet(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, ulong originToHighlight); // 0x000000018090A790-0x000000018090A7D0
		public EVRInputError GetComponentStateForBinding(string pchRenderModelName, string pchComponentName, ref InputBindingInfo_t pOriginInfo, uint unBindingInfoSize, uint unBindingInfoCount, ref RenderModel_ComponentState_t pComponentState); // 0x000000018090A140-0x000000018090A260
		public bool IsUsingLegacyInput(); // 0x0000000180908150-0x00000001809082E0
		public EVRInputError OpenBindingUI(string pchAppKey, ulong ulActionSetHandle, ulong ulDeviceHandle, bool bShowOnDesktop); // 0x000000018090A590-0x000000018090A680
		public EVRInputError GetBindingVariant(ulong ulDevicePath, StringBuilder pchVariantArray, uint unVariantArraySize); // 0x000000018090A080-0x000000018090A0B0
	}
}
