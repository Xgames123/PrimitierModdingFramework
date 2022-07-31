using PrimitierModdingFramework.Debugging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework
{
	/// <summary>
	/// The event types for a PMFSystem
	/// </summary>
	public enum PMFEventType
	{
		ApplicationStart,
		ApplicationLateStart,
		ApplicationQuit,
		SceneLoad,
		Update,
		GUI,

		SystemEnabled,
		SystemDisabled,
		RealyLateStart,
	}

	/// <summary>
	/// Base class for all systems in pmf
	/// </summary>
	public abstract class PMFSystem
	{
		internal static List<PMFSystem> EnabledSystems = new List<PMFSystem>();
		/// <summary>
		/// The current mod
		/// </summary>
		public static PrimitierMod Mod { get; private set; }

		/// <summary>
		/// All the registered mods
		/// </summary>
		public static IReadOnlyList<PrimitierMod> RegisteredMods { get { return _registeredMods; } }
		private static List<PrimitierMod> _registeredMods = new List<PrimitierMod>();

		private static bool _hasParsedCommandlineArgs = false;
		private bool _IsStarted = false;


		internal static void RegisterMod(PrimitierMod mod)
		{
			_registeredMods.Add(mod);
		}


		internal static void FireEventOnSystems(PrimitierMod mod, PMFEventType type)
		{
			Mod = mod;
			foreach (var system in EnabledSystems)
			{
				system.FireEvent(type);
			}

		}

		/// <summary>
		/// Enables a system.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public static void EnableSystem<T>() where T : PMFSystem, new()
		{
			if (IsEnabled<T>())
				return;

			var newSystem = new T();
			newSystem.FireEvent(PMFEventType.SystemEnabled);
			EnabledSystems.Add(newSystem);
		}

		/// <summary>
		/// Disables a system
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public static void DisableSystem<T>() where T: PMFSystem, new()
		{
			foreach (var system in EnabledSystems)
			{
				if (system is T)
				{
					system.FireEvent(PMFEventType.SystemDisabled);
					EnabledSystems.Remove(system);
					return;
				}

			}
			

		}

		/// <summary>
		/// Returns true if the system is enabled
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static bool IsEnabled<T>() where T : PMFSystem
		{
			return EnabledSystems.Any((system) => { return system is T; }); ;
		}

		internal static void TryParseCommandlineArgs()
		{
			if (_hasParsedCommandlineArgs)
				return;
			var args = Environment.GetCommandLineArgs();

			foreach (var arg in args)
			{
				if (arg == "--pmf.flycam")
				{
					EnableSystem<InGameDebuggingSystem>();
					FlyCam.Create();
				}
				if (arg.StartsWith("--pmf.start-slot:"))
				{
					if (int.TryParse(arg.Substring(17), out int slot))
					{
						try
						{
							if (PMFLog.IsEnabled)
								PMFLog.Message("Loading save slot " + slot);

							var loadingSequence = GameObject.FindObjectOfType<LoadingSequence>();

							var destroyObject = new UnhollowerBaseLib.Il2CppReferenceArray<GameObject>(0);
							var titleSpace = GameObject.Find("TitleSpace");
							if (titleSpace != null)
							{
								destroyObject = new UnhollowerBaseLib.Il2CppReferenceArray<GameObject>(1);
								destroyObject[0] = titleSpace;
							}

							var enableObjects = new UnhollowerBaseLib.Il2CppReferenceArray<GameObject>(0);
							//TODO: enable the save and load buttons


							loadingSequence.StartLoading(slot, GameObject.Find("InfoText").GetComponent<TextMeshPro>(), destroyObject, enableObjects);

						}
						catch (Exception e)
						{
							if (PMFLog.IsEnabled)
								PMFLog.Error($"Could not start primitier in slot {slot} Exception:{e}");
						}


					}


				}

			}
			_hasParsedCommandlineArgs = true;
		}


		internal void FireEvent(PMFEventType type)
		{

			switch (type)
			{
				case PMFEventType.ApplicationStart:
					OnApplicationStart();
					if (!_IsStarted)
					{
						OnStart();
						_IsStarted = true;
					}
					break;

				case PMFEventType.ApplicationLateStart:
					OnApplicationLateStart();
					break;

				case PMFEventType.SceneLoad:
					OnSceneLoad();
					break;
				case PMFEventType.RealyLateStart:
					OnRealyLateStart();
					break;

				case PMFEventType.Update:
					OnUpdate();
					break;
				case PMFEventType.GUI:
					OnGUI();
					break;

				case PMFEventType.ApplicationQuit:
					OnApplicationQuit();
					break;


				case PMFEventType.SystemEnabled:
					OnSystemEnabled();
					if (!_IsStarted && Mod.IsApplicationStarted)
					{
						OnStart();
						_IsStarted = true;
					}
					break;
				case PMFEventType.SystemDisabled:
					OnSystemDisabled();
					break;

			}

		}

		public virtual void OnApplicationStart() { }
		public virtual void OnApplicationLateStart() { }

		public virtual void OnSceneLoad() { }

		public virtual void OnUpdate() { }
		public virtual void OnGUI() { }

		public virtual void OnApplicationQuit() { }


		public virtual void OnSystemDisabled() { }
		public virtual void OnSystemEnabled() { }

		public virtual void OnStart() { }

		public virtual void OnRealyLateStart() { }

	}
}
