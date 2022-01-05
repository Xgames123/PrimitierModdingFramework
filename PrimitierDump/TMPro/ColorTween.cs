/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	internal struct ColorTween : ITweenValue // TypeDefIndex: 6091
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private Color m_StartColor; // 0x08
		private Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public Color startColor { get; set; } // 0x000000018036B850-0x000000018036B860 0x000000018036B870-0x000000018036B880
		public Color targetColor { get; set; } // 0x00000001802B78A0-0x00000001802B78B0 0x00000001802B7970-0x00000001802B7980
		public ColorTweenMode tweenMode { get; set; } // 0x00000001802B51E0-0x00000001802B51F0 0x00000001802B51F0-0x00000001802B5200
		public float duration { get; set; } // 0x000000018036B0F0-0x000000018036B100 0x000000018036B5F0-0x000000018036B600
		public bool ignoreTimeScale { get; set; } // 0x000000018036B730-0x000000018036B740 0x000000018036B860-0x000000018036B870
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 6089
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 6090
		{
			// Constructors
			public ColorTweenCallback(); // 0x0000000180882CE0-0x0000000180882D20
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018036B740-0x000000018036B840
		public void AddOnChangedCallback(UnityAction<Color> callback); // 0x000000018036B6A0-0x000000018036B730
		public bool GetIgnoreTimescale(); // 0x000000018036B730-0x000000018036B740
		public float GetDuration(); // 0x000000018036B0F0-0x000000018036B100
		public bool ValidTarget(); // 0x000000018036B840-0x000000018036B850
	}
}
