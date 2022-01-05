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
	[ExecuteInEditMode] // 0x0000000180014D50-0x0000000180014D60
	public class SteamVR_SphericalProjection : MonoBehaviour // TypeDefIndex: 7374
	{
		// Fields
		private static Material material; // 0x00
	
		// Constructors
		public SteamVR_SphericalProjection(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public void Set(Vector3 N, float phi0, float phi1, float theta0, float theta1, Vector3 uAxis, Vector3 uOrigin, float uScale, Vector3 vAxis, Vector3 vOrigin, float vScale); // 0x0000000180C73840-0x0000000180C73D20
		private void OnRenderImage(RenderTexture src, RenderTexture dest); // 0x0000000180C737B0-0x0000000180C73840
	}
}
