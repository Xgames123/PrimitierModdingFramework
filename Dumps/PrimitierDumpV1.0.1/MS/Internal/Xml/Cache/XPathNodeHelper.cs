/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1759-2427

namespace MS.Internal.Xml.Cache
{
	internal abstract class XPathNodeHelper // TypeDefIndex: 1783
	{
		// Methods
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x0000000180E8BBB0-0x0000000180E8BC30
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x0000000180E8BAC0-0x0000000180E8BBB0
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180E8BD50-0x0000000180E8BDB0
		public static int GetLocation(XPathNode[] pageNode, int idxNode); // 0x0000000180E8BC30-0x0000000180E8BC80
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd); // 0x0000000180E8BDB0-0x0000000180E8C000
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode); // 0x0000000180E8BC80-0x0000000180E8BD50
	}
}
