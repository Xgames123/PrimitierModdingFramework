/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 28: Unity.ResourceManager.dll - Assembly: Unity.ResourceManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4897-4994

internal class DelegateList<T> // TypeDefIndex: 4900
{
	// Fields
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc;
	private Action<LinkedListNode<Action<T>>> m_releaseFunc;
	private LinkedList<Action<T>> m_callbacks;
	private bool m_invoking;

	// Properties
	public int Count { get; }

	// Constructors
	public DelegateList(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc);

	// Methods
	public void Add(Action<T> action);
	public void Remove(Action<T> action);
	public void Invoke(T res);
	public void Clear();
	public static DelegateList<T> CreateWithGlobalCache();
}

