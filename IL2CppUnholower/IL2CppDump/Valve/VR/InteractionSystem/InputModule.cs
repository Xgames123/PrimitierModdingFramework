/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class InputModule : BaseInputModule // TypeDefIndex: 7418
	{
		// Fields
		private GameObject submitObject; // 0x48
		private static InputModule _instance; // 0x00
	
		// Properties
		public static InputModule instance { get; } // 0x0000000180356330-0x0000000180356400 
	
		// Constructors
		public InputModule(); // 0x0000000180356320-0x0000000180356330
	
		// Methods
		public override bool ShouldActivateModule(); // 0x00000001803562B0-0x0000000180356320
		public void HoverBegin(GameObject gameObject); // 0x0000000180355F10-0x0000000180356020
		public void HoverEnd(GameObject gameObject); // 0x0000000180356020-0x0000000180356150
		public void Submit(GameObject gameObject); // 0x00000001802B0B50-0x00000001802B0B60
		public override void Process(); // 0x0000000180356150-0x00000001803562B0
	}
}
