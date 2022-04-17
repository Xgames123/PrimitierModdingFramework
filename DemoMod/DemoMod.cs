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
				CubeGenerator.GenerateTree(spawnMenu.transform.position, 0.1f, CubeGenerator.TreeType.Conifer);
			}));
			spawnMenu.CreateButton("Custom Tree", new System.Action(() =>
			{
				GenerateCustomTree(spawnMenu.transform.position);
			}));
			spawnMenu.CreateButton("Drone", new System.Action(()=>
			{
				CubeGenerator.GenerateDrone(spawnMenu.transform.position, 0.1f);
			}));

			spawnMenu.CreateButton("Leaf", new System.Action(() =>
			{
				var cube = CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf);
				cube.GetComponent<Heat>().AddHeat(10000);
			}));

			spawnMenu.CreateButton("Custom", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(spawnMenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
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
			customSubstance.density = 0.1f;
			customSubstance.stiffness = 99999999; //Damage
			customSubstance.strength = 999999999999999999; //HP

			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);


		
		}

		public override void OnRealyLateStart()
		{
			base.OnRealyLateStart();


			//FlyCam.Create();
		}

		private static void GenerateCustomTree(Vector3 pos)
		{
			const float treeThicness = 0.1f;
			const float stemHeight = 1f;
			const float leafSize = 0.5f;
			const float leafHeight = 0.8f;

			var stem = CubeGenerator.GenerateCube(new Vector3(pos.x, pos.y+(stemHeight/2), pos.z), new Vector3(treeThicness, stemHeight, treeThicness), Substance.Wood);
			var leaf = CubeGenerator.GenerateCube(pos+new Vector3(0, stemHeight + leafHeight/2, 0), new Vector3(leafSize, leafHeight, leafSize), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));


			leaf.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Permanent;
			stem.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Permanent;
			stem.GetComponent<CubeConnector>().Connect(leaf.GetComponent<CubeConnector>());

		}




		public override void OnApplicationStart()
		{
			base.OnApplicationStart();


			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();
			PMFSystem.EnableSystem<CustomSubstanceSystem>();
			PMFSystem.EnableSystem<CustomAssetSystem>();
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
