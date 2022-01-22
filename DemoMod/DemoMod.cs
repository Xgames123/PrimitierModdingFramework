using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				CubeGenerator.GenerateTree(spawnMenu.transform.position, 0.1f, CubeGenerator.TreeType.Conifer);
			}));

			spawnMenu.CreateButton("Leaf", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf, temperature:999);
			}));

			spawnMenu.CreateButton("Custom", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"), temperature: 999);
			}));


			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Iron);
			customSubstance.displayNameKey = "SUB_CUSTOM";
			customSubstance.isEdible = true;
			customSubstance.material = "Slime";
			customSubstance.stiffness = 99999999;

			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);

		}



		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();
			PMFSystem.EnableSystem<CustomSubstanceSystem>();
			

		}
		public override void OnUpdate()
		{
			base.OnUpdate();


		}

		public override void OnFixedUpdate()
		{
		

			if (Input.GetKey(KeyCode.A))
			{

				CubeGenerator.GenerateCube(new Vector3(1, 1, 1), new Vector3(0.1f, 0.1f, 0.1f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
			}

			

		}



	}
}
