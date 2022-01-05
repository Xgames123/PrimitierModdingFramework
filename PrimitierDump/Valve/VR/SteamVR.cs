/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR : IDisposable // TypeDefIndex: 7327
	{
		// Fields
		private static bool _enabled; // 0x00
		private static SteamVR _instance; // 0x08
		public static InitializedStates initializedState; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static SteamVR_Settings _settings_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private CVRSystem _hmd_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private CVRCompositor _compositor_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private CVROverlay _overlay_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static bool _initializing_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static bool _calibrating_k__BackingField; // 0x21
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static bool _outOfRange_k__BackingField; // 0x22
		public static bool[] connected; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _sceneWidth_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _sceneHeight_k__BackingField; // 0x2C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _aspect_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _fieldOfView_k__BackingField; // 0x34
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 _tanHalfFov_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private VRTextureBounds_t[] _textureBounds_k__BackingField; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private SteamVR_Utils.RigidTransform[] _eyes_k__BackingField; // 0x48
		public ETextureType textureType; // 0x50
		private static bool runningTemporarySession; // 0x30
		public const string defaultUnityAppKeyTemplate = "application.generated.unity.{0}.exe"; // Metadata: 0x003A5716
		public const string defaultAppKeyTemplate = "application.generated.{0}"; // Metadata: 0x003A573D
	
		// Properties
		public static bool active { get; } // 0x000000018036AC60-0x000000018036ACC0 
		public static bool enabled { get; set; } // 0x000000018036AD20-0x000000018036ADC0 0x000000018036B270-0x000000018036B520
		public static SteamVR instance { get; } // 0x000000018036AEE0-0x000000018036B090 
		public static bool usingNativeSupport { get; } // 0x000000018036B190-0x000000018036B200 
		public static SteamVR_Settings settings { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B110-0x000000018036B170 0x000000018036B610-0x000000018036B670
		public CVRSystem hmd { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public CVRCompositor compositor { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public CVROverlay overlay { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public static bool initializing { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036AE80-0x000000018036AEE0 0x000000018036B530-0x000000018036B590
		public static bool calibrating { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036ACC0-0x000000018036AD20 0x000000018036B210-0x000000018036B270
		public static bool outOfRange { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B090-0x000000018036B0F0 0x000000018036B590-0x000000018036B5F0
		public float sceneWidth { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B100-0x000000018036B110 0x000000018036B600-0x000000018036B610
		public float sceneHeight { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B0F0-0x000000018036B100 0x000000018036B5F0-0x000000018036B600
		public float aspect { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803496C0-0x00000001803496D0 0x000000018036B200-0x000000018036B210
		public float fieldOfView { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180349570-0x0000000180349580 0x000000018036B520-0x000000018036B530
		public Vector2 tanHalfFov { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036B170-0x000000018036B190 0x000000018036B670-0x000000018036B690
		public VRTextureBounds_t[] textureBounds { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public SteamVR_Utils.RigidTransform[] eyes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public string hmd_TrackingSystemName { get; } // 0x000000018036AE60-0x000000018036AE70 
		public string hmd_ModelNumber { get; } // 0x000000018036AE00-0x000000018036AE10 
		public string hmd_SerialNumber { get; } // 0x000000018036AE50-0x000000018036AE60 
		public string hmd_Type { get; } // 0x000000018036AE70-0x000000018036AE80 
		public float hmd_SecondsFromVsyncToPhotons { get; } // 0x000000018036AE10-0x000000018036AE50 
		public float hmd_DisplayFrequency { get; } // 0x000000018036ADC0-0x000000018036AE00 
	
		// Nested types
		public enum InitializedStates // TypeDefIndex: 7326
		{
			None = 0,
			Initializing = 1,
			InitializeSuccess = 2,
			InitializeFailure = 3
		}
	
		// Constructors
		private SteamVR(); // 0x000000018036A010-0x000000018036AC60
		static SteamVR(); // 0x0000000180369F80-0x000000018036A010
	
		// Methods
		public static void Initialize(bool forceUnityVRMode = false /* Metadata: 0x003A570B */); // 0x0000000180369300-0x0000000180369480
		private static void ReportGeneralErrors(); // 0x0000000180369E00-0x0000000180369E80
		private static SteamVR CreateInstance(); // 0x00000001803676C0-0x0000000180367D30
		private static void ReportError(EVRInitError error); // 0x0000000180369C70-0x0000000180369E00
		public EDeviceActivityLevel GetHeadsetActivityLevel(); // 0x00000001803683E0-0x0000000180368450
		public string GetTrackedDeviceString(uint deviceId); // 0x0000000180368C30-0x0000000180368D30
		public string GetStringProperty(ETrackedDeviceProperty prop, uint deviceId = 0 /* Metadata: 0x003A570C */); // 0x0000000180368AC0-0x0000000180368C30
		public float GetFloatProperty(ETrackedDeviceProperty prop, uint deviceId = 0 /* Metadata: 0x003A5710 */); // 0x00000001803683A0-0x00000001803683E0
		public static bool InitializeTemporarySession(bool initInput = false /* Metadata: 0x003A5714 */); // 0x00000001803690B0-0x0000000180369300
		public static void ExitTemporarySession(); // 0x0000000180368090-0x0000000180368150
		public static string GenerateAppKey(); // 0x00000001803681B0-0x00000001803682D0
		public static string GenerateCleanProductName(); // 0x00000001803682D0-0x00000001803683A0
		private static string GetManifestFile(); // 0x0000000180368450-0x0000000180368AC0
		private static void IdentifyEditorApplication(bool showLogs = true /* Metadata: 0x003A5715 */); // 0x0000000180368D30-0x00000001803690B0
		private void OnInitializing(bool initializing); // 0x00000001803695C0-0x0000000180369670
		private void OnCalibrating(bool calibrating); // 0x0000000180369480-0x0000000180369530
		private void OnOutOfRange(bool outOfRange); // 0x0000000180369BC0-0x0000000180369C70
		private void OnDeviceConnected(int i, bool connected); // 0x0000000180369530-0x00000001803695C0
		private void OnNewPoses(TrackedDevicePose_t[] poses); // 0x0000000180369670-0x0000000180369BC0
		~SteamVR(); // 0x0000000180368150-0x00000001803681B0
		public void Dispose(); // 0x0000000180367D30-0x0000000180367D90
		private void Dispose(bool disposing); // 0x0000000180367D90-0x0000000180368090
		public static void SafeDispose(); // 0x0000000180369E80-0x0000000180369F80
	}
}
