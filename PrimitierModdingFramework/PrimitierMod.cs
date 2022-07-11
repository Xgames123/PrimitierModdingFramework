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
		internal bool IsApplicationStarted { get; private set; } = false;

		private bool RealyLateStartCalled = false;
		private bool OnSceneWasLoadedCalled = false;

		/// <summary>
		/// Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
		/// When overriding call base.OnSceneWasLoaded() before you do anything.
		/// </summary>
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			PMFSystem.FireEventOnSystems(PMFEventType.SceneLoad);
			OnSceneWasLoadedCalled = true;
			CustomSubstanceBuilder.BuildAll();
		}


		public override void OnGUI()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.GUI);
			base.OnGUI();
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

			HarmonyInstance.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());

		}

		/// <summary>
		/// Runs after OnApplicationStart.
		/// When overriding call base.OnApplicationLateStart() before you do anything.
		/// </summary>
		public override void OnApplicationLateStart()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.ApplicationLateStart);
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


		/// <summary>
		/// Runs after OnSceneWasLoaded
		/// When overriding call base.OnRealyLateStart() before you do anything.
		/// </summary>
		public virtual void OnRealyLateStart()
		{
			PMFSystem.FireEventOnSystems(PMFEventType.RealyLateStart);

			var args = Environment.GetCommandLineArgs();
			if (args.Contains("--pmf.flycam"))
			{
				
			}
			foreach (var arg in args)
			{
				if (arg == "--pmf.flycam")
				{
					PMFSystem.EnableSystem<InGameDebuggingSystem>();
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
						catch(Exception e)
						{
							if (PMFLog.IsEnabled)
								PMFLog.Error($"Could not start primitier in slot {slot} Exception:{e}");
						}
						

					}


				}

			}

		}

	}
}
