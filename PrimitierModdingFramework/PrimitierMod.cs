using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework
{

	/// <summary>
	/// Main entry point for a PrimitierMod
	/// </summary>
	public abstract class PrimitierMod : MelonMod
	{
		public bool IsApplicationStarted { get; private set; } = false;
		public bool OnSceneWasLoadedCalled { get; private set; } = false;
		public bool RealyLateStartCalled { get; private set; } = false;

		/// <summary>
		/// The Id of the mod (Author.Name_version)
		/// </summary>
		public string ModId { get { return $"{Info.Author}.{Info.Name}_{Info.Version}"; } }

		/// <summary>
		/// Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
		/// When overriding call base.OnSceneWasLoaded() before you do anything.
		/// </summary>
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.SceneLoad);
			OnSceneWasLoadedCalled = true;
			CustomSubstanceBuilder.BuildAll();
		}


		public override void OnGUI()
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.GUI);
			base.OnGUI();
		}

		/// <summary>
		/// Runs after game Initialization
		/// When overriding call base.OnApplicationStart() before you do anything.
		/// </summary>
		public override void OnApplicationStart()
		{
			PMFSystem.RegisterMod(this);
			PMFSystem.FireEventOnSystems(this, PMFEventType.ApplicationStart);

			IsApplicationStarted = true;

			var assembly = System.Reflection.Assembly.GetExecutingAssembly();
			HarmonyInstance.PatchAll(assembly);

			PMFLog.Message("PMF: current pmf version: " + assembly.GetName().Version);
		}

		/// <summary>
		/// Runs after OnApplicationStart.
		/// When overriding call base.OnApplicationLateStart() before you do anything.
		/// </summary>
		public override void OnApplicationLateStart()
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.ApplicationLateStart);
		}

		public override void OnFixedUpdate()
		{
			if (!RealyLateStartCalled && OnSceneWasLoadedCalled)
			{
				RealyLateStartCalled = true;
				OnRealyLateStart();
			}
		}


		/// <summary>
		/// Runs once per frame.
		/// When overriding call base.OnUpdate() before you do anything.
		/// </summary>
		public override void OnUpdate()
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.Update);
		}




		/// <summary>
		/// Runs when the Game is told to Close.
		/// When overriding call base.OnApplicationQuit() before you do anything.
		/// </summary>
		public override void OnApplicationQuit()
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.ApplicationQuit);
			IsApplicationStarted = false;
		}


		/// <summary>
		/// Runs after OnSceneWasLoaded
		/// When overriding call base.OnRealyLateStart() before you do anything.
		/// </summary>
		public virtual void OnRealyLateStart()
		{
			PMFSystem.FireEventOnSystems(this, PMFEventType.RealyLateStart);
			PMFSystem.TryParseCommandlineArgs();
		}

	}
}
