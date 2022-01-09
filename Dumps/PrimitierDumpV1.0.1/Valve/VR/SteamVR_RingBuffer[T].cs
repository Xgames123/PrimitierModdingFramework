/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_RingBuffer<T> // TypeDefIndex: 7368
	{
		// Fields
		protected T[] buffer;
		protected int currentIndex;
		protected T lastElement;
		private bool cleared;
	
		// Constructors
		public SteamVR_RingBuffer(int size);
	
		// Methods
		public void Add(T newElement);
		public virtual void StepForward();
		public virtual T GetAtIndex(int atIndex);
		public virtual T GetLast();
		public virtual int GetLastIndex();
		public void Clear();
	}
}
