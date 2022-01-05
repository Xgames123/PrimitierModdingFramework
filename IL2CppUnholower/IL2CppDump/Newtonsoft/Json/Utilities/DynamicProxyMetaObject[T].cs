/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Utilities
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 5369
	{
		// Fields
		private readonly DynamicProxy<T> _proxy;
	
		// Properties
		private static Expression[] NoArgs { get; }
	
		// Nested types
		[NullableContext] // 0x0000000180015700-0x0000000180015720
		private delegate DynamicMetaObject Fallback([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ DynamicMetaObject errorSuggestion); // TypeDefIndex: 5365; 0x00000000-0x00000000
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 5366
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public GetMemberBinder binder;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public DynamicProxyMetaObject<T> __4__this;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal DynamicMetaObject _BindGetMember_b__0([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ DynamicMetaObject e);
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 5367
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public SetMemberBinder binder;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public DynamicProxyMetaObject<T> __4__this;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public DynamicMetaObject value;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal DynamicMetaObject _BindSetMember_b__0([Nullable] /* 0x00000001800155E0-0x0000000180015600 */ DynamicMetaObject e);
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5368
		{
			// Fields
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static readonly __c<T> __9;
			[Nullable] // 0x0000000180015680-0x00000001800156A0
			public static Func<DynamicMetaObject, Expression> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			[NullableContext] // 0x0000000180015700-0x0000000180015720
			internal Expression _GetArgs_b__18_0(DynamicMetaObject arg);
		}
	
		// Constructors
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy);
	
		// Methods
		private bool IsOverridden(string method);
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder);
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value);
		private static IEnumerable<Expression> GetArgs(params /* 0x0000000180014D50-0x0000000180014D60 */ DynamicMetaObject[] args);
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder);
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable] /* 0x0000000180017770-0x00000001800177D0 */ Fallback fallback, [Nullable] /* 0x00000001800177D0-0x0000000180017830 */ Fallback fallbackInvoke = null);
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, [Nullable] /* 0x0000000180017830-0x0000000180017890 */ Fallback fallbackInvoke);
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable] /* 0x0000000180017890-0x00000001800178F0 */ Fallback fallback);
		private BindingRestrictions GetRestrictions();
		public override IEnumerable<string> GetDynamicMemberNames();
	}
}
