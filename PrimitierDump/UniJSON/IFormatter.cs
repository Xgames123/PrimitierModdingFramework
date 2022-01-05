/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public interface IFormatter // TypeDefIndex: 5586
	{
		// Methods
		IStore GetStore();
		void Clear();
		void BeginList(int n);
		void EndList();
		void BeginMap(int n);
		void EndMap();
		void Key(Utf8String x);
		void Null();
		void Value(Utf8String x);
		void Value(string x);
		void Value(ArraySegment<byte> bytes);
		void Value(bool x);
		void Value(byte x);
		void Value(ushort x);
		void Value(uint x);
		void Value(ulong x);
		void Value(sbyte x);
		void Value(short x);
		void Value(int x);
		void Value(long x);
		void Value(float x);
		void Value(double x);
		void Value(DateTimeOffset x);
	}
}
