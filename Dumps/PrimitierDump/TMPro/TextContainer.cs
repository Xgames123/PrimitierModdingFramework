/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[RequireComponent] // 0x000000018003C560-0x000000018003C5B0
	public class TextContainer : UIBehaviour // TypeDefIndex: 6232
	{
		// Fields
		private bool m_hasChanged; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector2 m_pivot; // 0x1C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextContainerAnchors m_anchorPosition; // 0x24
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get; set; } // 0x00000001802A9AD0-0x00000001802A9AE0 0x00000001802C2010-0x00000001802C2020
		public Vector2 pivot { get; set; } // 0x00000001803AE150-0x00000001803AE170 0x00000001803AE4D0-0x00000001803AE650
		public TextContainerAnchors anchorPosition { get; set; } // 0x000000018036C890-0x000000018036C8A0 0x00000001803AE2E0-0x00000001803AE3F0
		public Rect rect { get; set; } // 0x0000000180313470-0x0000000180313480 0x00000001803AE650-0x00000001803AE6B0
		public Vector2 size { get; set; } // 0x00000001803AE200-0x00000001803AE240 0x00000001803AE6B0-0x00000001803AE750
		public float width { get; set; } // 0x00000001803AE2D0-0x00000001803AE2E0 0x00000001803AE750-0x00000001803AE7A0
		public float height { get; set; } // 0x00000001803AE110-0x00000001803AE120 0x00000001803AE3F0-0x00000001803AE440
		public bool isDefaultWidth { get; } // 0x000000018030F460-0x000000018030F470 
		public bool isDefaultHeight { get; } // 0x00000001803AE130-0x00000001803AE140 
		public bool isAutoFitting { get; set; } // 0x00000001803AE120-0x00000001803AE130 0x00000001803AE440-0x00000001803AE450
		public Vector3[] corners { get; } // 0x0000000180268310-0x0000000180268320 
		public Vector3[] worldCorners { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public Vector4 margins { get; set; } // 0x00000001803AE140-0x00000001803AE150 0x00000001803AE450-0x00000001803AE4D0
		public RectTransform rectTransform { get; } // 0x00000001803AE170-0x00000001803AE200 
		public TextMeshPro textMeshPro { get; } // 0x00000001803AE240-0x00000001803AE2D0 
	
		// Constructors
		public TextContainer(); // 0x00000001803AE0A0-0x00000001803AE110
		static TextContainer(); // 0x00000001803AE060-0x00000001803AE0A0
	
		// Methods
		protected override void Awake(); // 0x00000001803AD510-0x00000001803AD5D0
		protected override void OnEnable(); // 0x00000001803ADA80-0x00000001803ADA90
		protected override void OnDisable(); // 0x0000000180265310-0x0000000180265320
		private void OnContainerChanged(); // 0x00000001803AD8B0-0x00000001803ADA80
		protected override void OnRectTransformDimensionsChange(); // 0x00000001803ADA90-0x00000001803ADCF0
		private void SetRect(Vector2 size); // 0x00000001803ADCF0-0x00000001803ADD70
		private void UpdateCorners(); // 0x00000001803ADD70-0x00000001803AE060
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x00000001803AD780-0x00000001803AD8B0
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x00000001803AD5D0-0x00000001803AD780
	}
}
