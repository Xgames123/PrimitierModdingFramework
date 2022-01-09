/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[RequireComponent] // 0x00000001800240C0-0x0000000180024110
	public class SteamVR_Camera : MonoBehaviour // TypeDefIndex: 7330
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform _head; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Camera _camera_k__BackingField; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform _ears; // 0x28
		public bool wireframe; // 0x30
		private static Hashtable values; // 0x00
		private const string eyeSuffix = " (eye)"; // Metadata: 0x003A5777
		private const string earsSuffix = " (ears)"; // Metadata: 0x003A5781
		private const string headSuffix = " (head)"; // Metadata: 0x003A578C
		private const string originSuffix = " (origin)"; // Metadata: 0x003A5797
	
		// Properties
		public Transform head { get; } // 0x0000000180268C10-0x0000000180268C20 
		public Transform offset { get; } // 0x0000000180268C10-0x0000000180268C20 
		public Transform origin { get; } // 0x0000000180321780-0x00000001803217A0 
		public Camera camera { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public Transform ears { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public static float sceneResolutionScale { get; set; } // 0x00000001803217A0-0x00000001803217B0 0x00000001803217B0-0x00000001803217C0
		public string baseName { get; } // 0x00000001803216D0-0x0000000180321780 
	
		// Constructors
		public SteamVR_Camera(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public Ray GetRay(); // 0x0000000180321230-0x00000001803212E0
		private void OnDisable(); // 0x00000001803212E0-0x00000001803212F0
		private void OnEnable(); // 0x00000001803212F0-0x00000001803216D0
		private void Awake(); // 0x000000018031FE50-0x000000018031FEA0
		public void ForceLast(); // 0x0000000180320B70-0x0000000180321230
		public void Expand(); // 0x0000000180320300-0x0000000180320B70
		public void Collapse(); // 0x000000018031FEA0-0x0000000180320300
	}
}
