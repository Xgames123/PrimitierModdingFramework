/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 6176
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20
	
		// Properties
		internal List<TMP_Style> styles { get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Constructors
		public TMP_StyleSheet(); // 0x0000000180268BA0-0x0000000180268C10
	
		// Methods
		private void Reset(); // 0x0000000180268B90-0x0000000180268BA0
		public TMP_Style GetStyle(int hashCode); // 0x00000001802687B0-0x0000000180268840
		public TMP_Style GetStyle(string name); // 0x00000001802686F0-0x00000001802687B0
		public void RefreshStyles(); // 0x0000000180268B90-0x0000000180268BA0
		private void LoadStyleDictionaryInternal(); // 0x0000000180268840-0x0000000180268B90
	}
}
