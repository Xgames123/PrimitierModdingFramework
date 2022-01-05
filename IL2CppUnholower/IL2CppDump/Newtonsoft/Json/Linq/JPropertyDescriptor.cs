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
using System.Runtime.Versioning;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Linq
{
	[Nullable] // 0x0000000180015010-0x0000000180015050
	[NullableContext] // 0x0000000180015010-0x0000000180015050
	public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5499
	{
		// Properties
		public override System.Type ComponentType { get; } // 0x00000001804B1410-0x00000001804B1480 
		public override bool IsReadOnly { get; } // 0x0000000180295620-0x0000000180295630 
		public override System.Type PropertyType { get; } // 0x00000001804B1480-0x00000001804B14F0 
		protected override int NameHashCode { get; } // 0x000000018030A1D0-0x000000018030A1E0 
	
		// Constructors
		public JPropertyDescriptor(string name); // 0x00000001804B1400-0x00000001804B1410
	
		// Methods
		public override object GetValue(object component); // 0x00000001804B1200-0x00000001804B12C0
		public override void SetValue(object component, object value); // 0x00000001804B12C0-0x00000001804B1400
		public override bool ShouldSerializeValue(object component); // 0x0000000180295620-0x0000000180295630
	}
}
