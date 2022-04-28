using DemoMod.CubeBehaviors;
using PrimitierModdingFramework;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.Substances
{
	public class DroneSpawnEggBuilder : CustomSubstanceBuilder
	{

		public override void OnBuild()
		{

			var mat = CustomSubstanceSystem.CreateCustomMaterial("DryGrass");
			mat.name = "SpawnEggMat";
			mat.mainTexture = LoadEggTexture();
			mat.color = Color.white;
			CustomSubstanceSystem.LoadCustomMaterial(mat);

			var spawnEgg = CustomSubstanceSystem.CreateCustomSubstance(Substance.Leaf);
			spawnEgg.displayNameKey = "SUB_SPAWN_EGG_DRONE";
			spawnEgg.density = 0.5f;
			spawnEgg.material = "SpawnEggMat";
			spawnEgg.hardness = 1;
			spawnEgg.strength = 1;
			spawnEgg.stiffness = 10;
			spawnEgg.collisionSound = "stone1";


			CustomSubstanceSystem.LoadCustomSubstance(spawnEgg, new CustomSubstanceSettings() 
			{
				EnName = "Spawn egg drone",
				JpName = "産卵用ドローン",
				OnSubstanceInitialize = (CubeBase cubeBase) => 
				{
					cubeBase.gameObject.AddComponent<DroneSpawnEgg>();
				}
			});
		}


		private Texture2D LoadEggTexture()
		{
			var eggTexture = new Texture2D(1, 1);
			eggTexture.filterMode = FilterMode.Point; //This is important if you don't want your textures to look blurry
			CustomAssetSystem.LoadImageFromEmbeddedResource(System.Reflection.Assembly.GetExecutingAssembly(), "DemoMod.Assets.Textures.EggTexture.png", ref eggTexture);
			return eggTexture;
		}

	}
}
