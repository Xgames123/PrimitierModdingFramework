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
	[DisallowMultipleComponent] // 0x0000000180014D50-0x0000000180014D60
	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 6170
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoSpriteAnimationInternal_d__7 : IEnumerator<object> // TypeDefIndex: 6169
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_SpriteAnimator __4__this; // 0x20
			public int start; // 0x28
			public int end; // 0x2C
			public TMP_SpriteAsset spriteAsset; // 0x30
			public int currentCharacter; // 0x38
			public int framerate; // 0x3C
			private int _currentFrame_5__2; // 0x40
			private TMP_CharacterInfo _charInfo_5__3; // 0x48
			private int _materialIndex_5__4; // 0x1C0
			private int _vertexIndex_5__5; // 0x1C4
			private TMP_MeshInfo _meshInfo_5__6; // 0x1C8
			private float _baseSpriteScale_5__7; // 0x218
			private float _elapsedTime_5__8; // 0x21C
			private float _targetTime_5__9; // 0x220
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoSpriteAnimationInternal_d__7(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180883C60-0x00000001808848B0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001808848B0-0x00000001808848F0
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x00000001802662A0-0x0000000180266310
	
		// Methods
		private void Awake(); // 0x0000000180266050-0x0000000180266090
		private void OnEnable(); // 0x0000000180265310-0x0000000180265320
		private void OnDisable(); // 0x0000000180265310-0x0000000180265320
		public void StopAllAnimations(); // 0x0000000180266250-0x00000001802662A0
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x0000000180266140-0x0000000180266250
		[IteratorStateMachine] // 0x000000018003C110-0x000000018003C160
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x0000000180266090-0x0000000180266140
	}
}
