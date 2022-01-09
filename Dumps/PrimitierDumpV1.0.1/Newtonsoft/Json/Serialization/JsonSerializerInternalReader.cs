/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 5472
	{
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		internal enum PropertyPresence // TypeDefIndex: 5468
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		[Nullable] // 0x0000000180015720-0x0000000180015760
		[NullableContext] // 0x0000000180015720-0x0000000180015760
		internal class CreatorPropertyContext // TypeDefIndex: 5469
		{
			// Fields
			[Nullable] // 0x0000000180014ED0-0x0000000180014EF0
			public readonly string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
			public CreatorPropertyContext(string name); // 0x00000001802A9A60-0x00000001802A9A90
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 5470
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public JsonProperty property; // 0x10
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _CreateObjectUsingCreatorWithParameters_b__1(CreatorPropertyContext p); // 0x0000000180796AB0-0x0000000180796AD0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5471
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<JsonProperty, string> __9__38_0; // 0x08
			[Nullable] // 0x0000000180015760-0x00000001800157C0
			public static Func<JsonProperty, string> __9__38_2; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<JsonProperty, JsonProperty> __9__42_0; // 0x18
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<JsonProperty, PropertyPresence> __9__42_1; // 0x20
	
			// Constructors
			static __c(); // 0x00000001807978B0-0x0000000180797910
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal string _CreateObjectUsingCreatorWithParameters_b__38_0(JsonProperty p); // 0x0000000180425E80-0x0000000180425EA0
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal string _CreateObjectUsingCreatorWithParameters_b__38_2(JsonProperty p); // 0x0000000180425E80-0x0000000180425EA0
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal JsonProperty _PopulateObject_b__42_0(JsonProperty m); // 0x00000001802D5FD0-0x00000001802D5FE0
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal PropertyPresence _PopulateObject_b__42_1(JsonProperty m); // 0x0000000180273F80-0x0000000180273F90
		}
	
		// Constructors
		public JsonSerializerInternalReader(JsonSerializer serializer); // 0x0000000180513F20-0x0000000180513F30
	
		// Methods
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private JsonContract GetContractSafe(System.Type type); // 0x000000018050E770-0x000000018050E830
		private JsonContract GetContract(System.Type type); // 0x000000018050E830-0x000000018050E890
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public object Deserialize([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType, bool checkAdditionalContent); // 0x000000018050D690-0x000000018050DA80
		private JsonSerializerProxy GetInternalSerializer(); // 0x000000018050EA30-0x000000018050EAA0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private JToken CreateJToken([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, JsonContract contract); // 0x0000000180509640-0x0000000180509890
		private JToken CreateJObject(JsonReader reader); // 0x0000000180509330-0x0000000180509640
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object CreateValueInternal([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x000000018050CE00-0x000000018050D360
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private static bool CoerceEmptyStringToNull(System.Type objectType, JsonContract contract, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ string s); // 0x0000000180508000-0x0000000180508140
		internal string GetExpectedDescription(JsonContract contract); // 0x000000018050E930-0x000000018050EA30
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x000000018050E890-0x000000018050E930
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object CreateObject([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x000000018050C100-0x000000018050CE00
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ReadMetadataPropertiesToken([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JTokenReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, [NotNullWhen] /* 0x0000000180014D90-0x0000000180014DB0 */ out object newValue, out string id); // 0x00000001805115D0-0x0000000180511DE0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ReadMetadataProperties([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x0000000180511DE0-0x0000000180512590
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private void ResolveTypeName([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ string qualifiedTypeName); // 0x0000000180512D90-0x00000001805133E0
		private JsonArrayContract EnsureArrayContract(JsonReader reader, System.Type objectType, JsonContract contract); // 0x000000018050DF90-0x000000018050E1B0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object CreateList([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id); // 0x0000000180509890-0x000000018050A010
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool HasNoDefinedType(JsonContract contract); // 0x000000018050EB70-0x000000018050EC70
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private object EnsureType([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, object value, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ CultureInfo culture, JsonContract contract, System.Type targetType); // 0x000000018050E1B0-0x000000018050E770
		private bool SetPropertyValue(JsonProperty property, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonConverter propertyConverter, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonContainerContract containerContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, JsonReader reader, object target); // 0x0000000180513650-0x0000000180513AB0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool CalculatePropertyDetails([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonReader reader, [Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue); // 0x0000000180507A00-0x0000000180507EF0
		private void AddReference(JsonReader reader, string id, object value); // 0x00000001805076B0-0x0000000180507A00
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180432500-0x0000000180432510
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		private bool ShouldSetPropertyValue([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ JsonProperty property, JsonObjectContract contract, object value); // 0x0000000180513C90-0x0000000180513DB0
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator); // 0x000000018050A320-0x000000018050A6F0
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator); // 0x000000018050A010-0x000000018050A320
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value); // 0x000000018050EE30-0x000000018050EFF0
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value); // 0x000000018050EC70-0x000000018050EE30
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x000000018050EFF0-0x000000018050FAA0
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x00000001805100A0-0x0000000180510900
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object currentObject, string message); // 0x0000000180513DB0-0x0000000180513F20
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x000000018050FAA0-0x00000001805100A0
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x0000000180508B40-0x0000000180509330
		internal object CreateISerializableItem(JToken token, System.Type type, JsonISerializableContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member); // 0x00000001805089A0-0x0000000180508B40
		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x0000000180508140-0x00000001805089A0
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, ObjectConstructor<object> creator, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x000000018050AA70-0x000000018050C100
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, System.Type objectType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object existingValue); // 0x000000018050D360-0x000000018050D690
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, JsonReader reader, System.Type objectType); // 0x0000000180512590-0x0000000180512D90
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerMember, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty containerProperty, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id, out bool createdFromNonDefaultCreator); // 0x000000018050A6F0-0x000000018050AA70
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string id); // 0x0000000180510900-0x0000000180511510
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target); // 0x0000000180513AB0-0x0000000180513C90
		private bool CheckPropertyName(JsonReader reader, string memberName); // 0x0000000180507EF0-0x0000000180508000
		private void SetExtensionData(JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, JsonReader reader, string memberName, object o); // 0x00000001805133E0-0x0000000180513530
		private object ReadExtensionDataValue(JsonObjectContract contract, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty member, JsonReader reader); // 0x0000000180511510-0x00000001805115D0
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue); // 0x000000018050DA80-0x000000018050DF90
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, [Nullable] /* 0x00000001800156A0-0x0000000180015700 */ Dictionary<JsonProperty, PropertyPresence> requiredProperties); // 0x0000000180513530-0x0000000180513650
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth); // 0x000000018050EAA0-0x000000018050EB70
	}
}
