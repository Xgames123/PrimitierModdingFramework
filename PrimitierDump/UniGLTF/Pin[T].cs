/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class Pin<T> : IDisposable // TypeDefIndex: 5692
		where T : struct
	{
		// Fields
		private GCHandle m_pinnedArray;
		private ArraySegment<T> m_src;
		private bool disposedValue;
	
		// Properties
		public int Length { get; }
		public IntPtr Ptr { get; }
	
		// Constructors
		public Pin(ArraySegment<T> src);
	
		// Methods
		protected virtual void Dispose(bool disposing);
		public void Dispose();
	}
}
