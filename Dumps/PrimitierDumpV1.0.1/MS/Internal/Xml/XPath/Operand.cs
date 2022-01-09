/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1759-2427

namespace MS.Internal.Xml.XPath
{
	internal class Operand : AstNode // TypeDefIndex: 1771
	{
		// Fields
		private XPathResultType type; // 0x10
		private object val; // 0x18
	
		// Properties
		public override AstType Type { get; } // 0x00000001802DFC40-0x00000001802DFC50 
		public override XPathResultType ReturnType { get; } // 0x0000000180260E80-0x0000000180260F00 
	
		// Constructors
		public Operand(string val); // 0x0000000180B00650-0x0000000180B00680
		public Operand(double val); // 0x0000000180B005E0-0x0000000180B00650
	}
}
