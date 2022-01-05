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
	public class ItemPackage : MonoBehaviour // TypeDefIndex: 7425
	{
		// Fields
		public string name; // 0x18
		public ItemPackageType packageType; // 0x20
		public GameObject itemPrefab; // 0x28
		public GameObject otherHandItemPrefab; // 0x30
		public GameObject previewPrefab; // 0x38
		public GameObject fadedPreviewPrefab; // 0x40
	
		// Nested types
		public enum ItemPackageType // TypeDefIndex: 7424
		{
			Unrestricted = 0,
			OneHanded = 1,
			TwoHanded = 2
		}
	
		// Constructors
		public ItemPackage(); // 0x0000000180265240-0x0000000180265250
	}
}
