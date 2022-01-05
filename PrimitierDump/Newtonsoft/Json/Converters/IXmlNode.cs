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
	[NullableContext] // 0x0000000180015660-0x0000000180015680
	internal interface IXmlNode // TypeDefIndex: 5533
	{
		// Properties
		XmlNodeType NodeType { get; }
		string LocalName { get; }
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		List<IXmlNode> ChildNodes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; }
		[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
		List<IXmlNode> Attributes { [NullableContext] /* 0x0000000180014D90-0x0000000180014DB0 */ get; }
		IXmlNode ParentNode { get; }
		string Value { get; }
		string NamespaceUri { get; }
		object WrappedNode { get; }
	
		// Methods
		[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
