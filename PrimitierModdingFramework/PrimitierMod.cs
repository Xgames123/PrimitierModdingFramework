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
		/// Overwrite this method and put ClassInjector.RegisterTypeInIl2Cpp<MyCustomComponent>(); in it for all your custom MonoBehaviors
		/// </summary>
		public virtual void OnRegisterCustomTypes()
		{

		}

		public override void OnApplicationStart()
		{
			OnRegisterCustomTypes();
		}

	}
}
