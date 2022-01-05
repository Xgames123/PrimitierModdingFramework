/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class TaskCaller : IAwaitCaller // TypeDefIndex: 5807
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5806
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static System.Action __9__0_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001806E6BB0-0x00000001806E6C10
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _NextFrame_b__0_0(); // 0x0000000180265310-0x0000000180265320
		}
	
		// Constructors
		public TaskCaller(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public Task NextFrame(); // 0x0000000180BC3010-0x0000000180BC3120
		public Task Run(System.Action action); // 0x0000000180BC3120-0x0000000180BC3180
		public Task<T> Run<T>(Func<T> action);
	}
}
