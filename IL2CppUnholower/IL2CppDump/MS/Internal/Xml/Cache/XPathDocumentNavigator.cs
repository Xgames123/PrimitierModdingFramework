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
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1759-2427

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1780
	{
		// Fields
		private XPathNode[] pageCurrent; // 0x10
		private XPathNode[] pageParent; // 0x18
		private int idxCurrent; // 0x20
		private int idxParent; // 0x24
	
		// Properties
		public override string Value { get; } // 0x0000000180E892F0-0x0000000180E89590 
		public override XPathNodeType NodeType { get; } // 0x0000000180E89240-0x0000000180E89280 
		public override string LocalName { get; } // 0x0000000180E89150-0x0000000180E891A0 
		public override string NamespaceURI { get; } // 0x0000000180E891F0-0x0000000180E89240 
		public override string Prefix { get; } // 0x0000000180E89280-0x0000000180E892D0 
		public override XmlNameTable NameTable { get; } // 0x0000000180E891A0-0x0000000180E891F0 
		public override object UnderlyingObject { get; } // 0x0000000180E892D0-0x0000000180E892F0 
		public int LineNumber { get; } // 0x0000000180E88FF0-0x0000000180E89090 
		public int LinePosition { get; } // 0x0000000180E89090-0x0000000180E89150 
	
		// Constructors
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent); // 0x0000000180E88F60-0x0000000180E88FF0
	
		// Methods
		public override XPathNavigator Clone(); // 0x0000000180E88940-0x0000000180E88A10
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope); // 0x0000000180E88B00-0x0000000180E88D20
		public override bool MoveToNextNamespace(XPathNamespaceScope scope); // 0x0000000180E88D20-0x0000000180E88ED0
		public override bool MoveToParent(); // 0x0000000180E88ED0-0x0000000180E88F60
		public override bool IsSamePosition(XPathNavigator other); // 0x0000000180E88A70-0x0000000180E88B00
		public bool HasLineInfo(); // 0x0000000180E88A20-0x0000000180E88A70
		public int GetPositionHashCode(); // 0x0000000180E88A10-0x0000000180E88A20
	}
}
