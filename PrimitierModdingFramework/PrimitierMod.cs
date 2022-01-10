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
			PMFSystem.FireEventOnRegisterd(PMFEventType.SceneLoad);
			
		}

		/// <summary>
		/// Runs after game Initialization
		/// When overriding call base.OnApplicationStart() before you do anything
		/// </summary>
		public override void OnApplicationStart()
		{
			PMFSystem.RegisterSystem(new PMFTypeInjector());
			PMFSystem.RegisterSystem(new PMFHelper());
			

			PMFSystem.FireEventOnRegisterd(PMFEventType.ApplicationStart);
		}

		/// <summary>
		/// Runs after OnApplicationStart.
		/// When overriding call base.OnApplicationLateStart() before you do anything
		/// </summary>
		public override void OnApplicationLateStart()
		{
			PMFSystem.FireEventOnRegisterd(PMFEventType.ApplicationLateStart);
		}

	}
}
