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
	public class SciFiButtonScript : MonoBehaviour // TypeDefIndex: 8769
	{
		// Fields
		public GameObject Button; // 0x18
		private UnityEngine.UI.Text MyButtonText; // 0x20
		private string projectileParticleName; // 0x28
		private SciFiFireProjectile effectScript; // 0x30
		private SciFiProjectileScript projectileScript; // 0x38
		public float buttonsX; // 0x40
		public float buttonsY; // 0x44
		public float buttonsSizeX; // 0x48
		public float buttonsSizeY; // 0x4C
		public float buttonsDistance; // 0x50
	
		// Constructors
		public SciFiButtonScript(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Start(); // 0x0000000180B4EC90-0x0000000180B4ED70
		private void Update(); // 0x0000000180B4ED70-0x0000000180B4EDA0
		public void getProjectileNames(); // 0x0000000180B4EDA0-0x0000000180B4EE30
		public bool overButton(); // 0x0000000180B4EE30-0x0000000180B4EF90
	}
}
