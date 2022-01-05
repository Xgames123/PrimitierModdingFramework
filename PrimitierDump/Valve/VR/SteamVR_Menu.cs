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
	public class SteamVR_Menu : MonoBehaviour // TypeDefIndex: 7355
	{
		// Fields
		public Texture cursor; // 0x18
		public Texture background; // 0x20
		public Texture logo; // 0x28
		public float logoHeight; // 0x30
		public float menuOffset; // 0x34
		public Vector2 scaleLimits; // 0x38
		public float scaleRate; // 0x40
		private SteamVR_Overlay overlay; // 0x48
		private Camera overlayCam; // 0x50
		private Vector4 uvOffset; // 0x58
		private float distance; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _scale_k__BackingField; // 0x6C
		private string scaleLimitX; // 0x70
		private string scaleLimitY; // 0x78
		private string scaleRateText; // 0x80
		private CursorLockMode savedCursorLockState; // 0x88
		private bool savedCursorVisible; // 0x8C
	
		// Properties
		public RenderTexture texture { get; } // 0x0000000180C690D0-0x0000000180C691B0 
		public float scale { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180313890-0x00000001803138A0 0x0000000180783A70-0x0000000180783A80
	
		// Constructors
		public SteamVR_Menu(); // 0x0000000180C690B0-0x0000000180C690D0
	
		// Methods
		private void Awake(); // 0x0000000180C67A00-0x0000000180C67B60
		private void OnGUI(); // 0x0000000180C67C60-0x0000000180C68AB0
		public void ShowMenu(); // 0x0000000180C68BE0-0x0000000180C68F50
		public void HideMenu(); // 0x0000000180C67B60-0x0000000180C67C60
		private void Update(); // 0x0000000180C68F50-0x0000000180C690B0
		private void SetScale(float scale); // 0x0000000180C68B10-0x0000000180C68BE0
		private void SaveCursorState(); // 0x0000000180C68AE0-0x0000000180C68B10
		private void RestoreCursorState(); // 0x0000000180C68AB0-0x0000000180C68AE0
	}
}
