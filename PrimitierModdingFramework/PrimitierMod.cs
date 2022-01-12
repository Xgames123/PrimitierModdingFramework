using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using PrimitierModdingFramework.Internals;
namespace PrimitierModdingFramework
{

	public abstract class PrimitierMod : MelonMod
	{
		/// <summary>
		/// Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
		/// When overriding call base.OnSceneWasLoaded() before you do anything
		/// </summary>
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			PMFSystem.FireEventOnSystems(PMFEventType.SceneLoad);
			
		}

		/// <summary>
		/// Runs after game Initialization
		/// When overriding call base.OnApplicationStart() before you do anything
		/// </summary>
		public override void OnApplicationStart()
		{
			PMFSystem.Startup(this);
			PMFSystem.RegisterSystem(new PMFLog());
			PMFSystem.RegisterSystem(new PMFTypeInjector());
			PMFSystem.RegisterSystem(new PMFHelper());
			

			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationStart);
		}

		/// <summary>
		/// Runs after OnApplicationStart.
		/// When overriding call base.OnApplicationLateStart() before you do anything
		/// </summary>
		public override void OnApplicationLateStart()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationLateStart);
		}


	}
}
