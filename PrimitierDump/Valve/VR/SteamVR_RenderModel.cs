/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[ExecuteInEditMode] // 0x0000000180014D50-0x0000000180014D60
	public class SteamVR_RenderModel : MonoBehaviour // TypeDefIndex: 7367
	{
		// Fields
		public SteamVR_TrackedObject.EIndex index; // 0x18
		protected SteamVR_Input_Sources inputSource; // 0x1C
		public const string modelOverrideWarning = "Model override is really only meant to be used in the scene view for lining things up; using it at runtime is discouraged.  Use tracked device index instead to ensure the correct model is displayed for all users."; // Metadata: 0x003A57CE
		[Tooltip] // 0x0000000180024470-0x00000001800244A0
		public string modelOverride; // 0x20
		[Tooltip] // 0x00000001800244A0-0x00000001800244D0
		public Shader shader; // 0x28
		[Tooltip] // 0x00000001800244D0-0x0000000180024500
		public bool verbose; // 0x30
		[Tooltip] // 0x0000000180024500-0x0000000180024530
		public bool createComponents; // 0x31
		[Tooltip] // 0x0000000180024530-0x0000000180024560
		public bool updateDynamically; // 0x32
		public RenderModel_ControllerMode_State_t controllerModeState; // 0x33
		public const string k_localTransformName = "attach"; // Metadata: 0x003A58A6
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private string _renderModelName_k__BackingField; // 0x38
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initializedAttachPoints_k__BackingField; // 0x40
		private Dictionary<string, Transform> componentAttachPoints; // 0x48
		private List<MeshRenderer> meshRenderers; // 0x50
		public static Hashtable models; // 0x00
		public static Hashtable materials; // 0x08
		private SteamVR_Events.Action deviceConnectedAction; // 0x58
		private SteamVR_Events.Action hideRenderModelsAction; // 0x60
		private SteamVR_Events.Action modelSkinSettingsHaveChangedAction; // 0x68
		private Dictionary<int, string> nameCache; // 0x70
	
		// Properties
		public string renderModelName { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FE0-0x0000000180268FF0 0x00000001802A43D0-0x00000001802A43E0
		public bool initializedAttachPoints { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ set; } // 0x00000001802B7950-0x00000001802B7960 0x00000001803F9470-0x00000001803F9480
	
		// Nested types
		public class RenderModel // TypeDefIndex: 7363
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Mesh _mesh_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Material _material_k__BackingField; // 0x18
	
			// Properties
			public Mesh mesh { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
			public Material material { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
	
			// Constructors
			public RenderModel(Mesh mesh, Material material); // 0x000000018028A110-0x000000018028A150
		}
	
		public sealed class RenderModelInterfaceHolder : IDisposable // TypeDefIndex: 7364
		{
			// Fields
			private bool needsShutdown; // 0x10
			private bool failedLoadInterface; // 0x11
			private CVRRenderModels _instance; // 0x18
	
			// Properties
			public CVRRenderModels instance { get; } // 0x000000018028FE70-0x000000018028FF80 
	
			// Constructors
			public RenderModelInterfaceHolder(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Dispose(); // 0x000000018028FE10-0x000000018028FE70
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _SetModelAsync_d__29 : IEnumerator<object> // TypeDefIndex: 7365
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_RenderModel __4__this; // 0x20
			public string newRenderModelName; // 0x28
			private RenderModelInterfaceHolder _holder_5__2; // 0x30
			private CVRRenderModels _renderModels_5__3; // 0x38
			private string[] _renderModelNames_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _SetModelAsync_d__29(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x000000018029C7E0-0x000000018029C870
			private bool MoveNext(); // 0x000000018029BED0-0x000000018029C7A0
			private void __m__Finally1(); // 0x000000018029C870-0x000000018029C8C0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029C7A0-0x000000018029C7E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _FreeRenderModel_d__32 : IEnumerator<object> // TypeDefIndex: 7366
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IntPtr pRenderModel; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _FreeRenderModel_d__32(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029A410-0x000000018029A550
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029A550-0x000000018029A590
		}
	
		// Constructors
		private SteamVR_RenderModel(); // 0x0000000180C6E150-0x0000000180C6E350
		static SteamVR_RenderModel(); // 0x0000000180C6E0C0-0x0000000180C6E150
	
		// Methods
		private void OnModelSkinSettingsHaveChanged(VREvent_t vrEvent); // 0x0000000180C6CF60-0x0000000180C6CFC0
		public void SetMeshRendererState(bool state); // 0x0000000180C6D020-0x0000000180C6D130
		private void OnHideRenderModels(bool hidden); // 0x0000000180C6CE50-0x0000000180C6CF60
		private void OnDeviceConnected(int i, bool connected); // 0x0000000180C6CCC0-0x0000000180C6CCE0
		public void UpdateModel(); // 0x0000000180C6DE00-0x0000000180C6E050
		[IteratorStateMachine] // 0x0000000180024560-0x00000001800245B0
		private IEnumerator SetModelAsync(string newRenderModelName); // 0x0000000180C6D130-0x0000000180C6D1B0
		private bool SetModel(string renderModelName); // 0x0000000180C6D1B0-0x0000000180C6D780
		private RenderModel LoadRenderModel(CVRRenderModels renderModels, string renderModelName, string baseName); // 0x0000000180C6BAB0-0x0000000180C6C820
		[IteratorStateMachine] // 0x00000001800245B0-0x0000000180024600
		private IEnumerator FreeRenderModel(IntPtr pRenderModel); // 0x0000000180C6B1A0-0x0000000180C6B210
		public Transform FindTransformByName(string componentName, Transform inTransform = null); // 0x0000000180C6B0B0-0x0000000180C6B1A0
		public Transform GetComponentTransform(string componentName); // 0x0000000180C6B210-0x0000000180C6B2C0
		private void StripMesh(GameObject go); // 0x0000000180C6D790-0x0000000180C6D8D0
		private bool LoadComponents(RenderModelInterfaceHolder holder, string renderModelName); // 0x0000000180C6B2C0-0x0000000180C6BAB0
		private void OnEnable(); // 0x0000000180C6CD30-0x0000000180C6CE50
		private void OnDisable(); // 0x0000000180C6CCE0-0x0000000180C6CD30
		private void Update(); // 0x0000000180C6E050-0x0000000180C6E0C0
		public void UpdateComponents(CVRRenderModels renderModels); // 0x0000000180C6D8D0-0x0000000180C6DE00
		public void SetDeviceIndex(int newIndex); // 0x0000000180C6CFC0-0x0000000180C6D020
		public void SetInputSource(SteamVR_Input_Sources newInputSource); // 0x00000001802C2020-0x00000001802C2030
		private static void Sleep(); // 0x0000000180C6D780-0x0000000180C6D790
		private RenderModel_t MarshalRenderModel(IntPtr pRenderModel); // 0x0000000180C6CA60-0x0000000180C6CCC0
		private RenderModel_TextureMap_t MarshalRenderModel_TextureMap(IntPtr pRenderModel); // 0x0000000180C6C820-0x0000000180C6CA60
	}
}
