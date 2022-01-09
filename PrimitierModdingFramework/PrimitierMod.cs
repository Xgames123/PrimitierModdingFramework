using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
namespace PrimitierModdingFramework
{

	public abstract class PrimitierMod : MelonMod
	{
		/// <summary>
		/// Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
		/// When overwriting call base.OnSceneWasLoaded() before you do anything
		/// </summary>
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			PMFHelper.OnSceneLoad();
			PlayerHelper.OnSceneLoad();
			
		}

		/// <summary>
		/// Overwrite this method and put ClassInjector.RegisterTypeInIl2Cpp<MyCustomComponent>(); in it for all your custom MonoBehaviors
		/// </summary>
		public virtual void OnRegisterCustomTypes()
		{

		}

		/// <summary>
		/// Runs after game Initialization
		/// When overwriting call base.OnApplicationStart() before you do anything
		/// </summary>
		public override void OnApplicationStart()
		{

			OnRegisterCustomTypes();
			
		}

	}
}
