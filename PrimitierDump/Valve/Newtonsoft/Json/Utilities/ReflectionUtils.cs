/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Utilities
{
	internal static class ReflectionUtils // TypeDefIndex: 7024
	{
		// Fields
		public static readonly System.Type[] EmptyTypes; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7022
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ConstructorInfo, bool> __9__10_0; // 0x08
			public static Func<MemberInfo, string> __9__29_0; // 0x10
			public static Func<ParameterInfo, System.Type> __9__37_0; // 0x18
			public static Func<FieldInfo, bool> __9__39_0; // 0x20
	
			// Constructors
			static __c(); // 0x0000000180882BC0-0x0000000180882C20
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetDefaultConstructor_b__10_0(ConstructorInfo c); // 0x00000001808812A0-0x0000000180881300
			internal string _GetFieldsAndProperties_b__29_0(MemberInfo m); // 0x0000000180796050-0x0000000180796080
			internal System.Type _GetMemberInfoFromType_b__37_0(ParameterInfo p); // 0x0000000180796050-0x0000000180796080
			internal bool _GetChildPrivateFields_b__39_0(FieldInfo f); // 0x0000000180795920-0x0000000180795940
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 7023
		{
			// Fields
			public PropertyInfo subTypeProperty; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetChildPrivateProperties_b__0(PropertyInfo p); // 0x0000000180796B50-0x0000000180796BC0
			internal bool _GetChildPrivateProperties_b__1(PropertyInfo p); // 0x00000001808823C0-0x0000000180882480
			internal bool _GetChildPrivateProperties_b__2(PropertyInfo p); // 0x0000000180882480-0x0000000180882610
		}
	
		// Constructors
		static ReflectionUtils(); // 0x000000018087D6F0-0x000000018087D770
	
		// Methods
		public static bool IsPublic(PropertyInfo property); // 0x000000018087CF60-0x000000018087CFE0
		public static System.Type GetObjectType(object v); // 0x000000018068DBC0-0x000000018068DBD0
		public static string GetTypeName(System.Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder); // 0x000000018087BF40-0x000000018087C150
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName); // 0x000000018087D0B0-0x000000018087D220
		public static bool HasDefaultConstructor(System.Type t, bool nonPublic); // 0x000000018087C150-0x000000018087C240
		public static ConstructorInfo GetDefaultConstructor(System.Type t); // 0x000000018087A2B0-0x000000018087A310
		public static ConstructorInfo GetDefaultConstructor(System.Type t, bool nonPublic); // 0x000000018087A160-0x000000018087A2B0
		public static bool IsNullable(System.Type t); // 0x000000018087CC90-0x000000018087CD60
		public static bool IsNullableType(System.Type t); // 0x000000018087CB80-0x000000018087CC90
		public static System.Type EnsureNotNullableType(System.Type t); // 0x0000000180879070-0x00000001808790E0
		public static bool IsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition); // 0x000000018087C910-0x000000018087C970
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition); // 0x000000018087C500-0x000000018087C580
		public static bool ImplementsGenericDefinition(System.Type type, System.Type genericInterfaceDefinition, out System.Type implementingType); // 0x000000018087C240-0x000000018087C500
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition); // 0x000000018087C890-0x000000018087C910
		public static bool InheritsGenericDefinition(System.Type type, System.Type genericClassDefinition, out System.Type implementingType); // 0x000000018087C690-0x000000018087C890
		private static bool InheritsGenericDefinitionInternal(System.Type currentType, System.Type genericClassDefinition, out System.Type implementingType); // 0x000000018087C580-0x000000018087C690
		public static System.Type GetCollectionItemType(System.Type type); // 0x0000000180879DE0-0x000000018087A160
		public static void GetDictionaryKeyValueTypes(System.Type dictionaryType, out System.Type keyType, out System.Type valueType); // 0x000000018087A690-0x000000018087AA10
		public static System.Type GetMemberUnderlyingType(MemberInfo member); // 0x000000018087B500-0x000000018087B830
		public static bool IsIndexedProperty(MemberInfo member); // 0x000000018087CA20-0x000000018087CB80
		public static bool IsIndexedProperty(PropertyInfo property); // 0x000000018087C970-0x000000018087CA20
		public static object GetMemberValue(MemberInfo member, object target); // 0x000000018087B830-0x000000018087BC60
		public static void SetMemberValue(MemberInfo member, object target, object value); // 0x000000018087D220-0x000000018087D570
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic); // 0x0000000180878D50-0x0000000180878ED0
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly); // 0x0000000180878ED0-0x0000000180879070
		public static List<MemberInfo> GetFieldsAndProperties(System.Type type, BindingFlags bindingAttr); // 0x000000018087AA10-0x000000018087B100
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr); // 0x000000018087CD60-0x000000018087CF60
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static Attribute[] GetAttributes(object attributeProvider, System.Type attributeType, bool inherit); // 0x00000001808791B0-0x0000000180879810
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName); // 0x000000018087D570-0x000000018087D6F0
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName); // 0x00000001808790E0-0x00000001808791B0
		public static MemberInfo GetMemberInfoFromType(System.Type targetType, MemberInfo memberInfo); // 0x000000018087B240-0x000000018087B500
		public static IEnumerable<FieldInfo> GetFields(System.Type targetType, BindingFlags bindingAttr); // 0x000000018087B100-0x000000018087B240
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, System.Type targetType, BindingFlags bindingAttr); // 0x00000001808798D0-0x0000000180879AD0
		public static IEnumerable<PropertyInfo> GetProperties(System.Type targetType, BindingFlags bindingAttr); // 0x000000018087BC60-0x000000018087BF40
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, System.Type targetType, BindingFlags bindingAttr); // 0x0000000180879AD0-0x0000000180879DE0
		public static object GetDefaultValue(System.Type type); // 0x000000018087A310-0x000000018087A690
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo); // 0x000000018087CFE0-0x000000018087D0B0
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x0000000180879810-0x00000001808798D0
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag); // 0x000000018068F2F0-0x000000018068F300
	}
}
