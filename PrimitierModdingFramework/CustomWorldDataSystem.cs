using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{


	public class CustomWorldDataSystem : PMFSystem
	{
		public static bool IsEnabled = false;

		public struct CubeAndCubeBehaviour
		{
			public Vector3 CubeGlobalPos;
			public Vector3 CubePos;
			public string BehaviourName;
		}

		public static Dictionary<CubeAndCubeBehaviour, string> CustomCubeBehaviourData = new Dictionary<CubeAndCubeBehaviour, string>();

		public override void OnSystemEnabled()
		{
			base.OnSystemEnabled();
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			base.OnSystemDisabled();
			IsEnabled = false;
		}

		public override void OnStart()
		{
			base.OnStart();
		}

		public static void WriteCubeBehavioursDataToSaveFile()
		{
			foreach (var cubeBehaviourPair in CustomCubeBehaviourData.Keys)
			{
				WriteCubeBehaviourDataToSaveFile(cubeBehaviourPair, CustomCubeBehaviourData[cubeBehaviourPair]);
			}
		}
		private static void WriteCubeBehaviourDataToSaveFile(CubeAndCubeBehaviour key, string data)
		{
			
			var cube = key.CubeGlobalPos;
			var chunkPos = CubeGenerator.WorldToChunkPos(cube);

			foreach (var cubeGroup in SaveAndLoad.chunkDict[chunkPos])
			{
				foreach (var cubeData in cubeGroup.cubes)
				{
					if (key.CubePos == cubeData.pos)
					{
						var index = cubeData.behaviors.IndexOf(key.BehaviourName);
						if (index != -1)
						{
							cubeData.states[index] = data;
						}
						else
						{
							cubeData.behaviors.Add(key.BehaviourName);
							cubeData.states.Add(data);
						}


						return;
					}



				}
			}
		}


		public static void LoadCustomCubeBehavioursDataFromSaveFile(Vector2Int chunkPos)
		{
			foreach (var cubeGroup in SaveAndLoad.chunkDict[chunkPos])
			{
				foreach (var cubeData in cubeGroup.cubes)
				{
					for (int i = 0; i < cubeData.behaviors.Count; i++)
					{
						CustomCubeBehaviourData.Add(new CubeAndCubeBehaviour() { CubePos = cubeData.pos, CubeGlobalPos = cubeGroup.pos + cubeData.pos, BehaviourName = cubeData.behaviors[i] }, cubeData.states[i]);
					}

				}
			}
		}



		public static string LoadCubeBehaviourData(CubeBase cube, string behaviourName)
		{
			
			var retValue = CustomCubeBehaviourData[new CubeAndCubeBehaviour() { CubeGlobalPos = cube.transform.position, CubePos = cube.transform.localPosition, BehaviourName = behaviourName }];
			if(retValue != null)
			{
				return retValue;
			}
			var chunkPos = CubeGenerator.WorldToChunkPos(cube.transform.position);

			LoadCustomCubeBehavioursDataFromSaveFile(chunkPos);

			retValue = CustomCubeBehaviourData[new CubeAndCubeBehaviour() { CubeGlobalPos = cube.transform.position, CubePos = cube.transform.localPosition, BehaviourName = behaviourName }];
			if (retValue != null)
			{
				return retValue;
			}
			return null;
		}


		public static void StoreCubeBehaviourData(CubeBase cube, string behaviourName, string data)
		{
			CustomCubeBehaviourData.Add(new CubeAndCubeBehaviour() { CubePos = cube.transform.localPosition, CubeGlobalPos = cube.transform.position, BehaviourName = behaviourName }, data);
		}


	}
}
