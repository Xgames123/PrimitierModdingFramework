/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
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
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal static class JsonTypeReflector // TypeDefIndex: 5478
	{
		// Fields
		private static bool? _fullyTrusted; // 0x00
		[Nullable] // 0x0000000180015920-0x0000000180015980
		private static readonly ThreadSafeStore<System.Type, Func<object[], object>> CreatorCache; // 0x08
		[Nullable] // 0x0000000180015980-0x00000001800159E0
		private static readonly ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache; // 0x10
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool FullyTrusted { get; } // 0x0000000180682940-0x0000000180682A80 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000180682A80-0x0000000180682B20 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 5476
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public System.Type type; // 0x10
			[Nullable] // 0x0000000180015AA0-0x0000000180015B00
			public Func<object> defaultConstructor; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _GetCreator_b__0([Nullable] /* 0x0000000180015B00-0x0000000180015B60 */ object[] parameters); // 0x0000000180796590-0x0000000180796A00
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5477
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<object, System.Type> __9__22_1; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180797AF0-0x0000000180797B50
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal System.Type _GetCreator_b__22_1(object param); // 0x0000000180795940-0x00000001807959B0
		}
	
		// Constructors
		static JsonTypeReflector(); // 0x00000001806827D0-0x0000000180682940
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static bool CanTypeDescriptorConvertString(System.Type type, out TypeConverter typeConverter); // 0x00000001806815A0-0x00000001806817B0
		public static DataContractAttribute GetDataContractAttribute(System.Type type); // 0x0000000180682030-0x00000001806820F0
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo); // 0x00000001806820F0-0x0000000180682390
		public static MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute); // 0x00000001806824E0-0x00000001806826F0
		public static JsonConverter GetJsonConverter(object attributeProvider); // 0x0000000180682390-0x00000001806824E0
		public static JsonConverter CreateJsonConverterInstance(System.Type converterType, [Nullable] /* 0x00000001800159E0-0x0000000180015A40 */ object[] args); // 0x00000001806817B0-0x00000001806818C0
		public static NamingStrategy CreateNamingStrategyInstance(System.Type namingStrategyType, [Nullable] /* 0x0000000180015A40-0x0000000180015AA0 */ object[] args); // 0x00000001806818C0-0x00000001806819D0
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute); // 0x0000000180681CD0-0x0000000180681EB0
		private static Func<object[], object> GetCreator(System.Type type); // 0x0000000180681EB0-0x0000000180682030
		private static System.Type GetAssociatedMetadataType(System.Type type); // 0x0000000180681C40-0x0000000180681CD0
		private static System.Type GetAssociateMetadataTypeFromAttribute(System.Type type); // 0x00000001806819D0-0x0000000180681C40
		private static T GetAttribute<T>(System.Type type)
			where T : Attribute;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute;
		public static bool IsNonSerializable(object provider); // 0x00000001806826F0-0x0000000180682760
		public static bool IsSerializable(object provider); // 0x0000000180682760-0x00000001806827D0
		public static T GetAttribute<T>(object provider)
			where T : Attribute;
	}
}
