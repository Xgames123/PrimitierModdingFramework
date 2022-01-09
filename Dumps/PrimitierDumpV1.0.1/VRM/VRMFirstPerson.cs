/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMFirstPerson : MonoBehaviour // TypeDefIndex: 8018
	{
		// Fields
		public static bool TriedSetupLayer; // 0x00
		public static int FIRSTPERSON_ONLY_LAYER; // 0x04
		public static int THIRDPERSON_ONLY_LAYER; // 0x08
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Transform FirstPersonBone; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Vector3 FirstPersonOffset; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public List<RendererFirstPersonFlags> Renderers; // 0x30
		private bool m_done; // 0x38
		private List<Mesh> m_headlessMeshes; // 0x40
	
		// Nested types
		[Serializable]
		public struct RendererFirstPersonFlags // TypeDefIndex: 8010
		{
			// Fields
			public Renderer Renderer; // 0x00
			public FirstPersonFlag FirstPersonFlag; // 0x08
	
			// Properties
			public Mesh SharedMesh { get; } // 0x000000018054A0B0-0x000000018054A1F0 
		}
	
		public delegate void SetVisibilityFunc(Renderer renderer, bool firstPerson, bool thirdPerson); // TypeDefIndex: 8011; 0x000000018054A290-0x000000018054A510
	
		[Obsolete] // 0x0000000180035620-0x0000000180035650
		public delegate void SetVisiblityFunc(Renderer renderer, bool firstPerson, bool thirdPerson); // TypeDefIndex: 8012; 0x000000018054A290-0x000000018054A510
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 8013
		{
			// Fields
			public Dictionary<Transform, Transform> map; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal RendererFirstPersonFlags _CopyTo_b__0(RendererFirstPersonFlags x); // 0x0000000180550380-0x0000000180550440
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 8014
		{
			// Fields
			public Mesh mesh; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _GetFirstPersonFlag_b__0(UniGLTF.MeshWithMaterials x); // 0x000000018054E750-0x000000018054E7D0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 8015
		{
			// Fields
			public Transform eraseRoot; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CreateHeadlessModelForMeshRenderer_b__0(Transform x); // 0x000000018054E7D0-0x000000018054E840
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 8016
		{
			// Fields
			public Transform eraseRoot; // 0x10
			public Func<Transform, bool> __9__3; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal __f__AnonymousType0<int, bool> _CreateHeadlessModelForSkinnedMeshRenderer_b__0(Transform x, int i); // 0x000000018054E840-0x000000018054E950
			internal bool _CreateHeadlessModelForSkinnedMeshRenderer_b__3(Transform y); // 0x000000018054E950-0x000000018054E9C0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8017
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<__f__AnonymousType0<int, bool>, bool> __9__15_1; // 0x08
			public static Func<__f__AnonymousType0<int, bool>, int> __9__15_2; // 0x10
	
			// Constructors
			static __c(); // 0x0000000180550500-0x0000000180550560
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _CreateHeadlessModelForSkinnedMeshRenderer_b__15_1(__f__AnonymousType0<int, bool> x); // 0x000000018054D720-0x000000018054D760
			internal int _CreateHeadlessModelForSkinnedMeshRenderer_b__15_2(__f__AnonymousType0<int, bool> x); // 0x000000018054D760-0x000000018054D7A0
		}
	
		// Constructors
		public VRMFirstPerson(); // 0x0000000180343F30-0x0000000180343FE0
		static VRMFirstPerson(); // 0x0000000180343ED0-0x0000000180343F30
	
		// Methods
		public void CopyTo(GameObject _dst, Dictionary<Transform, Transform> map); // 0x0000000180342470-0x00000001803425E0
		public void SetDefault(); // 0x00000001803433D0-0x00000001803434A0
		public void Reset(); // 0x00000001803433A0-0x00000001803433D0
		public void TraverseRenderers(VRMImporterContext context = null); // 0x0000000180343D50-0x0000000180343ED0
		private static FirstPersonFlag GetFirstPersonFlag(VRMImporterContext context, Renderer r); // 0x0000000180342EE0-0x00000001803431F0
		private Mesh CreateHeadlessModel(Renderer _renderer, Transform EraseRoot, SetVisibilityFunc setVisibility); // 0x0000000180342C20-0x0000000180342EE0
		public static void SetupLayers(); // 0x00000001803437C0-0x0000000180343940
		private static void CreateHeadlessModelForMeshRenderer(MeshRenderer renderer, Transform eraseRoot, SetVisibilityFunc setVisibility); // 0x00000001803425E0-0x0000000180342720
		private static Mesh CreateHeadlessModelForSkinnedMeshRenderer(SkinnedMeshRenderer renderer, Transform eraseRoot, SetVisibilityFunc setVisibility); // 0x0000000180342720-0x0000000180342C20
		public static void SetVisibility(Renderer renderer, bool firstPerson, bool thirdPerson); // 0x00000001803434A0-0x0000000180343740
		[Obsolete] // 0x00000001800355F0-0x0000000180035620
		public static void SetVisiblity(Renderer renderer, bool firstPerson, bool thirdPerson); // 0x0000000180343740-0x00000001803437C0
		public void Setup(); // 0x0000000180343940-0x00000001803439C0
		public void Setup(bool isSelf, SetVisibilityFunc setVisibility); // 0x00000001803439C0-0x0000000180343D50
		private void OnDestroy(); // 0x00000001803431F0-0x00000001803433A0
	}
}
