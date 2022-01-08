/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class gltfExporter : IDisposable // TypeDefIndex: 5901
	{
		// Fields
		protected glTF glTF; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private GameObject _Copy_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Mesh> _Meshes_k__BackingField; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private Dictionary<Mesh, Dictionary<int, int>> _MeshBlendShapeIndexMap_k__BackingField; // 0x28
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Transform> _Nodes_k__BackingField; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private List<Material> _Materials_k__BackingField; // 0x38
		public TextureExporter TextureManager; // 0x40
		private IAxisInverter m_axisInverter; // 0x48
		private GameObject m_tmpParent; // 0x50
	
		// Properties
		public GameObject Copy { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public List<Mesh> Meshes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public Dictionary<Mesh, Dictionary<int, int>> MeshBlendShapeIndexMap { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
		public List<Transform> Nodes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
		public List<Material> Materials { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		protected virtual IEnumerable<string> ExtensionUsed { [IteratorStateMachine] /* 0x0000000180029940-0x0000000180029FA0 */ get; } // 0x0000000180D64D10-0x0000000180D64D60 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_ExtensionUsed_d__24 : IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 5895
		{
			// Fields
			private int __1__state; // 0x10
			private string __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
	
			// Properties
			string IEnumerator<System.String>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_ExtensionUsed_d__24(int __1__state); // 0x000000018054BC30-0x000000018054BC60
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001806E7B30-0x00000001806E7BD0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x00000001806E7C60-0x00000001806E7CA0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x00000001806E7BD0-0x00000001806E7C60
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001806E7BD0-0x00000001806E7C60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 5896
		{
			// Fields
			public List<Transform> nodes; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal int _ExportNode_b__0(Transform y); // 0x00000001806E5E00-0x00000001806E5E60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 5897
		{
			// Fields
			public IMaterialExporter materialExporter; // 0x10
			public gltfExporter __4__this; // 0x18
			public List<MeshWithRenderer> uniqueUnityMeshes; // 0x20
			public List<MeshWithRenderer> unitySkins; // 0x28
			public Func<Transform, int> __9__9; // 0x30
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal glTFMaterial _Export_b__2(Material x); // 0x00000001806E5E60-0x00000001806E5F40
			internal glTFNode _Export_b__5(Transform x); // 0x00000001806E5F40-0x00000001806E60D0
			internal int _Export_b__8(Transform x); // 0x00000001806E60D0-0x00000001806E6130
			internal int _Export_b__9(Transform y); // 0x00000001806E6130-0x00000001806E6190
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 5898
		{
			// Fields
			public MeshWithRenderer um; // 0x10
	
			// Constructors
			public __c__DisplayClass33_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Export_b__6(MeshWithRenderer x); // 0x00000001806E6190-0x00000001806E61C0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass33_2 // TypeDefIndex: 5899
		{
			// Fields
			public MeshWithRenderer x; // 0x10
			public Func<Transform, bool> __9__10; // 0x30
	
			// Constructors
			public __c__DisplayClass33_2(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _Export_b__10(Transform y); // 0x00000001806E61C0-0x00000001806E6210
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5900
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, IEnumerable<Material>> __9__33_0; // 0x08
			public static Func<Material, bool> __9__33_1; // 0x10
			public static Func<MeshWithRenderer, bool> __9__33_3; // 0x18
			public static Func<MeshWithRenderer, bool> __9__33_4; // 0x20
			public static Func<MeshWithRenderer, SkinnedMeshRenderer> __9__33_7; // 0x28
	
			// Constructors
			static __c(); // 0x00000001806E7090-0x00000001806E70F0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal IEnumerable<Material> _Export_b__33_0(Transform x); // 0x00000001806E4CE0-0x00000001806E4CF0
			internal bool _Export_b__33_1(Material x); // 0x00000001806E4CF0-0x00000001806E4D50
			internal bool _Export_b__33_3(MeshWithRenderer x); // 0x00000001806E4D50-0x00000001806E4DA0
			internal bool _Export_b__33_4(MeshWithRenderer x); // 0x00000001806E4DA0-0x00000001806E4DC0
			internal SkinnedMeshRenderer _Export_b__33_7(MeshWithRenderer y); // 0x00000001806E4DC0-0x00000001806E4E50
		}
	
		// Constructors
		public gltfExporter(glTF gltf, Axises invertAxis = Axises.Z /* Metadata: 0x003A1BFC */); // 0x0000000180D64BC0-0x0000000180D64D10
	
		// Methods
		protected virtual IMaterialExporter CreateMaterialExporter(); // 0x0000000180D62CB0-0x0000000180D62D00
		public virtual void Prepare(GameObject go); // 0x0000000180D648D0-0x0000000180D64AD0
		public void Dispose(); // 0x0000000180D62D00-0x0000000180D62E80
		private static glTFNode ExportNode(Transform x, List<Transform> nodes, List<MeshWithRenderer> meshWithRenderers, List<SkinnedMeshRenderer> skins); // 0x0000000180D62E80-0x0000000180D63360
		private static bool TryGetSameMeshIndex(List<MeshWithRenderer> meshWithRenderers, Mesh mesh, Material[] materials, out int meshIndex); // 0x0000000180D64AD0-0x0000000180D64BC0
		public virtual void ExportExtensions(Func<Texture2D, ValueTuple<byte[], string>> getTextureBytes); // 0x0000000180265310-0x0000000180265320
		public virtual void Export(MeshExportSettings meshExportSettings, Func<Texture, bool> useAsset, Func<Texture2D, ValueTuple<byte[], string>> getTextureBytes); // 0x0000000180D63360-0x0000000180D648D0
	}
}
