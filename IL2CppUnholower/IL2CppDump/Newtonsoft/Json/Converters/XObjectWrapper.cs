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
using System.Xml.Linq;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x0000000180015720-0x0000000180015760
	[NullableContext] // 0x0000000180015720-0x0000000180015760
	internal class XObjectWrapper : IXmlNode // TypeDefIndex: 5541
	{
		// Fields
		private readonly XObject _xmlObject; // 0x10
	
		// Properties
		public object WrappedNode { get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public virtual XmlNodeType NodeType { get; } // 0x0000000180799AB0-0x0000000180799AD0 
		public virtual string LocalName { get; } // 0x0000000180273F80-0x0000000180273F90 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public virtual List<IXmlNode> ChildNodes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x0000000180799A50-0x0000000180799AB0 
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		public virtual List<IXmlNode> Attributes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; } // 0x00000001807999F0-0x0000000180799A50 
		public virtual IXmlNode ParentNode { get; } // 0x0000000180273F80-0x0000000180273F90 
		public virtual string Value { get; } // 0x0000000180273F80-0x0000000180273F90 
		public virtual string NamespaceUri { get; } // 0x0000000180273F80-0x0000000180273F90 
	
		// Constructors
		public XObjectWrapper(XObject xmlObject); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		public virtual IXmlNode AppendChild(IXmlNode newChild); // 0x00000001807999B0-0x00000001807999F0
	}
}
