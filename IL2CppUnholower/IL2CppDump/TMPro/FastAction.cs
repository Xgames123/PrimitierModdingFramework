/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241
[assembly: CompilationRelaxations] // 0x000000018003BC60-0x000000018003BD10
[assembly: Debuggable] // 0x000000018003BC60-0x000000018003BD10
[assembly: InternalsVisibleTo] // 0x000000018003BC60-0x000000018003BD10
[assembly: InternalsVisibleTo] // 0x000000018003BC60-0x000000018003BD10
[assembly: RuntimeCompatibility] // 0x000000018003BC60-0x000000018003BD10

namespace TMPro
{
	public class FastAction // TypeDefIndex: 6070
	{
		// Fields
		private LinkedList<System.Action> delegates; // 0x10
		private Dictionary<System.Action, LinkedListNode<System.Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x000000018036BFC0-0x000000018036C070
	
		// Methods
		public void Add(System.Action rhs); // 0x000000018036BDB0-0x000000018036BE70
		public void Remove(System.Action rhs); // 0x000000018036BF00-0x000000018036BFC0
		public void Call(); // 0x000000018036BE70-0x000000018036BF00
	}
}
