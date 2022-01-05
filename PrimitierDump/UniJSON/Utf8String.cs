/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public struct Utf8String : IComparable<UniJSON.Utf8String> // TypeDefIndex: 5630
	{
		// Fields
		public static readonly Encoding Encoding; // 0x00
		public readonly ArraySegment<byte> Bytes; // 0x00
	
		// Properties
		public int ByteLength { get; } // 0x0000000180BCEA20-0x0000000180BCEA60 
		public byte this[int i] { get => default; } // 0x0000000180BCEB40-0x0000000180BCEBC0 
		public bool IsEmpty { get; } // 0x0000000180BCEA60-0x0000000180BCEAB0 
		public bool IsInt { get; } // 0x0000000180BCEAB0-0x0000000180BCEB40 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5629
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<char, int> __9__12_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E7150-0x00000001806E71B0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal int _From_b__12_0(char c); // 0x00000001806E4F00-0x00000001806E4F10
		}
	
		// Constructors
		public Utf8String(ArraySegment<byte> bytes); // 0x0000000180461FC0-0x0000000180461FD0
		public Utf8String(byte[] bytes, int offset, int count); // 0x0000000180BCE960-0x0000000180BCE9F0
		public Utf8String(byte[] bytes); // 0x0000000180BCE9F0-0x0000000180BCEA20
		static Utf8String(); // 0x0000000180BCE8F0-0x0000000180BCE960
	
		// Methods
		public Utf8Iterator GetIterator(); // 0x0000000180BCE030-0x0000000180BCE0B0
		public int CompareTo(Utf8String other); // 0x0000000180BCC920-0x0000000180BCCA70
		public static Utf8String From(string src); // 0x0000000180BCDF30-0x0000000180BCDFE0
		public static Utf8String From(string src, byte[] bytes); // 0x0000000180BCDC20-0x0000000180BCDF30
		public static Utf8String From(int src); // 0x0000000180BCCF60-0x0000000180BCDC20
		public Utf8String Concat(Utf8String rhs); // 0x0000000180BCCA70-0x0000000180BCCC60
		public override string ToString(); // 0x0000000180BCE550-0x0000000180BCE660
		public string ToAscii(); // 0x0000000180BCE470-0x0000000180BCE550
		public bool StartsWith(Utf8String rhs); // 0x0000000180BCE1D0-0x0000000180BCE2E0
		public bool EndsWith(Utf8String rhs); // 0x0000000180BCCC60-0x0000000180BCCDC0
		public int IndexOf(byte code); // 0x0000000180BCE0B0-0x0000000180BCE0C0
		public int IndexOf(int offset, byte code); // 0x0000000180BCE0C0-0x0000000180BCE1B0
		public Utf8String Subbytes(int offset); // 0x0000000180BCE2E0-0x0000000180BCE3E0
		public Utf8String Subbytes(int offset, int count); // 0x0000000180BCE3E0-0x0000000180BCE470
		private static bool IsSpace(byte b); // 0x0000000180BCE1B0-0x0000000180BCE1D0
		public Utf8String TrimStart(); // 0x0000000180BCE7C0-0x0000000180BCE8B0
		public Utf8String TrimEnd(); // 0x0000000180BCE660-0x0000000180BCE7C0
		public Utf8String Trim(); // 0x0000000180BCE8B0-0x0000000180BCE8F0
		public override bool Equals(object obj); // 0x0000000180BCCEC0-0x0000000180BCCF60
		public static bool operator ==(Utf8String x, Utf8String y); // 0x0000000180BCEC20-0x0000000180BCEC40
		public static bool operator !=(Utf8String x, Utf8String y); // 0x0000000180BCEC40-0x0000000180BCECC0
		public bool Equals(Utf8String other); // 0x0000000180BCCDC0-0x0000000180BCCEC0
		public override int GetHashCode(); // 0x0000000180BCDFE0-0x0000000180BCE030
		public static Utf8String operator +(Utf8String l, Utf8String r); // 0x0000000180BCEBC0-0x0000000180BCEC20
	}
}
