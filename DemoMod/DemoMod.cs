using Il2CppSystem;
using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using Il2CppSystem.IO;
using System.Text;
using UnityEngine;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using DemoMod.CustomObjects;


namespace DemoMod
{

	public class DemoMod : PrimitierMod
    {

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{

			base.OnSceneWasLoaded(buildIndex, sceneName);
	
			var demoMenu = InGameDebugTool.CreateMenu("Demo", "MainMenu");

			var spawnEggsSettingsMenu = InGameDebugTool.CreateMenu("Spawn Eggs Settings", "Demo");
			var autoHatchToggleButton = spawnEggsSettingsMenu.CreateToggleButton("Auto hatch");
			autoHatchToggleButton.Value = SpawnEggSettings.AutoHatchEntry.Value;
			autoHatchToggleButton.AttachOnValueChanged(new System.Action(() =>
			{
				SpawnEggSettings.AutoHatchEntry.Value = autoHatchToggleButton.Value;
			}));


			var spawnMenu = InGameDebugTool.CreateMenu("Spawn", "Demo");

			var spawnEggsMenu = InGameDebugTool.CreateMenu("Eggs", "Spawn");


			foreach (SpawnEggType eggType in System.Enum.GetValues(typeof(SpawnEggType)))
			{
				spawnEggsMenu.CreateButton(SpawnEggGenerator.GetEggInfo(eggType).NameEn, new System.Action(() =>
				{
					SpawnEggGenerator.Generate(spawnEggsMenu.transform.position, 1f, eggType);
				}));
			}




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
				cube.GetComponent<Heat>().AddHeat(9000000);
			}));

			spawnMenu.CreateButton("Custom", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.4f, 0.4f, 0.4f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
			}));

			spawnMenu.CreateButton("Drone Spawn egg", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.15f, 0.1f), CustomSubstanceSystem.GetSubstanceByName("SUB_SPAWN_EGG_DRONE"));
			}));
			

		}

		public override void OnRealyLateStart()
		{
			base.OnRealyLateStart();
			FlyCam.Create();

			SpawnEggGenerator.Generate(new Vector3(0, 2, 0), 2f, SpawnEggType.GreenSlime);
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

			SpawnEggSettings.LoadFromMelonPreferences();
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
