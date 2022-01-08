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
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 7045
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly JsonConverter[] BuiltInConverters; // 0x08
		private static readonly object TypeContractCacheLock; // 0x10
		private static readonly DefaultContractResolverState _sharedState; // 0x18
		private readonly DefaultContractResolverState _instanceState; // 0x10
		private readonly bool _sharedCache; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private BindingFlags _DefaultMembersSearchFlags_k__BackingField; // 0x1C
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _SerializeCompilerGeneratedMembers_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreSerializableInterface_k__BackingField; // 0x21
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _IgnoreSerializableAttribute_k__BackingField; // 0x22
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private NamingStrategy _NamingStrategy_k__BackingField; // 0x28
	
		// Properties
		internal static IContractResolver Instance { get; } // 0x00000001803928B0-0x0000000180392910 
		[Obsolete] // 0x0000000180019090-0x00000001800190C0
		public BindingFlags DefaultMembersSearchFlags { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802AC190-0x00000001802AC1A0 0x00000001802C2020-0x00000001802C2030
		public bool SerializeCompilerGeneratedMembers { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802A2B80-0x00000001802A2B90 
		public bool IgnoreSerializableInterface { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001803928A0-0x00000001803928B0 
		public bool IgnoreSerializableAttribute { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180392890-0x00000001803928A0 0x0000000180392910-0x0000000180392920
		public NamingStrategy NamingStrategy { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268FD0-0x0000000180268FE0 
	
		// Nested types
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>> // TypeDefIndex: 7037
		{
			// Fields
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Nested types
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private sealed class _GetEnumerator_d__2 : IEnumerator<KeyValuePair<object, object>> // TypeDefIndex: 7036
			{
				// Fields
				private int __1__state;
				private KeyValuePair<object, object> __2__current;
				public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> __4__this;
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
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
	
			// Methods
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7038
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MemberInfo, bool> __9__34_0; // 0x08
			public static Func<MemberInfo, bool> __9__34_1; // 0x10
			public static Func<System.Type, IEnumerable<MemberInfo>> __9__37_0; // 0x18
			public static Func<MemberInfo, bool> __9__37_1; // 0x20
			public static Func<ConstructorInfo, bool> __9__40_0; // 0x28
			public static Func<JsonProperty, int> __9__64_0; // 0x30
	
			// Constructors
			static __c(); // 0x0000000180882B60-0x0000000180882BC0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetSerializableMembers_b__34_0(MemberInfo m); // 0x0000000180881910-0x0000000180881970
			internal bool _GetSerializableMembers_b__34_1(MemberInfo m); // 0x0000000180881970-0x00000001808819D0
			internal IEnumerable<MemberInfo> _GetExtensionDataMemberForType_b__37_0(System.Type baseType); // 0x0000000180881300-0x00000001808813D0
			internal bool _GetExtensionDataMemberForType_b__37_1(MemberInfo m); // 0x00000001808813D0-0x0000000180881910
			internal bool _GetAttributeConstructor_b__40_0(ConstructorInfo c); // 0x00000001808811E0-0x0000000180881280
			internal int _CreateProperties_b__64_0(JsonProperty p); // 0x0000000180881180-0x00000001808811E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 7039
		{
			// Fields
			public Func<object, object> getExtensionDataDictionary; // 0x10
			public MemberInfo member; // 0x18
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass38_1 // TypeDefIndex: 7040
		{
			// Fields
			public Action<object, object> setExtensionDataDictionary; // 0x10
			public Func<object> createExtensionDataDictionary; // 0x18
			public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
			public __c__DisplayClass38_0 CS___8__locals1; // 0x28
	
			// Constructors
			public __c__DisplayClass38_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _SetExtensionDataDelegates_b__0(object o, string key, object value); // 0x0000000180881FD0-0x0000000180882280
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass38_2 // TypeDefIndex: 7041
		{
			// Fields
			public ObjectConstructor<object> createEnumerableWrapper; // 0x10
			public __c__DisplayClass38_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass38_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal IEnumerable<KeyValuePair<object, object>> _SetExtensionDataDelegates_b__1(object o); // 0x0000000180882280-0x00000001808823C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 7042
		{
			// Fields
			public NamingStrategy namingStrategy; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _CreateDictionaryContract_b__0(string s); // 0x0000000180882610-0x0000000180882640
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass68_0 // TypeDefIndex: 7043
		{
			// Fields
			public MethodCall<object, object> shouldSerializeCall; // 0x10
	
			// Constructors
			public __c__DisplayClass68_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CreateShouldSerializeTest_b__0(object o); // 0x0000000180882640-0x00000001808826F0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 7044
		{
			// Fields
			public Func<object, object> specifiedPropertyGet; // 0x10
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _SetIsSpecifiedActions_b__0(object o); // 0x00000001808826F0-0x0000000180882780
		}
	
		// Constructors
		public DefaultContractResolver(); // 0x0000000180392720-0x00000001803927D0
		[Obsolete] // 0x0000000180037AC0-0x0000000180037AF0
		public DefaultContractResolver(bool shareCache); // 0x00000001803927D0-0x0000000180392890
		static DefaultContractResolver(); // 0x0000000180392390-0x0000000180392720
	
		// Methods
		internal DefaultContractResolverState GetState(); // 0x000000018038FA40-0x000000018038FAB0
		public virtual JsonContract ResolveContract(System.Type type); // 0x0000000180390D30-0x0000000180390FA0
		protected virtual List<MemberInfo> GetSerializableMembers(System.Type objectType); // 0x000000018038F250-0x000000018038FA40
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo); // 0x0000000180392270-0x0000000180392390
		protected virtual JsonObjectContract CreateObjectContract(System.Type objectType); // 0x000000018038D080-0x000000018038D3E0
		private MemberInfo GetExtensionDataMemberForType(System.Type type); // 0x000000018038EF70-0x000000018038F180
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member); // 0x0000000180391000-0x00000001803918A0
		private ConstructorInfo GetAttributeConstructor(System.Type objectType); // 0x000000018038E030-0x000000018038E4A0
		private ConstructorInfo GetParameterizedConstructor(System.Type objectType); // 0x000000018038F180-0x000000018038F230
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties); // 0x000000018038BFE0-0x000000018038C1B0
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo); // 0x000000018038D830-0x000000018038DB40
		protected virtual JsonConverter ResolveContractConverter(System.Type objectType); // 0x0000000180390CD0-0x0000000180390D30
		private Func<object> GetDefaultCreator(System.Type createdType); // 0x000000018038EED0-0x000000018038EF70
		private void InitializeContract(JsonContract contract); // 0x000000018038FAB0-0x000000018038FED0
		private void ResolveCallbackMethods(JsonContract contract, System.Type t); // 0x0000000180390B30-0x0000000180390CD0
		private void GetCallbackMethodsForType(System.Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError); // 0x000000018038E4A0-0x000000018038EBE0
		private static bool ShouldSkipDeserialized(System.Type t); // 0x0000000180295620-0x0000000180295630
		private static bool ShouldSkipSerializing(System.Type t); // 0x0000000180295620-0x0000000180295630
		private List<System.Type> GetClassHierarchyForType(System.Type type); // 0x000000018038EBE0-0x000000018038ED00
		protected virtual JsonDictionaryContract CreateDictionaryContract(System.Type objectType); // 0x000000018038C7C0-0x000000018038CD70
		protected virtual JsonArrayContract CreateArrayContract(System.Type objectType); // 0x000000018038BC70-0x000000018038BFE0
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType); // 0x000000018038D3E0-0x000000018038D450
		protected virtual JsonLinqContract CreateLinqContract(System.Type objectType); // 0x000000018038CFB0-0x000000018038D020
		protected virtual JsonISerializableContract CreateISerializableContract(System.Type objectType); // 0x000000018038CD70-0x000000018038CFB0
		protected virtual JsonStringContract CreateStringContract(System.Type objectType); // 0x000000018038DFC0-0x000000018038E030
		protected virtual JsonContract CreateContract(System.Type objectType); // 0x000000018038C1B0-0x000000018038C7C0
		internal static bool IsJsonPrimitiveType(System.Type t); // 0x0000000180390070-0x0000000180390120
		internal static bool IsIConvertible(System.Type t); // 0x000000018038FED0-0x0000000180390070
		internal static bool CanConvertToString(System.Type type); // 0x000000018038B9D0-0x000000018038BC70
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, System.Type attributeType, MethodInfo currentCallback, ref System.Type prevAttributeType); // 0x0000000180390120-0x0000000180390B30
		internal static string GetClrTypeFullName(System.Type type); // 0x000000018038ED00-0x000000018038EED0
		protected virtual IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization); // 0x000000018038D450-0x000000018038D830
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member); // 0x000000018038D020-0x000000018038D080
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization); // 0x000000018038DB40-0x000000018038DD50
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, System.Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess); // 0x0000000180391BC0-0x0000000180392270
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member); // 0x000000018038DD50-0x000000018038DFC0
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess); // 0x00000001803918A0-0x0000000180391BC0
		protected virtual string ResolvePropertyName(string propertyName); // 0x0000000180390FD0-0x0000000180391000
		protected virtual string ResolveDictionaryKey(string dictionaryKey); // 0x0000000180390FA0-0x0000000180390FD0
		public string GetResolvedPropertyName(string propertyName); // 0x000000018038F230-0x000000018038F250
	}
}
