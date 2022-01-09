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
	public interface IAwaitCaller // TypeDefIndex: 5804
	{
		// Methods
		Task NextFrame();
		Task Run(System.Action action);
		Task<T> Run<T>(Func<T> action);
	}
}
