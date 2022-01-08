/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 5473
	{
		// Fields
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private System.Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter(JsonSerializer serializer); // 0x0000000180519F70-0x0000000180519FF0
	
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public void Serialize([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter jsonWriter, object value, System.Type objectType); // 0x0000000180518AE0-0x0000000180518D10
		private JsonSerializerProxy GetInternalSerializer(); // 0x0000000180514890-0x0000000180514900
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private JsonContract GetContractSafe(object value); // 0x0000000180514800-0x0000000180514810
		private JsonContract GetContract(object value); // 0x0000000180514810-0x0000000180514890
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract containerContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180518200-0x0000000180518380
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private void SerializeValue([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180518430-0x0000000180518AE0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool? ResolveIsReference([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180515740-0x00000001805157F0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180519080-0x0000000180519250
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonProperty property); // 0x0000000180518FB0-0x0000000180519080
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool CheckForCircularReference([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x00000001805143C0-0x0000000180514800
		private void WriteReference(JsonWriter writer, object value); // 0x00000001805198F0-0x0000000180519AF0
		private string GetReference(JsonWriter writer, object value); // 0x0000000180514EB0-0x00000001805150B0
		internal static bool TryConvertToString(object value, System.Type type, [NotNullWhen] /* 0x00000001800157C0-0x0000000180015800 */ [Nullable] /* 0x00000001800157C0-0x0000000180015800 */ out string s); // 0x00000001805194A0-0x00000001805195C0
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract); // 0x0000000180518380-0x0000000180518430
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value); // 0x00000001805155B0-0x0000000180515740
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value); // 0x0000000180515420-0x00000001805155B0
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180517AD0-0x0000000180518200
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, JsonProperty property, [NotNullWhen] /* 0x00000001800157C0-0x0000000180015800 */ [Nullable] /* 0x00000001800157C0-0x0000000180015800 */ out JsonContract memberContract, [NotNullWhen] /* 0x00000001800157C0-0x0000000180015800 */ [Nullable] /* 0x00000001800157C0-0x0000000180015800 */ out object memberValue); // 0x0000000180513F30-0x00000001805143C0
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x00000001805195C0-0x0000000180519730
		private bool HasCreatorParameter([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract contract, JsonProperty property); // 0x0000000180515180-0x0000000180515240
		private void WriteReferenceIdProperty(JsonWriter writer, System.Type type, object value); // 0x0000000180519730-0x00000001805198F0
		private void WriteTypeProperty(JsonWriter writer, System.Type type); // 0x0000000180519D70-0x0000000180519F70
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180432500-0x0000000180432510
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag); // 0x0000000180432500-0x0000000180432510
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag); // 0x0000000180432500-0x0000000180432510
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x00000001805157F0-0x0000000180515BD0
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180516F30-0x0000000180517470
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180517470-0x0000000180517690
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, int initialDepth, int[] indices); // 0x0000000180517690-0x0000000180517AD0
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract containerContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180519AF0-0x0000000180519D70
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x00000001805169D0-0x0000000180516F30
		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x00000001805162E0-0x00000001805169D0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ShouldWriteDynamicProperty(object memberValue); // 0x0000000180518EF0-0x0000000180518FB0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180519250-0x00000001805194A0
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract collectionContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty); // 0x0000000180515BD0-0x00000001805162E0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape); // 0x0000000180514900-0x0000000180514EB0
		private void HandleError(JsonWriter writer, int initialDepth); // 0x00000001805150B0-0x0000000180515180
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target); // 0x0000000180518D10-0x0000000180518EF0
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target); // 0x0000000180515240-0x0000000180515420
	}
}
