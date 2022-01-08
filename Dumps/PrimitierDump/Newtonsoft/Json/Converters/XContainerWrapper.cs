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
	internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 5540
	{
		// Fields
		[Nullable] // 0x00000001800174B0-0x0000000180017510
		private List<IXmlNode> _childNodes; // 0x18
	
		// Properties
		private XContainer Container { get; } // 0x0000000180798480-0x0000000180798500 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180798200-0x0000000180798480 
		protected virtual bool HasChildNodes { get; } // 0x0000000180798500-0x0000000180798530 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public override IXmlNode ParentNode { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180798530-0x0000000180798590 
	
		// Constructors
		public XContainerWrapper(XContainer container); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		internal static IXmlNode WrapNode(XObject node); // 0x0000000180797F00-0x0000000180798200
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180797E70-0x0000000180797F00
	}
}
