/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 7081
	{
		// Fields
		private System.Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter(JsonSerializer serializer); // 0x00000001807570A0-0x0000000180757120
	
		// Methods
		public void Serialize(JsonWriter jsonWriter, object value, System.Type objectType); // 0x0000000180755C30-0x0000000180755E50
		private JsonSerializerProxy GetInternalSerializer(); // 0x0000000180752240-0x00000001807522E0
		private JsonContract GetContractSafe(object value); // 0x00000001807521C0-0x0000000180752240
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180755270-0x00000001807553F0
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x00000001807554A0-0x0000000180755C30
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180752EE0-0x0000000180752F90
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180756130-0x0000000180756300
		private bool ShouldWriteProperty(object memberValue, JsonProperty property); // 0x0000000180756030-0x0000000180756130
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180751D80-0x00000001807521C0
		private void WriteReference(JsonWriter writer, object value); // 0x0000000180756A30-0x0000000180756C30
		private string GetReference(JsonWriter writer, object value); // 0x00000001807526D0-0x0000000180752890
		internal static bool TryConvertToString(object value, System.Type type, out string s); // 0x0000000180756490-0x0000000180756710
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract); // 0x00000001807553F0-0x00000001807554A0
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value); // 0x0000000180752D50-0x0000000180752EE0
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value); // 0x0000000180752BC0-0x0000000180752D50
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180754BA0-0x0000000180755270
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue); // 0x0000000180751850-0x0000000180751D80
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180756710-0x0000000180756870
		private void WriteReferenceIdProperty(JsonWriter writer, System.Type type, object value); // 0x0000000180756870-0x0000000180756A30
		private void WriteTypeProperty(JsonWriter writer, System.Type type); // 0x0000000180756EA0-0x00000001807570A0
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180432500-0x0000000180432510
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag); // 0x0000000180432500-0x0000000180432510
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag); // 0x0000000180432500-0x0000000180432510
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180752F90-0x00000001807533B0
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180754030-0x00000001807545B0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x00000001807549D0-0x0000000180754BA0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices); // 0x00000001807545B0-0x00000001807549D0
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180756C30-0x0000000180756EA0
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180753AD0-0x0000000180754030
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180756300-0x0000000180756490
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x00000001807533B0-0x0000000180753AD0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape); // 0x00000001807522E0-0x00000001807526D0
		private void HandleError(JsonWriter writer, int initialDepth); // 0x0000000180752890-0x00000001807529E0
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target); // 0x0000000180755E50-0x0000000180756030
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target); // 0x00000001807529E0-0x0000000180752BC0
	}
}
