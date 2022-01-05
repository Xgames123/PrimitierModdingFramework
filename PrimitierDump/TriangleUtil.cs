/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

public static class TriangleUtil // TypeDefIndex: 5570
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class __c // TypeDefIndex: 5568
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Func<byte, int> __9__0_0; // 0x08
		public static Func<ushort, int> __9__1_0; // 0x10
		public static Func<uint, int> __9__2_0; // 0x18

		// Constructors
		static __c(); // 0x00000001806E6F10-0x00000001806E6F70
		public __c(); // 0x00000001802650F0-0x0000000180265100

		// Methods
		internal int _FlipTriangle_b__0_0(byte x); // 0x00000001806E4EE0-0x00000001806E4EF0
		internal int _FlipTriangle_b__1_0(ushort x); // 0x00000001806E4EF0-0x00000001806E4F00
		internal int _FlipTriangle_b__2_0(uint x); // 0x0000000180333550-0x0000000180333560
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class _FlipTriangle_d__3 : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 5569
	{
		// Fields
		private int __1__state; // 0x10
		private int __2__current; // 0x14
		private int __l__initialThreadId; // 0x18
		private IEnumerable<int> src; // 0x20
		public IEnumerable<int> __3__src; // 0x28
		private IEnumerator<int> _it_5__2; // 0x30
		private int _i0_5__3; // 0x38
		private int _i1_5__4; // 0x3C

		// Properties
		int IEnumerator<System.Int32>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802A6C70-0x00000001802A6C80 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806DF730-0x00000001806DF780 

		// Constructors
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		public _FlipTriangle_d__3(int __1__state); // 0x00000001806DE540-0x00000001806DE570

		// Methods
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
		private bool MoveNext(); // 0x00000001806DF4D0-0x00000001806DF650
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		void IEnumerator.Reset(); // 0x00000001806DF6F0-0x00000001806DF730
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x00000001806DF650-0x00000001806DF6F0
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806DF650-0x00000001806DF6F0
	}

	// Methods
	public static IEnumerable<int> FlipTriangle(IEnumerable<byte> src); // 0x0000000180BC3460-0x0000000180BC35D0
	public static IEnumerable<int> FlipTriangle(IEnumerable<ushort> src); // 0x0000000180BC3740-0x0000000180BC38B0
	public static IEnumerable<int> FlipTriangle(IEnumerable<uint> src); // 0x0000000180BC35D0-0x0000000180BC3740
	[IteratorStateMachine] // 0x0000000180026B00-0x0000000180026B50
	public static IEnumerable<int> FlipTriangle(IEnumerable<int> src); // 0x0000000180BC33F0-0x0000000180BC3460
}

