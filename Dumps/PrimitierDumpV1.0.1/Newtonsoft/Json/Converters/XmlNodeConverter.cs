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
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Converters
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class XmlNodeConverter : JsonConverter // TypeDefIndex: 5544
	{
		// Fields
		internal static readonly List<IXmlNode> EmptyChildNodes; // 0x00
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private string _DeserializeRootElementName_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _WriteArrayAttribute_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _OmitRootObject_k__BackingField; // 0x19
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _EncodeSpecialCharacters_k__BackingField; // 0x1A
	
		// Properties
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public string DeserializeRootElementName { [CompilerGenerated] /* 0x0000000180017480-0x00000001800174B0 */ [NullableContext] /* 0x0000000180017480-0x00000001800174B0 */ get; } // 0x0000000180268FC0-0x0000000180268FD0 
		public bool WriteArrayAttribute { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802A9AD0-0x00000001802A9AE0 
		public bool OmitRootObject { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001803078B0-0x00000001803078C0 
		public bool EncodeSpecialCharacters { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001807A1020-0x00000001807A1030 
	
		// Constructors
		public XmlNodeConverter(); // 0x00000001802686E0-0x00000001802686F0
		static XmlNodeConverter(); // 0x00000001807A0FB0-0x00000001807A1020
	
		// Methods
		public override void WriteJson(JsonWriter writer, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value, JsonSerializer serializer); // 0x00000001807A0D50-0x00000001807A0FB0
		private IXmlNode WrapXml(object value); // 0x00000001807A09A0-0x00000001807A0AE0
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager); // 0x000000018079D680-0x000000018079DB60
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager); // 0x000000018079EFC0-0x000000018079F180
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager); // 0x000000018079CE50-0x000000018079D200
		private bool IsArray(IXmlNode node); // 0x000000018079D200-0x000000018079D480
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x000000018079F180-0x000000018079F890
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames); // 0x00000001807A0BD0-0x00000001807A0D50
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames); // 0x00000001807A0AE0-0x00000001807A0BD0
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName); // 0x000000018079F890-0x00000001807A06E0
		private static bool AllSameName(IXmlNode node); // 0x000000018079AAD0-0x000000018079ACD0
		public override object ReadJson(JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue, JsonSerializer serializer); // 0x000000018079E830-0x000000018079EFC0
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode); // 0x000000018079CB20-0x000000018079CE50
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager); // 0x000000018079E4D0-0x000000018079E830
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string elementPrefix, [Nullable] /* 0x0000000180017570-0x00000001800175D0 */ Dictionary<string, string> attributeNameValues); // 0x000000018079B860-0x000000018079BD50
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string attributePrefix); // 0x000000018079A660-0x000000018079A8D0
		private static string ConvertTokenToXmlValue(JsonReader reader); // 0x000000018079AD80-0x000000018079B4B0
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager); // 0x000000018079DB60-0x000000018079DE20
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document); // 0x000000018079A8D0-0x000000018079AAD0
		private bool ShouldReadInto(JsonReader reader); // 0x00000001807A06E0-0x00000001807A0770
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager); // 0x000000018079DE20-0x000000018079E4D0
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName); // 0x000000018079BEA0-0x000000018079C230
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode); // 0x000000018079B4B0-0x000000018079B860
		private IXmlElement CreateElement(string elementName, IXmlDocument document, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string elementPrefix, XmlNamespaceManager manager); // 0x000000018079BD50-0x000000018079BEA0
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode); // 0x000000018079C230-0x000000018079CB20
		private bool IsNamespaceAttribute(string attributeName, [Nullable] /* 0x0000000180015560-0x00000001800155A0 */ [NotNullWhen] /* 0x0000000180015560-0x00000001800155A0 */ out string prefix); // 0x000000018079D480-0x000000018079D560
		private bool ValueAttributes(List<IXmlNode> c); // 0x00000001807A0770-0x00000001807A09A0
		public override bool CanConvert(System.Type valueType); // 0x000000018079ACD0-0x000000018079AD80
		private bool IsXObject(System.Type valueType); // 0x000000018079D560-0x000000018079D5F0
		private bool IsXmlNode(System.Type valueType); // 0x000000018079D5F0-0x000000018079D680
	}
}
