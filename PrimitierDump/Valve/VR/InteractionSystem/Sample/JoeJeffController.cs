/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class JoeJeffController : MonoBehaviour // TypeDefIndex: 7507
	{
		// Fields
		public Transform Joystick; // 0x18
		public float joyMove; // 0x20
		public SteamVR_Action_Vector2 moveAction; // 0x28
		public SteamVR_Action_Boolean jumpAction; // 0x30
		public JoeJeff character; // 0x38
		public Renderer jumpHighlight; // 0x40
		private Vector3 movement; // 0x48
		private bool jump; // 0x54
		private float glow; // 0x58
		private SteamVR_Input_Sources hand; // 0x5C
		private Interactable interactable; // 0x60
	
		// Constructors
		public JoeJeffController(); // 0x000000018035B2D0-0x000000018035B3C0
	
		// Methods
		private void Start(); // 0x000000018035AD60-0x000000018035ADA0
		private void Update(); // 0x000000018035ADA0-0x000000018035B2D0
	}
}
