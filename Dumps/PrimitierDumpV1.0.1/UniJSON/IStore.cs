/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniJSON
{
	public interface IStore // TypeDefIndex: 5592
	{
		// Properties
		ArraySegment<byte> Bytes { get; }
	
		// Methods
		void Clear();
		void Write(byte value);
		void Write(sbyte value);
		void WriteBigEndian(ushort value);
		void WriteBigEndian(uint value);
		void WriteBigEndian(ulong value);
		void WriteBigEndian(short value);
		void WriteBigEndian(int value);
		void WriteBigEndian(long value);
		void WriteBigEndian(float value);
		void WriteBigEndian(double value);
		void WriteLittleEndian(ushort value);
		void WriteLittleEndian(uint value);
		void WriteLittleEndian(ulong value);
		void WriteLittleEndian(short value);
		void WriteLittleEndian(int value);
		void WriteLittleEndian(long value);
		void WriteLittleEndian(float value);
		void WriteLittleEndian(double value);
		void Write(ArraySegment<byte> bytes);
		void Write(string src);
		void Write(char c);
	}
}
