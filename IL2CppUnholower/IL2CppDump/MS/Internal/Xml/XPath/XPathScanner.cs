/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1759-2427

namespace MS.Internal.Xml.XPath
{
	internal sealed class XPathScanner // TypeDefIndex: 1779
	{
		// Fields
		private string xpathExpr; // 0x10
		private int xpathExprIndex; // 0x18
		private LexKind kind; // 0x1C
		private char currentChar; // 0x20
		private string name; // 0x28
		private string prefix; // 0x30
		private string stringValue; // 0x38
		private double numberValue; // 0x40
		private bool canBeFunction; // 0x48
		private XmlCharType xmlCharType; // 0x50
	
		// Properties
		public string SourceText { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		private char CurerntChar { get; } // 0x00000001805D6D50-0x00000001805D6D60 
		public LexKind Kind { get; } // 0x00000001802AC190-0x00000001802AC1A0 
		public string Name { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public string Prefix { get; } // 0x00000001802684F0-0x0000000180268500 
		public string StringValue { get; } // 0x0000000180268FE0-0x0000000180268FF0 
		public double NumberValue { get; } // 0x00000001805D6D60-0x00000001805D6D70 
		public bool CanBeFunction { get; } // 0x000000018026BB60-0x000000018026BB70 
	
		// Nested types
		public enum LexKind // TypeDefIndex: 1778
		{
			Bang = 33,
			Quote = 34,
			Dollar = 36,
			Apos = 39,
			LParens = 40,
			RParens = 41,
			Star = 42,
			Plus = 43,
			Comma = 44,
			Minus = 45,
			Dot = 46,
			Slash = 47,
			Lt = 60,
			Eq = 61,
			Gt = 62,
			At = 64,
			And = 65,
			DotDot = 68,
			Eof = 69,
			Ge = 71,
			Le = 76,
			Ne = 78,
			Or = 79,
			SlashSlash = 83,
			LBracket = 91,
			RBracket = 93,
			Axe = 97,
			Number = 100,
			Name = 110,
			String = 115,
			Union = 124
		}
	
		// Constructors
		public XPathScanner(string xpathExpr); // 0x00000001805D6C80-0x00000001805D6D50
	
		// Methods
		private bool NextChar(); // 0x00000001805D6150-0x00000001805D61A0
		private void SkipSpace(); // 0x00000001805D6BE0-0x00000001805D6C80
		public bool NextLex(); // 0x00000001805D61A0-0x00000001805D6760
		private double ScanNumber(); // 0x00000001805D6910-0x00000001805D6AA0
		private double ScanFraction(); // 0x00000001805D6760-0x00000001805D6850
		private string ScanString(); // 0x00000001805D6AA0-0x00000001805D6BE0
		private string ScanName(); // 0x00000001805D6850-0x00000001805D6910
	}
}
