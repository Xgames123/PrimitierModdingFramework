/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Utilities;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	internal static class JsonTypeReflector // TypeDefIndex: 7086
	{
		// Fields
		private static bool? _fullyTrusted; // 0x00
		private static readonly ThreadSafeStore<System.Type, Func<object[], object>> CreatorCache; // 0x08
		private static readonly ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache; // 0x10
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool FullyTrusted { get; } // 0x0000000180762720-0x0000000180762900 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000180762900-0x00000001807629A0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 7084
		{
			// Fields
			public System.Type type; // 0x10
			public Func<object> defaultConstructor; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _GetCreator_b__0(object[] parameters); // 0x0000000180881BA0-0x0000000180881FD0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7085
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<object, System.Type> __9__20_1; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180882B00-0x0000000180882B60
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal System.Type _GetCreator_b__20_1(object param); // 0x0000000180881280-0x00000001808812A0
		}
	
		// Constructors
		static JsonTypeReflector(); // 0x00000001807625B0-0x0000000180762720
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static DataContractAttribute GetDataContractAttribute(System.Type type); // 0x0000000180761F60-0x0000000180761FF0
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo); // 0x0000000180761FF0-0x0000000180762250
		public static MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute); // 0x00000001807623A0-0x0000000180762550
		public static JsonConverter GetJsonConverter(object attributeProvider); // 0x0000000180762250-0x00000001807623A0
		public static JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] converterArgs); // 0x00000001807616A0-0x00000001807617B0
		public static NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, object[] converterArgs); // 0x00000001807617B0-0x00000001807618C0
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute); // 0x0000000180761BC0-0x0000000180761D60
		private static Func<object[], object> GetCreator(System.Type type); // 0x0000000180761D60-0x0000000180761F60
		public static TypeConverter GetTypeConverter(System.Type type); // 0x0000000180762550-0x00000001807625B0
		private static System.Type GetAssociatedMetadataType(System.Type type); // 0x0000000180761B30-0x0000000180761BC0
		private static System.Type GetAssociateMetadataTypeFromAttribute(System.Type type); // 0x00000001807618C0-0x0000000180761B30
		private static T GetAttribute<T>(System.Type type)
			where T : Attribute;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute;
		public static T GetAttribute<T>(object provider)
			where T : Attribute;
	}
}
