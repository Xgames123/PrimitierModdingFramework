/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using VRMShaders;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public class ImporterContext : IDisposable // TypeDefIndex: 5815
	{
		// Fields
		protected IAnimationImporter m_animationImporter; // 0x10
		private MaterialFactory m_materialFactory; // 0x18
		public readonly GltfMaterialImporter GltfMaterialImporter; // 0x20
		private TextureFactory m_textureFactory; // 0x28
		private GltfParser m_parser; // 0x30
		public Axises InvertAxis; // 0x38
		public static List<string> UnsupportedExtensions; // 0x00
		public GameObject Root; // 0x40
		private bool m_ownRoot; // 0x48
		public List<Transform> Nodes; // 0x50
		public List<MeshWithMaterials> Meshes; // 0x58
		public List<AnimationClip> AnimationClips; // 0x60
	
		// Properties
		public IAnimationImporter AnimationImporter { get; } // 0x0000000180D24B40-0x0000000180D24BA0 
		public MaterialFactory MaterialFactory { get; } // 0x0000000180268C10-0x0000000180268C20 
		public TextureFactory TextureFactory { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public GltfParser Parser { get; } // 0x00000001802684F0-0x0000000180268500 
		public string Json { get; } // 0x00000001802BB450-0x00000001802BB470 
		public glTF GLTF { get; } // 0x0000000180D24BA0-0x0000000180D24BC0 
		public IStorage Storage { get; } // 0x0000000180D24BC0-0x0000000180D24BE0 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _LoadAsync_d__23 : IAsyncStateMachine // TypeDefIndex: 5808
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public IAwaitCaller awaitCaller; // 0x20
			public Func<string, IDisposable> MeasureTime; // 0x28
			public ImporterContext __4__this; // 0x30
			private IDisposable __7__wrap1; // 0x38
			private TaskAwaiter __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x0000000180D53D20-0x0000000180D546B0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _LoadGeometryAsync_d__24 : IAsyncStateMachine // TypeDefIndex: 5809
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public ImporterContext __4__this; // 0x20
			public Func<string, IDisposable> MeasureTime; // 0x28
			public IAwaitCaller awaitCaller; // 0x30
			private IAxisInverter _inverter_5__2; // 0x38
			private MeshImporter _meshImporter_5__3; // 0x40
			private int _i_5__4; // 0x48
			private IDisposable __7__wrap4; // 0x50
			private TaskAwaiter<MeshWithMaterials> __u__1; // 0x58
			private TaskAwaiter __u__2; // 0x60
	
			// Methods
			private void MoveNext(); // 0x0000000180D546B0-0x0000000180D55250
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _LoadMaterialsAsync_d__25 : IAsyncStateMachine // TypeDefIndex: 5810
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public ImporterContext __4__this; // 0x20
			private TaskAwaiter<Material> __u__1; // 0x28
			private int _i_5__2; // 0x30
	
			// Methods
			private void MoveNext(); // 0x0000000180D55250-0x0000000180D55620
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 5811
		{
			// Fields
			public Mesh mesh; // 0x10
			public Func<MeshWithMaterials, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _BuildMeshAsync_b__0(MeshWithMaterials y); // 0x0000000180D57770-0x0000000180D577D0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _BuildMeshAsync_d__27 : IAsyncStateMachine // TypeDefIndex: 5812
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<MeshWithMaterials> __t__builder; // 0x08
			public Func<string, IDisposable> MeasureTime; // 0x20
			public IAwaitCaller awaitCaller; // 0x28
			public ImporterContext __4__this; // 0x30
			public MeshImporter.MeshContext x; // 0x38
			private __c__DisplayClass27_0 __8__1; // 0x40
			public int i; // 0x48
			private IDisposable __7__wrap1; // 0x50
			private TaskAwaiter<MeshWithMaterials> __u__1; // 0x58
	
			// Methods
			private void MoveNext(); // 0x0000000180D50F60-0x0000000180D514E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180D514E0-0x0000000180D51530
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 5813
		{
			// Fields
			public Mesh mesh; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _RemoveMesh_b__0(MeshWithMaterials x); // 0x0000000180D57960-0x0000000180D579E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 5814
		{
			// Fields
			public UnityResourceDestroyer destroyer; // 0x10
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _DisposeOnGameObjectDestroyed_b__0(UnityEngine.Object o); // 0x0000000180D579E0-0x0000000180D57AB0
		}
	
		// Constructors
		public ImporterContext(GltfParser parser, IEnumerable<ValueTuple<string, UnityEngine.Object>> externalObjectMap = null); // 0x0000000180D248A0-0x0000000180D24B40
		static ImporterContext(); // 0x0000000180D247D0-0x0000000180D248A0
	
		// Methods
		public void SetAnimationImporter(IAnimationImporter animationImporter); // 0x000000018028FF80-0x000000018028FF90
		public virtual async Task LoadAsync(IAwaitCaller awaitCaller = null, Func<string, IDisposable> MeasureTime = null); // 0x0000000180D23960-0x0000000180D23A70
		protected virtual async Task LoadGeometryAsync(IAwaitCaller awaitCaller, Func<string, IDisposable> MeasureTime); // 0x0000000180D23A70-0x0000000180D23B70
		public async Task LoadMaterialsAsync(); // 0x0000000180D23B70-0x0000000180D23C60
		protected virtual Task OnLoadHierarchy(IAwaitCaller awaitCaller, Func<string, IDisposable> MeasureTime); // 0x0000000180D23C60-0x0000000180D23CC0
		private async Task<MeshWithMaterials> BuildMeshAsync(IAwaitCaller awaitCaller, Func<string, IDisposable> MeasureTime, MeshImporter.MeshContext x, int i); // 0x0000000180D23100-0x0000000180D23240
		public void ShowMeshes(); // 0x0000000180D23DD0-0x0000000180D24020
		private void RemoveMesh(Mesh mesh); // 0x0000000180D23CC0-0x0000000180D23DD0
		public void EnableUpdateWhenOffscreen(); // 0x0000000180D236C0-0x0000000180D23960
		public virtual void Dispose(); // 0x0000000180D23330-0x0000000180D236C0
		public virtual void TransferOwnership(Func<UnityEngine.Object, bool> take); // 0x0000000180D24020-0x0000000180D247D0
		public UnityResourceDestroyer DisposeOnGameObjectDestroyed(); // 0x0000000180D23240-0x0000000180D23330
	}
}
