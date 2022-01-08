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
using Newtonsoft.Json.Serialization;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x00000001800155A0-0x00000001800155E0
	[NullableContext] // 0x00000001800155A0-0x00000001800155E0
	internal class FSharpUtils // TypeDefIndex: 5382
	{
		// Fields
		private static readonly object Lock; // 0x00
		[Nullable] // 0x00000001800155E0-0x0000000180015600
		private static FSharpUtils _instance; // 0x08
		private MethodInfo _ofSeq; // 0x10
		private System.Type _mapType; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Assembly _FSharpCoreAssembly_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180017AB0-0x0000000180017B20
		[Nullable] // 0x0000000180017AB0-0x0000000180017B20
		private MethodCall<object, object> _IsUnion_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180017B20-0x0000000180017B90
		[Nullable] // 0x0000000180017B20-0x0000000180017B90
		private MethodCall<object, object> _GetUnionCases_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180017B90-0x0000000180017C00
		[Nullable] // 0x0000000180017B90-0x0000000180017C00
		private MethodCall<object, object> _PreComputeUnionTagReader_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180017C00-0x0000000180017C70
		[Nullable] // 0x0000000180017C00-0x0000000180017C70
		private MethodCall<object, object> _PreComputeUnionReader_k__BackingField; // 0x40
		[CompilerGenerated] // 0x0000000180017C70-0x0000000180017CE0
		[Nullable] // 0x0000000180017C70-0x0000000180017CE0
		private MethodCall<object, object> _PreComputeUnionConstructor_k__BackingField; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<object, object> _GetUnionCaseInfoDeclaringType_k__BackingField; // 0x50
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<object, object> _GetUnionCaseInfoName_k__BackingField; // 0x58
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Func<object, object> _GetUnionCaseInfoTag_k__BackingField; // 0x60
		[CompilerGenerated] // 0x0000000180017CE0-0x0000000180017D50
		[Nullable] // 0x0000000180017CE0-0x0000000180017D50
		private MethodCall<object, object> _GetUnionCaseInfoFields_k__BackingField; // 0x68
	
		// Properties
		public static FSharpUtils Instance { get; } // 0x00000001803DFDF0-0x00000001803DFE50 
		private Assembly FSharpCoreAssembly { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x000000018026C0A0-0x000000018026C0B0
		[Nullable] // 0x0000000180017F90-0x0000000180017FF0
		public MethodCall<object, object> IsUnion { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		[Nullable] // 0x0000000180017FF0-0x0000000180018050
		public MethodCall<object, object> GetUnionCases { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		[Nullable] // 0x0000000180018050-0x00000001800180B0
		public MethodCall<object, object> PreComputeUnionTagReader { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		[Nullable] // 0x00000001800180B0-0x0000000180018110
		public MethodCall<object, object> PreComputeUnionReader { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268310-0x0000000180268320 0x0000000180268390-0x00000001802683A0
		[Nullable] // 0x0000000180018110-0x0000000180018170
		public MethodCall<object, object> PreComputeUnionConstructor { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF7E0-0x00000001802AF7F0 0x00000001802B0B50-0x00000001802B0B60
		public Func<object, object> GetUnionCaseInfoDeclaringType { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public Func<object, object> GetUnionCaseInfoName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802BF820-0x00000001802BF890 0x00000001802C6D60-0x00000001802C6D70
		public Func<object, object> GetUnionCaseInfoTag { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802C6D20-0x00000001802C6D30 0x000000018026C080-0x000000018026C090
		[Nullable] // 0x0000000180018170-0x00000001800181D0
		public MethodCall<object, object> GetUnionCaseInfoFields { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802C6D10-0x00000001802C6D20 0x00000001802C6D50-0x00000001802C6D60
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 5379
		{
			// Fields
			[Nullable] // 0x00000001800181D0-0x0000000180018230
			public MethodCall<object, object> call; // 0x10
			[Nullable] // 0x0000000180018230-0x0000000180018290
			public MethodCall<object, object> invoke; // 0x18
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal object _CreateFSharpFuncCall_b__0([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ object target, [Nullable] /* 0x0000000180018290-0x00000001800182F0 */ object[] args); // 0x0000000180797360-0x0000000180797400
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass55_0<TKey, TValue> // TypeDefIndex: 5380
		{
			// Fields
			[Nullable] // 0x00000001800182F0-0x0000000180018350
			public ObjectConstructor<object> ctorDelegate;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal object _BuildMapCreator_b__0([Nullable] /* 0x0000000180018350-0x00000001800183B0 */ object[] args);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__55<TKey, TValue> // TypeDefIndex: 5381
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c__55<TKey, TValue> __9;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>> __9__55_1;
	
			// Constructors
			static __c__55();
			public __c__55();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal Tuple<TKey, TValue> _BuildMapCreator_b__55_1(KeyValuePair<TKey, TValue> kv);
		}
	
		// Constructors
		private FSharpUtils(Assembly fsharpCoreAssembly); // 0x00000001803DF8F0-0x00000001803DFDF0
		static FSharpUtils(); // 0x00000001803DF890-0x00000001803DF8F0
	
		// Methods
		public static void EnsureInitialized(Assembly fsharpCoreAssembly); // 0x00000001803DF6A0-0x00000001803DF810
		private static MethodInfo GetMethodWithNonPublicFallback(System.Type type, string methodName, BindingFlags bindingFlags); // 0x00000001803DF810-0x00000001803DF890
		private static MethodCall<object, object> CreateFSharpFuncCall(System.Type type, string methodName); // 0x00000001803DF150-0x00000001803DF390
		public ObjectConstructor<object> CreateSeq(System.Type t); // 0x00000001803DF580-0x00000001803DF6A0
		public ObjectConstructor<object> CreateMap(System.Type keyType, System.Type valueType); // 0x00000001803DF390-0x00000001803DF580
		[NullableContext] // 0x0000000180015660-0x0000000180015680
		public ObjectConstructor<object> BuildMapCreator<TKey, TValue>();
	}
}
