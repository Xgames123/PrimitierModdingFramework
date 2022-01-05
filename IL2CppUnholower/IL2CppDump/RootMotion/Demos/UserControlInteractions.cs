/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	public class UserControlInteractions : UserControlThirdPerson // TypeDefIndex: 8350
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CharacterThirdPerson character; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private InteractionSystem interactionSystem; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool disableInputInInteraction; // 0x58
		public float enableInputAtProgress; // 0x5C
	
		// Constructors
		public UserControlInteractions(); // 0x000000018071A830-0x000000018071A850
	
		// Methods
		protected override void Update(); // 0x000000018071A740-0x000000018071A830
		private void OnGUI(); // 0x000000018071A5E0-0x000000018071A740
	}
}
