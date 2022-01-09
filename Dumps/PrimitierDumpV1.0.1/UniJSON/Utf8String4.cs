/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct Utf8String4 : IEquatable<UniJSON.Utf8String4>, IUtf8String // TypeDefIndex: 5627
	{
		// Fields
		private uint _value; // 0x00
		private byte _byte0; // 0x00
		private byte _byte1; // 0x01
		private byte _byte2; // 0x02
		private byte _byte3; // 0x03
	
		// Properties
		public int ByteLength { get; } // 0x0000000180BCABE0-0x0000000180BCAC10 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _GetEnumerator_d__14 : IEnumerator<byte> // TypeDefIndex: 5626
		{
			// Fields
			private int __1__state; // 0x10
			private byte __2__current; // 0x14
			public Utf8String4 __4__this; // 0x18
	
			// Properties
			byte IEnumerator<System.Byte>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018036C110-0x000000018036C120 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E0720-0x00000001806E0770 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _GetEnumerator_d__14(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E0640-0x00000001806E06E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E06E0-0x00000001806E0720
		}
	
		// Methods
		private static Utf8String4 Create(uint value); // 0x0000000180639EF0-0x0000000180639F00
		public static Utf8String4 Create(IEnumerable<byte> bytes); // 0x0000000180BCA820-0x0000000180BCA9A0
		public static Utf8String4 Create(string src); // 0x0000000180BCA630-0x0000000180BCA820
		public bool Equals(Utf8String4 other); // 0x0000000180BCA9A0-0x0000000180BCA9B0
		public override bool Equals(object obj); // 0x0000000180BCA9B0-0x0000000180BCAAA0
		public override int GetHashCode(); // 0x00000001806C8C10-0x00000001806C8C20
		public override string ToString(); // 0x0000000180BCAB10-0x0000000180BCABE0
		[IteratorStateMachine] // 0x0000000180026E50-0x0000000180026EA0
		public IEnumerator<byte> GetEnumerator(); // 0x0000000180BCAAA0-0x0000000180BCAB10
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180BCAAA0-0x0000000180BCAB10
	}
}
