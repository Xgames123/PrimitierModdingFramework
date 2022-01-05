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
	public class SteamVR_Fade : MonoBehaviour // TypeDefIndex: 7350
	{
		// Fields
		private Color currentColor; // 0x18
		private Color targetColor; // 0x28
		private Color deltaColor; // 0x38
		private bool fadeOverlay; // 0x48
		private static Material fadeMaterial; // 0x00
		private static int fadeMaterialColorID; // 0x08
	
		// Constructors
		public SteamVR_Fade(); // 0x0000000180325D30-0x0000000180325DF0
		static SteamVR_Fade(); // 0x0000000180325CE0-0x0000000180325D30
	
		// Methods
		public static void Start(Color newColor, float duration, bool fadeOverlay = false /* Metadata: 0x003A57A4 */); // 0x0000000180325B80-0x0000000180325C40
		public static void View(Color newColor, float duration); // 0x0000000180325C40-0x0000000180325CE0
		public void OnStartFade(Color newColor, float duration, bool fadeOverlay); // 0x0000000180325AF0-0x0000000180325B80
		private void OnEnable(); // 0x0000000180325570-0x0000000180325790
		private void OnDisable(); // 0x0000000180325480-0x0000000180325570
		private void OnPostRender(); // 0x0000000180325790-0x0000000180325AF0
	}
}
