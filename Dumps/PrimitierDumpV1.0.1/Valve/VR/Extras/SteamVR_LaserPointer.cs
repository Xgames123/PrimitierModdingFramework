/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.Extras
{
	public class SteamVR_LaserPointer : MonoBehaviour // TypeDefIndex: 7540
	{
		// Fields
		public SteamVR_Behaviour_Pose pose; // 0x18
		public SteamVR_Action_Boolean interactWithUI; // 0x20
		public bool active; // 0x28
		public Color color; // 0x2C
		public float thickness; // 0x3C
		public Color clickColor; // 0x40
		public GameObject holder; // 0x50
		public GameObject pointer; // 0x58
		private bool isActive; // 0x60
		public bool addRigidBody; // 0x61
		public Transform reference; // 0x68
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private PointerEventHandler PointerIn; // 0x70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private PointerEventHandler PointerOut; // 0x78
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private PointerEventHandler PointerClick; // 0x80
		private Transform previousContact; // 0x88
	
		// Events
		public event PointerEventHandler PointerIn {
			add; // 0x00000001803356F0-0x0000000180335790
			remove; // 0x00000001803358D0-0x0000000180335970
		}
		public event PointerEventHandler PointerOut {
			add; // 0x0000000180335790-0x0000000180335830
			remove; // 0x0000000180335970-0x0000000180335A10
		}
		public event PointerEventHandler PointerClick {
			add; // 0x0000000180335650-0x00000001803356F0
			remove; // 0x0000000180335830-0x00000001803358D0
		}
	
		// Constructors
		public SteamVR_LaserPointer(); // 0x0000000180335550-0x0000000180335650
	
		// Methods
		private void Start(); // 0x00000001803349C0-0x0000000180334F30
		public virtual void OnPointerIn(PointerEventArgs e); // 0x0000000180334940-0x0000000180334980
		public virtual void OnPointerClick(PointerEventArgs e); // 0x0000000180334900-0x0000000180334940
		public virtual void OnPointerOut(PointerEventArgs e); // 0x0000000180334980-0x00000001803349C0
		private void Update(); // 0x0000000180334F30-0x0000000180335550
	}
}
