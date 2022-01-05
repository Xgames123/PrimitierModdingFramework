/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	public class TMP_Style // TypeDefIndex: 6175
	{
		// Fields
		internal static TMP_Style k_NormalStyle; // 0x00
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_Name; // 0x10
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int m_HashCode; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_OpeningDefinition; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_ClosingDefinition; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int[] m_OpeningTagArray; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int[] m_ClosingTagArray; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal uint[] m_OpeningTagUnicodeArray; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		internal uint[] m_ClosingTagUnicodeArray; // 0x48
	
		// Properties
		public static TMP_Style NormalStyle { get; } // 0x0000000180268EF0-0x0000000180268FB0 
		public string name { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x0000000180269010-0x0000000180269050
		public int hashCode { get; set; } // 0x0000000180268FB0-0x0000000180268FC0 0x0000000180269000-0x0000000180269010
		public string styleOpeningDefinition { get; } // 0x0000000180268FF0-0x0000000180269000 
		public string styleClosingDefinition { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public int[] styleOpeningTagArray { get; } // 0x00000001802684F0-0x0000000180268500 
		public int[] styleClosingTagArray { get; } // 0x0000000180268FE0-0x0000000180268FF0 
	
		// Constructors
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition); // 0x0000000180268E50-0x0000000180268EF0
	
		// Methods
		public void RefreshStyle(); // 0x0000000180268C20-0x0000000180268E50
	}
}
