/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1759-2427

namespace MS.Internal.Xml.XPath
{
	internal class XPathParser // TypeDefIndex: 1777
	{
		// Fields
		private XPathScanner scanner; // 0x10
		private int parseDepth; // 0x18
		private static readonly XPathResultType[] temparray1; // 0x00
		private static readonly XPathResultType[] temparray2; // 0x08
		private static readonly XPathResultType[] temparray3; // 0x10
		private static readonly XPathResultType[] temparray4; // 0x18
		private static readonly XPathResultType[] temparray5; // 0x20
		private static readonly XPathResultType[] temparray6; // 0x28
		private static readonly XPathResultType[] temparray7; // 0x30
		private static readonly XPathResultType[] temparray8; // 0x38
		private static readonly XPathResultType[] temparray9; // 0x40
		private static Hashtable functionTable; // 0x48
		private static Hashtable AxesTable; // 0x50
	
		// Nested types
		private class ParamInfo // TypeDefIndex: 1776
		{
			// Fields
			private Function.FunctionType ftype; // 0x10
			private int minargs; // 0x14
			private int maxargs; // 0x18
			private XPathResultType[] argTypes; // 0x20
	
			// Properties
			public Function.FunctionType FType { get; } // 0x0000000180260E80-0x0000000180260F00 
			public int Minargs { get; } // 0x00000001802A6C70-0x00000001802A6C80 
			public int Maxargs { get; } // 0x0000000180268FB0-0x0000000180268FC0 
			public XPathResultType[] ArgTypes { get; } // 0x0000000180268FF0-0x0000000180269000 
	
			// Constructors
			internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes); // 0x0000000180C85FB0-0x0000000180C86000
		}
	
		// Constructors
		private XPathParser(XPathScanner scanner); // 0x00000001802A9A60-0x00000001802A9A90
		static XPathParser(); // 0x00000001805D5E50-0x00000001805D6150
	
		// Methods
		public static AstNode ParseXPathExpresion(string xpathExpresion); // 0x00000001805D5C50-0x00000001805D5DD0
		private AstNode ParseExpresion(AstNode qyInput); // 0x00000001805D3CC0-0x00000001805D3E50
		private AstNode ParseOrExpr(AstNode qyInput); // 0x00000001805D4D20-0x00000001805D4E60
		private AstNode ParseAndExpr(AstNode qyInput); // 0x00000001805D3A80-0x00000001805D3BC0
		private AstNode ParseEqualityExpr(AstNode qyInput); // 0x00000001805D3BC0-0x00000001805D3CC0
		private AstNode ParseRelationalExpr(AstNode qyInput); // 0x00000001805D54C0-0x00000001805D55E0
		private AstNode ParseAdditiveExpr(AstNode qyInput); // 0x00000001805D3980-0x00000001805D3A80
		private AstNode ParseMultiplicativeExpr(AstNode qyInput); // 0x00000001805D47A0-0x00000001805D4960
		private AstNode ParseUnaryExpr(AstNode qyInput); // 0x00000001805D5970-0x00000001805D5A70
		private AstNode ParseUnionExpr(AstNode qyInput); // 0x00000001805D5A70-0x00000001805D5C50
		private static bool IsNodeType(XPathScanner scaner); // 0x00000001805D37C0-0x00000001805D3890
		private AstNode ParsePathExpr(AstNode qyInput); // 0x00000001805D4E60-0x00000001805D5180
		private AstNode ParseFilterExpr(AstNode qyInput); // 0x00000001805D3E50-0x00000001805D3F10
		private AstNode ParsePredicate(AstNode qyInput); // 0x00000001805D5180-0x00000001805D5270
		private AstNode ParseLocationPath(AstNode qyInput); // 0x00000001805D3F10-0x00000001805D4080
		private AstNode ParseRelativeLocationPath(AstNode qyInput); // 0x00000001805D55E0-0x00000001805D56C0
		private static bool IsStep(XPathScanner.LexKind lexKind); // 0x00000001805D3930-0x00000001805D3960
		private AstNode ParseStep(AstNode qyInput); // 0x00000001805D56C0-0x00000001805D5970
		private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType); // 0x00000001805D4960-0x00000001805D4D20
		private static bool IsPrimaryExpr(XPathScanner scanner); // 0x00000001805D3890-0x00000001805D3930
		private AstNode ParsePrimaryExpr(AstNode qyInput); // 0x00000001805D5270-0x00000001805D54C0
		private AstNode ParseMethod(AstNode qyInput); // 0x00000001805D4080-0x00000001805D47A0
		private void CheckToken(XPathScanner.LexKind t); // 0x00000001805D26A0-0x00000001805D2720
		private void PassToken(XPathScanner.LexKind t); // 0x00000001805D5DD0-0x00000001805D5E00
		private void NextLex(); // 0x00000001805D3960-0x00000001805D3980
		private bool TestOp(string op); // 0x00000001805D5E00-0x00000001805D5E50
		private void CheckNodeSet(XPathResultType t); // 0x00000001805D2630-0x00000001805D26A0
		private static Hashtable CreateFunctionTable(); // 0x00000001805D2AF0-0x00000001805D36A0
		private static Hashtable CreateAxesTable(); // 0x00000001805D2720-0x00000001805D2AF0
		private Axis.AxisType GetAxis(XPathScanner scaner); // 0x00000001805D36A0-0x00000001805D37C0
	}
}
