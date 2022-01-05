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
	public abstract class SteamVR_Action_Source_Map<SourceElement> : SteamVR_Action_Source_Map // TypeDefIndex: 7154
		where SourceElement : SteamVR_Action_Source, new()
	{
		// Fields
		protected SourceElement[] sources;
	
		// Properties
		public SourceElement this[SteamVR_Input_Sources inputSource] { get => default; }
	
		// Constructors
		protected SteamVR_Action_Source_Map();
	
		// Methods
		protected virtual void OnAccessSource(SteamVR_Input_Sources inputSource);
		public override void Initialize();
		protected override void PreinitializeMap(SteamVR_Input_Sources inputSource, SteamVR_Action wrappingAction);
		protected virtual SourceElement GetSourceElementForIndexer(SteamVR_Input_Sources inputSource);
	}
}
