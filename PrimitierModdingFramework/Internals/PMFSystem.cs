using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.Internals
{
	public enum PMFEventType
	{
		ApplicationStart,
		ApplicationLateStart,
		SceneLoad,

	}


	public abstract class PMFSystem
	{
		internal static List<PMFSystem> RegisterdSystems = new List<PMFSystem>();

		internal static PrimitierMod Mod { get; private set; }

		internal static void Startup(PrimitierMod mod)
		{
			Mod = mod;
		}


		internal static void FireEventOnSystems(PMFEventType type)
		{
			foreach (var system in RegisterdSystems)
			{
				system.FireEvent(type);
			}

		}

		internal static void RegisterSystem(PMFSystem system)
		{
			RegisterdSystems.Add(system);
		}

		internal static void RegisterSystems(params PMFSystem[] systems)
		{
			RegisterdSystems.AddRange(systems);
		}

		internal void FireEvent(PMFEventType type)
		{
			switch (type)
			{
				case PMFEventType.ApplicationStart:
					OnApplicationStart();
					break;

				case PMFEventType.ApplicationLateStart:
					OnApplicationLateStart();
					break;

				case PMFEventType.SceneLoad:
					OnSceneLoad();
					break;

			}

		}

		public virtual void OnApplicationStart() { }
		
		public virtual void OnApplicationLateStart() { }

		public virtual void OnSceneLoad() { }

	}
}
