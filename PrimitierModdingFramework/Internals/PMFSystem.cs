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
		public static List<PMFSystem> RegisterdSystems = new List<PMFSystem>();


		public static void FireEventOnRegisterd(PMFEventType type)
		{
			foreach (var system in RegisterdSystems)
			{
				system.FireEvent(type);
			}

		}

		public static void RegisterSystem(PMFSystem system)
		{
			RegisterdSystems.Add(system);
		}

		public static void RegisterSystems(params PMFSystem[] systems)
		{
			RegisterdSystems.AddRange(systems);
		}

		public void FireEvent(PMFEventType type)
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
