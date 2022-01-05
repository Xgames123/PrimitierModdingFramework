/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class PreviewSceneManager : MonoBehaviour // TypeDefIndex: 7996
	{
		// Fields
		public GameObject Prefab; // 0x18
		private MeshPreviewItem[] m_meshes; // 0x20
		private MeshPreviewItem[] m_blendShapeMeshes; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string[] _MaterialNames_k__BackingField; // 0x30
		private Dictionary<string, MaterialItem> m_materialMap; // 0x38
		private string[] m_rendererPathList; // 0x40
		private string[] m_skinnedMeshRendererPathList; // 0x48
		public Transform m_target; // 0x50
	
		// Properties
		public IEnumerable<MeshPreviewItem> EnumRenderItems { [IteratorStateMachine] /* 0x00000001800353B0-0x0000000180035400 */ get; } // 0x000000018033E250-0x000000018033E2C0 
		public string[] MaterialNames { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public string[] RendererPathList { get; } // 0x0000000180268310-0x0000000180268320 
		public string[] SkinnedMeshRendererPathList { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public Vector3 TargetPosition { get; } // 0x000000018033E2C0-0x000000018033E3B0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 7993
		{
			// Fields
			public Dictionary<Material, Material> map; // 0x10
			public List<string> materialNames; // 0x18
			public PreviewSceneManager __4__this; // 0x20
			public Func<Material, Material> getOrCreateMaterial; // 0x28
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Material _Initialize_b__0(Material src); // 0x000000018054F4B0-0x000000018054F680
			internal MeshPreviewItem _Initialize_b__1(Transform x); // 0x000000018054F680-0x000000018054F6D0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 7994
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MeshPreviewItem, bool> __9__2_2; // 0x08
			public static Func<MeshPreviewItem, bool> __9__2_3; // 0x10
			public static Func<MeshPreviewItem, string> __9__2_4; // 0x18
			public static Func<MeshPreviewItem, bool> __9__2_5; // 0x20
			public static Func<MeshPreviewItem, string> __9__2_6; // 0x28
	
			// Constructors
			static __c(); // 0x0000000180550740-0x00000001805507A0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Initialize_b__2_2(MeshPreviewItem x); // 0x000000018054DA50-0x000000018054DA60
			internal bool _Initialize_b__2_3(MeshPreviewItem x); // 0x000000018054DA60-0x000000018054DB00
			internal string _Initialize_b__2_4(MeshPreviewItem x); // 0x000000018054DB00-0x000000018054DB20
			internal bool _Initialize_b__2_5(MeshPreviewItem x); // 0x000000018054DB20-0x000000018054DB90
			internal string _Initialize_b__2_6(MeshPreviewItem x); // 0x000000018054DB00-0x000000018054DB20
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_EnumRenderItems_d__6 : IEnumerable<MeshPreviewItem>, IEnumerator<MeshPreviewItem> // TypeDefIndex: 7995
		{
			// Fields
			private int __1__state; // 0x10
			private MeshPreviewItem __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public PreviewSceneManager __4__this; // 0x28
			private MeshPreviewItem[] __7__wrap1; // 0x30
			private int __7__wrap2; // 0x38
	
			// Properties
			MeshPreviewItem IEnumerator<VRM.MeshPreviewItem>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_EnumRenderItems_d__6(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180550E00-0x0000000180550EA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180550F40-0x0000000180550F80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<MeshPreviewItem> IEnumerable<MeshPreviewItem>.GetEnumerator(); // 0x0000000180550EA0-0x0000000180550F40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180550EA0-0x0000000180550F40
		}
	
		// Constructors
		public PreviewSceneManager(); // 0x000000018033E1E0-0x000000018033E250
	
		// Methods
		public void Clean(); // 0x000000018033D530-0x000000018033D6B0
		private void Initialize(GameObject prefab); // 0x000000018033D790-0x000000018033DE90
		public string[] GetBlendShapeNames(int blendShapeMeshIndex); // 0x000000018033D6B0-0x000000018033D710
		public MaterialItem GetMaterialItem(string materialName); // 0x000000018033D710-0x000000018033D790
		public void SetupCamera(Camera camera, Vector3 target, float yaw, float pitch, Vector3 position); // 0x000000018033DE90-0x000000018033E1E0
	}
}
