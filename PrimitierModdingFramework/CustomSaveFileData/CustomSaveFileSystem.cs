using System;
using System.Collections.Generic;
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

		internal class LoadRequest
		{
			public ICustomSavable Savable;
			public UnityEngine.Vector3 Position;
			public string FullName;
			public bool Fulfilled = false;


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
