/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem.Sample
{
	public class JoeJeffGestures : MonoBehaviour // TypeDefIndex: 7508
	{
		// Fields
		private const float openFingerAmount = 0.1f; // Metadata: 0x003A5B5A
		private const float closedFingerAmount = 0.9f; // Metadata: 0x003A5B5E
		private const float closedThumbAmount = 0.4f; // Metadata: 0x003A5B62
		private JoeJeff joeJeff; // 0x18
		private bool lastPeaceSignState; // 0x20
	
		// Constructors
		public JoeJeffGestures(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x000000018035B3C0-0x000000018035B400
		private void Update(); // 0x000000018035B440-0x000000018035B7D0
		private void PeaceSignRecognized(bool currentPeaceSignState); // 0x000000018035B400-0x000000018035B440
	}
}
