using Il2CppNewtonsoft.Json;
using MelonLoader.TinyJSON;
using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{
	public class CustomSaveFileSystem : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		internal static List<LoadRequest> LoadRequests = new List<LoadRequest>();
		internal static int LastParsedSaveSlot = -1;

		internal class LoadRequest
		{
			public ICustomSavable Savable;
			public UnityEngine.Vector3 Position;
			public string FullName;
			public bool Fulfilled = false;


		}

		public static void WriteSaveMetadata(int slot)
		{
			var fullPathToMetaFile = Path.Combine(SaveAndLoad.GetSaveDirectory(), SaveAndLoad.mapFileDirectoryName, SaveAndLoad.mapFileName+ slot + ".pmf.json");
			PMFLog.Message("Writing meta data file");
			var metaData = new MetaDataFile();
			foreach (var mod in PMFSystem.RegisteredMods)
			{
				var modMetaData = new ModMetaData()
				{
					Id = Mod.ModId,
				};

				if (CustomSubstanceSystem.IsEnabled)
				{

					foreach (var settings in CustomSubstanceSystem.CustomSubstanceSettings.Values)
					{
						if (settings.ModId == mod.ModId)
						{
							modMetaData.SubstanceToIndexMaps.Add(new SubstanceToIndexMap() { Name = settings.NameKey, Index = settings.Index });
						}
					}
				}


				metaData.Mods.Add(modMetaData);
			}

			var json = JSON.Dump(metaData);
			try
			{
				File.WriteAllText(fullPathToMetaFile, json);
			}catch(Exception e)
			{
				PMFLog.Error($"Could not write save file meta data \n\n {e}");
			}


			
		}
		public static SaveAndLoad.SaveData ReadMetaDataFile(int slot, SaveAndLoad.SaveData saveData)
		{
			var fullPathToMetaFile = Path.Combine(SaveAndLoad.GetSaveDirectory(), SaveAndLoad.mapFileDirectoryName, SaveAndLoad.mapFileName + slot + ".pmf.json");
			PMFLog.Message("Reading meta data file");
			string json = null;
			try
			{
				json = File.ReadAllText(fullPathToMetaFile);
			}
			catch (Exception e)
			{
				PMFLog.Error($"Could not read save meta data \n\n {e}");
			}
			if (json == null)
				return null;

			var jsonVar = JSON.Load(json);
			JSON.MakeInto(jsonVar, out MetaDataFile metaDataFile);

			var subToIndexMaps = new List<SubstanceToIndexMap>(); 
			foreach (var mod in metaDataFile.Mods)
			{
				subToIndexMaps.AddRange(mod.SubstanceToIndexMaps);
			}
			return SwapSubstances(saveData, subToIndexMaps);
		}

		public static SaveAndLoad.SaveData SwapSubstances(SaveAndLoad.SaveData data, List<SubstanceToIndexMap> maps)
		{
			var mapDict = new Dictionary<Substance, Substance>();
			foreach (var map in maps)
			{
				mapDict.Add((Substance)map.Index, CustomSubstanceSystem.GetSubstanceByName(map.Name));

			}


			foreach (var chunk in data.chunks)
			{
				foreach (var group in chunk.groups)
				{
					foreach (var cube in group.cubes)
					{
						if (mapDict.TryGetValue(cube.substance, out var newSubstance))
						{
							cube.substance = newSubstance;
						}

					}

				}

			}
			return data;
		}

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

		public static void RequestLoad(ICustomSavable savable)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(CustomSaveFileSystem));

			LoadRequests.Add(new LoadRequest() { Savable = savable, Position = (savable as MonoBehaviour).transform.localPosition, FullName = savable.GetType().FullName });
		}

	}
	
}
