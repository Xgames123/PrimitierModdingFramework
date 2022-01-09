/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	public class JJupiterSettings : ScriptableObject // TypeDefIndex: 8724
	{
		// Fields
		private static JJupiterSettings instance; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Material defaultSkybox; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Texture2D noiseTexture; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Texture2D cloudTexture; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JSkyProfile defaultProfileSunnyDay; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JSkyProfile defaultProfileStarryNight; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JDayNightCycleProfile defaultDayNightCycleProfile; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JInternalShaderSettings internalShaders; // 0x48
	
		// Properties
		public static JJupiterSettings Instance { get; } // 0x000000018030FA10-0x000000018030FB40 
		public Material DefaultSkybox { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public Texture2D NoiseTexture { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public Texture2D CloudTexture { get; set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public JSkyProfile DefaultProfileSunnyDay { get; set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public JSkyProfile DefaultProfileStarryNight { get; set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		public JDayNightCycleProfile DefaultDayNightCycleProfile { get; set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		public JInternalShaderSettings InternalShaders { get; set; } // 0x000000018030FB40-0x000000018030FB60 0x000000018030FB60-0x000000018030FB70
	
		// Constructors
		public JJupiterSettings(); // 0x000000018030DE80-0x000000018030DE90
	}
}
