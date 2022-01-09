/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniGLTF;
using UniHumanoid;
using UnityEngine;
using VRMShaders;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMImporterContext : UniGLTF.ImporterContext // TypeDefIndex: 8060
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private glTF_VRM_extensions _VRM_k__BackingField; // 0x68
		public AvatarDescription AvatarDescription; // 0x70
		public Avatar HumanoidAvatar; // 0x78
		public BlendShapeAvatar BlendShapeAvatar; // 0x80
		public VRMMetaObject Meta; // 0x88
	
		// Properties
		public glTF_VRM_extensions VRM { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802C6D10-0x00000001802C6D20 0x00000001802C6D50-0x00000001802C6D60
	
		// Nested types
		public class NotVrm0Exception : Exception // TypeDefIndex: 8053
		{
			// Constructors
			public NotVrm0Exception(); // 0x000000018054A050-0x000000018054A0B0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _OnLoadHierarchy_d__6 : IAsyncStateMachine // TypeDefIndex: 8054
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public VRMImporterContext __4__this; // 0x20
			public Func<string, IDisposable> MeasureTime; // 0x28
			public IAwaitCaller awaitCaller; // 0x30
			private IDisposable __7__wrap1; // 0x38
			private TaskAwaiter __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x000000018054C350-0x000000018054CC70
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _LoadMetaAsync_d__7 : IAsyncStateMachine // TypeDefIndex: 8055
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public VRMImporterContext __4__this; // 0x20
			private TaskAwaiter<VRMMetaObject> __u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018054C1A0-0x000000018054C340
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 8056
		{
			// Fields
			public VRMImporterContext __4__this; // 0x10
			public Dictionary<Mesh, Transform> transformMeshTable; // 0x18
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal BlendShapeBinding _LoadBlendShapeBind_b__0(glTF_VRM_BlendShapeBind x); // 0x000000018054DFE0-0x000000018054E100
			internal MaterialValueBinding? _LoadBlendShapeBind_b__1(glTF_VRM_MaterialValueBind x); // 0x000000018054E100-0x000000018054E710
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 8057
		{
			// Fields
			public glTF_VRM_MaterialValueBind x; // 0x10
	
			// Constructors
			public __c__DisplayClass10_1(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _LoadBlendShapeBind_b__5(Material y); // 0x000000018054E710-0x000000018054E750
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 8058
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MaterialFactory.MaterialLoadInfo, Material> __9__10_4; // 0x08
			public static Func<MaterialValueBinding?, bool> __9__10_2; // 0x10
			public static Func<MaterialValueBinding?, MaterialValueBinding> __9__10_3; // 0x18
	
			// Constructors
			static __c(); // 0x0000000180550620-0x0000000180550680
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal Material _LoadBlendShapeBind_b__10_4(MaterialFactory.MaterialLoadInfo y); // 0x000000018054DCB0-0x000000018054DCC0
			internal bool _LoadBlendShapeBind_b__10_2(MaterialValueBinding? x); // 0x000000018054DC00-0x000000018054DC40
			internal MaterialValueBinding _LoadBlendShapeBind_b__10_3(MaterialValueBinding? x); // 0x000000018054DC40-0x000000018054DCB0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private struct _ReadMetaAsync_d__18 : IAsyncStateMachine // TypeDefIndex: 8059
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder<VRMMetaObject> __t__builder; // 0x08
			public IAwaitCaller awaitCaller; // 0x20
			public VRMImporterContext __4__this; // 0x28
			private VRMMetaObject _meta_5__2; // 0x30
			private glTF_VRM_Meta _gltfMeta_5__3; // 0x38
			private TaskAwaiter<Texture2D> __u__1; // 0x40
	
			// Methods
			private void MoveNext(); // 0x000000018054CC70-0x000000018054D2E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054D2E0-0x000000018054D330
		}
	
		// Constructors
		public VRMImporterContext(GltfParser parser, IEnumerable<ValueTuple<string, UnityEngine.Object>> externalObjectMap = null); // 0x0000000180346420-0x00000001803465E0
	
		// Methods
		protected override async Task OnLoadHierarchy(IAwaitCaller awaitCaller, Func<string, IDisposable> MeasureTime); // 0x0000000180345D70-0x0000000180345E80
		private async Task LoadMetaAsync(); // 0x0000000180345C90-0x0000000180345D70
		private void LoadFirstPerson(); // 0x0000000180345890-0x00000001803459D0
		private void LoadBlendShapeMaster(); // 0x0000000180345350-0x0000000180345890
		private BlendShapeClip LoadBlendShapeBind(glTF_VRM_BlendShapeGroup group, Dictionary<Mesh, Transform> transformMeshTable); // 0x0000000180344EB0-0x0000000180345350
		private static string ToHumanBoneName(HumanBodyBones b); // 0x0000000180345FB0-0x0000000180346130
		private static SkeletonBone ToSkeletonBone(Transform t); // 0x0000000180346130-0x0000000180346210
		private void LoadHumanoid(); // 0x00000001803459D0-0x0000000180345C90
		public async Task<VRMMetaObject> ReadMetaAsync(IAwaitCaller awaitCaller = null, bool createThumbnail = false /* Metadata: 0x003A61EC */); // 0x0000000180345E80-0x0000000180345FB0
		public override void TransferOwnership(Func<UnityEngine.Object, bool> take); // 0x0000000180346210-0x0000000180346420
		public override void Dispose(); // 0x0000000180344BC0-0x0000000180344EB0
	}
}
