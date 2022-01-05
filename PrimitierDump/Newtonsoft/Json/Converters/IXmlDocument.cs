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

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
	internal interface IXmlDocument : IXmlNode // TypeDefIndex: 5529
	{
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		IXmlElement DocumentElement { [NullableContext] /* 0x0000000180015660-0x0000000180015680 */ get; }
	
		// Methods
		IXmlNode CreateComment([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text);
		IXmlNode CreateTextNode([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text);
		IXmlNode CreateCDataSection([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data);
		IXmlNode CreateWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text);
		IXmlNode CreateSignificantWhitespace([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string text);
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
		IXmlNode CreateProcessingInstruction(string target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string data);
		IXmlElement CreateElement(string elementName);
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);
		IXmlNode CreateAttribute(string name, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value);
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string value);
	}
}
