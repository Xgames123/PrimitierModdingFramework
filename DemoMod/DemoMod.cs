using Il2CppSystem;
using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using Il2CppSystem.IO;
using System.Text;
using UnityEngine;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using DemoMod.Substances;
using DemoMod.CustomObjects;

namespace DemoMod
{

	public class DemoMod : PrimitierMod
    {

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{

			base.OnSceneWasLoaded(buildIndex, sceneName);
	
			var demoMenu = InGameDebugTool.CreateMenu("Demo", "MainMenu");

			var spawnMenu = InGameDebugTool.CreateMenu("Spawn", "Demo");
			spawnMenu.CreateButton("Tree", new System.Action(() =>
			{
				CubeGenerator.GenerateTree(spawnMenu.transform.position, 1f, CubeGenerator.TreeType.Conifer);
			}));
			spawnMenu.CreateButton("Custom Tree", new System.Action(() =>
			{
				CustomThreeGenerator.Generate(spawnMenu.transform.position, 1f);
			}));
			spawnMenu.CreateButton("Drone", new System.Action(()=>
			{
				CubeGenerator.GenerateDrone(spawnMenu.transform.position, 1f);
			}));

			spawnMenu.CreateButton("Hot Leaf", new System.Action(() =>
			{
				var cube = CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf);
				cube.GetComponent<Heat>().AddHeat(10000);
			}));

			spawnMenu.CreateButton("Custom", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.4f, 0.4f, 0.4f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
			}));
			
			

		}

		public override void OnRealyLateStart()
		{
			base.OnRealyLateStart();
			Localizer.table.AddEntry("SUB_CUSTOM", "Custom substance");
			PMFLog.Message(Localizer.GetLocalizedString("SUB_CUSTOM"));
		}





		public override void OnApplicationStart()
		{
			base.OnApplicationStart();

			PMFSystem.EnableSystem<CustomAssetSystem>();
			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();
			PMFSystem.EnableSystem<CustomSubstanceSystem>();
			PMFSystem.EnableSystem<CustomAssetSystem>();

			PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly());
			
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
