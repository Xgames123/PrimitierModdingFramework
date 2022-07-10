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

	public class DecayThingBuilder : CustomSubstanceBuilder
	{

		public override void OnBuild()
		{

			var customTexture = new Texture2D(1, 1);
			customTexture.filterMode = FilterMode.Point; //This is important if you don't want your textures to look blurry
			CustomAssetSystem.LoadImageFromEmbeddedResource(System.Reflection.Assembly.GetExecutingAssembly(), "DemoMod.Assets.Textures.CustomTexture.png", ref customTexture);

			var customMat = CustomSubstanceSystem.CreateCustomMaterial("Leaf");
			customMat.name = "CustomMat";
			customMat.color = Color.cyan;

			customMat.mainTexture = customTexture;


			CustomSubstanceSystem.LoadCustomMaterial(customMat);

			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Iron);

			customSubstance.displayNameKey = "SUB_CUSTOM";
			customSubstance.collisionSound = "RespawnPoint";
			customSubstance.material = "CustomMat";

			customSubstance.density = 0.1f;
			customSubstance.specificHeatCapacity = 100;
			customSubstance.stiffness = 20; //Damage
			customSubstance.strength = 999; //HP

			CustomSubstanceSystem.LoadCustomSubstance(customSubstance, new CustomSubstanceSettings()
			{
				EnName = "Decay thing",
				JpName = "腐敗の事",
				AddCustomCubeBehaviour = (CubeBase cubeBase) =>
				{
					return cubeBase.gameObject.AddComponent<Decay>();
				}
			});

		}


	}
}
