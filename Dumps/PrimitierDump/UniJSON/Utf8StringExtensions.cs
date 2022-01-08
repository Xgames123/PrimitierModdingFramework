/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public static class Utf8StringExtensions // TypeDefIndex: 5633
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Split_d__4 : IEnumerable<Utf8String>, IEnumerator<Utf8String> // TypeDefIndex: 5632
		{
			// Fields
			private int __1__state; // 0x10
			private Utf8String __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private Utf8String src; // 0x30
			public Utf8String __3__src; // 0x40
			private byte delimiter; // 0x50
			public byte __3__delimiter; // 0x51
			private Utf8Iterator _p_5__2; // 0x58
	
			// Properties
			Utf8String IEnumerator<UniJSON.Utf8String>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E24B0-0x00000001806E2500 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Split_d__4(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E2230-0x00000001806E23D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E2470-0x00000001806E24B0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Utf8String> IEnumerable<Utf8String>.GetEnumerator(); // 0x00000001806E23D0-0x00000001806E2470
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E23D0-0x00000001806E2470
		}
	
		// Extension methods
		public static void WriteTo(this Utf8String src, Stream dst); // 0x0000000180BCC690-0x0000000180BCC730
		public static Utf8Iterator GetFirst(this Utf8String src); // 0x0000000180BCAE50-0x0000000180BCAEF0
		public static bool TrySearchByte(this Utf8String src, Func<byte, bool> pred, out int pos); // 0x0000000180BCC5C0-0x0000000180BCC690
		public static bool TrySearchAscii(this Utf8String src, byte target, int start, out int pos); // 0x0000000180BCC310-0x0000000180BCC5C0
		[IteratorStateMachine] // 0x0000000180026EA0-0x0000000180026F10
		public static IEnumerable<Utf8String> Split(this Utf8String src, byte delimiter); // 0x0000000180BCAFF0-0x0000000180BCB070
		public static sbyte ToSByte(this Utf8String src); // 0x0000000180BCB9F0-0x0000000180BCBC20
		public static short ToInt16(this Utf8String src); // 0x0000000180BCB340-0x0000000180BCB590
		public static int ToInt32(this Utf8String src); // 0x0000000180BCB590-0x0000000180BCB7D0
		public static long ToInt64(this Utf8String src); // 0x0000000180BCB7D0-0x0000000180BCB9F0
		public static byte ToByte(this Utf8String src); // 0x0000000180BCB070-0x0000000180BCB2A0
		public static ushort ToUInt16(this Utf8String src); // 0x0000000180BCBC90-0x0000000180BCBEE0
		public static uint ToUInt32(this Utf8String src); // 0x0000000180BCBEE0-0x0000000180BCC0F0
		public static ulong ToUInt64(this Utf8String src); // 0x0000000180BCC0F0-0x0000000180BCC310
		public static float ToSingle(this Utf8String src); // 0x0000000180BCBC20-0x0000000180BCBC90
		public static double ToDouble(this Utf8String src); // 0x0000000180BCB2A0-0x0000000180BCB340
		public static Utf8String GetLine(this Utf8String src); // 0x0000000180BCAEF0-0x0000000180BCAFF0
	}
}
