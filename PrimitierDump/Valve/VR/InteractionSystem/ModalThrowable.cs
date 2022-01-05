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
	public class ModalThrowable : Throwable // TypeDefIndex: 7435
	{
		// Fields
		[Tooltip] // 0x0000000180025530-0x0000000180025560
		public Transform gripOffset; // 0xB8
		[Tooltip] // 0x0000000180025560-0x0000000180025590
		public Transform pinchOffset; // 0xC0
	
		// Constructors
		public ModalThrowable(); // 0x000000018035F5E0-0x000000018035F5F0
	
		// Methods
		protected override void HandHoverUpdate(Hand hand); // 0x000000018035F540-0x000000018035F5E0
		protected override void HandAttachedUpdate(Hand hand); // 0x000000018035F390-0x000000018035F540
	}
}
