/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	public struct UnityPath // TypeDefIndex: 5690
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _Value_k__BackingField; // 0x00
		private static readonly char[] EscapeChars; // 0x00
		private static string s_basePath; // 0x08
	
		// Properties
		public string Value { [IsReadOnly] /* 0x0000000180016550-0x0000000180016580 */ [CompilerGenerated] /* 0x0000000180016550-0x0000000180016580 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802B6C10-0x00000001802B6C20 0x00000001802D7C80-0x00000001802D7C90
		public bool IsNull { get; } // 0x00000001806254B0-0x00000001806254C0 
		public bool IsUnderAssetsFolder { get; } // 0x0000000180BC95D0-0x0000000180BC9650 
		public bool IsStreamingAsset { get; } // 0x0000000180BC94B0-0x0000000180BC9530 
		public string FileName { get; } // 0x0000000180BC90C0-0x0000000180BC9120 
		public string FileNameWithoutExtension { get; } // 0x0000000180BC9000-0x0000000180BC9060 
		public string Extension { get; } // 0x0000000180BC8F40-0x0000000180BC8FA0 
		public UnityPath Parent { get; } // 0x0000000180BC9710-0x0000000180BC97D0 
		public bool HasParent { get; } // 0x0000000180BC9360-0x0000000180BC9380 
		private static string BaseFullPath { get; } // 0x0000000180BC8BA0-0x0000000180BC8D20 
		private static string AssetFullPath { get; } // 0x0000000180BC8940-0x0000000180BC89B0 
		public string FullPath { get; } // 0x0000000180BC9240-0x0000000180BC9360 
		public bool IsFileExists { get; } // 0x0000000180BC93C0-0x0000000180BC93E0 
		public bool IsDirectoryExists { get; } // 0x0000000180BC9380-0x0000000180BC93A0 
		public IEnumerable<UnityPath> ChildDirs { [IteratorStateMachine] /* 0x00000001800273C0-0x0000000180027410 */ get; } // 0x0000000180BC8D20-0x0000000180BC8D90 
		public IEnumerable<UnityPath> ChildFiles { [IteratorStateMachine] /* 0x0000000180027410-0x0000000180027460 */ get; } // 0x0000000180BC8E00-0x0000000180BC8E70 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TraverseDir_d__43 : IEnumerable<UnityPath>, IEnumerator<UnityPath> // TypeDefIndex: 5687
		{
			// Fields
			private int __1__state; // 0x10
			private UnityPath __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public UnityPath __4__this; // 0x28
			public UnityPath __3____4__this; // 0x30
			private IEnumerator<UnityPath> __7__wrap1; // 0x38
			private IEnumerator<UnityPath> __7__wrap2; // 0x40
	
			// Properties
			UnityPath IEnumerator<MeshUtility.UnityPath>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E2B80-0x00000001806E2BD0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TraverseDir_d__43(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E2C20-0x00000001806E2D00
			private bool MoveNext(); // 0x00000001806E2500-0x00000001806E2760
			private void __m__Finally1(); // 0x00000001806E2DE0-0x00000001806E2E30
			private void __m__Finally2(); // 0x00000001806E2E80-0x00000001806E2ED0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E2B00-0x00000001806E2B40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<UnityPath> IEnumerable<UnityPath>.GetEnumerator(); // 0x00000001806E29C0-0x00000001806E2A60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E29C0-0x00000001806E2A60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_ChildDirs_d__45 : IEnumerable<UnityPath>, IEnumerator<UnityPath> // TypeDefIndex: 5688
		{
			// Fields
			private int __1__state; // 0x10
			private UnityPath __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public UnityPath __4__this; // 0x28
			public UnityPath __3____4__this; // 0x30
			private string[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			UnityPath IEnumerator<MeshUtility.UnityPath>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E7680-0x00000001806E76D0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_ChildDirs_d__45(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E7270-0x00000001806E7370
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E75F0-0x00000001806E7630
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<UnityPath> IEnumerable<UnityPath>.GetEnumerator(); // 0x00000001806E7470-0x00000001806E7510
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E7470-0x00000001806E7510
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_ChildFiles_d__47 : IEnumerable<UnityPath>, IEnumerator<UnityPath> // TypeDefIndex: 5689
		{
			// Fields
			private int __1__state; // 0x10
			private UnityPath __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public UnityPath __4__this; // 0x28
			public UnityPath __3____4__this; // 0x30
			private string[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			UnityPath IEnumerator<MeshUtility.UnityPath>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E7A90-0x00000001806E7AE0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_ChildFiles_d__47(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E76D0-0x00000001806E77D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E7A50-0x00000001806E7A90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<UnityPath> IEnumerable<UnityPath>.GetEnumerator(); // 0x00000001806E78D0-0x00000001806E7970
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E78D0-0x00000001806E7970
		}
	
		// Constructors
		private UnityPath(string value); // 0x0000000180BC88D0-0x0000000180BC8940
		static UnityPath(); // 0x0000000180BC87E0-0x0000000180BC8860
	
		// Methods
		public override string ToString(); // 0x0000000180BC8600-0x0000000180BC8640
		private static string EscapeFilePath(string path); // 0x0000000180BC7A60-0x0000000180BC7B30
		public UnityPath Child(string name); // 0x0000000180BC7800-0x0000000180BC7900
		public override int GetHashCode(); // 0x0000000180BC8390-0x0000000180BC83B0
		public override bool Equals(object obj); // 0x0000000180BC7900-0x0000000180BC79B0
		public UnityPath GetAssetFolder(string suffix); // 0x0000000180BC8240-0x0000000180BC8390
		public static UnityPath FromUnityPath(string unityPath); // 0x0000000180BC8040-0x0000000180BC80F0
		public static UnityPath FromFullpath(string fullPath); // 0x0000000180BC7C00-0x0000000180BC7DB0
		public static bool IsUnderAssetFolder(string fullPath); // 0x0000000180BC84F0-0x0000000180BC8600
		[Obsolete] // 0x0000000180027340-0x0000000180027370
		public IEnumerable<UnityPath> TravserseDir(); // 0x0000000180BC86F0-0x0000000180BC8760
		[IteratorStateMachine] // 0x0000000180027370-0x00000001800273C0
		public IEnumerable<UnityPath> TraverseDir(); // 0x0000000180BC86F0-0x0000000180BC8760
	}
}
