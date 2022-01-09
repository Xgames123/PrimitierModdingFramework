/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	internal struct FloatTween : ITweenValue // TypeDefIndex: 6093
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x00000001802649B0-0x00000001802649C0 0x0000000180264BB0-0x0000000180264BC0
		public float targetValue { get; set; } // 0x0000000180264980-0x0000000180264990 0x0000000180264B70-0x0000000180264B80
		public float duration { get; set; } // 0x000000018036C100-0x000000018036C110 0x000000018036C190-0x000000018036C1A0
		public bool ignoreTimeScale { get; set; } // 0x000000018036C110-0x000000018036C120 0x000000018036C1A0-0x000000018036C1B0
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 6092
		{
			// Constructors
			public FloatTweenCallback(); // 0x0000000180882E70-0x0000000180882EB0
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018036C120-0x000000018036C190
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018036C070-0x000000018036C100
		public bool GetIgnoreTimescale(); // 0x000000018036C110-0x000000018036C120
		public float GetDuration(); // 0x000000018036C100-0x000000018036C110
		public bool ValidTarget(); // 0x000000018036B840-0x000000018036B850
	}
}
