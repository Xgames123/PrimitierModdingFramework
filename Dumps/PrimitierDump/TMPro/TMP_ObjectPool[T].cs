/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	internal class TMP_ObjectPool<T> // TypeDefIndex: 6157
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private int _countAll_k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Constructors
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease);
	
		// Methods
		public T Get();
		public void Release(T element);
	}
}
