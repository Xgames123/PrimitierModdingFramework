/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 28: Unity.ResourceManager.dll - Assembly: Unity.ResourceManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4897-4994

internal class ListWithEvents<T> : IList<T> // TypeDefIndex: 4901
{
	// Fields
	private List<T> m_List;
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private Action<T> OnElementAdded;
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private Action<T> OnElementRemoved;

	// Properties
	public T this[int index] { get => default; set {} }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Events
	public event Action<T> OnElementAdded {
		add; // 0x00000000-0x00000000
		remove; // 0x00000000-0x00000000
	}
	public event Action<T> OnElementRemoved {
		add; // 0x00000000-0x00000000
		remove; // 0x00000000-0x00000000
	}

	// Constructors
	public ListWithEvents();

	// Methods
	private void InvokeAdded(T element);
	private void InvokeRemoved(T element);
	public void Add(T item);
	public void Clear();
	public bool Contains(T item);
	public void CopyTo(T[] array, int arrayIndex);
	public IEnumerator<T> GetEnumerator();
	public int IndexOf(T item);
	public void Insert(int index, T item);
	public bool Remove(T item);
	public void RemoveAt(int index);
	IEnumerator IEnumerable.GetEnumerator();
}

