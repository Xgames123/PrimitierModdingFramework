/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x00000001800212C0-0x0000000180021320
	[HelpURL] // 0x00000001800212C0-0x0000000180021320
	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 8485
	{
		// Fields
		[Tooltip] // 0x0000000180021320-0x0000000180021350
		public FullBodyBipedEffector effectorType; // 0x18
		[Tooltip] // 0x0000000180021350-0x0000000180021380
		public Multiplier[] multipliers; // 0x20
		[Tooltip] // 0x0000000180021380-0x00000001800213B0
		public float interactionSpeedMlp; // 0x28
		[Tooltip] // 0x00000001800213B0-0x00000001800213E0
		public Transform pivot; // 0x30
		[Tooltip] // 0x00000001800213E0-0x0000000180021410
		public Vector3 twistAxis; // 0x38
		[Tooltip] // 0x0000000180021410-0x0000000180021440
		public float twistWeight; // 0x44
		[Tooltip] // 0x0000000180021440-0x0000000180021470
		public float swingWeight; // 0x48
		[Tooltip] // 0x0000000180021470-0x00000001800214A0
		public bool rotateOnce; // 0x4C
		private Quaternion defaultLocalRotation; // 0x50
		private Transform lastPivot; // 0x60
	
		// Nested types
		[Serializable]
		public class Multiplier // TypeDefIndex: 8484
		{
			// Fields
			[Tooltip] // 0x00000001800214A0-0x00000001800214D0
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x00000001800214D0-0x0000000180021500
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier(); // 0x00000001802650F0-0x0000000180265100
		}
	
		// Constructors
		public InteractionTarget(); // 0x000000018076FFE0-0x0000000180770030
	
		// Methods
		[ContextMenu] // 0x0000000180020B80-0x0000000180020BB0
		private void OpenTutorial1(); // 0x000000018076F7A0-0x000000018076F7E0
		[ContextMenu] // 0x0000000180020BB0-0x0000000180020BE0
		private void OpenTutorial2(); // 0x000000018076F7E0-0x000000018076F820
		[ContextMenu] // 0x0000000180020BE0-0x0000000180020C10
		private void OpenTutorial3(); // 0x000000018076F820-0x000000018076F860
		[ContextMenu] // 0x0000000180020C10-0x0000000180020C40
		private void OpenTutorial4(); // 0x000000018076F860-0x000000018076F8A0
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018076FFA0-0x000000018076FFE0
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x000000018076F690-0x000000018076F6D0
		public float GetValue(InteractionObject.WeightCurve.Type curveType); // 0x000000018076F6D0-0x000000018076F760
		public void ResetRotation(); // 0x000000018076F8E0-0x000000018076F970
		public void RotateTo(Vector3 position); // 0x000000018076F970-0x000000018076FFA0
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018076F8A0-0x000000018076F8E0
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018076F760-0x000000018076F7A0
	}
}
