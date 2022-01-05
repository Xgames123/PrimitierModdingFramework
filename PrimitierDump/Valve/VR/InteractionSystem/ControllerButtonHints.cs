/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public class ControllerButtonHints : MonoBehaviour // TypeDefIndex: 7463
	{
		// Fields
		public Material controllerMaterial; // 0x18
		public Material urpControllerMaterial; // 0x20
		public Color flashColor; // 0x28
		public GameObject textHintPrefab; // 0x38
		public SteamVR_Action_Vibration hapticFlash; // 0x40
		public bool autoSetWithControllerRangeOfMotion; // 0x48
		[Header] // 0x0000000180026120-0x0000000180026150
		public bool debugHints; // 0x49
		private SteamVR_RenderModel renderModel; // 0x50
		private Player player; // 0x58
		private List<MeshRenderer> renderers; // 0x60
		private List<MeshRenderer> flashingRenderers; // 0x68
		private float startTime; // 0x70
		private float tickCount; // 0x74
		private Dictionary<ISteamVR_Action_In_Source, ActionHintInfo> actionHintInfos; // 0x78
		private Transform textHintParent; // 0x80
		private int colorID; // 0x88
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initialized_k__BackingField; // 0x8C
		private Vector3 centerPosition; // 0x90
		private SteamVR_Events.Action renderModelLoadedAction; // 0xA0
		protected SteamVR_Input_Sources inputSource; // 0xA8
		private Dictionary<string, Transform> componentTransformMap; // 0xB0
	
		// Properties
		public Material usingMaterial { get; } // 0x0000000180268C10-0x0000000180268C20 
		public bool initialized { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018058EFB0-0x000000018058EFC0 0x000000018058EFC0-0x000000018058EFD0
	
		// Nested types
		private enum OffsetType // TypeDefIndex: 7458
		{
			Up = 0,
			Right = 1,
			Forward = 2,
			Back = 3
		}
	
		private class ActionHintInfo // TypeDefIndex: 7459
		{
			// Fields
			public string componentName; // 0x10
			public List<MeshRenderer> renderers; // 0x18
			public Transform localTransform; // 0x20
			public GameObject textHintObject; // 0x28
			public Transform textStartAnchor; // 0x30
			public Transform textEndAnchor; // 0x38
			public Vector3 textEndOffsetDir; // 0x40
			public Transform canvasOffset; // 0x50
			public UnityEngine.UI.Text text; // 0x58
			public TextMesh textMesh; // 0x60
			public Canvas textCanvas; // 0x68
			public LineRenderer line; // 0x70
			public float distanceFromCenter; // 0x78
			public bool textHintActive; // 0x7C
	
			// Constructors
			public ActionHintInfo(); // 0x00000001802650F0-0x0000000180265100
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DoInitialize_d__37 : IEnumerator<object> // TypeDefIndex: 7460
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SteamVR_RenderModel renderModel; // 0x20
			public ControllerButtonHints __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DoInitialize_d__37(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180297510-0x0000000180297AD0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180297AD0-0x0000000180297B10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TestButtonHints_d__44 : IEnumerator<object> // TypeDefIndex: 7461
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ControllerButtonHints __4__this; // 0x20
			private int _actionIndex_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TestButtonHints_d__44(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029D790-0x000000018029D9A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029D9A0-0x000000018029D9E0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _TestTextHints_d__45 : IEnumerator<object> // TypeDefIndex: 7462
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ControllerButtonHints __4__this; // 0x20
			private int _actionIndex_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _TestTextHints_d__45(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029DD50-0x000000018029DF90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029DF90-0x000000018029DFD0
		}
	
		// Constructors
		public ControllerButtonHints(); // 0x000000018058EE20-0x000000018058EFB0
	
		// Methods
		private void Awake(); // 0x000000018058AD00-0x000000018058ADD0
		private void Start(); // 0x000000018058E5C0-0x000000018058E5E0
		private void HintDebugLog(string msg); // 0x000000018058D4C0-0x000000018058D550
		private void OnEnable(); // 0x000000018058D880-0x000000018058D8B0
		private void OnDisable(); // 0x000000018058D810-0x000000018058D880
		private void OnParentHandInputFocusLost(); // 0x000000018058DAB0-0x000000018058DAD0
		public virtual void SetInputSource(SteamVR_Input_Sources newInputSource); // 0x000000018058DC50-0x000000018058DCE0
		private void OnHandInitialized(int deviceIndex); // 0x000000018058D8B0-0x000000018058DAB0
		private void OnRenderModelLoaded(SteamVR_RenderModel renderModel, bool succeess); // 0x000000018058DAD0-0x000000018058DC50
		[IteratorStateMachine] // 0x0000000180026150-0x00000001800261A0
		private IEnumerator DoInitialize(SteamVR_RenderModel renderModel); // 0x000000018058C690-0x000000018058C710
		private void CreateAndAddButtonInfo(ISteamVR_Action_In action, SteamVR_Input_Sources inputSource); // 0x000000018058B5C0-0x000000018058C690
		private void ComputeTextEndTransforms(); // 0x000000018058AE30-0x000000018058B5C0
		private void ShowButtonHint(params /* 0x0000000180014D50-0x0000000180014D60 */ ISteamVR_Action_In_Source[] actions); // 0x000000018058DCE0-0x000000018058E1E0
		private void HideAllButtonHints(); // 0x000000018058CAA0-0x000000018058CBC0
		private void HideButtonHint(params /* 0x0000000180014D50-0x0000000180014D60 */ ISteamVR_Action_In_Source[] actions); // 0x000000018058CDB0-0x000000018058D100
		private bool IsButtonHintActive(ISteamVR_Action_In_Source action); // 0x000000018058D5F0-0x000000018058D810
		[IteratorStateMachine] // 0x00000001800261A0-0x00000001800261F0
		private IEnumerator TestButtonHints(); // 0x000000018058E5E0-0x000000018058E650
		[IteratorStateMachine] // 0x00000001800261F0-0x0000000180026240
		private IEnumerator TestTextHints(); // 0x000000018058E650-0x000000018058E6C0
		private void Update(); // 0x000000018058EA20-0x000000018058EE20
		private void UpdateTextHint(ActionHintInfo hintInfo); // 0x000000018058E6C0-0x000000018058EA20
		private void Clear(); // 0x000000018058ADD0-0x000000018058AE30
		private void ShowText(ISteamVR_Action_In_Source action, string text, bool highlightButton = true /* Metadata: 0x003A5AA8 */); // 0x000000018058E390-0x000000018058E5C0
		private void HideText(ISteamVR_Action_In_Source action); // 0x000000018058D390-0x000000018058D4C0
		private void HideAllText(); // 0x000000018058CC50-0x000000018058CDB0
		private string GetActiveHintText(ISteamVR_Action_In_Source action); // 0x000000018058C870-0x000000018058C940
		private static ControllerButtonHints GetControllerButtonHints(Hand hand); // 0x000000018058C940-0x000000018058CA10
		public static void ShowButtonHint(Hand hand, params /* 0x0000000180014D50-0x0000000180014D60 */ ISteamVR_Action_In_Source[] actions); // 0x000000018058E1E0-0x000000018058E270
		public static void HideButtonHint(Hand hand, params /* 0x0000000180014D50-0x0000000180014D60 */ ISteamVR_Action_In_Source[] actions); // 0x000000018058D100-0x000000018058D190
		public static void HideAllButtonHints(Hand hand); // 0x000000018058CA10-0x000000018058CAA0
		public static bool IsButtonHintActive(Hand hand, ISteamVR_Action_In_Source action); // 0x000000018058D550-0x000000018058D5F0
		public static void ShowTextHint(Hand hand, ISteamVR_Action_In_Source action, string text, bool highlightButton = true /* Metadata: 0x003A5AA9 */); // 0x000000018058E270-0x000000018058E390
		public static void HideTextHint(Hand hand, ISteamVR_Action_In_Source action); // 0x000000018058D190-0x000000018058D390
		public static void HideAllTextHints(Hand hand); // 0x000000018058CBC0-0x000000018058CC50
		public static string GetActiveHintText(Hand hand, ISteamVR_Action_In_Source action); // 0x000000018058C710-0x000000018058C870
	}
}
