/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace SciFiArsenal
{
	public class SciFiBeamScript : MonoBehaviour // TypeDefIndex: 8768
	{
		// Fields
		[Header] // 0x000000018002CFC0-0x000000018002CFF0
		public GameObject[] beamLineRendererPrefab; // 0x18
		public GameObject[] beamStartPrefab; // 0x20
		public GameObject[] beamEndPrefab; // 0x28
		private int currentBeam; // 0x30
		private GameObject beamStart; // 0x38
		private GameObject beamEnd; // 0x40
		private GameObject beam; // 0x48
		private LineRenderer line; // 0x50
		[Header] // 0x000000018002EAD0-0x000000018002EB00
		public float beamEndOffset; // 0x58
		public float textureScrollSpeed; // 0x5C
		public float textureLengthScale; // 0x60
		[Header] // 0x000000018002EB00-0x000000018002EB30
		public Slider endOffSetSlider; // 0x68
		public Slider scrollSpeedSlider; // 0x70
		[Header] // 0x000000018002EB30-0x000000018002EB60
		public UnityEngine.UI.Text textBeamName; // 0x78
	
		// Constructors
		public SciFiBeamScript(); // 0x0000000180B4E0B0-0x0000000180B4E0D0
	
		// Methods
		private void Start(); // 0x0000000180B4DA00-0x0000000180B4DB70
		private void Update(); // 0x0000000180B4DBF0-0x0000000180B4E0B0
		public void nextBeam(); // 0x0000000180B4E0D0-0x0000000180B4E1B0
		public void previousBeam(); // 0x0000000180B4E1B0-0x0000000180B4E290
		public void UpdateEndOffset(); // 0x0000000180B4DB70-0x0000000180B4DBB0
		public void UpdateScrollSpeed(); // 0x0000000180B4DBB0-0x0000000180B4DBF0
		private void ShootBeamInDir(Vector3 start, Vector3 dir); // 0x0000000180B4D5D0-0x0000000180B4DA00
	}
}
