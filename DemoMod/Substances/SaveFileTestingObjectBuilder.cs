using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMod.CubeBehaviors;
using Newtonsoft.Json;
using PrimitierModdingFramework;
using PrimitierModdingFramework.SubstanceModding;
using UnityEngine;

namespace DemoMod.Substances
{
	public class SaveFileTestingObjectBuilder : CustomSubstanceBuilder
	{
		public override void OnBuild()
		{
			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Wheat);

			customSubstance.displayNameKey = "SUB_SFTO";
			customSubstance.strength = 999; //HP

			CustomSubstanceSystem.LoadCustomSubstance(customSubstance, new CustomSubstanceSettings()
			{
				EnName = "Save file testing object",
				JpName = "ファイルテストオブジェクトの保存",
				OnSubstanceInitialize = (CubeBase cubeBase) =>
				{
					var sfto = cubeBase.gameObject.AddComponent<SaveFileTestingObject>();

					sfto.value = JsonConvert.DeserializeObject<Color>(CustomWorldDataSystem.LoadCubeBehaviourData(cubeBase, nameof(SaveFileTestingObject)));
				}
			});

		}
	}
}
