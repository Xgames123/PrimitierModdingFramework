using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod.Substances
{
	public class DroneSpawnEggBuilder : CustomSubstanceBuilder
	{

		public override void OnBuild()
		{
			var spawnEgg = CustomSubstanceSystem.CreateCustomSubstance(Substance.Leaf);
			spawnEgg.displayNameKey = "SUB_SPAWN_EGG_DRONE";
			spawnEgg.density = 10;
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
					cubeBase.gameObject.AddComponent<CubeBehaviors.DroneSpawnEgg>();
				}
			});
		}
	}
}
