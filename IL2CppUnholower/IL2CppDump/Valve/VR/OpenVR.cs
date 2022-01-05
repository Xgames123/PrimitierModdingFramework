/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class OpenVR // TypeDefIndex: 6855
	{
		// Fields
		public const ulong k_ulSharedTextureIsNTHandle = 4294967296; // Metadata: 0x003A3647
		public const uint k_nDriverNone = 4294967295; // Metadata: 0x003A364F
		public const uint k_unMaxDriverDebugResponseSize = 32768; // Metadata: 0x003A3653
		public const uint k_unTrackedDeviceIndex_Hmd = 0; // Metadata: 0x003A3657
		public const uint k_unMaxTrackedDeviceCount = 64; // Metadata: 0x003A365B
		public const uint k_unTrackedDeviceIndexOther = 4294967294; // Metadata: 0x003A365F
		public const uint k_unTrackedDeviceIndexInvalid = 4294967295; // Metadata: 0x003A3663
		public const ulong k_ulInvalidPropertyContainer = 0; // Metadata: 0x003A3667
		public const uint k_unInvalidPropertyTag = 0; // Metadata: 0x003A366F
		public const ulong k_ulInvalidDriverHandle = 0; // Metadata: 0x003A3673
		public const uint k_unFloatPropertyTag = 1; // Metadata: 0x003A367B
		public const uint k_unInt32PropertyTag = 2; // Metadata: 0x003A367F
		public const uint k_unUint64PropertyTag = 3; // Metadata: 0x003A3683
		public const uint k_unBoolPropertyTag = 4; // Metadata: 0x003A3687
		public const uint k_unStringPropertyTag = 5; // Metadata: 0x003A368B
		public const uint k_unErrorPropertyTag = 6; // Metadata: 0x003A368F
		public const uint k_unDoublePropertyTag = 7; // Metadata: 0x003A3693
		public const uint k_unHmdMatrix34PropertyTag = 20; // Metadata: 0x003A3697
		public const uint k_unHmdMatrix44PropertyTag = 21; // Metadata: 0x003A369B
		public const uint k_unHmdVector3PropertyTag = 22; // Metadata: 0x003A369F
		public const uint k_unHmdVector4PropertyTag = 23; // Metadata: 0x003A36A3
		public const uint k_unHmdVector2PropertyTag = 24; // Metadata: 0x003A36A7
		public const uint k_unHmdQuadPropertyTag = 25; // Metadata: 0x003A36AB
		public const uint k_unHiddenAreaPropertyTag = 30; // Metadata: 0x003A36AF
		public const uint k_unPathHandleInfoTag = 31; // Metadata: 0x003A36B3
		public const uint k_unActionPropertyTag = 32; // Metadata: 0x003A36B7
		public const uint k_unInputValuePropertyTag = 33; // Metadata: 0x003A36BB
		public const uint k_unWildcardPropertyTag = 34; // Metadata: 0x003A36BF
		public const uint k_unHapticVibrationPropertyTag = 35; // Metadata: 0x003A36C3
		public const uint k_unSkeletonPropertyTag = 36; // Metadata: 0x003A36C7
		public const uint k_unSpatialAnchorPosePropertyTag = 40; // Metadata: 0x003A36CB
		public const uint k_unJsonPropertyTag = 41; // Metadata: 0x003A36CF
		public const uint k_unActiveActionSetPropertyTag = 42; // Metadata: 0x003A36D3
		public const uint k_unOpenVRInternalReserved_Start = 1000; // Metadata: 0x003A36D7
		public const uint k_unOpenVRInternalReserved_End = 10000; // Metadata: 0x003A36DB
		public const uint k_unMaxPropertyStringSize = 32768; // Metadata: 0x003A36DF
		public const ulong k_ulInvalidActionHandle = 0; // Metadata: 0x003A36E3
		public const ulong k_ulInvalidActionSetHandle = 0; // Metadata: 0x003A36EB
		public const ulong k_ulInvalidInputValueHandle = 0; // Metadata: 0x003A36F3
		public const uint k_unControllerStateAxisCount = 5; // Metadata: 0x003A36FB
		public const ulong k_ulOverlayHandleInvalid = 0; // Metadata: 0x003A36FF
		public const uint k_unMaxDistortionFunctionParameters = 8; // Metadata: 0x003A3707
		public const uint k_unScreenshotHandleInvalid = 0; // Metadata: 0x003A370B
		public const string IVRSystem_Version = "IVRSystem_022"; // Metadata: 0x003A370F
		public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001"; // Metadata: 0x003A3720
		public const string IVRTrackedCamera_Version = "IVRTrackedCamera_006"; // Metadata: 0x003A373A
		public const uint k_unMaxApplicationKeyLength = 128; // Metadata: 0x003A3752
		public const string k_pch_MimeType_HomeApp = "vr/home"; // Metadata: 0x003A3756
		public const string k_pch_MimeType_GameTheater = "vr/game_theater"; // Metadata: 0x003A3761
		public const string IVRApplications_Version = "IVRApplications_007"; // Metadata: 0x003A3774
		public const string IVRChaperone_Version = "IVRChaperone_004"; // Metadata: 0x003A378B
		public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_006"; // Metadata: 0x003A379F
		public const string IVRCompositor_Version = "IVRCompositor_026"; // Metadata: 0x003A37B8
		public const uint k_unVROverlayMaxKeyLength = 128; // Metadata: 0x003A37CD
		public const uint k_unVROverlayMaxNameLength = 128; // Metadata: 0x003A37D1
		public const uint k_unMaxOverlayCount = 128; // Metadata: 0x003A37D5
		public const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32; // Metadata: 0x003A37D9
		public const string IVROverlay_Version = "IVROverlay_024"; // Metadata: 0x003A37DD
		public const string IVROverlayView_Version = "IVROverlayView_003"; // Metadata: 0x003A37EF
		public const uint k_unHeadsetViewMaxWidth = 3840; // Metadata: 0x003A3805
		public const uint k_unHeadsetViewMaxHeight = 2160; // Metadata: 0x003A3809
		public const string k_pchHeadsetViewOverlayKey = "system.HeadsetView"; // Metadata: 0x003A380D
		public const string IVRHeadsetView_Version = "IVRHeadsetView_001"; // Metadata: 0x003A3823
		public const string k_pch_Controller_Component_GDC2015 = "gdc2015"; // Metadata: 0x003A3839
		public const string k_pch_Controller_Component_Base = "base"; // Metadata: 0x003A3844
		public const string k_pch_Controller_Component_Tip = "tip"; // Metadata: 0x003A384C
		public const string k_pch_Controller_Component_HandGrip = "handgrip"; // Metadata: 0x003A3853
		public const string k_pch_Controller_Component_Status = "status"; // Metadata: 0x003A385F
		public const string IVRRenderModels_Version = "IVRRenderModels_006"; // Metadata: 0x003A3869
		public const uint k_unNotificationTextMaxSize = 256; // Metadata: 0x003A3880
		public const string IVRNotifications_Version = "IVRNotifications_002"; // Metadata: 0x003A3884
		public const uint k_unMaxSettingsKeyLength = 128; // Metadata: 0x003A389C
		public const string IVRSettings_Version = "IVRSettings_003"; // Metadata: 0x003A38A0
		public const string k_pch_SteamVR_Section = "steamvr"; // Metadata: 0x003A38B3
		public const string k_pch_SteamVR_RequireHmd_String = "requireHmd"; // Metadata: 0x003A38BE
		public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver"; // Metadata: 0x003A38CC
		public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd"; // Metadata: 0x003A38DC
		public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug"; // Metadata: 0x003A38E9
		public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe"; // Metadata: 0x003A38F9
		public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX"; // Metadata: 0x003A390D
		public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY"; // Metadata: 0x003A391E
		public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps"; // Metadata: 0x003A392F
		public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel"; // Metadata: 0x003A394C
		public const string k_pch_SteamVR_IPD_Float = "ipd"; // Metadata: 0x003A3958
		public const string k_pch_SteamVR_Background_String = "background"; // Metadata: 0x003A395F
		public const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection"; // Metadata: 0x003A396D
		public const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight"; // Metadata: 0x003A398C
		public const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius"; // Metadata: 0x003A39A6
		public const string k_pch_SteamVR_GridColor_String = "gridColor"; // Metadata: 0x003A39BE
		public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor"; // Metadata: 0x003A39CB
		public const string k_pch_SteamVR_TrackingLossColor_String = "trackingLossColor"; // Metadata: 0x003A39DC
		public const string k_pch_SteamVR_ShowStage_Bool = "showStage"; // Metadata: 0x003A39F1
		public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers"; // Metadata: 0x003A39FE
		public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers"; // Metadata: 0x003A3A19
		public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees"; // Metadata: 0x003A3A2A
		public const string k_pch_SteamVR_BaseStationPowerManagement_Int32 = "basestationPowerManagement"; // Metadata: 0x003A3A4D
		public const string k_pch_SteamVR_ShowBaseStationPowerManagementTip_Int32 = "ShowBaseStationPowerManagementTip"; // Metadata: 0x003A3A6B
		public const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses"; // Metadata: 0x003A3A90
		public const string k_pch_SteamVR_SupersampleScale_Float = "supersampleScale"; // Metadata: 0x003A3AA6
		public const string k_pch_SteamVR_MaxRecommendedResolution_Int32 = "maxRecommendedResolution"; // Metadata: 0x003A3ABA
		public const string k_pch_SteamVR_MotionSmoothing_Bool = "motionSmoothing"; // Metadata: 0x003A3AD6
		public const string k_pch_SteamVR_MotionSmoothingOverride_Int32 = "motionSmoothingOverride"; // Metadata: 0x003A3AE9
		public const string k_pch_SteamVR_DisableAsyncReprojection_Bool = "disableAsync"; // Metadata: 0x003A3B04
		public const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking"; // Metadata: 0x003A3B14
		public const string k_pch_SteamVR_DefaultMirrorView_Int32 = "mirrorView"; // Metadata: 0x003A3B2E
		public const string k_pch_SteamVR_ShowLegacyMirrorView_Bool = "showLegacyMirrorView"; // Metadata: 0x003A3B3C
		public const string k_pch_SteamVR_MirrorViewVisibility_Bool = "showMirrorView"; // Metadata: 0x003A3B54
		public const string k_pch_SteamVR_MirrorViewDisplayMode_Int32 = "mirrorViewDisplayMode"; // Metadata: 0x003A3B66
		public const string k_pch_SteamVR_MirrorViewEye_Int32 = "mirrorViewEye"; // Metadata: 0x003A3B7F
		public const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry"; // Metadata: 0x003A3B90
		public const string k_pch_SteamVR_MirrorViewGeometryMaximized_String = "mirrorViewGeometryMaximized"; // Metadata: 0x003A3BA6
		public const string k_pch_SteamVR_PerfGraphVisibility_Bool = "showPerfGraph"; // Metadata: 0x003A3BC5
		public const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch"; // Metadata: 0x003A3BD6
		public const string k_pch_SteamVR_StartCompositorFromAppLaunch_Bool = "startCompositorFromAppLaunch"; // Metadata: 0x003A3BF3
		public const string k_pch_SteamVR_StartDashboardFromAppLaunch_Bool = "startDashboardFromAppLaunch"; // Metadata: 0x003A3C13
		public const string k_pch_SteamVR_StartOverlayAppsFromDashboard_Bool = "startOverlayAppsFromDashboard"; // Metadata: 0x003A3C32
		public const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp"; // Metadata: 0x003A3C53
		public const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec"; // Metadata: 0x003A3C64
		public const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo"; // Metadata: 0x003A3C83
		public const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset"; // Metadata: 0x003A3C91
		public const string k_pch_SteamVR_AllowSupersampleFiltering_Bool = "allowSupersampleFiltering"; // Metadata: 0x003A3C9E
		public const string k_pch_SteamVR_SupersampleManualOverride_Bool = "supersampleManualOverride"; // Metadata: 0x003A3CBB
		public const string k_pch_SteamVR_EnableLinuxVulkanAsync_Bool = "enableLinuxVulkanAsync"; // Metadata: 0x003A3CD8
		public const string k_pch_SteamVR_AllowDisplayLockedMode_Bool = "allowDisplayLockedMode"; // Metadata: 0x003A3CF2
		public const string k_pch_SteamVR_HaveStartedTutorialForNativeChaperoneDriver_Bool = "haveStartedTutorialForNativeChaperoneDriver"; // Metadata: 0x003A3D0C
		public const string k_pch_SteamVR_ForceWindows32bitVRMonitor = "forceWindows32BitVRMonitor"; // Metadata: 0x003A3D3B
		public const string k_pch_SteamVR_DebugInputBinding = "debugInputBinding"; // Metadata: 0x003A3D59
		public const string k_pch_SteamVR_DoNotFadeToGrid = "doNotFadeToGrid"; // Metadata: 0x003A3D6E
		public const string k_pch_SteamVR_RenderCameraMode = "renderCameraMode"; // Metadata: 0x003A3D81
		public const string k_pch_SteamVR_EnableSharedResourceJournaling = "enableSharedResourceJournaling"; // Metadata: 0x003A3D95
		public const string k_pch_SteamVR_EnableSafeMode = "enableSafeMode"; // Metadata: 0x003A3DB7
		public const string k_pch_SteamVR_PreferredRefreshRate = "preferredRefreshRate"; // Metadata: 0x003A3DC9
		public const string k_pch_SteamVR_LastVersionNotice = "lastVersionNotice"; // Metadata: 0x003A3DE1
		public const string k_pch_SteamVR_LastVersionNoticeDate = "lastVersionNoticeDate"; // Metadata: 0x003A3DF6
		public const string k_pch_SteamVR_HmdDisplayColorGainR_Float = "hmdDisplayColorGainR"; // Metadata: 0x003A3E0F
		public const string k_pch_SteamVR_HmdDisplayColorGainG_Float = "hmdDisplayColorGainG"; // Metadata: 0x003A3E27
		public const string k_pch_SteamVR_HmdDisplayColorGainB_Float = "hmdDisplayColorGainB"; // Metadata: 0x003A3E3F
		public const string k_pch_SteamVR_CustomIconStyle_String = "customIconStyle"; // Metadata: 0x003A3E57
		public const string k_pch_SteamVR_CustomOffIconStyle_String = "customOffIconStyle"; // Metadata: 0x003A3E6A
		public const string k_pch_SteamVR_CustomIconForceUpdate_String = "customIconForceUpdate"; // Metadata: 0x003A3E80
		public const string k_pch_SteamVR_AllowGlobalActionSetPriority = "globalActionSetPriority"; // Metadata: 0x003A3E99
		public const string k_pch_SteamVR_OverlayRenderQuality = "overlayRenderQuality_2"; // Metadata: 0x003A3EB4
		public const string k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool = "blockOculusSDKOnOpenVRLaunchOption"; // Metadata: 0x003A3ECE
		public const string k_pch_SteamVR_BlockOculusSDKOnAllLaunches_Bool = "blockOculusSDKOnAllLaunches"; // Metadata: 0x003A3EF4
		public const string k_pch_DirectMode_Section = "direct_mode"; // Metadata: 0x003A3F13
		public const string k_pch_DirectMode_Enable_Bool = "enable"; // Metadata: 0x003A3F22
		public const string k_pch_DirectMode_Count_Int32 = "count"; // Metadata: 0x003A3F2C
		public const string k_pch_DirectMode_EdidVid_Int32 = "edidVid"; // Metadata: 0x003A3F35
		public const string k_pch_DirectMode_EdidPid_Int32 = "edidPid"; // Metadata: 0x003A3F40
		public const string k_pch_Lighthouse_Section = "driver_lighthouse"; // Metadata: 0x003A3F4B
		public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu"; // Metadata: 0x003A3F60
		public const string k_pch_Lighthouse_DisableIMUExceptHMD_Bool = "disableimuexcepthmd"; // Metadata: 0x003A3F6E
		public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation"; // Metadata: 0x003A3F85
		public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug"; // Metadata: 0x003A3F9A
		public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation"; // Metadata: 0x003A3FB1
		public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory"; // Metadata: 0x003A3FC7
		public const string k_pch_Lighthouse_EnableBluetooth_Bool = "enableBluetooth"; // Metadata: 0x003A3FD4
		public const string k_pch_Lighthouse_PowerManagedBaseStations_String = "PowerManagedBaseStations"; // Metadata: 0x003A3FE7
		public const string k_pch_Lighthouse_PowerManagedBaseStations2_String = "PowerManagedBaseStations2"; // Metadata: 0x003A4003
		public const string k_pch_Lighthouse_InactivityTimeoutForBaseStations_Int32 = "InactivityTimeoutForBaseStations"; // Metadata: 0x003A4020
		public const string k_pch_Lighthouse_EnableImuFallback_Bool = "enableImuFallback"; // Metadata: 0x003A4044
		public const string k_pch_Null_Section = "driver_null"; // Metadata: 0x003A4059
		public const string k_pch_Null_SerialNumber_String = "serialNumber"; // Metadata: 0x003A4068
		public const string k_pch_Null_ModelNumber_String = "modelNumber"; // Metadata: 0x003A4078
		public const string k_pch_Null_WindowX_Int32 = "windowX"; // Metadata: 0x003A4087
		public const string k_pch_Null_WindowY_Int32 = "windowY"; // Metadata: 0x003A4092
		public const string k_pch_Null_WindowWidth_Int32 = "windowWidth"; // Metadata: 0x003A409D
		public const string k_pch_Null_WindowHeight_Int32 = "windowHeight"; // Metadata: 0x003A40AC
		public const string k_pch_Null_RenderWidth_Int32 = "renderWidth"; // Metadata: 0x003A40BC
		public const string k_pch_Null_RenderHeight_Int32 = "renderHeight"; // Metadata: 0x003A40CB
		public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons"; // Metadata: 0x003A40DB
		public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency"; // Metadata: 0x003A40F8
		public const string k_pch_WindowsMR_Section = "driver_holographic"; // Metadata: 0x003A410C
		public const string k_pch_UserInterface_Section = "userinterface"; // Metadata: 0x003A4122
		public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop"; // Metadata: 0x003A4133
		public const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray"; // Metadata: 0x003A4148
		public const string k_pch_UserInterface_HidePopupsWhenStatusMinimized_Bool = "HidePopupsWhenStatusMinimized"; // Metadata: 0x003A415A
		public const string k_pch_UserInterface_Screenshots_Bool = "screenshots"; // Metadata: 0x003A417B
		public const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType"; // Metadata: 0x003A418A
		public const string k_pch_Notifications_Section = "notifications"; // Metadata: 0x003A419C
		public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb"; // Metadata: 0x003A41AD
		public const string k_pch_Keyboard_Section = "keyboard"; // Metadata: 0x003A41BD
		public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions"; // Metadata: 0x003A41C9
		public const string k_pch_Keyboard_ScaleX = "ScaleX"; // Metadata: 0x003A41E0
		public const string k_pch_Keyboard_ScaleY = "ScaleY"; // Metadata: 0x003A41EA
		public const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX"; // Metadata: 0x003A41F4
		public const string k_pch_Keyboard_OffsetRightX = "OffsetRightX"; // Metadata: 0x003A4203
		public const string k_pch_Keyboard_OffsetY = "OffsetY"; // Metadata: 0x003A4213
		public const string k_pch_Keyboard_Smoothing = "Smoothing"; // Metadata: 0x003A421E
		public const string k_pch_Perf_Section = "perfcheck"; // Metadata: 0x003A422B
		public const string k_pch_Perf_PerfGraphInHMD_Bool = "perfGraphInHMD"; // Metadata: 0x003A4238
		public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore"; // Metadata: 0x003A424A
		public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit"; // Metadata: 0x003A425E
		public const string k_pch_Perf_TestData_Float = "perfTestData"; // Metadata: 0x003A4273
		public const string k_pch_Perf_GPUProfiling_Bool = "GPUProfiling"; // Metadata: 0x003A4283
		public const string k_pch_CollisionBounds_Section = "collisionBounds"; // Metadata: 0x003A4293
		public const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle"; // Metadata: 0x003A42A6
		public const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn"; // Metadata: 0x003A42BE
		public const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn"; // Metadata: 0x003A42E2
		public const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn"; // Metadata: 0x003A4303
		public const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance"; // Metadata: 0x003A4321
		public const string k_pch_CollisionBounds_WallHeight_Float = "CollisionBoundsWallHeight"; // Metadata: 0x003A4340
		public const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR"; // Metadata: 0x003A435D
		public const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG"; // Metadata: 0x003A437B
		public const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB"; // Metadata: 0x003A4399
		public const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA"; // Metadata: 0x003A43B7
		public const string k_pch_CollisionBounds_EnableDriverImport = "enableDriverBoundsImport"; // Metadata: 0x003A43D5
		public const string k_pch_Camera_Section = "camera"; // Metadata: 0x003A43F1
		public const string k_pch_Camera_EnableCamera_Bool = "enableCamera"; // Metadata: 0x003A43FB
		public const string k_pch_Camera_ShowOnController_Bool = "showOnController"; // Metadata: 0x003A440B
		public const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds"; // Metadata: 0x003A441F
		public const string k_pch_Camera_RoomView_Int32 = "roomView"; // Metadata: 0x003A4441
		public const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR"; // Metadata: 0x003A444D
		public const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG"; // Metadata: 0x003A4468
		public const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB"; // Metadata: 0x003A4483
		public const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA"; // Metadata: 0x003A449E
		public const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength"; // Metadata: 0x003A44B9
		public const string k_pch_Camera_RoomViewStyle_Int32 = "roomViewStyle"; // Metadata: 0x003A44D1
		public const string k_pch_audio_Section = "audio"; // Metadata: 0x003A44E2
		public const string k_pch_audio_SetOsDefaultPlaybackDevice_Bool = "setOsDefaultPlaybackDevice"; // Metadata: 0x003A44EB
		public const string k_pch_audio_EnablePlaybackDeviceOverride_Bool = "enablePlaybackDeviceOverride"; // Metadata: 0x003A4509
		public const string k_pch_audio_PlaybackDeviceOverride_String = "playbackDeviceOverride"; // Metadata: 0x003A4529
		public const string k_pch_audio_PlaybackDeviceOverrideName_String = "playbackDeviceOverrideName"; // Metadata: 0x003A4543
		public const string k_pch_audio_SetOsDefaultRecordingDevice_Bool = "setOsDefaultRecordingDevice"; // Metadata: 0x003A4561
		public const string k_pch_audio_EnableRecordingDeviceOverride_Bool = "enableRecordingDeviceOverride"; // Metadata: 0x003A4580
		public const string k_pch_audio_RecordingDeviceOverride_String = "recordingDeviceOverride"; // Metadata: 0x003A45A1
		public const string k_pch_audio_RecordingDeviceOverrideName_String = "recordingDeviceOverrideName"; // Metadata: 0x003A45BC
		public const string k_pch_audio_EnablePlaybackMirror_Bool = "enablePlaybackMirror"; // Metadata: 0x003A45DB
		public const string k_pch_audio_PlaybackMirrorDevice_String = "playbackMirrorDevice"; // Metadata: 0x003A45F3
		public const string k_pch_audio_PlaybackMirrorDeviceName_String = "playbackMirrorDeviceName"; // Metadata: 0x003A460B
		public const string k_pch_audio_OldPlaybackMirrorDevice_String = "onPlaybackMirrorDevice"; // Metadata: 0x003A4627
		public const string k_pch_audio_ActiveMirrorDevice_String = "activePlaybackMirrorDevice"; // Metadata: 0x003A4641
		public const string k_pch_audio_EnablePlaybackMirrorIndependentVolume_Bool = "enablePlaybackMirrorIndependentVolume"; // Metadata: 0x003A465F
		public const string k_pch_audio_LastHmdPlaybackDeviceId_String = "lastHmdPlaybackDeviceId"; // Metadata: 0x003A4688
		public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain"; // Metadata: 0x003A46A3
		public const string k_pch_Power_Section = "power"; // Metadata: 0x003A46B3
		public const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit"; // Metadata: 0x003A46BC
		public const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout"; // Metadata: 0x003A46CE
		public const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout"; // Metadata: 0x003A46E7
		public const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout"; // Metadata: 0x003A4704
		public const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress"; // Metadata: 0x003A471F
		public const string k_pch_Power_PauseCompositorOnStandby_Bool = "pauseCompositorOnStandby"; // Metadata: 0x003A4741
		public const string k_pch_Dashboard_Section = "dashboard"; // Metadata: 0x003A475D
		public const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard"; // Metadata: 0x003A476A
		public const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode"; // Metadata: 0x003A477D
		public const string k_pch_Dashboard_Position = "position"; // Metadata: 0x003A478B
		public const string k_pch_Dashboard_DesktopScale = "desktopScale"; // Metadata: 0x003A4797
		public const string k_pch_Dashboard_DashboardScale = "dashboardScale"; // Metadata: 0x003A47A7
		public const string k_pch_modelskin_Section = "modelskins"; // Metadata: 0x003A47B9
		public const string k_pch_Driver_Enable_Bool = "enable"; // Metadata: 0x003A47C7
		public const string k_pch_Driver_BlockedBySafemode_Bool = "blocked_by_safe_mode"; // Metadata: 0x003A47D1
		public const string k_pch_Driver_LoadPriority_Int32 = "loadPriority"; // Metadata: 0x003A47E9
		public const string k_pch_WebInterface_Section = "WebInterface"; // Metadata: 0x003A47F9
		public const string k_pch_VRWebHelper_Section = "VRWebHelper"; // Metadata: 0x003A4809
		public const string k_pch_VRWebHelper_DebuggerEnabled_Bool = "DebuggerEnabled"; // Metadata: 0x003A4818
		public const string k_pch_VRWebHelper_DebuggerPort_Int32 = "DebuggerPort"; // Metadata: 0x003A482B
		public const string k_pch_TrackingOverride_Section = "TrackingOverrides"; // Metadata: 0x003A483B
		public const string k_pch_App_BindingAutosaveURLSuffix_String = "AutosaveURL"; // Metadata: 0x003A4850
		public const string k_pch_App_BindingLegacyAPISuffix_String = "_legacy"; // Metadata: 0x003A485F
		public const string k_pch_App_BindingSteamVRInputAPISuffix_String = "_steamvrinput"; // Metadata: 0x003A486A
		public const string k_pch_App_BindingCurrentURLSuffix_String = "CurrentURL"; // Metadata: 0x003A487B
		public const string k_pch_App_BindingPreviousURLSuffix_String = "PreviousURL"; // Metadata: 0x003A4889
		public const string k_pch_App_NeedToUpdateAutosaveSuffix_Bool = "NeedToUpdateAutosave"; // Metadata: 0x003A4898
		public const string k_pch_App_DominantHand_Int32 = "DominantHand"; // Metadata: 0x003A48B0
		public const string k_pch_App_BlockOculusSDK_Bool = "blockOculusSDK"; // Metadata: 0x003A48C0
		public const string k_pch_Trackers_Section = "trackers"; // Metadata: 0x003A48D2
		public const string k_pch_DesktopUI_Section = "DesktopUI"; // Metadata: 0x003A48DE
		public const string k_pch_LastKnown_Section = "LastKnown"; // Metadata: 0x003A48EB
		public const string k_pch_LastKnown_HMDManufacturer_String = "HMDManufacturer"; // Metadata: 0x003A48F8
		public const string k_pch_LastKnown_HMDModel_String = "HMDModel"; // Metadata: 0x003A490B
		public const string k_pch_DismissedWarnings_Section = "DismissedWarnings"; // Metadata: 0x003A4917
		public const string k_pch_Input_Section = "input"; // Metadata: 0x003A492C
		public const string k_pch_Input_LeftThumbstickRotation_Float = "leftThumbstickRotation"; // Metadata: 0x003A4935
		public const string k_pch_Input_RightThumbstickRotation_Float = "rightThumbstickRotation"; // Metadata: 0x003A494F
		public const string k_pch_Input_ThumbstickDeadzone_Float = "thumbstickDeadzone"; // Metadata: 0x003A496A
		public const string k_pch_GpuSpeed_Section = "GpuSpeed"; // Metadata: 0x003A4980
		public const string IVRScreenshots_Version = "IVRScreenshots_001"; // Metadata: 0x003A498C
		public const string IVRResources_Version = "IVRResources_001"; // Metadata: 0x003A49A2
		public const string IVRDriverManager_Version = "IVRDriverManager_001"; // Metadata: 0x003A49B6
		public const uint k_unMaxActionNameLength = 64; // Metadata: 0x003A49CE
		public const uint k_unMaxActionSetNameLength = 64; // Metadata: 0x003A49D2
		public const uint k_unMaxActionOriginCount = 16; // Metadata: 0x003A49D6
		public const uint k_unMaxBoneNameLength = 32; // Metadata: 0x003A49DA
		public const int k_nActionSetOverlayGlobalPriorityMin = 16777216; // Metadata: 0x003A49DE
		public const int k_nActionSetOverlayGlobalPriorityMax = 33554431; // Metadata: 0x003A49E2
		public const int k_nActionSetPriorityReservedMin = 33554432; // Metadata: 0x003A49E6
		public const string IVRInput_Version = "IVRInput_010"; // Metadata: 0x003A49EA
		public const ulong k_ulInvalidIOBufferHandle = 0; // Metadata: 0x003A49FA
		public const string IVRIOBuffer_Version = "IVRIOBuffer_002"; // Metadata: 0x003A4A02
		public const uint k_ulInvalidSpatialAnchorHandle = 0; // Metadata: 0x003A4A15
		public const string IVRSpatialAnchors_Version = "IVRSpatialAnchors_001"; // Metadata: 0x003A4A19
		public const string IVRDebug_Version = "IVRDebug_001"; // Metadata: 0x003A4A32
		public const ulong k_ulDisplayRedirectContainer = 25769803779; // Metadata: 0x003A4A42
		public const string IVRProperties_Version = "IVRProperties_001"; // Metadata: 0x003A4A4A
		public const string k_pchPathUserHandRight = "/user/hand/right"; // Metadata: 0x003A4A5F
		public const string k_pchPathUserHandLeft = "/user/hand/left"; // Metadata: 0x003A4A73
		public const string k_pchPathUserHandPrimary = "/user/hand/primary"; // Metadata: 0x003A4A86
		public const string k_pchPathUserHandSecondary = "/user/hand/secondary"; // Metadata: 0x003A4A9C
		public const string k_pchPathUserHead = "/user/head"; // Metadata: 0x003A4AB4
		public const string k_pchPathUserGamepad = "/user/gamepad"; // Metadata: 0x003A4AC2
		public const string k_pchPathUserTreadmill = "/user/treadmill"; // Metadata: 0x003A4AD3
		public const string k_pchPathUserStylus = "/user/stylus"; // Metadata: 0x003A4AE6
		public const string k_pchPathDevices = "/devices"; // Metadata: 0x003A4AF6
		public const string k_pchPathDevicePath = "/device_path"; // Metadata: 0x003A4B02
		public const string k_pchPathBestAliasPath = "/best_alias_path"; // Metadata: 0x003A4B12
		public const string k_pchPathBoundTrackerAliasPath = "/bound_tracker_path"; // Metadata: 0x003A4B26
		public const string k_pchPathBoundTrackerRole = "/bound_tracker_role"; // Metadata: 0x003A4B3D
		public const string k_pchPathPoseRaw = "/pose/raw"; // Metadata: 0x003A4B54
		public const string k_pchPathPoseTip = "/pose/tip"; // Metadata: 0x003A4B61
		public const string k_pchPathSystemButtonClick = "/input/system/click"; // Metadata: 0x003A4B6E
		public const string k_pchPathProximity = "/proximity"; // Metadata: 0x003A4B85
		public const string k_pchPathControllerTypePrefix = "/controller_type/"; // Metadata: 0x003A4B93
		public const string k_pchPathInputProfileSuffix = "/input_profile"; // Metadata: 0x003A4BA8
		public const string k_pchPathBindingNameSuffix = "/binding_name"; // Metadata: 0x003A4BBA
		public const string k_pchPathBindingUrlSuffix = "/binding_url"; // Metadata: 0x003A4BCB
		public const string k_pchPathBindingErrorSuffix = "/binding_error"; // Metadata: 0x003A4BDB
		public const string k_pchPathActiveActionSets = "/active_action_sets"; // Metadata: 0x003A4BED
		public const string k_pchPathComponentUpdates = "/total_component_updates"; // Metadata: 0x003A4C04
		public const string k_pchPathUserFootLeft = "/user/foot/left"; // Metadata: 0x003A4C20
		public const string k_pchPathUserFootRight = "/user/foot/right"; // Metadata: 0x003A4C33
		public const string k_pchPathUserShoulderLeft = "/user/shoulder/left"; // Metadata: 0x003A4C47
		public const string k_pchPathUserShoulderRight = "/user/shoulder/right"; // Metadata: 0x003A4C5E
		public const string k_pchPathUserElbowLeft = "/user/elbow/left"; // Metadata: 0x003A4C76
		public const string k_pchPathUserElbowRight = "/user/elbow/right"; // Metadata: 0x003A4C8A
		public const string k_pchPathUserKneeLeft = "/user/knee/left"; // Metadata: 0x003A4C9F
		public const string k_pchPathUserKneeRight = "/user/knee/right"; // Metadata: 0x003A4CB2
		public const string k_pchPathUserWaist = "/user/waist"; // Metadata: 0x003A4CC6
		public const string k_pchPathUserChest = "/user/chest"; // Metadata: 0x003A4CD5
		public const string k_pchPathUserCamera = "/user/camera"; // Metadata: 0x003A4CE4
		public const string k_pchPathUserKeyboard = "/user/keyboard"; // Metadata: 0x003A4CF4
		public const string k_pchPathClientAppKey = "/client_info/app_key"; // Metadata: 0x003A4D06
		public const ulong k_ulInvalidPathHandle = 0; // Metadata: 0x003A4D1E
		public const string IVRPaths_Version = "IVRPaths_001"; // Metadata: 0x003A4D26
		public const string IVRBlockQueue_Version = "IVRBlockQueue_004"; // Metadata: 0x003A4D36
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static uint _VRToken_k__BackingField; // 0x00
		private const string FnTable_Prefix = "FnTable:"; // Metadata: 0x003A4D4B
		private static COpenVRContext _OpenVRInternal_ModuleContext; // 0x08
	
		// Properties
		private static uint VRToken { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018091D1B0-0x000000018091D210 0x000000018091D210-0x000000018091D270
		private static COpenVRContext OpenVRInternal_ModuleContext { get; } // 0x000000018091CD50-0x000000018091CEB0 
		public static CVRSystem System { get; } // 0x000000018091D0F0-0x000000018091D150 
		public static CVRChaperone Chaperone { get; } // 0x000000018091CA50-0x000000018091CAB0 
		public static CVRChaperoneSetup ChaperoneSetup { get; } // 0x000000018091C9F0-0x000000018091CA50 
		public static CVRCompositor Compositor { get; } // 0x000000018091CAB0-0x000000018091CB10 
		public static CVRHeadsetView HeadsetView { get; } // 0x000000018091CBD0-0x000000018091CC30 
		public static CVROverlay Overlay { get; } // 0x000000018091CF10-0x000000018091CF70 
		public static CVROverlayView OverlayView { get; } // 0x000000018091CEB0-0x000000018091CF10 
		public static CVRRenderModels RenderModels { get; } // 0x000000018091CF70-0x000000018091CFD0 
		public static CVRExtendedDisplay ExtendedDisplay { get; } // 0x000000018091CB70-0x000000018091CBD0 
		public static CVRSettings Settings { get; } // 0x000000018091D030-0x000000018091D090 
		public static CVRApplications Applications { get; } // 0x000000018091C990-0x000000018091C9F0 
		public static CVRScreenshots Screenshots { get; } // 0x000000018091CFD0-0x000000018091D030 
		public static CVRTrackedCamera TrackedCamera { get; } // 0x000000018091D150-0x000000018091D1B0 
		public static CVRInput Input { get; } // 0x000000018091CC90-0x000000018091CCF0 
		public static CVRIOBuffer IOBuffer { get; } // 0x000000018091CC30-0x000000018091CC90 
		public static CVRSpatialAnchors SpatialAnchors { get; } // 0x000000018091D090-0x000000018091D0F0 
		public static CVRNotifications Notifications { get; } // 0x000000018091CCF0-0x000000018091CD50 
		public static CVRDebug Debug { get; } // 0x000000018091CB10-0x000000018091CB70 
	
		// Nested types
		private class COpenVRContext // TypeDefIndex: 6854
		{
			// Fields
			private CVRSystem m_pVRSystem; // 0x10
			private CVRChaperone m_pVRChaperone; // 0x18
			private CVRChaperoneSetup m_pVRChaperoneSetup; // 0x20
			private CVRCompositor m_pVRCompositor; // 0x28
			private CVRHeadsetView m_pVRHeadsetView; // 0x30
			private CVROverlay m_pVROverlay; // 0x38
			private CVROverlayView m_pVROverlayView; // 0x40
			private CVRRenderModels m_pVRRenderModels; // 0x48
			private CVRExtendedDisplay m_pVRExtendedDisplay; // 0x50
			private CVRSettings m_pVRSettings; // 0x58
			private CVRApplications m_pVRApplications; // 0x60
			private CVRScreenshots m_pVRScreenshots; // 0x68
			private CVRTrackedCamera m_pVRTrackedCamera; // 0x70
			private CVRInput m_pVRInput; // 0x78
			private CVRIOBuffer m_pVRIOBuffer; // 0x80
			private CVRSpatialAnchors m_pVRSpatialAnchors; // 0x88
			private CVRNotifications m_pVRNotifications; // 0x90
			private CVRDebug m_pVRDebug; // 0x98
	
			// Constructors
			public COpenVRContext(); // 0x0000000180902990-0x0000000180902A00
	
			// Methods
			public void Clear(); // 0x00000001808FFDF0-0x00000001808FFE50
			private void CheckClear(); // 0x00000001808FFC60-0x00000001808FFDF0
			public CVRSystem VRSystem(); // 0x0000000180902470-0x0000000180902730
			public CVRChaperone VRChaperone(); // 0x0000000180900380-0x00000001809005D0
			public CVRChaperoneSetup VRChaperoneSetup(); // 0x0000000180900100-0x0000000180900380
			public CVRCompositor VRCompositor(); // 0x00000001809005D0-0x0000000180900860
			public CVRHeadsetView VRHeadsetView(); // 0x0000000180900CD0-0x0000000180900F20
			public CVROverlay VROverlay(); // 0x0000000180901850-0x0000000180901B10
			public CVROverlayView VROverlayView(); // 0x0000000180901620-0x0000000180901850
			public CVRRenderModels VRRenderModels(); // 0x0000000180901B10-0x0000000180901DA0
			public CVRExtendedDisplay VRExtendedDisplay(); // 0x0000000180900AA0-0x0000000180900CD0
			public CVRSettings VRSettings(); // 0x0000000180901FE0-0x0000000180902230
			public CVRApplications VRApplications(); // 0x00000001808FFE50-0x0000000180900100
			public CVRScreenshots VRScreenshots(); // 0x0000000180901DA0-0x0000000180901FE0
			public CVRTrackedCamera VRTrackedCamera(); // 0x0000000180902730-0x0000000180902990
			public CVRInput VRInput(); // 0x0000000180901160-0x00000001809013F0
			public CVRIOBuffer VRIOBuffer(); // 0x0000000180900F20-0x0000000180901160
			public CVRSpatialAnchors VRSpatialAnchors(); // 0x0000000180902230-0x0000000180902470
			public CVRDebug VRDebug(); // 0x0000000180900860-0x0000000180900AA0
			public CVRNotifications VRNotifications(); // 0x00000001809013F0-0x0000000180901620
		}
	
		// Constructors
		public OpenVR(); // 0x00000001802650F0-0x0000000180265100
		static OpenVR(); // 0x0000000180265310-0x0000000180265320
	
		// Methods
		public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType); // 0x000000018091A6F0-0x000000018091A780
		public static uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, string pchStartupInfo); // 0x000000018091A630-0x000000018091A6F0
		public static void ShutdownInternal(); // 0x000000018091A990-0x000000018091AA00
		public static bool IsHmdPresent(); // 0x000000018091A780-0x000000018091A7F0
		public static bool IsRuntimeInstalled(); // 0x000000018091A890-0x000000018091A900
		public static string RuntimePath(); // 0x000000018091C800-0x000000018091C940
		public static string GetStringForHmdError(EVRInitError error); // 0x000000018091C3F0-0x000000018091C4B0
		public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError); // 0x000000018091C3E0-0x000000018091C3F0
		public static bool IsInterfaceVersionValid(string pchInterfaceVersion); // 0x000000018091A7F0-0x000000018091A890
		public static uint GetInitToken(); // 0x000000018091A470-0x000000018091A4E0
		public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene /* Metadata: 0x003A363F */, string pchStartupInfo = "" /* Metadata: 0x003A3643 */); // 0x000000018091C4B0-0x000000018091C800
		public static void Shutdown(); // 0x000000018091C940-0x000000018091C990
	}
}
