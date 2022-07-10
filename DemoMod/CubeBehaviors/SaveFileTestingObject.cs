using Newtonsoft.Json;
using PrimitierModdingFramework;
using PrimitierModdingFramework.SubstanceModding;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CubeBehaviors
{
	public class SaveFileTestingObject : MonoBehaviour, ICustomCubeBehaviour, ICustomSavable
	{
		public class SaveData
		{
			public Color32 overlayColor;

		}

		public SaveFileTestingObject(System.IntPtr ptr) : base(ptr)
		{

		}

		private void Start()
		{
			
		}


		public string Save()
		{
			PMFLog.Message("Saveing...");
			return JsonConvert.SerializeObject(new SaveData() { overlayColor = GetComponent<MeshRenderer>().material.color });
		}

		public void Load(string json)
		{
			PMFLog.Message("Loading... "+json);

			

			var saveData = JsonConvert.DeserializeObject<SaveData>(json);
			if (saveData != null)
			{
				GetComponent<MeshRenderer>().material.color = saveData.overlayColor;

				return;
			}
			GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

		}
	}
}
