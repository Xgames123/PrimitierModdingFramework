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
	public class TeleportArc : MonoBehaviour // TypeDefIndex: 7489
	{
		// Fields
		public int segmentCount; // 0x18
		public float thickness; // 0x1C
		[Tooltip] // 0x0000000180026500-0x0000000180026530
		public float arcDuration; // 0x20
		[Tooltip] // 0x0000000180026530-0x0000000180026560
		public float segmentBreak; // 0x24
		[Tooltip] // 0x0000000180026560-0x0000000180026590
		public float arcSpeed; // 0x28
		public Material material; // 0x30
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public int traceLayerMask; // 0x38
		private LineRenderer[] lineRenderers; // 0x40
		private float arcTimeOffset; // 0x48
		private float prevThickness; // 0x4C
		private int prevSegmentCount; // 0x50
		private bool showArc; // 0x54
		private Vector3 startPos; // 0x58
		private Vector3 projectileVelocity; // 0x64
		private bool useGravity; // 0x70
		private Transform arcObjectsTransfrom; // 0x78
		private bool arcInvalid; // 0x80
		private float scale; // 0x84
	
		// Constructors
		public TeleportArc(); // 0x0000000180293ED0-0x0000000180293F10
	
		// Methods
		private void Start(); // 0x0000000180293E30-0x0000000180293E50
		private void Update(); // 0x0000000180293E50-0x0000000180293ED0
		private void CreateLineRendererObjects(); // 0x0000000180292EC0-0x0000000180293350
		public void SetArcData(Vector3 position, Vector3 velocity, bool gravity, bool pointerAtBadAngle); // 0x0000000180293CB0-0x0000000180293D40
		public void Show(); // 0x0000000180293E10-0x0000000180293E30
		public void Hide(); // 0x0000000180293C20-0x0000000180293CB0
		public bool DrawArc(out RaycastHit hitInfo); // 0x00000001802934B0-0x0000000180293810
		private void DrawArcSegment(int index, float startTime, float endTime); // 0x0000000180293350-0x00000001802934B0
		public void SetColor(Color color); // 0x0000000180293D40-0x0000000180293E10
		private float FindProjectileCollision(out RaycastHit hitInfo); // 0x0000000180293810-0x0000000180293A90
		public Vector3 GetArcPositionAtTime(float time); // 0x0000000180293A90-0x0000000180293BA0
		private void HideLineSegments(int startSegment, int endSegment); // 0x0000000180293BA0-0x0000000180293C20
	}
}
