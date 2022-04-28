using DemoMod.CubeBehaviors;
using DemoMod.CustomObjects;
using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.Substances
{

	//If you are here to learn the basics of PMF look at the DecayThing. This class is more complicated
	public class SpawnEggBuilder : CustomSubstanceBuilder
	{


		public override void OnBuild()
		{
			var eggTexture = LoadEggTexture();


			foreach (var eggdef in SpawnEggGenerator.EggDefs)
			{
				var shortName = eggdef.NameEn.Replace(" ", "_");

				var mat = CustomSubstanceSystem.CreateCustomMaterial("DryGrass");
				mat.name = "SpawnEggMat__"+ shortName;
				mat.mainTexture = eggTexture;
				mat.color = eggdef.Color;
				CustomSubstanceSystem.LoadCustomMaterial(mat);

				var spawnEgg = CustomSubstanceSystem.CreateCustomSubstance(Substance.Stone);
				spawnEgg.displayNameKey = "SUB_SPAWN_EGG_"+ shortName.ToUpper();
				spawnEgg.density = 0.5f;
				spawnEgg.material = "SpawnEggMat__" + shortName;
				spawnEgg.hardness = 1;
				spawnEgg.strength = 1;
				spawnEgg.stiffness = 10;


				CustomSubstanceSystem.LoadCustomSubstance(spawnEgg, new CustomSubstanceSettings()
				{
					EnName = $"Spawn egg ({eggdef.NameEn})",
					JpName = $"産卵用卵（{eggdef.NameJp}）",

				});
			}

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
