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
	internal abstract class AstNode // TypeDefIndex: 1764
	{
		// Properties
		public abstract AstType Type { get; }
		public abstract XPathResultType ReturnType { get; }
	
		// Nested types
		public enum AstType // TypeDefIndex: 1763
		{
			Axis = 0,
			Operator = 1,
			Filter = 2,
			ConstantOperand = 3,
			Function = 4,
			Group = 5,
			Root = 6,
			Variable = 7,
			Error = 8
		}
	
		// Constructors
		protected AstNode(); // 0x00000001802650F0-0x0000000180265100
	}
}
