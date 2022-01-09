/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public class SteamVR_Input // TypeDefIndex: 7282
	{
		// Fields
		public const string defaultInputGameObjectName = "[SteamVR Input]"; // Metadata: 0x003A549F
		private const string localizationKeyName = "localization"; // Metadata: 0x003A54B2
		public static bool fileInitialized; // 0x00
		public static bool initialized; // 0x01
		public static bool preInitialized; // 0x02
		public static SteamVR_Input_ActionFile actionFile; // 0x08
		public static string actionFileHash; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static System.Action onNonVisualActionsUpdated; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static PosesUpdatedHandler onPosesUpdated; // 0x20
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private static SkeletonsUpdatedHandler onSkeletonsUpdated; // 0x28
		protected static bool initializing; // 0x30
		protected static int startupFrame; // 0x34
		public static SteamVR_ActionSet[] actionSets; // 0x38
		public static SteamVR_Action[] actions; // 0x40
		public static ISteamVR_Action_In[] actionsIn; // 0x48
		public static ISteamVR_Action_Out[] actionsOut; // 0x50
		public static SteamVR_Action_Boolean[] actionsBoolean; // 0x58
		public static SteamVR_Action_Single[] actionsSingle; // 0x60
		public static SteamVR_Action_Vector2[] actionsVector2; // 0x68
		public static SteamVR_Action_Vector3[] actionsVector3; // 0x70
		public static SteamVR_Action_Pose[] actionsPose; // 0x78
		public static SteamVR_Action_Skeleton[] actionsSkeleton; // 0x80
		public static SteamVR_Action_Vibration[] actionsVibration; // 0x88
		public static ISteamVR_Action_In[] actionsNonPoseNonSkeletonIn; // 0x90
		protected static Dictionary<string, SteamVR_ActionSet> actionSetsByPath; // 0x98
		protected static Dictionary<string, SteamVR_ActionSet> actionSetsByPathLowered; // 0xA0
		protected static Dictionary<string, SteamVR_Action> actionsByPath; // 0xA8
		protected static Dictionary<string, SteamVR_Action> actionsByPathLowered; // 0xB0
		protected static Dictionary<string, SteamVR_ActionSet> actionSetsByPathCache; // 0xB8
		protected static Dictionary<string, SteamVR_Action> actionsByPathCache; // 0xC0
		protected static Dictionary<string, SteamVR_Action> actionsByNameCache; // 0xC8
		protected static Dictionary<string, SteamVR_ActionSet> actionSetsByNameCache; // 0xD0
		private static uint sizeVRActiveActionSet_t; // 0xD8
		private static VRActiveActionSet_t[] setCache; // 0xE0
	
		// Properties
		public static bool isStartupFrame { get; } // 0x0000000180334550-0x0000000180334600 
	
		// Events
		public static event System.Action onNonVisualActionsUpdated {
			add; // 0x0000000180334250-0x0000000180334350
			remove; // 0x0000000180334600-0x0000000180334700
		}
		public static event PosesUpdatedHandler onPosesUpdated {
			add; // 0x0000000180334350-0x0000000180334450
			remove; // 0x0000000180334700-0x0000000180334800
		}
		public static event SkeletonsUpdatedHandler onSkeletonsUpdated {
			add; // 0x0000000180334450-0x0000000180334550
			remove; // 0x0000000180334800-0x0000000180334900
		}
	
		// Nested types
		public delegate void PosesUpdatedHandler(bool skipSendingEvents); // TypeDefIndex: 7280; 0x000000018028FC80-0x000000018028FE10
	
		public delegate void SkeletonsUpdatedHandler(bool skipSendingEvents); // TypeDefIndex: 7281; 0x000000018028FC80-0x000000018028FE10
	
		// Constructors
		static SteamVR_Input(); // 0x0000000180333FB0-0x0000000180334250
		public SteamVR_Input(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static void ForcePreinitialize(); // 0x000000018032E0C0-0x000000018032E110
		private static void FindPreinitializeMethod(); // 0x000000018032DE00-0x000000018032DF60
		public static void Initialize(bool force = false /* Metadata: 0x003A544A */); // 0x00000001803312E0-0x00000001803316E0
		public static void PreinitializeFinishActionSets(); // 0x0000000180332240-0x0000000180332320
		public static void PreinitializeActionSetDictionaries(); // 0x0000000180332010-0x0000000180332240
		public static void PreinitializeActionDictionaries(); // 0x0000000180331DD0-0x0000000180332010
		public static void Update(); // 0x0000000180333E50-0x0000000180333FB0
		public static void LateUpdate(); // 0x00000001803316E0-0x0000000180331870
		public static void FixedUpdate(); // 0x000000018032DF60-0x000000018032E0C0
		public static void OnPreCull(); // 0x0000000180331AD0-0x0000000180331C30
		public static void UpdateVisualActions(bool skipStateAndEventUpdates = false /* Metadata: 0x003A544B */); // 0x0000000180333C00-0x0000000180333E50
		public static void UpdatePoseActions(bool skipSendingEvents = false /* Metadata: 0x003A544C */); // 0x00000001803338D0-0x0000000180333A60
		public static void UpdateSkeletonActions(bool skipSendingEvents = false /* Metadata: 0x003A544D */); // 0x0000000180333A60-0x0000000180333C00
		public static void UpdateNonVisualActions(); // 0x0000000180333700-0x00000001803338D0
		protected static void ShowBindingHintsForSets(VRActiveActionSet_t[] sets, ulong highlightAction = 0 /* Metadata: 0x003A544E */); // 0x0000000180332580-0x0000000180332740
		public static bool ShowBindingHints(ISteamVR_Action_In originToHighlight); // 0x0000000180332820-0x0000000180332990
		public static bool ShowBindingHints(ISteamVR_ActionSet setToShow); // 0x0000000180332740-0x0000000180332820
		public static void ShowBindingHintsForActiveActionSets(ulong highlightAction = 0 /* Metadata: 0x003A5456 */); // 0x0000000180332380-0x0000000180332580
		public static T GetActionDataFromPath<T>(string path, bool caseSensitive = false /* Metadata: 0x003A545E */)
			where T : SteamVR_Action_Source_Map;
		public static SteamVR_ActionSet_Data GetActionSetDataFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A545F */); // 0x000000018032E110-0x000000018032E200
		public static T GetActionFromPath<T>(string path, bool caseSensitive = false /* Metadata: 0x003A5460 */, bool returnNulls = false /* Metadata: 0x003A5461 */)
			where T : SteamVR_Action, new();
		public static SteamVR_Action GetBaseActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5462 */); // 0x000000018032E580-0x000000018032E980
		public static bool HasActionPath(string path, bool caseSensitive = false /* Metadata: 0x003A5463 */); // 0x0000000180330850-0x00000001803308F0
		public static bool HasAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A5464 */); // 0x0000000180330A20-0x0000000180330AC0
		public static bool HasAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5465 */); // 0x0000000180330970-0x0000000180330A20
		public static SteamVR_Action_Boolean GetBooleanActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5466 */); // 0x000000018032EDC0-0x000000018032EE40
		public static SteamVR_Action_Single GetSingleActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5467 */); // 0x000000018032F380-0x000000018032F400
		public static SteamVR_Action_Vector2 GetVector2ActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5468 */); // 0x000000018032FEE0-0x000000018032FF60
		public static SteamVR_Action_Vector3 GetVector3ActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5469 */); // 0x00000001803302B0-0x0000000180330330
		public static SteamVR_Action_Vibration GetVibrationActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A546A */); // 0x00000001803306C0-0x0000000180330740
		public static SteamVR_Action_Pose GetPoseActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A546B */); // 0x000000018032F1F0-0x000000018032F270
		public static SteamVR_Action_Skeleton GetSkeletonActionFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A546C */); // 0x000000018032F690-0x000000018032F710
		public static T GetAction<T>(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A546D */, bool returnNulls = false /* Metadata: 0x003A546E */)
			where T : SteamVR_Action, new();
		public static SteamVR_Action GetBaseAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A546F */); // 0x000000018032E980-0x000000018032EDC0
		private static T CreateFakeAction<T>(string actionSetName, string actionName, bool caseSensitive)
			where T : SteamVR_Action, new();
		private static T CreateFakeAction<T>(string actionPath, bool caseSensitive)
			where T : SteamVR_Action, new();
		public static T GetAction<T>(string actionName, bool caseSensitive = false /* Metadata: 0x003A5470 */)
			where T : SteamVR_Action, new();
		public static SteamVR_Action_Boolean GetBooleanAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5471 */); // 0x000000018032EE40-0x000000018032EED0
		public static SteamVR_Action_Boolean GetBooleanAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A5472 */); // 0x000000018032EED0-0x000000018032EF50
		public static SteamVR_Action_Single GetSingleAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5473 */); // 0x000000018032F400-0x000000018032F490
		public static SteamVR_Action_Single GetSingleAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A5474 */); // 0x000000018032F490-0x000000018032F510
		public static SteamVR_Action_Vector2 GetVector2Action(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5475 */); // 0x000000018032FF60-0x000000018032FFF0
		public static SteamVR_Action_Vector2 GetVector2Action(string actionName, bool caseSensitive = false /* Metadata: 0x003A5476 */); // 0x000000018032FFF0-0x0000000180330070
		public static SteamVR_Action_Vector3 GetVector3Action(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5477 */); // 0x0000000180330330-0x00000001803303C0
		public static SteamVR_Action_Vector3 GetVector3Action(string actionName, bool caseSensitive = false /* Metadata: 0x003A5478 */); // 0x00000001803303C0-0x0000000180330440
		public static SteamVR_Action_Pose GetPoseAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A5479 */); // 0x000000018032F2F0-0x000000018032F380
		public static SteamVR_Action_Pose GetPoseAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A547A */); // 0x000000018032F270-0x000000018032F2F0
		public static SteamVR_Action_Skeleton GetSkeletonAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A547B */); // 0x000000018032F710-0x000000018032F7A0
		public static SteamVR_Action_Skeleton GetSkeletonAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A547C */); // 0x000000018032F7A0-0x000000018032F820
		public static SteamVR_Action_Vibration GetVibrationAction(string actionSetName, string actionName, bool caseSensitive = false /* Metadata: 0x003A547D */); // 0x00000001803307C0-0x0000000180330850
		public static SteamVR_Action_Vibration GetVibrationAction(string actionName, bool caseSensitive = false /* Metadata: 0x003A547E */); // 0x0000000180330740-0x00000001803307C0
		public static T GetActionSet<T>(string actionSetName, bool caseSensitive = false /* Metadata: 0x003A547F */, bool returnNulls = false /* Metadata: 0x003A5480 */)
			where T : SteamVR_ActionSet, new();
		public static SteamVR_ActionSet GetActionSet(string actionSetName, bool caseSensitive = false /* Metadata: 0x003A5481 */, bool returnsNulls = false /* Metadata: 0x003A5482 */); // 0x000000018032E280-0x000000018032E310
		protected static bool HasActionSet(string name, bool caseSensitive = false /* Metadata: 0x003A5483 */); // 0x00000001803308F0-0x0000000180330970
		public static T GetActionSetFromPath<T>(string path, bool caseSensitive = false /* Metadata: 0x003A5484 */, bool returnsNulls = false /* Metadata: 0x003A5485 */)
			where T : SteamVR_ActionSet, new();
		public static SteamVR_ActionSet GetActionSetFromPath(string path, bool caseSensitive = false /* Metadata: 0x003A5486 */); // 0x000000018032E200-0x000000018032E280
		public static bool GetState(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5487 */); // 0x000000018032FCA0-0x000000018032FDA0
		public static bool GetState(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5488 */); // 0x000000018032FDA0-0x000000018032FEE0
		public static bool GetStateDown(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5489 */); // 0x000000018032F960-0x000000018032FA60
		public static bool GetStateDown(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548A */); // 0x000000018032F820-0x000000018032F960
		public static bool GetStateUp(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548B */); // 0x000000018032FA60-0x000000018032FB60
		public static bool GetStateUp(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548C */); // 0x000000018032FB60-0x000000018032FCA0
		public static float GetFloat(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548D */); // 0x000000018032EF50-0x000000018032F050
		public static float GetFloat(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548E */); // 0x000000018032F050-0x000000018032F0D0
		public static float GetSingle(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A548F */); // 0x000000018032F510-0x000000018032F610
		public static float GetSingle(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5490 */); // 0x000000018032F610-0x000000018032F690
		public static Vector2 GetVector2(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5491 */); // 0x0000000180330070-0x0000000180330170
		public static Vector2 GetVector2(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5492 */); // 0x0000000180330170-0x00000001803302B0
		public static Vector3 GetVector3(string actionSet, string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5493 */); // 0x00000001803305A0-0x00000001803306C0
		public static Vector3 GetVector3(string action, SteamVR_Input_Sources inputSource, bool caseSensitive = false /* Metadata: 0x003A5494 */); // 0x0000000180330440-0x00000001803305A0
		public static SteamVR_ActionSet[] GetActionSets(); // 0x000000018032E310-0x000000018032E370
		public static T[] GetActions<T>()
			where T : SteamVR_Action;
		internal static bool ShouldMakeCopy(); // 0x0000000180332320-0x0000000180332380
		public static string GetLocalizedName(ulong originHandle, params /* 0x0000000180014D50-0x0000000180014D60 */ EVRInputStringBits[] localizedParts); // 0x000000018032F0D0-0x000000018032F1F0
		public static bool CheckOldLocation(); // 0x0000000180295620-0x0000000180295630
		public static void IdentifyActionsFile(bool showLogs = true /* Metadata: 0x003A5495 */); // 0x0000000180330C20-0x0000000180330F60
		public static bool HasFileInMemoryBeenModified(); // 0x0000000180330AC0-0x0000000180330C20
		public static bool CreateEmptyActionsFile(bool completelyEmpty = false /* Metadata: 0x003A5496 */); // 0x000000018032D430-0x000000018032DB30
		public static bool DoesActionsFileExist(); // 0x000000018032DDA0-0x000000018032DE00
		public static bool InitializeFile(bool force = false /* Metadata: 0x003A5497 */, bool showErrors = true /* Metadata: 0x003A5498 */); // 0x0000000180330F60-0x00000001803312E0
		public static string GetActionsFileFolder(bool fullPath = true /* Metadata: 0x003A5499 */); // 0x000000018032E370-0x000000018032E420
		public static string GetActionsFilePath(bool fullPath = true /* Metadata: 0x003A549A */); // 0x000000018032E440-0x000000018032E580
		public static string GetActionsFileName(); // 0x000000018032E420-0x000000018032E440
		public static bool DeleteManifestAndBindings(); // 0x000000018032DB30-0x000000018032DDA0
		public static void OpenBindingUI(SteamVR_ActionSet actionSetToEdit = null, SteamVR_Input_Sources deviceBindingToEdit = SteamVR_Input_Sources.Any /* Metadata: 0x003A549B */); // 0x0000000180331C30-0x0000000180331DD0
	}
}
