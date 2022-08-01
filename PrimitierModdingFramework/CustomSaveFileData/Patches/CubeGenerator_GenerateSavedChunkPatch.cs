using HarmonyLib;
using Il2CppSystem;
using System.Reflection;
using UnityEngine;

namespace PrimitierModdingFramework.CustomSaveFileData.Patches
{
	[HarmonyPatch(typeof(CubeGenerator), nameof(CubeGenerator.GenerateSavedChunk))]
	public class CubeGenerator_GenerateSavedChunkPatch
	{
		public static void Postfix(Vector2Int chunkPos)
		{

			var chunk = SaveAndLoad.chunkDict[chunkPos];
			foreach (var group in chunk)
			{
				foreach (var cube in group.cubes)
				{
					foreach (var loadRequest in CustomSaveFileSystem.LoadRequests)
					{
						if (loadRequest.Fulfilled)
							continue;

						if (loadRequest.Position == cube.pos)
						{
							for (int i = 0; i < cube.behaviors.Count; i++)
							{
								var splitName = cube.behaviors[i].Split(',');
								if (splitName.Length == 0)
									continue;

								if(splitName[0] == loadRequest.FullName)
								{
									var state = cube.states[i];

									loadRequest.Savable.Load(state);
									loadRequest.Fulfilled = true;
								}

							}

						}

					}
				}

			}

			CustomSaveFileSystem.LoadRequests.Clear();
		}

	}
}
