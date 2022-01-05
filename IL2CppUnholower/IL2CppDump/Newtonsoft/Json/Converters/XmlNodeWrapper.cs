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
using System.Xml;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x0000000180015050-0x0000000180015090
	[NullableContext] // 0x0000000180015050-0x0000000180015090
	internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 5528
	{
		// Fields
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		private readonly XmlNode _node; // 0x10
		[Nullable] // 0x00000001800171D0-0x0000000180017230
		private List<IXmlNode> _childNodes; // 0x18
		[Nullable] // 0x0000000180017230-0x0000000180017290
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		public object WrappedNode { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public XmlNodeType NodeType { get; } // 0x0000000180643450-0x0000000180643480 
		public virtual string LocalName { get; } // 0x00000001806433F0-0x0000000180643420 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public List<IXmlNode> ChildNodes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x00000001807A16A0-0x00000001807A19D0 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public List<IXmlNode> Attributes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x00000001807A12D0-0x00000001807A16A0 
		private bool HasAttributes { get; } // 0x00000001807A19D0-0x00000001807A1AA0 
		public IXmlNode ParentNode { get; } // 0x00000001807A1AA0-0x00000001807A1B60 
		public string Value { get; set; } // 0x0000000180643420-0x0000000180643450 0x00000001807A1B60-0x00000001807A1B90
		public string NamespaceUri { get; } // 0x0000000180642ED0-0x0000000180642F00 
	
		// Constructors
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public XmlNodeWrapper(XmlNode node); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		internal static IXmlNode WrapNode(XmlNode node); // 0x00000001807A10F0-0x00000001807A12D0
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public IXmlNode AppendChild(IXmlNode newChild); // 0x00000001807A1030-0x00000001807A10F0
	}
}
