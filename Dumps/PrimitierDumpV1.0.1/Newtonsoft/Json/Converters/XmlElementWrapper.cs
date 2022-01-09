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
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement // TypeDefIndex: 5525
	{
		// Fields
		private readonly XmlElement _element; // 0x28
	
		// Properties
		public bool IsEmpty { get; } // 0x000000018079A640-0x000000018079A660 
	
		// Constructors
		public XmlElementWrapper(XmlElement element); // 0x0000000180799C90-0x0000000180799CC0
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute); // 0x000000018079A530-0x000000018079A640
		public string GetPrefixOfNamespace(string namespaceUri); // 0x000000018079A500-0x000000018079A530
	}
}
