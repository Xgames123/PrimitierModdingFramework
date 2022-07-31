using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.CustomSaveFileData
{
	public class CustomSaveFileSystem
	{
		internal class LoadRequest
		{
			public ICustomSavable Savable;
			public UnityEngine.Vector3 Position;
			public bool Fulfilled = false;
		}

		internal static List<LoadRequest> LoadRequests = new List<LoadRequest>();

		public static void RequestLoad(ICustomSavable savable)
		{
			LoadRequests.Add(new LoadRequest() { Savable = savable, Position = (savable as MonoBehaviour).transform.localPosition });
		}

	}
	
}
