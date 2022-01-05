/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	[ExecuteInEditMode] // 0x0000000180014D50-0x0000000180014D60
	public class LuxWater_PlanarReflection : MonoBehaviour // TypeDefIndex: 8751
	{
		// Fields
		[LuxWater_HelpBtn] // 0x000000018002E480-0x000000018002E4D0
		[Space] // 0x000000018002E480-0x000000018002E4D0
		public bool UpdateSceneView; // 0x18
		[Space] // 0x000000018002E4D0-0x000000018002E4F0
		public bool isMaster; // 0x19
		public Material[] WaterMaterials; // 0x20
		[Space] // 0x000000018002E4D0-0x000000018002E4F0
		public LayerMask reflectionMask; // 0x28
		public ReflectionResolution Resolution; // 0x2C
		public Color clearColor; // 0x30
		public bool reflectSkybox; // 0x40
		[Space] // 0x000000018002E4D0-0x000000018002E4F0
		public bool disablePixelLights; // 0x41
		[Space] // 0x000000018002E4D0-0x000000018002E4F0
		public bool renderShadows; // 0x42
		public float shadowDistance; // 0x44
		public NumberOfShadowCascades ShadowCascades; // 0x48
		[Space] // 0x000000018002E4D0-0x000000018002E4F0
		public float WaterSurfaceOffset; // 0x4C
		public float clipPlaneOffset; // 0x50
		private string reflectionSampler; // 0x58
		private Vector3 m_Oldpos; // 0x60
		private Camera m_ReflectionCamera; // 0x70
		private Material m_SharedMaterial; // 0x78
		private Dictionary<Camera, bool> m_HelperCameras; // 0x80
		private RenderTexture m_reflectionMap; // 0x88
	
		// Nested types
		public enum ReflectionResolution // TypeDefIndex: 8749
		{
			Full = 1,
			Half = 2,
			Quarter = 4,
			Eighth = 8
		}
	
		public enum NumberOfShadowCascades // TypeDefIndex: 8750
		{
			One = 1,
			Two = 2,
			Four = 4
		}
	
		// Constructors
		public LuxWater_PlanarReflection(); // 0x000000018047BB80-0x000000018047BC00
	
		// Methods
		private void OnEnable(); // 0x000000018047AC30-0x000000018047AD20
		private void OnDisable(); // 0x000000018047AB50-0x000000018047AC30
		private Camera CreateReflectionCameraFor(Camera cam); // 0x000000018047A5D0-0x000000018047AA30
		private void SetStandardCameraParameter(Camera cam, LayerMask mask); // 0x000000018047B9C0-0x000000018047BA60
		private RenderTexture CreateTextureFor(Camera cam); // 0x000000018047AA30-0x000000018047AB00
		public void RenderHelpCameras(Camera currentCam); // 0x000000018047AD60-0x000000018047AF40
		public void LateUpdate(); // 0x000000018047AB00-0x000000018047AB50
		public void WaterTileBeingRendered(Transform tr, Camera currentCam); // 0x000000018047BA90-0x000000018047BB80
		public void OnWillRenderObject(); // 0x000000018047AD20-0x000000018047AD60
		private void RenderReflectionFor(Camera cam, Camera reflectCamera); // 0x000000018047AF40-0x000000018047B950
		private void SaneCameraSettings(Camera helperCam); // 0x000000018047B950-0x000000018047B9C0
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane); // 0x0000000180479E40-0x000000018047A090
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane); // 0x000000018047A090-0x000000018047A3A0
		private static float Sgn(float a); // 0x000000018047BA60-0x000000018047BA90
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign); // 0x000000018047A3A0-0x000000018047A5D0
	}
}
