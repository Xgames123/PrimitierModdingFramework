/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	[DisallowMultipleComponent] // 0x0000000180037330-0x0000000180037380
	[Obsolete] // 0x0000000180037330-0x0000000180037380
	public class VRMMetaInformation : MonoBehaviour, IEquatable<VRM.VRMMetaInformation> // TypeDefIndex: 8081
	{
		// Fields
		[Header] // 0x0000000180037380-0x00000001800373C0
		[SerializeField] // 0x0000000180037380-0x00000001800373C0
		public string Title; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Author; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string ContactInformation; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Texture2D Thumbnail; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Reference; // 0x38
		[Header] // 0x00000001800373C0-0x0000000180037400
		[SerializeField] // 0x00000001800373C0-0x0000000180037400
		public LicenseType LicenseType; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string OtherLicenseUrl; // 0x48
	
		// Constructors
		public VRMMetaInformation(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		public bool Equals(VRMMetaInformation other); // 0x000000018034E4F0-0x000000018034E560
		private void Reset(); // 0x000000018034E660-0x000000018034E680
		public void CopyTo(GameObject _dst); // 0x000000018034E480-0x000000018034E4F0
		public void OnValidate(); // 0x000000018034E560-0x000000018034E660
	}
}
