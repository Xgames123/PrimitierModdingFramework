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
	internal struct XPathNode // TypeDefIndex: 1781
	{
		// Fields
		private XPathNodeInfoAtom info; // 0x00
		private ushort idxSibling; // 0x08
		private ushort idxParent; // 0x0A
		private ushort idxSimilar; // 0x0C
		private ushort posOffset; // 0x0E
		private uint props; // 0x10
		private string value; // 0x18
	
		// Properties
		public XPathNodeType NodeType { get; } // 0x0000000180E8C240-0x0000000180E8C250 
		public string Prefix { get; } // 0x0000000180E8C270-0x0000000180E8C290 
		public string LocalName { get; } // 0x0000000180E8C200-0x0000000180E8C220 
		public string NamespaceUri { get; } // 0x0000000180E8C220-0x0000000180E8C240 
		public XPathDocument Document { get; } // 0x0000000180E8C090-0x0000000180E8C0B0 
		public int LineNumber { get; } // 0x0000000180E8C1B0-0x0000000180E8C1E0 
		public int LinePosition { get; } // 0x0000000180E8C1E0-0x0000000180E8C200 
		public int CollapsedLinePosition { get; } // 0x0000000180E8C060-0x0000000180E8C090 
		public XPathNodePageInfo PageInfo { get; } // 0x0000000180E8C250-0x0000000180E8C270 
		public bool IsXmlNamespaceNode { get; } // 0x0000000180E8C140-0x0000000180E8C1B0 
		public bool HasSibling { get; } // 0x0000000180E8C0D0-0x0000000180E8C0E0 
		public bool HasCollapsedText { get; } // 0x0000000180E8C0B0-0x0000000180E8C0C0 
		public bool IsText { get; } // 0x0000000180E8C0E0-0x0000000180E8C140 
		public bool HasNamespaceDecls { get; } // 0x0000000180E8C0C0-0x0000000180E8C0D0 
		public string Value { get; } // 0x0000000180268C10-0x0000000180268C20 
	
		// Methods
		public int GetParent(out XPathNode[] pageNode); // 0x0000000180E8C000-0x0000000180E8C030
		public int GetSibling(out XPathNode[] pageNode); // 0x0000000180E8C030-0x0000000180E8C060
	}
}
