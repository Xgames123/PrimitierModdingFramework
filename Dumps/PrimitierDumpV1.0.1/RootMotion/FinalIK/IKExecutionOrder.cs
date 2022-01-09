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
	public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 8408
	{
		// Fields
		[Tooltip] // 0x000000018001E650-0x000000018001E680
		public IK[] IKComponents; // 0x18
		[Tooltip] // 0x000000018001E680-0x000000018001E6B0
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get; } // 0x000000018086ABB0-0x000000018086AC40 
	
		// Constructors
		public IKExecutionOrder(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x000000018086AB00-0x000000018086AB80
		private void Update(); // 0x000000018086AB80-0x000000018086ABB0
		private void FixedUpdate(); // 0x000000018086A9B0-0x000000018086A9E0
		private void LateUpdate(); // 0x000000018086A9E0-0x000000018086AB00
		private void FixTransforms(); // 0x000000018086A900-0x000000018086A9B0
	}
}
