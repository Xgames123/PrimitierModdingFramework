/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public sealed class RootAnimationImporter : IAnimationImporter // TypeDefIndex: 5872
	{
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ImportAnimationClips_d__1 : IEnumerable<AnimationClip>, IEnumerator<AnimationClip> // TypeDefIndex: 5871
		{
			// Fields
			private int __1__state; // 0x10
			private AnimationClip __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private glTF gltf; // 0x28
			public glTF __3__gltf; // 0x30
			private Axises invertAxis; // 0x38
			public Axises __3__invertAxis; // 0x3C
			private int _i_5__2; // 0x40
	
			// Properties
			AnimationClip IEnumerator<UnityEngine.AnimationClip>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ImportAnimationClips_d__1(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E16C0-0x00000001806E1940
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E19E0-0x00000001806E1A20
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<AnimationClip> IEnumerable<AnimationClip>.GetEnumerator(); // 0x00000001806E1940-0x00000001806E19E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E1940-0x00000001806E19E0
		}
	
		// Constructors
		public RootAnimationImporter(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public List<AnimationClip> Import(glTF gltf, GameObject root, List<Transform> _nodes, List<AnimationClip> _clips, Axises invertAxis); // 0x0000000180BC0E50-0x0000000180BC1120
		[IteratorStateMachine] // 0x00000001800296D0-0x0000000180029720
		private IEnumerable<AnimationClip> ImportAnimationClips(glTF gltf, Axises invertAxis); // 0x0000000180BC0DD0-0x0000000180BC0E50
	}
}
