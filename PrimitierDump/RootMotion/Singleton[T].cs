/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 8291
		where T : Singleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static T instance { get; }
	
		// Constructors
		protected Singleton();
		static Singleton();
	
		// Methods
		protected virtual void Awake();
	}
}
