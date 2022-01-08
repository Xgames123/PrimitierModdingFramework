/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class TeleportPoint : TeleportMarkerBase // TypeDefIndex: 7493
	{
		// Fields
		public TeleportPointType teleportType; // 0x20
		public string title; // 0x28
		public string switchToScene; // 0x30
		public Color titleVisibleColor; // 0x38
		public Color titleHighlightedColor; // 0x48
		public Color titleLockedColor; // 0x58
		public bool playerSpawnPoint; // 0x68
		private bool gotReleventComponents; // 0x69
		private MeshRenderer markerMesh; // 0x70
		private MeshRenderer switchSceneIcon; // 0x78
		private MeshRenderer moveLocationIcon; // 0x80
		private MeshRenderer lockedIcon; // 0x88
		private MeshRenderer pointIcon; // 0x90
		private Transform lookAtJointTransform; // 0x98
		private Animation animation; // 0xA0
		private UnityEngine.UI.Text titleText; // 0xA8
		private Player player; // 0xB0
		private Vector3 lookAtPosition; // 0xB8
		private int tintColorID; // 0xC4
		private Color tintColor; // 0xC8
		private Color titleColor; // 0xD8
		private float fullTitleAlpha; // 0xE8
		private const string switchSceneAnimation = "switch_scenes_idle"; // Metadata: 0x003A5B17
		private const string moveLocationAnimation = "move_location_idle"; // Metadata: 0x003A5B2D
		private const string lockedAnimation = "locked_idle"; // Metadata: 0x003A5B43
	
		// Properties
		public override bool showReticle { get; } // 0x0000000180295620-0x0000000180295630 
	
		// Nested types
		public enum TeleportPointType // TypeDefIndex: 7492
		{
			MoveToLocation = 0,
			SwitchToNewScene = 1
		}
	
		// Constructors
		public TeleportPoint(); // 0x00000001802955B0-0x0000000180295620
	
		// Methods
		private void Awake(); // 0x00000001802946B0-0x00000001802947A0
		private void Start(); // 0x0000000180294E20-0x0000000180294E40
		private void Update(); // 0x0000000180295480-0x00000001802955B0
		public override bool ShouldActivate(Vector3 playerPosition); // 0x0000000180294DB0-0x0000000180294E20
		public override bool ShouldMovePlayer(); // 0x00000001802942D0-0x00000001802942E0
		public override void Highlight(bool highlight); // 0x00000001802949A0-0x0000000180294B00
		public override void UpdateVisuals(); // 0x00000001802952C0-0x0000000180295480
		public override void SetAlpha(float tintAlpha, float alphaPercent); // 0x0000000180294B30-0x0000000180294CE0
		public void SetMeshMaterials(Material material, Color textColor); // 0x0000000180294CE0-0x0000000180294DB0
		public void TeleportToScene(); // 0x0000000180294E40-0x0000000180294F30
		public void GetRelevantComponents(); // 0x00000001802947A0-0x00000001802949A0
		public void ReleaseRelevantComponents(); // 0x0000000180294B00-0x0000000180294B30
		public void UpdateVisualsInEditor(); // 0x0000000180294F30-0x00000001802952C0
	}
}
