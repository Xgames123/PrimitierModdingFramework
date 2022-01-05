/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class SlowMo : MonoBehaviour // TypeDefIndex: 8374
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private KeyCode[] keyCodes; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool mouse0; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool mouse1; // 0x21
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float slowMoTimeScale; // 0x24
	
		// Constructors
		public SlowMo(); // 0x0000000180717850-0x0000000180717860
	
		// Methods
		private void Update(); // 0x0000000180717790-0x0000000180717850
		private bool IsSlowMotion(); // 0x00000001807176E0-0x0000000180717790
	}
}
