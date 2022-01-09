/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public struct TMP_Offset // TypeDefIndex: 6081
	{
		// Fields
		private float m_Left; // 0x00
		private float m_Right; // 0x04
		private float m_Top; // 0x08
		private float m_Bottom; // 0x0C
		private static readonly TMP_Offset k_ZeroOffset; // 0x00
	
		// Properties
		public float left { get; set; } // 0x0000000180264990-0x00000001802649A0 0x0000000180264B90-0x0000000180264BA0
		public float right { get; set; } // 0x00000001802649A0-0x00000001802649B0 0x0000000180264BA0-0x0000000180264BB0
		public float top { get; set; } // 0x00000001802649B0-0x00000001802649C0 0x0000000180264BB0-0x0000000180264BC0
		public float bottom { get; set; } // 0x0000000180264980-0x0000000180264990 0x0000000180264B70-0x0000000180264B80
		public float horizontal { get; set; } // 0x0000000180264990-0x00000001802649A0 0x0000000180264B80-0x0000000180264B90
		public float vertical { get; set; } // 0x00000001802649B0-0x00000001802649C0 0x0000000180264BC0-0x0000000180264BD0
		public static TMP_Offset zero { get; } // 0x00000001802649C0-0x0000000180264A30 
	
		// Constructors
		public TMP_Offset(float left, float right, float top, float bottom); // 0x0000000180264940-0x0000000180264960
		public TMP_Offset(float horizontal, float vertical); // 0x0000000180264960-0x0000000180264980
		static TMP_Offset(); // 0x0000000180264900-0x0000000180264940
	
		// Methods
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs); // 0x0000000180264A30-0x0000000180264A70
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs); // 0x0000000180264A70-0x0000000180264B30
		public static TMP_Offset operator *(TMP_Offset a, float b); // 0x0000000180264B30-0x0000000180264B70
		public override int GetHashCode(); // 0x00000001802648A0-0x0000000180264900
		public override bool Equals(object obj); // 0x0000000180264830-0x00000001802648A0
		public bool Equals(TMP_Offset other); // 0x00000001802647A0-0x0000000180264830
	}
}
