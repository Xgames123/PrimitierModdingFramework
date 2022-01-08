/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class ControllerHoverHighlight : MonoBehaviour // TypeDefIndex: 7388
	{
		// Fields
		public Material highLightMaterial; // 0x18
		public bool fireHapticsOnHightlight; // 0x20
		protected Hand hand; // 0x28
		protected RenderModel renderModel; // 0x30
		protected SteamVR_Events.Action renderModelLoadedAction; // 0x38
	
		// Constructors
		public ControllerHoverHighlight(); // 0x0000000180484390-0x00000001804843A0
	
		// Methods
		protected void Awake(); // 0x000000018058F360-0x000000018058F3A0
		protected void OnHandInitialized(int deviceIndex); // 0x000000018058F470-0x000000018058F780
		private void RenderModel_onControllerLoaded(); // 0x000000018058F9A0-0x000000018058F9C0
		protected void OnParentHandHoverBegin(Interactable other); // 0x000000018058F780-0x000000018058F860
		private void OnParentHandHoverEnd(Interactable other); // 0x000000018058F860-0x000000018058F870
		private void OnParentHandInputFocusAcquired(); // 0x000000018058F870-0x000000018058F9A0
		private void OnParentHandInputFocusLost(); // 0x000000018058F860-0x000000018058F870
		public void ShowHighlight(); // 0x000000018058F9C0-0x000000018058FA90
		public void HideHighlight(); // 0x000000018058F3A0-0x000000018058F470
	}
}
