/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	internal class TweenRunner<T> // TypeDefIndex: 6095
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 6094
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T tweenInfo;
			private float _elapsedTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Start_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine] // 0x000000018003BD40-0x000000018003BD90
		private static IEnumerator Start(T tweenInfo);
		public void Init(MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}
}
