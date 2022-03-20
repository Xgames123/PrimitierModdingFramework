using Il2CppSystem;
using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using Il2CppSystem.IO;
using System.Text;
using UnityEngine;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;

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
				ObjectGenerationSystem.GenerateTree(spawnMenu.transform.position, 0.1f, CubeGenerator.TreeType.Conifer);
			}));
			spawnMenu.CreateButton("Kill Tree", new System.Action(() =>
			{
				GenerateKillTree(spawnMenu.transform.position);
			}));
			spawnMenu.CreateButton("Drone", new System.Action(()=>
			{
				CubeGenerator.GenerateDrone(spawnMenu.transform.position, 0.1f);
			}));
			spawnMenu.CreateButton("Insect", new System.Action(() =>
			{
				Insect.Generate(spawnMenu.transform.position);
			}));

			spawnMenu.CreateButton("Leaf", new System.Action(() =>
			{
				var cube = ObjectGenerationSystem.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf);
				cube.GetComponent<Heat>().AddHeat(10000);
			}));

			spawnMenu.CreateButton("Custom", new System.Action(() =>
			{
				ObjectGenerationSystem.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
			}));


			

			var customMat = CustomSubstanceSystem.CreateCustomMaterial("Leaf");
			customMat.name = "CustomMat";
			customMat.color = new Color(0, 1, 1);
			

			CustomSubstanceSystem.LoadCustomMaterial(customMat);

			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Iron);

			customSubstance.displayNameKey = "SUB_CUSTOM";
			customSubstance.collisionSound = "RespawnPoint";
			customSubstance.isEdible = true;
			customSubstance.material = "CustomMat";
			customSubstance.stiffness = 99999999; //Damage
			customSubstance.strength = 999999999999999999; //HP


			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);


		
		
		}

		public override void OnRealyLateStart()
		{
			base.OnRealyLateStart();

			//GenerateKillTree(new Vector3(0, 0, 0));
			
			

			FlyCam.Create();
		}

		private static void GenerateKillTree(Vector3 pos)
		{
			const float treeThicness = 0.4f;
			const float stemHeight = 3f;
			const float leafSize = 2f;
			const float leafHeight = 2f;

			var stem = ObjectGenerationSystem.GenerateCube(new Vector3(pos.x, pos.y+(stemHeight/2), pos.z), new Vector3(treeThicness, stemHeight, treeThicness), Substance.Wood);
			var leaf = ObjectGenerationSystem.GenerateCube(new Vector3(0, stemHeight + leafHeight/2, 0), new Vector3(leafSize, leafHeight, leafSize), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));


			//TODO find out what CubeConnector.Anchor does (can't do it now because my oculus account is still not working)

			leaf.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Temporary;
			stem.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Temporary;
			stem.GetComponent<CubeConnector>().Connect(leaf.GetComponent<CubeConnector>());

		}




		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<Insect>(typeof(ICubeBehavior));

			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();
			PMFSystem.EnableSystem<CustomSubstanceSystem>();
			PMFSystem.EnableSystem<CustomAssetSystem>();
			PMFSystem.EnableSystem<ObjectGenerationSystem>();
		}
		public override void OnUpdate()
		{
			base.OnUpdate();

			if (Input.GetKeyUp(KeyCode.Space))
			{
				Insect.Generate(new Vector3(0, 2, 0));
			}

		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();

		}



	}
}
