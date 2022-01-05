/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class FastAction<A, B> // TypeDefIndex: 6072
	{
		// Fields
		private LinkedList<Action<A, B>> delegates;
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A, B> rhs);
		public void Remove(Action<A, B> rhs);
		public void Call(A a, B b);
	}
}
