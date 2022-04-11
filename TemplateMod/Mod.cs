using Il2CppSystem;
using PrimitierModdingFramework;
using UnityEngine;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;

namespace TemplateMod
{

	public class Mod : PrimitierMod
    {


		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);
		}

		public override void OnApplicationStart()
		{
			base.OnApplicationStart();

			PMFSystem.EnableSystem<PMFHelper>();
		}
		
		public override void OnUpdate()
		{
			base.OnUpdate();
		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();
		}


	}
}
