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
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6144
	{
		// Constructors
		protected TMP_InputValidator(); // 0x000000018030DE80-0x000000018030DE90
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}
}
