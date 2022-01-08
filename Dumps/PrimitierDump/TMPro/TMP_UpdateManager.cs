/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	public class TMP_UpdateManager // TypeDefIndex: 6209
	{
		// Fields
		private static TMP_UpdateManager s_Instance; // 0x00
		private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
		private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
		private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
		private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
		private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
		private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
		private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
		private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
		private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x08
		private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
		private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
		private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
		private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28
	
		// Properties
		private static TMP_UpdateManager instance { get; } // 0x00000001803AAEB0-0x00000001803AB140 
	
		// Constructors
		private TMP_UpdateManager(); // 0x00000001803AACF0-0x00000001803AAEB0
		static TMP_UpdateManager(); // 0x00000001803AABA0-0x00000001803AACF0
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803AA8A0-0x00000001803AA9B0
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803AA2C0-0x00000001803AA380
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803AA790-0x00000001803AA8A0
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803AA200-0x00000001803AA2C0
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803AA680-0x00000001803AA790
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803AA140-0x00000001803AA200
		public static void RegisterTextElementForCullingUpdate(TMP_Text element); // 0x00000001803AA570-0x00000001803AA680
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element); // 0x00000001803AA080-0x00000001803AA140
		private void OnCameraPreCull(); // 0x00000001803AA560-0x00000001803AA570
		private void DoRebuilds(); // 0x00000001803A9DB0-0x00000001803AA080
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803AAB30-0x00000001803AABA0
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x00000001803AA9B0-0x00000001803AAB30
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803AA380-0x00000001803AA420
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803AA420-0x00000001803AA4C0
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803AA4C0-0x00000001803AA560
	}
}
