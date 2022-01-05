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
	[Serializable]
	public class JAnimatedProperty // TypeDefIndex: 8729
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string name; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string displayName; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private JCurveOrGradient curveOrGradient; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private AnimationCurve curve; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Gradient gradient; // 0x30
	
		// Properties
		public string Name { get; set; } // 0x000000018030A430-0x000000018030A480 0x000000018028FF80-0x000000018028FF90
		public string DisplayName { get; set; } // 0x000000018030A220-0x000000018030A270 0x000000018026BFE0-0x000000018026BFF0
		public JCurveOrGradient CurveOrGradient { get; set; } // 0x000000018030A1D0-0x000000018030A1E0 0x000000018030A480-0x000000018030A490
		public AnimationCurve Curve { get; set; } // 0x000000018030A1E0-0x000000018030A220 0x00000001802A43E0-0x00000001802A43F0
		public Gradient Gradient { get; set; } // 0x000000018030A270-0x000000018030A430 0x00000001802A43C0-0x00000001802A43D0
	
		// Constructors
		public JAnimatedProperty(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public float EvaluateFloat(float t); // 0x000000018030A170-0x000000018030A1D0
		public Color EvaluateColor(float t); // 0x000000018030A120-0x000000018030A170
		public static JAnimatedProperty Create(string name, string displayName, JCurveOrGradient curveOrGradient); // 0x000000018030A0A0-0x000000018030A120
	}
}
