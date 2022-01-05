/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Serialization
{
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 7070
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private MemberSerialization _MemberSerialization_k__BackingField; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Required? _ItemRequired_k__BackingField; // 0xC4
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private JsonPropertyCollection _Properties_k__BackingField; // 0xD0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ExtensionDataSetter _ExtensionDataSetter_k__BackingField; // 0xD8
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ExtensionDataGetter _ExtensionDataGetter_k__BackingField; // 0xE0
		internal bool ExtensionDataIsJToken; // 0xE8
		private bool? _hasRequiredOrDefaultValueProperties; // 0xE9
		private ConstructorInfo _parametrizedConstructor; // 0xF0
		private ConstructorInfo _overrideConstructor; // 0xF8
		private ObjectConstructor<object> _overrideCreator; // 0x100
		private ObjectConstructor<object> _parameterizedCreator; // 0x108
		private JsonPropertyCollection _creatorParameters; // 0x110
		private System.Type _extensionDataValueType; // 0x118
	
		// Properties
		public MemberSerialization MemberSerialization { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424C40-0x0000000180424C50 0x0000000180424D20-0x0000000180424D30
		public Required? ItemRequired { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x0000000180424C30-0x0000000180424C40 0x0000000180424D10-0x0000000180424D20
		public JsonPropertyCollection Properties { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018031EBF0-0x000000018031EC00 0x000000018031EC50-0x000000018031EC60
		public JsonPropertyCollection CreatorParameters { get; } // 0x00000001804248B0-0x0000000180424930 
		[Obsolete] // 0x0000000180037AF0-0x0000000180037B20
		public ConstructorInfo OverrideConstructor { set; } // 0x0000000180424D30-0x0000000180424DE0
		[Obsolete] // 0x0000000180037B20-0x0000000180037B50
		public ConstructorInfo ParametrizedConstructor { set; } // 0x0000000180424DE0-0x0000000180424E90
		public ObjectConstructor<object> OverrideCreator { get; } // 0x000000018026A2E0-0x000000018026A2F0 
		internal ObjectConstructor<object> ParameterizedCreator { get; } // 0x0000000180377500-0x0000000180377510 
		public ExtensionDataSetter ExtensionDataSetter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A2F0-0x000000018026A300 0x000000018026A920-0x000000018026A930
		public ExtensionDataGetter ExtensionDataGetter { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026A6D0-0x000000018026A6E0 0x000000018026AA50-0x000000018026AA60
		public System.Type ExtensionDataValueType { set; } // 0x0000000180424C50-0x0000000180424D10
		internal bool HasRequiredOrDefaultValueProperties { get; } // 0x0000000180424930-0x0000000180424C30 
	
		// Constructors
		public JsonObjectContract(System.Type underlyingType); // 0x0000000180424830-0x00000001804248B0
	
		// Methods
		internal object GetUninitializedObject(); // 0x00000001804246E0-0x0000000180424830
	}
}
