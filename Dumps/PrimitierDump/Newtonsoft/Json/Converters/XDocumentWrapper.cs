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
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument // TypeDefIndex: 5536
	{
		// Properties
		private XDocument Document { get; } // 0x0000000180799000-0x0000000180799080 
		public override List<IXmlNode> ChildNodes { get; } // 0x0000000180798E40-0x0000000180798F60 
		protected override bool HasChildNodes { get; } // 0x0000000180799080-0x00000001807990D0 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public IXmlElement DocumentElement { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x0000000180798F60-0x0000000180799000 
	
		// Constructors
		public XDocumentWrapper(XDocument document); // 0x00000001802A9A60-0x00000001802A9A90
	
		// Methods
		public IXmlNode CreateComment([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x0000000180798910-0x0000000180798990
		public IXmlNode CreateTextNode([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x0000000180798BD0-0x0000000180798C50
		public IXmlNode CreateCDataSection([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data); // 0x0000000180798890-0x0000000180798910
		public IXmlNode CreateWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x0000000180798C50-0x0000000180798CD0
		public IXmlNode CreateSignificantWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x0000000180798B50-0x0000000180798BD0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x0000000180798CD0-0x0000000180798D80
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x0000000180798D80-0x0000000180798E40
		public IXmlNode CreateProcessingInstruction(string target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data); // 0x0000000180798AC0-0x0000000180798B50
		public IXmlElement CreateElement(string elementName); // 0x0000000180798990-0x0000000180798A20
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x0000000180798A20-0x0000000180798AC0
		public IXmlNode CreateAttribute(string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x00000001807987F0-0x0000000180798890
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x0000000180798740-0x00000001807987F0
		public override IXmlNode AppendChild(IXmlNode newChild); // 0x0000000180798680-0x0000000180798740
	}
}
