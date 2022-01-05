/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class BvhNode // TypeDefIndex: 5950
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Single3 _Offset_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Channel[] _Channels_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<BvhNode> _Children_k__BackingField; // 0x30
	
		// Properties
		public string Name { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public Single3 Offset { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001807203F0-0x0000000180720410 0x0000000180720410-0x0000000180720420
		public Channel[] Channels { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public List<BvhNode> Children { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5948
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool> __9__18_0; // 0x08
			public static Func<string, float> __9__18_1; // 0x10
			public static Func<string, Channel> __9__19_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001812BDC30-0x00000001812BDC90
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _ParseOffset_b__18_0(string x); // 0x0000000180D56950-0x0000000180D56970
			internal float _ParseOffset_b__18_1(string x); // 0x00000001812BD510-0x00000001812BD570
			internal Channel _ParseChannel_b__19_0(string x); // 0x00000001812BD420-0x00000001812BD510
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Traverse_d__20 : IEnumerable<BvhNode>, IEnumerator<BvhNode> // TypeDefIndex: 5949
		{
			// Fields
			private int __1__state; // 0x10
			private BvhNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public BvhNode __4__this; // 0x28
			private List<BvhNode> __7__wrap1; // 0x30
			private IEnumerator<BvhNode> __7__wrap2; // 0x48
	
			// Properties
			BvhNode IEnumerator<UniHumanoid.BvhNode>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Traverse_d__20(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001812BC890-0x00000001812BC970
			private bool MoveNext(); // 0x00000001812BC560-0x00000001812BC7B0
			private void __m__Finally1(); // 0x00000001812BC970-0x00000001812BC9C0
			private void __m__Finally2(); // 0x00000001812BC9C0-0x00000001812BCA10
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001812BC850-0x00000001812BC890
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<BvhNode> IEnumerable<BvhNode>.GetEnumerator(); // 0x00000001812BC7B0-0x00000001812BC850
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812BC7B0-0x00000001812BC850
		}
	
		// Constructors
		public BvhNode(string name); // 0x00000001812AF180-0x00000001812AF200
	
		// Methods
		public virtual void Parse(StringReader r); // 0x00000001812AF090-0x00000001812AF110
		private static Single3 ParseOffset(string line); // 0x00000001812AED00-0x00000001812AF090
		private static Channel[] ParseChannel(string line); // 0x00000001812AEA40-0x00000001812AED00
		[IteratorStateMachine] // 0x000000018004DF40-0x000000018004DF90
		public IEnumerable<BvhNode> Traverse(); // 0x00000001812AF110-0x00000001812AF180
	}
}
