/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5436
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly string[] BlacklistedTypeNames; // 0x08
		private static readonly JsonConverter[] BuiltInConverters; // 0x10
		private readonly DefaultJsonNameTable _nameTable; // 0x10
		private readonly ThreadSafeStore<System.Type, JsonContract> _contractCache; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private BindingFlags _DefaultMembersSearchFlags_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _SerializeCompilerGeneratedMembers_k__BackingField; // 0x24
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreSerializableInterface_k__BackingField; // 0x25
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreSerializableAttribute_k__BackingField; // 0x26
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreIsSpecifiedMembers_k__BackingField; // 0x27
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreShouldSerializeMembers_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180015E50-0x0000000180015E80
		[Nullable] // 0x0000000180015E50-0x0000000180015E80
		private NamingStrategy _NamingStrategy_k__BackingField; // 0x30
	
		// Properties
		internal static IContractResolver Instance { get; } // 0x00000001803D8E90-0x00000001803D8EF0 
		[Obsolete] // 0x0000000180019090-0x00000001800190C0
		public BindingFlags DefaultMembersSearchFlags { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018030A1D0-0x000000018030A1E0 0x000000018030A480-0x000000018030A490
		public bool SerializeCompilerGeneratedMembers { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001803D8EF0-0x00000001803D8F00 
		public bool IgnoreSerializableInterface { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001803D8E80-0x00000001803D8E90 
		public bool IgnoreSerializableAttribute { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001803D8E70-0x00000001803D8E80 0x00000001803D8F00-0x00000001803D8F10
		public bool IgnoreIsSpecifiedMembers { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001803D8E60-0x00000001803D8E70 
		public bool IgnoreShouldSerializeMembers { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018030F470-0x000000018030F480 
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		public NamingStrategy NamingStrategy { [NullableContext] /* 0x0000000180016840-0x0000000180016870 */ [CompilerGenerated] /* 0x0000000180016840-0x0000000180016870 */ get; } // 0x00000001802684F0-0x0000000180268500 
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>> // TypeDefIndex: 5426
		{
			// Fields
			[Nullable] // 0x00000001800190C0-0x0000000180019120
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Nested types
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class _GetEnumerator_d__2 : IEnumerator<KeyValuePair<object, object>> // TypeDefIndex: 5425
			{
				// Fields
				private int __1__state;
				[Nullable] // 0x00000001800191D0-0x0000000180019230
				private KeyValuePair<object, object> __2__current;
				public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> __4__this;
				[Nullable] // 0x0000000180019230-0x0000000180019290
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> __7__wrap1;
	
				// Properties
				KeyValuePair<object, object> IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; }
				object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; }
	
				// Constructors
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				public _GetEnumerator_d__2(int __1__state);
	
				// Methods
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IDisposable.Dispose();
				private bool MoveNext();
				private void __m__Finally1();
				[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
				void IEnumerator.Reset();
			}
	
			// Constructors
			public EnumerableDictionaryWrapper([Nullable] /* 0x0000000180019120-0x0000000180019180 */ IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
	
			// Methods
			[IteratorStateMachine] // 0x0000000180019180-0x00000001800191D0
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator();
			[NullableContext] // 0x0000000180014D90-0x0000000180014DB0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5427
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MemberInfo, bool> __9__40_0; // 0x08
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MemberInfo, bool> __9__40_1; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<System.Type, IEnumerable<MemberInfo>> __9__44_0; // 0x18
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MemberInfo, bool> __9__44_1; // 0x20
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<ConstructorInfo, bool> __9__47_0; // 0x28
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<JsonProperty, int> __9__75_0; // 0x30
	
			// Constructors
			static __c(); // 0x00000001807979D0-0x0000000180797A30
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetSerializableMembers_b__40_0(MemberInfo m); // 0x0000000180796080-0x0000000180796140
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetSerializableMembers_b__40_1(MemberInfo m); // 0x0000000180796140-0x00000001807961B0
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal IEnumerable<MemberInfo> _GetExtensionDataMemberForType_b__44_0(System.Type baseType); // 0x0000000180795A30-0x0000000180795B00
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetExtensionDataMemberForType_b__44_1(MemberInfo m); // 0x0000000180795B00-0x0000000180796050
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetAttributeConstructor_b__47_0(ConstructorInfo c); // 0x0000000180795880-0x0000000180795920
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal int _CreateProperties_b__75_0(JsonProperty p); // 0x0000000180795820-0x0000000180795880
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 5428
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public NamingStrategy namingStrategy; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _CreateObjectContract_b__0(string s); // 0x0000000180796B20-0x0000000180796B50
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 5429
		{
			// Fields
			[Nullable] // 0x0000000180019290-0x00000001800192F0
			public Func<object, object> getExtensionDataDictionary; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MemberInfo member; // 0x18
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass45_1 // TypeDefIndex: 5430
		{
			// Fields
			[Nullable] // 0x00000001800192F0-0x0000000180019350
			public Action<object, object> setExtensionDataDictionary; // 0x10
			[Nullable] // 0x0000000180019350-0x00000001800193B0
			public Func<object> createExtensionDataDictionary; // 0x18
			[Nullable] // 0x00000001800193B0-0x0000000180019410
			public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public __c__DisplayClass45_0 CS___8__locals1; // 0x28
	
			// Constructors
			public __c__DisplayClass45_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _SetExtensionDataDelegates_b__0(object o, string key, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x0000000180796F70-0x0000000180797220
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass45_2 // TypeDefIndex: 5431
		{
			// Fields
			[Nullable] // 0x0000000180019410-0x0000000180019470
			public ObjectConstructor<object> createEnumerableWrapper; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public __c__DisplayClass45_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass45_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal IEnumerable<KeyValuePair<object, object>> _SetExtensionDataDelegates_b__1(object o); // 0x0000000180797220-0x0000000180797360
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass62_0 // TypeDefIndex: 5432
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public NamingStrategy namingStrategy; // 0x10
	
			// Constructors
			public __c__DisplayClass62_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _CreateDictionaryContract_b__0(string s); // 0x0000000180796B20-0x0000000180796B50
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 5433
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public NamingStrategy namingStrategy; // 0x10
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _CreateDynamicContract_b__0(string s); // 0x0000000180796B20-0x0000000180796B50
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass80_0 // TypeDefIndex: 5434
		{
			// Fields
			[Nullable] // 0x0000000180019470-0x00000001800194D0
			public MethodCall<object, object> shouldSerializeCall; // 0x10
	
			// Constructors
			public __c__DisplayClass80_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CreateShouldSerializeTest_b__0(object o); // 0x0000000180797650-0x0000000180797700
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass81_0 // TypeDefIndex: 5435
		{
			// Fields
			[Nullable] // 0x00000001800194D0-0x0000000180019530
			public Func<object, object> specifiedPropertyGet; // 0x10
	
			// Constructors
			public __c__DisplayClass81_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _SetIsSpecifiedActions_b__0(object o); // 0x0000000180797700-0x0000000180797790
		}
	
		// Constructors
		public DefaultContractResolver(); // 0x00000001803D8D30-0x00000001803D8E60
		static DefaultContractResolver(); // 0x00000001803D85C0-0x00000001803D8D30
	
		// Methods
		public virtual JsonContract ResolveContract(System.Type type); // 0x00000001803D6C30-0x00000001803D6CB0
		private static bool FilterMembers(MemberInfo member); // 0x00000001803D38F0-0x00000001803D3A70
		protected virtual List<MemberInfo> GetSerializableMembers(System.Type objectType); // 0x00000001803D4DE0-0x00000001803D5710
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo); // 0x00000001803D8210-0x00000001803D8330
		protected virtual JsonObjectContract CreateObjectContract(System.Type objectType); // 0x00000001803D2590-0x00000001803D2C60
		private static void ThrowUnableToSerializeError(object o, StreamingContext context); // 0x00000001803D84F0-0x00000001803D85C0
		private MemberInfo GetExtensionDataMemberForType(System.Type type); // 0x00000001803D4980-0x00000001803D4B90
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member); // 0x00000001803D6D30-0x00000001803D7740
		private ConstructorInfo GetAttributeConstructor(System.Type objectType); // 0x00000001803D3A70-0x00000001803D3EF0
		private ConstructorInfo GetImmutableConstructor(System.Type objectType, JsonPropertyCollection memberProperties); // 0x00000001803D4B90-0x00000001803D4D70
		private ConstructorInfo GetParameterizedConstructor(System.Type objectType); // 0x00000001803D4D70-0x00000001803D4DC0
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties); // 0x00000001803D1130-0x00000001803D1300
		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, System.Type type); // 0x00000001803D6970-0x00000001803D6A30
		protected virtual JsonProperty CreatePropertyFromConstructorParameter([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ JsonProperty matchingMemberProperty, ParameterInfo parameterInfo); // 0x00000001803D30D0-0x00000001803D33D0
		protected virtual JsonConverter ResolveContractConverter(System.Type objectType); // 0x00000001803D6BD0-0x00000001803D6C30
		private Func<object> GetDefaultCreator(System.Type createdType); // 0x00000001803D48E0-0x00000001803D4980
		private void InitializeContract(JsonContract contract); // 0x00000001803D5710-0x00000001803D5B60
		private void ResolveCallbackMethods(JsonContract contract, System.Type t); // 0x00000001803D6A30-0x00000001803D6BD0
		private void GetCallbackMethodsForType(System.Type type, [Nullable] /* 0x0000000180018EB0-0x0000000180018F10 */ out List<SerializationCallback> onSerializing, [Nullable] /* 0x0000000180018F10-0x0000000180018F70 */ out List<SerializationCallback> onSerialized, [Nullable] /* 0x0000000180018F70-0x0000000180018FD0 */ out List<SerializationCallback> onDeserializing, [Nullable] /* 0x0000000180018FD0-0x0000000180019030 */ out List<SerializationCallback> onDeserialized, [Nullable] /* 0x0000000180019030-0x0000000180019090 */ out List<SerializationErrorCallback> onError); // 0x00000001803D3EF0-0x00000001803D4660
		private static bool IsConcurrentOrObservableCollection(System.Type t); // 0x00000001803D5B60-0x00000001803D5C90
		private static bool ShouldSkipDeserialized(System.Type t); // 0x00000001803D8330-0x00000001803D8410
		private static bool ShouldSkipSerializing(System.Type t); // 0x00000001803D8410-0x00000001803D84F0
		private List<System.Type> GetClassHierarchyForType(System.Type type); // 0x00000001803D4660-0x00000001803D47C0
		protected virtual JsonDictionaryContract CreateDictionaryContract(System.Type objectType); // 0x00000001803D1990-0x00000001803D2000
		protected virtual JsonArrayContract CreateArrayContract(System.Type objectType); // 0x00000001803D0D50-0x00000001803D1130
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType); // 0x00000001803D2C60-0x00000001803D2CD0
		protected virtual JsonLinqContract CreateLinqContract(System.Type objectType); // 0x00000001803D24C0-0x00000001803D2530
		protected virtual JsonISerializableContract CreateISerializableContract(System.Type objectType); // 0x00000001803D2240-0x00000001803D24C0
		protected virtual JsonDynamicContract CreateDynamicContract(System.Type objectType); // 0x00000001803D2000-0x00000001803D2240
		protected virtual JsonStringContract CreateStringContract(System.Type objectType); // 0x00000001803D3880-0x00000001803D38F0
		protected virtual JsonContract CreateContract(System.Type objectType); // 0x00000001803D1300-0x00000001803D1990
		internal static bool IsJsonPrimitiveType(System.Type t); // 0x00000001803D5E30-0x00000001803D5EE0
		internal static bool IsIConvertible(System.Type t); // 0x00000001803D5C90-0x00000001803D5E30
		internal static bool CanConvertToString(System.Type type); // 0x00000001803D0C20-0x00000001803D0D50
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, System.Type attributeType, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ MethodInfo currentCallback, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ ref System.Type prevAttributeType); // 0x00000001803D5EE0-0x00000001803D6970
		internal static string GetClrTypeFullName(System.Type type); // 0x00000001803D47C0-0x00000001803D48E0
		protected virtual IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization); // 0x00000001803D2CD0-0x00000001803D30D0
		internal virtual DefaultJsonNameTable GetNameTable(); // 0x0000000180268FC0-0x0000000180268FD0
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member); // 0x00000001803D2530-0x00000001803D2590
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization); // 0x00000001803D33D0-0x00000001803D35F0
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, System.Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess); // 0x00000001803D7A90-0x00000001803D8210
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member); // 0x00000001803D35F0-0x00000001803D3880
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess); // 0x00000001803D7740-0x00000001803D7A90
		protected virtual string ResolvePropertyName(string propertyName); // 0x00000001803D6D00-0x00000001803D6D30
		protected virtual string ResolveExtensionDataName(string extensionDataName); // 0x00000001803D6CE0-0x00000001803D6D00
		protected virtual string ResolveDictionaryKey(string dictionaryKey); // 0x00000001803D6CB0-0x00000001803D6CE0
		public string GetResolvedPropertyName(string propertyName); // 0x00000001803D4DC0-0x00000001803D4DE0
	}
}
