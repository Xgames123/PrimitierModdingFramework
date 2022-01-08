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
	internal class Axis : AstNode // TypeDefIndex: 1766
	{
		// Fields
		private AxisType axisType; // 0x10
		private AstNode input; // 0x18
		private string prefix; // 0x20
		private string name; // 0x28
		private XPathNodeType nodeType; // 0x30
		protected bool abbrAxis; // 0x34
		private string urn; // 0x38
	
		// Properties
		public override AstType Type { get; } // 0x0000000180273F80-0x0000000180273F90 
		public override XPathResultType ReturnType { get; } // 0x00000001802DFC40-0x00000001802DFC50 
		public AstNode Input { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public string Prefix { get; } // 0x0000000180268FF0-0x0000000180269000 
		public string Name { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public XPathNodeType NodeType { get; } // 0x00000001802DFC30-0x00000001802DFC40 
		public AxisType TypeOfAxis { get; } // 0x0000000180260E80-0x0000000180260F00 
		public bool AbbrAxis { get; } // 0x00000001802DFC20-0x00000001802DFC30 
		public string Urn { get; set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
	
		// Nested types
		public enum AxisType // TypeDefIndex: 1765
		{
			Ancestor = 0,
			AncestorOrSelf = 1,
			Attribute = 2,
			Child = 3,
			Descendant = 4,
			DescendantOrSelf = 5,
			Following = 6,
			FollowingSibling = 7,
			Namespace = 8,
			Parent = 9,
			Preceding = 10,
			PrecedingSibling = 11,
			Self = 12,
			None = 13
		}
	
		// Constructors
		public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype); // 0x00000001802DFAD0-0x00000001802DFB60
		public Axis(AxisType axisType, AstNode input); // 0x00000001802DFB60-0x00000001802DFC20
	}
}
