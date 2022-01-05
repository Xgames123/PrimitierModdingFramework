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
	public class TeleportArea : TeleportMarkerBase // TypeDefIndex: 7490
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Bounds _meshBounds_k__BackingField; // 0x20
		private MeshRenderer areaMesh; // 0x38
		private int tintColorId; // 0x40
		private Color visibleTintColor; // 0x44
		private Color highlightedTintColor; // 0x54
		private Color lockedTintColor; // 0x64
		private bool highlighted; // 0x74
	
		// Properties
		public Bounds meshBounds { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180294640-0x0000000180294660 0x0000000180294660-0x0000000180294680
	
		// Constructors
		public TeleportArea(); // 0x00000001802945E0-0x0000000180294640
	
		// Methods
		public void Awake(); // 0x0000000180293F10-0x0000000180294050
		public void Start(); // 0x00000001802942E0-0x00000001802943C0
		public override bool ShouldActivate(Vector3 playerPosition); // 0x00000001802942D0-0x00000001802942E0
		public override bool ShouldMovePlayer(); // 0x00000001802942D0-0x00000001802942E0
		public override void Highlight(bool highlight); // 0x0000000180294180-0x0000000180294250
		public override void SetAlpha(float tintAlpha, float alphaPercent); // 0x0000000180294250-0x00000001802942D0
		public override void UpdateVisuals(); // 0x0000000180294510-0x00000001802945E0
		public void UpdateVisualsInEditor(); // 0x00000001802943C0-0x0000000180294510
		private bool CalculateBounds(); // 0x0000000180294050-0x0000000180294150
		private Color GetTintColor(); // 0x0000000180294150-0x0000000180294180
	}
}
