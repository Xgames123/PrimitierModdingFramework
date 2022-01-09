/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Linq;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 7080
	{
		// Nested types
		internal enum PropertyPresence // TypeDefIndex: 7076
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		internal class CreatorPropertyContext // TypeDefIndex: 7077
		{
			// Fields
			public string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			public CreatorPropertyContext(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 7078
		{
			// Fields
			public JsonProperty property; // 0x10
	
			// Constructors
			public __c__DisplayClass36_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CreateObjectUsingCreatorWithParameters_b__1(CreatorPropertyContext p); // 0x0000000180796AB0-0x0000000180796AD0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7079
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<JsonProperty, string> __9__36_0; // 0x08
			public static Func<JsonProperty, string> __9__36_2; // 0x10
			public static Func<JsonProperty, JsonProperty> __9__41_0; // 0x18
			public static Func<JsonProperty, PropertyPresence> __9__41_1; // 0x20
	
			// Constructors
			static __c(); // 0x0000000180882AA0-0x0000000180882B00
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _CreateObjectUsingCreatorWithParameters_b__36_0(JsonProperty p); // 0x0000000180425E80-0x0000000180425EA0
			internal string _CreateObjectUsingCreatorWithParameters_b__36_2(JsonProperty p); // 0x0000000180425E80-0x0000000180425EA0
			internal JsonProperty _PopulateObject_b__41_0(JsonProperty m); // 0x00000001802D5FD0-0x00000001802D5FE0
			internal PropertyPresence _PopulateObject_b__41_1(JsonProperty m); // 0x0000000180273F80-0x0000000180273F90
		}
	
		// Constructors
		public JsonSerializerInternalReader(JsonSerializer serializer); // 0x000000018042BCA0-0x000000018042BD20
	
		// Methods
		private JsonContract GetContractSafe(System.Type type); // 0x00000001804321A0-0x0000000180432220
		public object Deserialize(JsonReader reader, System.Type objectType, bool checkAdditionalContent); // 0x0000000180431320-0x0000000180431710
		private JsonSerializerProxy GetInternalSerializer(); // 0x00000001804323C0-0x0000000180432430
		private JToken CreateJToken(JsonReader reader, JsonContract contract); // 0x000000018042D370-0x000000018042D5E0
		private JToken CreateJObject(JsonReader reader); // 0x000000018042D030-0x000000018042D370
		private object CreateValueInternal(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x0000000180430AC0-0x0000000180430FF0
		private static bool CoerceEmptyStringToNull(System.Type objectType, JsonContract contract, string s); // 0x000000018042C5E0-0x000000018042C6E0
		internal string GetExpectedDescription(JsonContract contract); // 0x00000001804322C0-0x00000001804323C0
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180432220-0x00000001804322C0
		private object CreateObject(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x000000018042FDE0-0x0000000180430AC0
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x0000000180435160-0x0000000180435970
		private bool ReadMetadataProperties(JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x0000000180435970-0x0000000180436160
		private void ResolveTypeName(JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName); // 0x0000000180436950-0x0000000180436E70
		private JsonArrayContract EnsureArrayContract(JsonReader reader, System.Type objectType, JsonContract contract); // 0x0000000180431C20-0x0000000180431E40
		private object CreateList(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id); // 0x000000018042D5E0-0x000000018042DE00
		private bool HasNoDefinedType(JsonContract contract); // 0x0000000180432510-0x00000001804325B0
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, System.Type targetType); // 0x0000000180431E40-0x00000001804321A0
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target); // 0x00000001804370E0-0x00000001804374D0
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue); // 0x000000018042C170-0x000000018042C4D0
		private void AddReference(JsonReader reader, string id, object value); // 0x000000018042BE20-0x000000018042C170
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180432500-0x0000000180432510
		private bool ShouldSetPropertyValue(JsonProperty property, object value); // 0x00000001804376B0-0x00000001804377F0
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator); // 0x000000018042E120-0x000000018042E4F0
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator); // 0x000000018042DE00-0x000000018042E120
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value); // 0x0000000180432770-0x0000000180432930
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value); // 0x00000001804325B0-0x0000000180432770
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id); // 0x0000000180432930-0x00000001804334A0
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x0000000180433AD0-0x00000001804342E0
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message); // 0x00000001804377F0-0x0000000180437960
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x00000001804334A0-0x0000000180433AD0
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id); // 0x000000018042C880-0x000000018042D030
		internal object CreateISerializableItem(JToken token, System.Type type, JsonISerializableContract contract, JsonProperty member); // 0x000000018042C6E0-0x000000018042C880
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id); // 0x000000018042E7E0-0x000000018042FDE0
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, System.Type objectType, object existingValue); // 0x0000000180430FF0-0x0000000180431320
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, System.Type objectType); // 0x0000000180436160-0x0000000180436950
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter); // 0x0000000180434F60-0x0000000180435160
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator); // 0x000000018042E4F0-0x000000018042E7E0
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id); // 0x00000001804342E0-0x0000000180434EA0
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target); // 0x00000001804374D0-0x00000001804376B0
		private bool CheckPropertyName(JsonReader reader, string memberName); // 0x000000018042C4D0-0x000000018042C5E0
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o); // 0x0000000180436E70-0x0000000180436FC0
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader); // 0x0000000180434EA0-0x0000000180434F60
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue); // 0x0000000180431710-0x0000000180431C20
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties); // 0x0000000180436FC0-0x00000001804370E0
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth); // 0x0000000180432430-0x0000000180432500
	}
}
