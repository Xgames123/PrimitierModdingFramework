using DemoMod.CubeBehaviors;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CustomObjects
{
	public enum SpawnEggShape
	{
		Normal,
		Large,
	}
	public enum SpawnEggType
	{
		Drone,
		BlueSlime,
		RedSlime,
		GreenSlime,
	}

	public struct SpawnEggInfo
	{
		public string NameEn;
		public string NameJp;
		public Color Color;
		public Action<SpawnEgg> OnSpawn;
		public SpawnEggShape Size;

		public SpawnEggInfo(string nameEn, string nameJp, Color color, SpawnEggShape size, Action<SpawnEgg> onSpawn)
		{
			NameEn = nameEn;
			NameJp = nameJp;
			Color = color;
			OnSpawn = onSpawn;
			Size = size;
		}
	}

	//If you are here to learn the basics of PMF look at the DecayThing. This class is more complicated
	public static class SpawnEggGenerator
	{

	

		public static SpawnEggInfo[] EggDefs = new SpawnEggInfo[]
		{
			new SpawnEggInfo("Drone", "ドローン", new Color(0.2f, 0.2f, 0.2f), SpawnEggShape.Normal, (SpawnEgg spawnEgg) => { CubeGenerator.GenerateDrone(spawnEgg.transform.position, 0.1f); }),
			new SpawnEggInfo("Blue slime", "ブルースライム",new Color(0, 0.4f, 1), SpawnEggShape.Normal, (SpawnEgg spawnEgg) => { CubeGenerator.GenerateSlime(spawnEgg.transform.position, 0.1f); }),
			new SpawnEggInfo("Red slime", "ベリースライム", Color.red, SpawnEggShape.Normal, (SpawnEgg spawnEgg) => { CubeGenerator.GenerateRedSlime(spawnEgg.transform.position, 0.1f); }),
			new SpawnEggInfo("Green slime", "グリーンスライム", Color.green, SpawnEggShape.Normal, (SpawnEgg spawnEgg) => { CubeGenerator.GenerateGreenSlime(spawnEgg.transform.position, 0.1f); }),
		};

		public static SpawnEggInfo GetEggInfo(SpawnEggType type)
		{
			return EggDefs[(int)type];
		}


		public static GameObject Generate(Vector3 spaceCenter, float spaceLength, SpawnEggType type)
		{
			var eggDef = EggDefs[(int)type];


			Vector3 eggSize;
			switch (eggDef.Size)
			{
				case SpawnEggShape.Normal:
					eggSize = new Vector3(0.1f, 0.15f, 0.1f);
					break;
				case SpawnEggShape.Large:
					eggSize = new Vector3(0.2f, 0.3f, 0.2f);
					break;

				default:
					goto case SpawnEggShape.Normal;
			}


			var margin = Mathf.Max(0, spaceLength - eggSize.y);
			var pos = spaceCenter + new Vector3((CubeGenerator.chunkRandom.Value - 0.5f) * margin, 0, (CubeGenerator.chunkRandom.Value - 0.5f) * margin);

			var subName = "SUB_SPAWN_EGG_" + eggDef.NameEn.Replace(" ", "_").ToUpper();

		 	var eggGameObject = CubeGenerator.GenerateCube(pos, eggSize, CustomSubstanceSystem.GetSubstanceByName(subName));

			var spawnEggComponent = eggGameObject.AddComponent<SpawnEgg>();
			spawnEggComponent.OnSpawn = eggDef.OnSpawn;

			return eggGameObject;
			
		}

	}
}
