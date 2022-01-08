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
	[RequireComponent] // 0x000000018001C6D0-0x000000018001C720
	public class InteractionSystemTestGUI : MonoBehaviour // TypeDefIndex: 8327
	{
		// Fields
		[SerializeField] // 0x000000018001C720-0x000000018001C770
		[Tooltip] // 0x000000018001C720-0x000000018001C770
		private InteractionObject interactionObject; // 0x18
		[SerializeField] // 0x000000018001C770-0x000000018001C7B0
		[Tooltip] // 0x000000018001C770-0x000000018001C7B0
		private FullBodyBipedEffector[] effectors; // 0x20
		private InteractionSystem interactionSystem; // 0x28
	
		// Constructors
		public InteractionSystemTestGUI(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x000000018076A900-0x000000018076A940
		private void OnGUI(); // 0x000000018076A940-0x000000018076AB90
	}
}
