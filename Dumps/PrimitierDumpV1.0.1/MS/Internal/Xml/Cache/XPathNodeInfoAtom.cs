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

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1785
	{
		// Fields
		private string localName; // 0x10
		private string namespaceUri; // 0x18
		private string prefix; // 0x20
		private XPathNode[] pageParent; // 0x28
		private XPathNode[] pageSibling; // 0x30
		private XPathDocument doc; // 0x38
		private int lineNumBase; // 0x40
		private int linePosBase; // 0x44
		private XPathNodePageInfo pageInfo; // 0x48
	
		// Properties
		public XPathNodePageInfo PageInfo { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public string LocalName { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public string NamespaceUri { get; } // 0x0000000180268C10-0x0000000180268C20 
		public string Prefix { get; } // 0x0000000180268FF0-0x0000000180269000 
		public XPathNode[] SiblingPage { get; } // 0x00000001802684F0-0x0000000180268500 
		public XPathNode[] ParentPage { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public XPathDocument Document { get; } // 0x0000000180268FE0-0x0000000180268FF0 
		public int LineNumberBase { get; } // 0x00000001802C6D30-0x00000001802C6D40 
		public int LinePositionBase { get; } // 0x00000001805B1C00-0x00000001805B1C10 
	}
}
