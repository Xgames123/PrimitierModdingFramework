using HarmonyLib;
using Il2CppSystem;
using UnityEngine;

namespace PrimitierModdingFramework.CustomSaveFileData.Patches
{
	[HarmonyPatch(nameof(CubeGenerator), nameof(CubeGenerator.GenerateSavedChunk))]
	public class CubeGenerator_GenerateSavedChunkPatch
	{
		public static void Postfix(Vector2Int chunkPos)
		{
			PMFLog.Message("loaded modded saved chunk");

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
								var behaviourName = cube.behaviors[i];
								if(behaviourName == loadRequest.Savable.GetType().AssemblyQualifiedName)
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
