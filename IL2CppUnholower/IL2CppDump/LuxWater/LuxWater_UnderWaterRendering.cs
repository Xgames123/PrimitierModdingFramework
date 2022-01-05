/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	[RequireComponent] // 0x000000018002E6B0-0x000000018002E700
	public class LuxWater_UnderWaterRendering : MonoBehaviour // TypeDefIndex: 8759
	{
		// Fields
		public static LuxWater_UnderWaterRendering instance; // 0x00
		[LuxWater_HelpBtn] // 0x000000018002E700-0x000000018002E750
		[Space] // 0x000000018002E700-0x000000018002E750
		public Transform Sun; // 0x18
		[Space] // 0x000000018002E750-0x000000018002E770
		public bool FindSunOnEnable; // 0x20
		public string SunGoName; // 0x28
		public string SunTagName; // 0x30
		private Light SunLight; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LuxWater_UnderWaterOnRenderImage underWaterOnRenderImage; // 0x40
		[Header] // 0x000000018002E770-0x000000018002E7E0
		[Space] // 0x000000018002E770-0x000000018002E7E0
		[Space] // 0x000000018002E770-0x000000018002E7E0
		public bool EnableDeepwaterLighting; // 0x48
		public float DefaultWaterSurfacePosition; // 0x4C
		public float DirectionalLightingFadeRange; // 0x50
		public float FogLightingFadeRange; // 0x54
		[Header] // 0x000000018002E7E0-0x000000018002E850
		[Space] // 0x000000018002E7E0-0x000000018002E850
		[Space] // 0x000000018002E7E0-0x000000018002E850
		public bool EnableAdvancedDeferredFog; // 0x58
		public float FogDepthShift; // 0x5C
		public float FogEdgeBlending; // 0x60
		[NonSerialized]
		[Space] // 0x000000018002D020-0x000000018002D040
		public int activeWaterVolume; // 0x64
		[NonSerialized]
		public List<Camera> activeWaterVolumeCameras; // 0x68
		[NonSerialized]
		public float activeGridSize; // 0x70
		[NonSerialized]
		public float WaterSurfacePos; // 0x74
		[NonSerialized]
		[Space] // 0x000000018002D020-0x000000018002D040
		public List<int> RegisteredWaterVolumesIDs; // 0x78
		[NonSerialized]
		public List<LuxWater_WaterVolume> RegisteredWaterVolumes; // 0x80
		private List<Mesh> WaterMeshes; // 0x88
		private List<Transform> WaterTransforms; // 0x90
		private List<Material> WaterMaterials; // 0x98
		private List<bool> WaterIsOnScreen; // 0xA0
		private List<bool> WaterUsesSlidingVolume; // 0xA8
		private RenderTexture UnderWaterMask; // 0xB0
		[Header] // 0x000000018002E850-0x000000018002E8C0
		[Space] // 0x000000018002E850-0x000000018002E8C0
		[Space] // 0x000000018002E850-0x000000018002E8C0
		public List<Material> m_aboveWatersurface; // 0xB8
		public List<Material> m_belowWatersurface; // 0xC0
		[Header] // 0x000000018002E8C0-0x000000018002E930
		[Space] // 0x000000018002E8C0-0x000000018002E930
		[Space] // 0x000000018002E8C0-0x000000018002E930
		public ShaderVariantCollection PrewarmedShaders; // 0xC8
		public int ListCapacity; // 0xD0
		[Header] // 0x000000018002E930-0x000000018002E990
		[Space] // 0x000000018002E930-0x000000018002E990
		[Space] // 0x000000018002E930-0x000000018002E990
		public bool enableDebug; // 0xD4
		[Space] // 0x000000018002D020-0x000000018002D040
		private Material mat; // 0xD8
		private Material blurMaterial; // 0xE0
		private Material blitMaterial; // 0xE8
		private Camera cam; // 0xF0
		private bool UnderwaterIsSetUp; // 0xF8
		private static CommandBuffer cb_Mask; // 0x08
		private CameraEvent cameraEvent; // 0xFC
		private Transform camTransform; // 0x100
		private Matrix4x4 frustumCornersArray; // 0x108
		private Matrix4x4 frustumCornersArray2nd; // 0x148
		private SphericalHarmonicsL2 ambientProbe; // 0x188
		private Vector3[] directions; // 0x1F8
		private Color[] AmbientLightingSamples; // 0x200
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _DoUnderWaterRendering_k__BackingField; // 0x208
		private Matrix4x4 camProj; // 0x20C
		private Vector3[] frustumCorners; // 0x250
		private float Projection; // 0x258
		private bool islinear; // 0x25C
		private Matrix4x4 WatervolumeMatrix; // 0x260
		private static readonly int UnderWaterMaskPID; // 0x10
		private static readonly int Lux_FrustumCornersWSPID; // 0x14
		private static readonly int Lux_FrustumCornersWS2ndPID; // 0x18
		private static readonly int Lux_CameraWSPID; // 0x1C
		private static readonly int GerstnerEnabledPID; // 0x20
		private static readonly int LuxWaterMask_GerstnerVertexIntensityPID; // 0x24
		private static readonly int GerstnerVertexIntensityPID; // 0x28
		private static readonly int LuxWaterMask_GAmplitudePID; // 0x2C
		private static readonly int GAmplitudePID; // 0x30
		private static readonly int LuxWaterMask_GFinalFrequencyPID; // 0x34
		private static readonly int GFinalFrequencyPID; // 0x38
		private static readonly int LuxWaterMask_GSteepnessPID; // 0x3C
		private static readonly int GSteepnessPID; // 0x40
		private static readonly int LuxWaterMask_GFinalSpeedPID; // 0x44
		private static readonly int GFinalSpeedPID; // 0x48
		private static readonly int LuxWaterMask_GDirectionABPID; // 0x4C
		private static readonly int GDirectionABPID; // 0x50
		private static readonly int LuxWaterMask_GDirectionCDPID; // 0x54
		private static readonly int GDirectionCDPID; // 0x58
		private static readonly int LuxWaterMask_GerstnerSecondaryWaves; // 0x5C
		private static readonly int GerstnerSecondaryWaves; // 0x60
		private static readonly int Lux_UnderWaterAmbientSkyLightPID; // 0x64
		private static readonly int Lux_UnderWaterSunColorPID; // 0x68
		private static readonly int Lux_UnderWaterSunDirPID; // 0x6C
		private static readonly int Lux_UnderWaterSunDirViewSpacePID; // 0x70
		private static readonly int Lux_EdgeLengthPID; // 0x74
		private static readonly int Lux_MaxDirLightDepthPID; // 0x78
		private static readonly int Lux_MaxFogLightDepthPID; // 0x7C
		private static readonly int Lux_CausticsEnabledPID; // 0x80
		private static readonly int Lux_CausticModePID; // 0x84
		private static readonly int Lux_UnderWaterFogColorPID; // 0x88
		private static readonly int Lux_UnderWaterFogDensityPID; // 0x8C
		private static readonly int Lux_UnderWaterFogAbsorptionCancellationPID; // 0x90
		private static readonly int Lux_UnderWaterAbsorptionHeightPID; // 0x94
		private static readonly int Lux_UnderWaterAbsorptionMaxHeightPID; // 0x98
		private static readonly int Lux_UnderWaterAbsorptionDepthPID; // 0x9C
		private static readonly int Lux_UnderWaterAbsorptionColorStrengthPID; // 0xA0
		private static readonly int Lux_UnderWaterAbsorptionStrengthPID; // 0xA4
		private static readonly int Lux_UnderWaterUnderwaterScatteringPowerPID; // 0xA8
		private static readonly int Lux_UnderWaterUnderwaterScatteringIntensityPID; // 0xAC
		private static readonly int Lux_UnderWaterUnderwaterScatteringColorPID; // 0xB0
		private static readonly int Lux_UnderWaterUnderwaterScatteringOcclusionPID; // 0xB4
		private static readonly int Lux_UnderWaterCausticsPID; // 0xB8
		private static readonly int Lux_UnderWaterDeferredFogParams; // 0xBC
		private static readonly int CausticTexPID; // 0xC0
		private static readonly int Lux_UnderWaterCausticsTilingPID; // 0xC4
		private static readonly int Lux_UnderWaterCausticsScalePID; // 0xC8
		private static readonly int Lux_UnderWaterCausticsSpeedPID; // 0xCC
		private static readonly int Lux_UnderWaterCausticsSelfDistortionPID; // 0xD0
		private static readonly int Lux_UnderWaterFinalBumpSpeed01PID; // 0xD4
		private static readonly int Lux_UnderWaterFogDepthAttenPID; // 0xD8
	
		// Properties
		public bool DoUnderWaterRendering { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001803E8A30-0x00000001803E8A40 0x0000000180483A90-0x0000000180483AA0
	
		// Constructors
		public LuxWater_UnderWaterRendering(); // 0x00000001804836C0-0x0000000180483A90
		static LuxWater_UnderWaterRendering(); // 0x0000000180482DC0-0x00000001804836C0
	
		// Methods
		private void OnEnable(); // 0x000000018047F200-0x000000018047F810
		private void CleanUp(); // 0x000000018047E9B0-0x000000018047EC60
		private void OnDisable(); // 0x000000018047F1F0-0x000000018047F200
		private void OnDestroy(); // 0x000000018047F1F0-0x000000018047F200
		private void OnValidate(); // 0x000000018047F8B0-0x000000018047F8D0
		public void SetDeferredFogParams(); // 0x00000001804825C0-0x00000001804826B0
		public void SetDeepwaterLighting(); // 0x0000000180482500-0x00000001804825C0
		public void RegisterWaterVolume(LuxWater_WaterVolume item, int ID, bool visible, bool SlidingVolume); // 0x000000018047F8D0-0x000000018047FB70
		public void DeRegisterWaterVolume(LuxWater_WaterVolume item, int ID); // 0x000000018047EC60-0x000000018047EDD0
		public void SetWaterVisible(int ID); // 0x0000000180482CB0-0x0000000180482D30
		public void SetWaterInvisible(int ID); // 0x0000000180482C30-0x0000000180482CB0
		public void EnteredWaterVolume(LuxWater_WaterVolume item, int ID, Camera triggerCam, float GridSize); // 0x000000018047EDD0-0x000000018047F010
		public void LeftWaterVolume(LuxWater_WaterVolume item, int ID, Camera triggerCam); // 0x000000018047F010-0x000000018047F1F0
		private void OnPreRender(); // 0x000000018047F810-0x000000018047F8B0
		private void Update(); // 0x0000000180482D30-0x0000000180482DC0
		public void SetGerstnerWaves(int index); // 0x00000001804826B0-0x0000000180482C30
		public void RenderWaterMask(Camera currentCamera, bool SecondaryCameraRendering, CommandBuffer cmb); // 0x0000000180480B50-0x0000000180482500
		public void RenderUnderWater(RenderTexture src, RenderTexture dest, Camera currentCamera, bool SecondaryCameraRendering); // 0x000000018047FB70-0x0000000180480B50
	}
}
