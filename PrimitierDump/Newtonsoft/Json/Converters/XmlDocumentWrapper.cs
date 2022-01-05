/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument // TypeDefIndex: 5524
	{
		// Fields
		private readonly XmlDocument _document; // 0x28
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public IXmlElement DocumentElement { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; } // 0x000000018079A470-0x000000018079A500 
	
		// Constructors
		public XmlDocumentWrapper(XmlDocument document); // 0x0000000180799C90-0x0000000180799CC0
	
		// Methods
		public IXmlNode CreateComment([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data); // 0x0000000180799F70-0x0000000180799FF0
		public IXmlNode CreateTextNode([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x000000018079A210-0x000000018079A290
		public IXmlNode CreateCDataSection([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data); // 0x0000000180799EF0-0x0000000180799F70
		public IXmlNode CreateWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x000000018079A290-0x000000018079A310
		public IXmlNode CreateSignificantWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text); // 0x000000018079A190-0x000000018079A210
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone); // 0x000000018079A310-0x000000018079A3C0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x000000018079A3C0-0x000000018079A470
		public IXmlNode CreateProcessingInstruction(string target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data); // 0x000000018079A100-0x000000018079A190
		public IXmlElement CreateElement(string elementName); // 0x0000000180799FF0-0x000000018079A070
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri); // 0x000000018079A070-0x000000018079A100
		public IXmlNode CreateAttribute(string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x0000000180799E50-0x0000000180799EF0
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value); // 0x0000000180799DA0-0x0000000180799E50
	}
}
