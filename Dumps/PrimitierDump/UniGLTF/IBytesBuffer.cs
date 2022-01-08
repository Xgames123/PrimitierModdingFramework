/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public interface IBytesBuffer // TypeDefIndex: 5722
	{
		// Properties
		string Uri { get; }
		ArraySegment<byte> Bytes { get; }
	
		// Methods
		glTFBufferView Extend<T>(ArraySegment<T> array, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A1A07 */)
			where T : struct;
		void ExtendCapacity(int capacity);
	}
}
