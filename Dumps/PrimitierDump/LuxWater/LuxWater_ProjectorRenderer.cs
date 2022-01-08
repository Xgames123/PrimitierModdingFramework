/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace LuxWater
{
	[ExecuteInEditMode] // 0x000000018002E540-0x000000018002E5A0
	[RequireComponent] // 0x000000018002E540-0x000000018002E5A0
	public class LuxWater_ProjectorRenderer : MonoBehaviour // TypeDefIndex: 8756
	{
		// Fields
		[Space] // 0x000000018002D020-0x000000018002D040
		public BufferResolution FoamBufferResolution; // 0x18
		public BufferResolution NormalBufferResolution; // 0x1C
		[Header] // 0x000000018002E5A0-0x000000018002E610
		[Space] // 0x000000018002E5A0-0x000000018002E610
		[Space] // 0x000000018002E5A0-0x000000018002E610
		public bool DebugFoamBuffer; // 0x20
		public bool DebugNormalBuffer; // 0x21
		public bool DebugStats; // 0x22
		private int drawnFoamProjectors; // 0x24
		private int drawnNormalProjectors; // 0x28
		private static CommandBuffer cb_Foam; // 0x00
		private static CommandBuffer cb_Normals; // 0x08
		private Camera cam; // 0x30
		private Transform camTransform; // 0x38
		private RenderTexture ProjectedFoam; // 0x40
		private RenderTexture ProjectedNormals; // 0x48
		private Texture2D defaultBump; // 0x50
		private Bounds tempBounds; // 0x58
		private int _LuxWater_FoamOverlayPID; // 0x70
		private int _LuxWater_NormalOverlayPID; // 0x74
		private Plane[] frustumPlanes; // 0x78
		private Material DebugMat; // 0x80
		private Material DebugNormalMat; // 0x88
	
		// Nested types
		public enum BufferResolution // TypeDefIndex: 8755
		{
			Full = 1,
			Half = 2,
			Quarter = 4,
			Eighth = 8
		}
	
		// Constructors
		public LuxWater_ProjectorRenderer(); // 0x000000018047D2A0-0x000000018047D300
	
		// Methods
		private void OnEnable(); // 0x000000018047C3F0-0x000000018047C5A0
		private void OnDisable(); // 0x000000018047BDA0-0x000000018047C040
		private void OnPreCull(); // 0x000000018047C880-0x000000018047D2A0
		private void OnDrawGizmos(); // 0x000000018047C040-0x000000018047C3F0
		private void OnGUI(); // 0x000000018047C5A0-0x000000018047C880
	}
}
