/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class TMP_UpdateRegistry // TypeDefIndex: 6210
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private HashSet<int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private HashSet<int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x00000001803ABF60-0x00000001803AC100 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x00000001803ABE30-0x00000001803ABF60
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803ABAA0-0x00000001803ABBF0
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803AB290-0x00000001803AB3E0
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803AB950-0x00000001803ABAA0
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803AB140-0x00000001803AB290
		private void PerformUpdateForCanvasRendererObjects(); // 0x00000001803AB620-0x00000001803AB8F0
		private void PerformUpdateForMeshRendererObjects(); // 0x00000001803AB8F0-0x00000001803AB950
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x00000001803ABBF0-0x00000001803ABE30
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803AB500-0x00000001803AB620
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803AB3E0-0x00000001803AB500
	}
}
