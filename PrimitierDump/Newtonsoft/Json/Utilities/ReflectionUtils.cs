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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180017730-0x0000000180017770
	[NullableContext] // 0x0000000180017730-0x0000000180017770
	internal static class ReflectionUtils // TypeDefIndex: 5413
	{
		// Fields
		public static readonly System.Type[] EmptyTypes; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5408
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c __9; // 0x00
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<ConstructorInfo, bool> __9__11_0; // 0x08
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<MemberInfo, string> __9__31_0; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<ParameterInfo, System.Type> __9__39_0; // 0x18
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<FieldInfo, bool> __9__41_0; // 0x20
	
			// Constructors
			static __c(); // 0x0000000180797910-0x0000000180797970
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetDefaultConstructor_b__11_0(ConstructorInfo c); // 0x00000001807959B0-0x0000000180795A10
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal string _GetFieldsAndProperties_b__31_0(MemberInfo m); // 0x0000000180796050-0x0000000180796080
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal System.Type _GetMemberInfoFromType_b__39_0(ParameterInfo p); // 0x0000000180796050-0x0000000180796080
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetChildPrivateFields_b__41_0(FieldInfo f); // 0x0000000180795920-0x0000000180795940
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 5409
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public MemberInfo memberInfo; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetFieldsAndProperties_b__1(MemberInfo m); // 0x0000000180796A00-0x0000000180796AB0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 5410
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public PropertyInfo subTypeProperty; // 0x10
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetChildPrivateProperties_b__0(PropertyInfo p); // 0x0000000180796B50-0x0000000180796BC0
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetChildPrivateProperties_b__1(PropertyInfo p); // 0x0000000180796BC0-0x0000000180796CD0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass44_1 // TypeDefIndex: 5411
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public System.Type subTypePropertyDeclaringType; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public __c__DisplayClass44_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass44_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _GetChildPrivateProperties_b__2(PropertyInfo p); // 0x0000000180796CD0-0x0000000180796E30
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 5412
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public string method; // 0x10
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public System.Type methodDeclaringType; // 0x18
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal bool _IsMethodOverridden_b__0(MethodInfo info); // 0x0000000180796E30-0x0000000180796F70
		}
	
		// Constructors
		static ReflectionUtils(); // 0x000000018068F770-0x000000018068F7F0
	
		// Methods
		public static bool IsPublic(PropertyInfo property); // 0x000000018068F050-0x000000018068F0F0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static System.Type GetObjectType(object v); // 0x000000018068DBC0-0x000000018068DBD0
		public static string GetTypeName(System.Type t, TypeNameAssemblyFormatHandling assemblyFormat, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ ISerializationBinder binder); // 0x000000018068DEC0-0x000000018068E1B0
		private static string GetFullyQualifiedTypeName(System.Type t, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ ISerializationBinder binder); // 0x000000018068D120-0x000000018068D260
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName); // 0x000000018068F1D0-0x000000018068F2F0
		public static bool HasDefaultConstructor(System.Type t, bool nonPublic); // 0x000000018068E1B0-0x000000018068E290
		public static ConstructorInfo GetDefaultConstructor(System.Type t); // 0x000000018068C010-0x000000018068C070
		public static ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic); // 0x000000018068C070-0x000000018068C1C0
		public static bool IsNullable(System.Type t); // 0x000000018068ED80-0x000000018068EE10
		public static bool IsNullableType(System.Type t); // 0x000000018068ECB0-0x000000018068ED80
		public static System.Type EnsureNotNullableType(System.Type t); // 0x000000018068AF70-0x000000018068AFE0
		public static System.Type EnsureNotByRefType(System.Type t); // 0x000000018068AF20-0x000000018068AF70
		public static bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition); // 0x000000018068EA90-0x000000018068EB30
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition); // 0x000000018068E530-0x000000018068E5B0
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, [NotNullWhen] /* 0x00000001800157C0-0x0000000180015800 */ [Nullable] /* 0x00000001800157C0-0x0000000180015800 */ out System.Type implementingType); // 0x000000018068E290-0x000000018068E530
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition); // 0x000000018068E6C0-0x000000018068E740
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out System.Type implementingType); // 0x000000018068E740-0x000000018068E980
		private static bool InheritsGenericDefinitionInternal(System.Type currentType, System.Type genericClassDefinition, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ out System.Type implementingType); // 0x000000018068E5B0-0x000000018068E6C0
		public static System.Type GetCollectionItemType(System.Type type); // 0x000000018068BCE0-0x000000018068C010
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public static void GetDictionaryKeyValueTypes([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ System.Type dictionaryType, out System.Type keyType, out System.Type valueType); // 0x000000018068C580-0x000000018068C8C0
		public static System.Type GetMemberUnderlyingType(MemberInfo member); // 0x000000018068D520-0x000000018068D810
		public static bool IsByRefLikeType(System.Type type); // 0x000000018068E980-0x000000018068EA90
		public static bool IsIndexedProperty(PropertyInfo property); // 0x000000018068EB30-0x000000018068EBA0
		public static object GetMemberValue(MemberInfo member, object target); // 0x000000018068D810-0x000000018068DBC0
		public static void SetMemberValue(MemberInfo member, object target, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object value); // 0x000000018068F300-0x000000018068F5F0
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic); // 0x000000018068ABD0-0x000000018068AD70
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly); // 0x000000018068AD70-0x000000018068AF20
		public static List<MemberInfo> GetFieldsAndProperties(System.Type type, BindingFlags bindingAttr); // 0x000000018068C8C0-0x000000018068D000
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr); // 0x000000018068EE10-0x000000018068F050
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static Attribute[] GetAttributes(object attributeProvider, [Nullable] /* 0x00000001800155E0-0x0000000180015600 */ System.Type attributeType, bool inherit); // 0x000000018068B0B0-0x000000018068B5C0
		public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName); // 0x000000018068F5F0-0x000000018068F770
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName); // 0x000000018068AFE0-0x000000018068B0B0
		public static MemberInfo GetMemberInfoFromType(System.Type targetType, MemberInfo memberInfo); // 0x000000018068D260-0x000000018068D520
		public static IEnumerable<FieldInfo> GetFields(System.Type targetType, BindingFlags bindingAttr); // 0x000000018068D000-0x000000018068D120
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, System.Type targetType, BindingFlags bindingAttr); // 0x000000018068B6A0-0x000000018068B8B0
		public static IEnumerable<PropertyInfo> GetProperties(System.Type targetType, BindingFlags bindingAttr); // 0x000000018068DBD0-0x000000018068DEC0
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, System.Type targetType, BindingFlags bindingAttr); // 0x000000018068B8B0-0x000000018068BCE0
		public static bool IsMethodOverridden(System.Type currentType, System.Type methodDeclaringType, string method); // 0x000000018068EBA0-0x000000018068ECB0
		public static object GetDefaultValue(System.Type type); // 0x000000018068C1C0-0x000000018068C580
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo); // 0x000000018068F0F0-0x000000018068F1D0
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x000000018068B5C0-0x000000018068B6A0
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag); // 0x000000018068F2F0-0x000000018068F300
	}
}
