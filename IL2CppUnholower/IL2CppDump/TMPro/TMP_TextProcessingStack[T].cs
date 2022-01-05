/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[DebuggerDisplay] // 0x000000018003C2B0-0x000000018003C2E0
	public struct TMP_TextProcessingStack<T> // TypeDefIndex: 6204
	{
		// Fields
		public T[] itemStack;
		public int index;
		private T m_DefaultItem;
		private int m_Capacity;
		private int m_RolloverSize;
		private int m_Count;
		private const int k_DefaultCapacity = 4; // Metadata: 0x003A2497
	
		// Properties
		public int Count { get; }
		public T current { get; }
		public int rolloverSize { get; set; }
	
		// Constructors
		public TMP_TextProcessingStack(T[] stack);
		public TMP_TextProcessingStack(int capacity);
		public TMP_TextProcessingStack(int capacity, int rolloverSize);
	
		// Methods
		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item);
		public void Clear();
		public void SetDefault(T item);
		public void Add(T item);
		public T Remove();
		public void Push(T item);
		public T Pop();
		public T Peek();
		public T CurrentItem();
		public T PreviousItem();
	}
}
