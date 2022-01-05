/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Xml.Linq;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class XElementWrapper : XContainerWrapper, IXmlElement // TypeDefIndex: 5543
	{
		// Fields
		[Nullable] // 0x0000000180017510-0x0000000180017570
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		private XElement Element { get; } // 0x0000000180799870-0x00000001807998F0 
		public override List<IXmlNode> Attributes { get; } // 0x00000001807994D0-0x0000000180799870 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override string Value { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180799980-0x00000001807999B0 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override string LocalName { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180799920-0x0000000180799950 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override string NamespaceUri { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180799950-0x0000000180799980 
		public bool IsEmpty { get; } // 0x00000001807998F0-0x0000000180799920 
	
		// Constructors
		public XElementWrapper(XElement element); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute); // 0x0000000180799400-0x00000001807994D0
		private bool HasImplicitNamespaceAttribute(string namespaceUri); // 0x0000000180799140-0x0000000180799400
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x00000001807990D0-0x00000001807990F0
		public string GetPrefixOfNamespace(string namespaceUri); // 0x00000001807990F0-0x0000000180799140
	}
}
