/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Newtonsoft.Json.Utilities;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Serialization
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 5438
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		[Nullable] // 0x0000000180019530-0x0000000180019590
		private readonly ThreadSafeStore<StructMultiKey<string, string>, System.Type> _typeCache; // 0x10
	
		// Constructors
		public DefaultSerializationBinder(); // 0x00000001803DA5A0-0x00000001803DA670
		static DefaultSerializationBinder(); // 0x00000001803DA4A0-0x00000001803DA5A0
	
		// Methods
		private System.Type GetTypeFromTypeNameKey([Nullable] /* 0x0000000180019590-0x00000001800195F0 */ StructMultiKey<string, string> typeNameKey); // 0x00000001803D9FC0-0x00000001803DA4A0
		private System.Type GetGenericTypeFromTypeName(string typeName, Assembly assembly); // 0x00000001803D9CB0-0x00000001803D9F60
		private System.Type GetTypeByName([Nullable] /* 0x00000001800195F0-0x0000000180019650 */ StructMultiKey<string, string> typeNameKey); // 0x00000001803D9F60-0x00000001803D9FC0
		public override System.Type BindToType([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ string assemblyName, string typeName); // 0x00000001803D9BF0-0x00000001803D9CB0
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public override void BindToName([Nullable] /* 0x0000000180014ED0-0x0000000180014EF0 */ System.Type serializedType, out string assemblyName, out string typeName); // 0x00000001803D9B70-0x00000001803D9BF0
	}
}
