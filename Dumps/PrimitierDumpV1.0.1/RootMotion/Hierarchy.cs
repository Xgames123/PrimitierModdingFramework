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
	public class Hierarchy // TypeDefIndex: 8284
	{
		// Constructors
		public Hierarchy(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones); // 0x0000000180865B30-0x0000000180865BD0
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects); // 0x00000001808653B0-0x00000001808654E0
		public static bool IsAncestor(Transform transform, Transform ancestor); // 0x0000000180865BD0-0x0000000180865D40
		public static bool ContainsChild(Transform transform, Transform child); // 0x00000001808652A0-0x00000001808653B0
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array); // 0x0000000180865020-0x00000001808652A0
		public static Transform GetAncestor(Transform transform, int minChildCount); // 0x00000001808654E0-0x0000000180865600
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2); // 0x00000001808657D0-0x0000000180865960
		public static Transform GetFirstCommonAncestor(Transform[] transforms); // 0x0000000180865960-0x0000000180865B30
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms); // 0x0000000180865600-0x00000001808657D0
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms); // 0x0000000180865D40-0x0000000180865F90
	}
}
