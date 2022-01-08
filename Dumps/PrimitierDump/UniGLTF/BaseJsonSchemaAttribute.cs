/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class BaseJsonSchemaAttribute : Attribute // TypeDefIndex: 5726
	{
		// Fields
		public string Title; // 0x10
		public string Description; // 0x18
		public double Minimum; // 0x20
		public bool ExclusiveMinimum; // 0x28
		public double Maximum; // 0x30
		public bool ExclusiveMaximum; // 0x38
		public double MultipleOf; // 0x40
		public string Pattern; // 0x48
		public int MinItems; // 0x50
		public int MaxItems; // 0x54
		public ValueNodeType ValueType; // 0x58
		public int MinProperties; // 0x5C
		public bool Required; // 0x60
		public string[] Dependencies; // 0x68
		public EnumSerializationType EnumSerializationType; // 0x70
		public object[] EnumValues; // 0x78
		public object[] EnumExcludes; // 0x80
		public string[] SerializationConditions; // 0x88
		public bool SkipSchemaComparison; // 0x90
		public object ExplicitIgnorableValue; // 0x98
		public int ExplicitIgnorableItemLength; // 0xA0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5725
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__24_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000180D58E50-0x0000000180D58EB0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal string _GetTypeName_b__24_0(System.Type x); // 0x0000000180796050-0x0000000180796080
		}
	
		// Constructors
		public BaseJsonSchemaAttribute(); // 0x00000001810AC0A0-0x00000001810AC0D0
	
		// Methods
		public void Merge(BaseJsonSchemaAttribute rhs); // 0x00000001810AC060-0x00000001810AC0A0
		public virtual string GetInfo(FieldInfo fi); // 0x00000001810AB8F0-0x00000001810AB920
		public static bool IsNumber(System.Type t); // 0x00000001810ABCF0-0x00000001810AC060
		public static string GetTypeName(System.Type t); // 0x00000001810AB920-0x00000001810ABCF0
	}
}
