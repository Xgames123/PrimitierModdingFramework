/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public abstract class TeleportMarkerBase : MonoBehaviour // TypeDefIndex: 7491
	{
		// Fields
		public bool locked; // 0x18
		public bool markerActive; // 0x19
	
		// Properties
		public virtual bool showReticle { get; } // 0x00000001802942D0-0x00000001802942E0 
	
		// Constructors
		protected TeleportMarkerBase(); // 0x00000001802946A0-0x00000001802946B0
	
		// Methods
		public void SetLocked(bool locked); // 0x0000000180294680-0x00000001802946A0
		public virtual void TeleportPlayer(Vector3 pointedAtPosition); // 0x0000000180265310-0x0000000180265320
		public abstract void UpdateVisuals();
		public abstract void Highlight(bool highlight);
		public abstract void SetAlpha(float tintAlpha, float alphaPercent);
		public abstract bool ShouldActivate(Vector3 playerPosition);
		public abstract bool ShouldMovePlayer();
	}
}
