using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
namespace PrimitierModdingFramework
{

	/// <summary>
	/// Main entry point for a PrimitierMod
	/// </summary>
	public abstract class PrimitierMod : MelonMod
	{
		internal bool IsApplicationStarted { get; private set; } = false;

		/// <summary>
		/// Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
		/// When overriding call base.OnSceneWasLoaded() before you do anything.
		/// </summary>
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			PMFSystem.FireEventOnSystems(PMFEventType.SceneLoad);
			
		}

		/// <summary>
		/// Runs after game Initialization
		/// When overriding call base.OnApplicationStart() before you do anything.
		/// </summary>
		public override void OnApplicationStart()
		{
			PMFSystem.Startup(this);

			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationStart);
			IsApplicationStarted = true;
		}

		/// <summary>
		/// Runs after OnApplicationStart.
		/// When overriding call base.OnApplicationLateStart() before you do anything.
		/// </summary>
		public override void OnApplicationLateStart()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationLateStart);
		}

		/// <summary>
		/// Runs once per frame.
		/// When overriding call base.OnUpdate() before you do anything.
		/// </summary>
		public override void OnUpdate()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.Update);
		}


		/// <summary>
		/// Runs when the Game is told to Close.
		/// When overriding call base.OnApplicationQuit() before you do anything.
		/// </summary>
		public override void OnApplicationQuit()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationQuit);
			IsApplicationStarted = false;
		}


	}
}
