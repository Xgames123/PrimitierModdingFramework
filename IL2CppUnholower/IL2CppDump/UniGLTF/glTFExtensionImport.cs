/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class glTFExtensionImport : glTFExtension // TypeDefIndex: 5717
	{
		// Fields
		private readonly JsonNode m_json; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _ObjectItems_d__3 : IEnumerable<KeyValuePair<JsonNode, JsonNode>>, IEnumerator<KeyValuePair<JsonNode, JsonNode>> // TypeDefIndex: 5716
		{
			// Fields
			private int __1__state; // 0x10
			private KeyValuePair<JsonNode, JsonNode> __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public glTFExtensionImport __4__this; // 0x40
			private IEnumerator<KeyValuePair<JsonNode, JsonNode>> __7__wrap1; // 0x48
	
			// Properties
			KeyValuePair<JsonNode, JsonNode> IEnumerator<System.Collections.Generic.KeyValuePair<UniJSON.JsonNode,UniJSON.JsonNode>>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x000000018054BFE0-0x000000018054C000 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001806E1D10-0x00000001806E1D60 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _ObjectItems_d__3(int __1__state); // 0x000000018054C170-0x000000018054C1A0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x00000001806E1D60-0x00000001806E1DF0
			private bool MoveNext(); // 0x00000001806E1A20-0x00000001806E1C30
			private void __m__Finally1(); // 0x00000001806E1DF0-0x00000001806E1E40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E1CD0-0x00000001806E1D10
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<KeyValuePair<JsonNode, JsonNode>> IEnumerable<KeyValuePair<JsonNode, JsonNode>>.GetEnumerator(); // 0x00000001806E1C30-0x00000001806E1CD0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E1C30-0x00000001806E1CD0
		}
	
		// Constructors
		public glTFExtensionImport(JsonNode json); // 0x0000000180D5D2C0-0x0000000180D5D330
	
		// Methods
		public override string ToString(); // 0x0000000180D5D1C0-0x0000000180D5D2C0
		[IteratorStateMachine] // 0x00000001800276D0-0x0000000180027720
		public IEnumerable<KeyValuePair<JsonNode, JsonNode>> ObjectItems(); // 0x0000000180D5D0C0-0x0000000180D5D130
		public override void Serialize(JsonFormatter f); // 0x0000000180D5D130-0x0000000180D5D1C0
	}
}
