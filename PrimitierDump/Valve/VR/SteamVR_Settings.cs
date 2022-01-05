/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Settings : ScriptableObject // TypeDefIndex: 7371
	{
		// Fields
		private static SteamVR_Settings _instance; // 0x00
		public bool pauseGameWhenDashboardVisible; // 0x18
		public bool lockPhysicsUpdateRateToRenderFrequency; // 0x19
		[FormerlySerializedAs] // 0x0000000180024600-0x0000000180024640
		[SerializeField] // 0x0000000180024600-0x0000000180024640
		private ETrackingUniverseOrigin trackingSpaceOrigin; // 0x1C
		[Tooltip] // 0x0000000180024640-0x0000000180024670
		public string actionsFilePath; // 0x20
		[Tooltip] // 0x0000000180024670-0x00000001800246A0
		public string steamVRInputPath; // 0x28
		public SteamVR_UpdateModes inputUpdateMode; // 0x30
		public SteamVR_UpdateModes poseUpdateMode; // 0x34
		public bool activateFirstActionSetOnStart; // 0x38
		[Tooltip] // 0x00000001800246A0-0x00000001800246D0
		public string editorAppKey; // 0x40
		[Tooltip] // 0x00000001800246D0-0x0000000180024700
		public bool autoEnableVR; // 0x48
		[Space] // 0x0000000180024700-0x0000000180024740
		[Tooltip] // 0x0000000180024700-0x0000000180024740
		public bool legacyMixedRealityCamera; // 0x49
		[Tooltip] // 0x0000000180024740-0x0000000180024770
		public SteamVR_Action_Pose mixedRealityCameraPose; // 0x50
		[Tooltip] // 0x0000000180024770-0x00000001800247A0
		public SteamVR_Input_Sources mixedRealityCameraInputSource; // 0x58
		[Tooltip] // 0x00000001800247A0-0x00000001800247D0
		public bool mixedRealityActionSetAutoEnable; // 0x5C
		[Tooltip] // 0x00000001800247D0-0x0000000180024800
		public GameObject previewHandLeft; // 0x60
		[Tooltip] // 0x0000000180024800-0x0000000180024830
		public GameObject previewHandRight; // 0x68
		private const string previewLeftDefaultAssetName = "vr_glove_left_model_slim"; // Metadata: 0x003A58C0
		private const string previewRightDefaultAssetName = "vr_glove_right_model_slim"; // Metadata: 0x003A58DC
		private const string defaultSettingsAssetName = "SteamVR_Settings"; // Metadata: 0x003A58F9
	
		// Properties
		public static SteamVR_Settings instance { get; } // 0x0000000180C70D00-0x0000000180C70D40 
		public ETrackingUniverseOrigin trackingSpace { get; set; } // 0x00000001802AC190-0x00000001802AC1A0 0x0000000180C70D40-0x0000000180C70DC0
	
		// Constructors
		public SteamVR_Settings(); // 0x0000000180C70C20-0x0000000180C70D00
	
		// Methods
		public bool IsInputUpdateMode(SteamVR_UpdateModes tocheck); // 0x000000018028B0E0-0x000000018028B0F0
		public bool IsPoseUpdateMode(SteamVR_UpdateModes tocheck); // 0x0000000180C707F0-0x0000000180C70800
		public static void VerifyScriptableObject(); // 0x0000000180C70C10-0x0000000180C70C20
		private static void LoadInstance(); // 0x0000000180C70800-0x0000000180C70A90
		public static void Save(); // 0x0000000180265310-0x0000000180265320
		private static void SetDefaultsIfNeeded(); // 0x0000000180C70A90-0x0000000180C70C10
		private static GameObject FindDefaultPreviewHand(string assetName); // 0x0000000180273F80-0x0000000180273F90
	}
}
