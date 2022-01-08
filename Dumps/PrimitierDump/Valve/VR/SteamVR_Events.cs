/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR
{
	public static class SteamVR_Events // TypeDefIndex: 7346
	{
		// Fields
		public static Event<bool> Calibrating; // 0x00
		public static Event<int, bool> DeviceConnected; // 0x08
		public static Event<Color, float, bool> Fade; // 0x10
		public static Event FadeReady; // 0x18
		public static Event<bool> HideRenderModels; // 0x20
		public static Event<bool> Initializing; // 0x28
		public static Event<bool> InputFocus; // 0x30
		public static Event<bool> Loading; // 0x38
		public static Event<float> LoadingFadeIn; // 0x40
		public static Event<float> LoadingFadeOut; // 0x48
		public static Event<TrackedDevicePose_t[]> NewPoses; // 0x50
		public static Event NewPosesApplied; // 0x58
		public static Event<bool> Initialized; // 0x60
		public static Event<bool> OutOfRange; // 0x68
		public static Event<SteamVR_RenderModel, bool> RenderModelLoaded; // 0x70
		private static Dictionary<EVREventType, Event<VREvent_t>> systemEvents; // 0x78
	
		// Nested types
		public abstract class Action // TypeDefIndex: 7337
		{
			// Properties
			public bool enabled { set; } // 0x000000018028A150-0x000000018028A170
	
			// Constructors
			protected Action(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public abstract void Enable(bool enabled);
		}
	
		[Serializable]
		public class ActionNoArgs : Valve.VR.SteamVR_Events.Action // TypeDefIndex: 7338
		{
			// Fields
			private Valve.VR.SteamVR_Events.Event _event; // 0x10
			private UnityAction action; // 0x18
	
			// Constructors
			public ActionNoArgs(Valve.VR.SteamVR_Events.Event _event, UnityAction action); // 0x000000018028A110-0x000000018028A150
	
			// Methods
			public override void Enable(bool enabled); // 0x000000018028A0D0-0x000000018028A110
		}
	
		[Serializable]
		public class Action<T> : Valve.VR.SteamVR_Events.Action // TypeDefIndex: 7339
		{
			// Fields
			private Event<T> _event;
			private UnityAction<T> action;
	
			// Constructors
			public Action(Event<T> _event, UnityAction<T> action);
	
			// Methods
			public override void Enable(bool enabled);
		}
	
		[Serializable]
		public class Action<T0, T1> : Valve.VR.SteamVR_Events.Action // TypeDefIndex: 7340
		{
			// Fields
			private Event<T0, T1> _event;
			private UnityAction<T0, T1> action;
	
			// Constructors
			public Action(Event<T0, T1> _event, UnityAction<T0, T1> action);
	
			// Methods
			public override void Enable(bool enabled);
		}
	
		[Serializable]
		public class Action<T0, T1, T2> : Valve.VR.SteamVR_Events.Action // TypeDefIndex: 7341
		{
			// Fields
			private Event<T0, T1, T2> _event;
			private UnityAction<T0, T1, T2> action;
	
			// Constructors
			public Action(Event<T0, T1, T2> _event, UnityAction<T0, T1, T2> action);
	
			// Methods
			public override void Enable(bool enabled);
		}
	
		public class Event : UnityEvent // TypeDefIndex: 7342
		{
			// Constructors
			public Event(); // 0x000000018028D800-0x000000018028D810
	
			// Methods
			public void Listen(UnityAction action); // 0x000000018028D3A0-0x000000018028D3B0
			public void Remove(UnityAction action); // 0x000000018028D560-0x000000018028D570
			public void Send(); // 0x000000018028D790-0x000000018028D7A0
		}
	
		public class Event<T> : UnityEvent<T> // TypeDefIndex: 7343
		{
			// Constructors
			public Event();
	
			// Methods
			public void Listen(UnityAction<T> action);
			public void Remove(UnityAction<T> action);
			public void Send(T arg0);
		}
	
		public class Event<T0, T1> : UnityEvent<T0, T1> // TypeDefIndex: 7344
		{
			// Constructors
			public Event();
	
			// Methods
			public void Listen(UnityAction<T0, T1> action);
			public void Remove(UnityAction<T0, T1> action);
			public void Send(T0 arg0, T1 arg1);
		}
	
		public class Event<T0, T1, T2> : UnityEvent<T0, T1, T2> // TypeDefIndex: 7345
		{
			// Constructors
			public Event();
	
			// Methods
			public void Listen(UnityAction<T0, T1, T2> action);
			public void Remove(UnityAction<T0, T1, T2> action);
			public void Send(T0 arg0, T1 arg1, T2 arg2);
		}
	
		// Constructors
		static SteamVR_Events(); // 0x0000000180322890-0x0000000180322C70
	
		// Methods
		public static Action CalibratingAction(UnityAction<bool> action); // 0x0000000180321B50-0x0000000180321C00
		public static Action DeviceConnectedAction(UnityAction<int, bool> action); // 0x0000000180321C00-0x0000000180321CB0
		public static Action FadeAction(UnityAction<Color, float, bool> action); // 0x0000000180321CB0-0x0000000180321D60
		public static Action FadeReadyAction(UnityAction action); // 0x0000000180321D60-0x0000000180321E00
		public static Action HideRenderModelsAction(UnityAction<bool> action); // 0x0000000180321E00-0x0000000180321EB0
		public static Action InitializingAction(UnityAction<bool> action); // 0x0000000180321F60-0x0000000180322010
		public static Action InputFocusAction(UnityAction<bool> action); // 0x0000000180322010-0x00000001803220C0
		public static Action LoadingAction(UnityAction<bool> action); // 0x00000001803220C0-0x0000000180322170
		public static Action LoadingFadeInAction(UnityAction<float> action); // 0x0000000180322170-0x0000000180322220
		public static Action LoadingFadeOutAction(UnityAction<float> action); // 0x0000000180322220-0x00000001803222D0
		public static Action NewPosesAction(UnityAction<TrackedDevicePose_t[]> action); // 0x00000001803222D0-0x0000000180322380
		public static Action NewPosesAppliedAction(UnityAction action); // 0x0000000180322380-0x0000000180322420
		public static Action InitializedAction(UnityAction<bool> action); // 0x0000000180321EB0-0x0000000180321F60
		public static Action OutOfRangeAction(UnityAction<bool> action); // 0x0000000180322420-0x00000001803224D0
		public static Action RenderModelLoadedAction(UnityAction<SteamVR_RenderModel, bool> action); // 0x00000001803224D0-0x0000000180322580
		public static Event<VREvent_t> System(EVREventType eventType); // 0x0000000180322750-0x0000000180322890
		public static Action SystemAction(EVREventType eventType, UnityAction<VREvent_t> action); // 0x0000000180322580-0x0000000180322750
	}
}
