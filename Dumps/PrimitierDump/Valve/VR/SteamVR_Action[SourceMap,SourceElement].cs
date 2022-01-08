/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	[Serializable]
	public abstract class SteamVR_Action<SourceMap, SourceElement> : SteamVR_Action, ISteamVR_Action // TypeDefIndex: 7152
		where SourceMap : SteamVR_Action_Source_Map<SourceElement>, new()
		where SourceElement : SteamVR_Action_Source, new()
	{
		// Fields
		[NonSerialized]
		protected SourceMap sourceMap;
		[NonSerialized]
		protected bool initialized;
	
		// Properties
		public virtual SourceElement this[SteamVR_Input_Sources inputSource] { get => default; }
		public override string fullPath { get; }
		public override ulong handle { get; }
		public override SteamVR_ActionSet actionSet { get; }
		public override SteamVR_ActionDirections direction { get; }
		public override bool active { get; }
		public override bool lastActive { get; }
		public override bool activeBinding { get; }
		public override bool lastActiveBinding { get; }
	
		// Constructors
		protected SteamVR_Action();
	
		// Methods
		public override void PreInitialize(string newActionPath);
		protected override void CreateUninitialized(string newActionPath, bool caseSensitive);
		protected override void CreateUninitialized(string newActionSet, SteamVR_ActionDirections direction, string newAction, bool caseSensitive);
		public override string TryNeedsInitData();
		public override void Initialize(bool createNew = false /* Metadata: 0x003A526B */, bool throwErrors = true /* Metadata: 0x003A526C */);
		public override SteamVR_Action_Source_Map GetSourceMap();
		protected override void InitializeCopy(string newActionPath, SteamVR_Action_Source_Map newData);
		protected void InitAfterDeserialize();
		public override bool GetActive(SteamVR_Input_Sources inputSource);
		public override bool GetActiveBinding(SteamVR_Input_Sources inputSource);
		public override bool GetLastActive(SteamVR_Input_Sources inputSource);
		public override bool GetLastActiveBinding(SteamVR_Input_Sources inputSource);
	}
}
