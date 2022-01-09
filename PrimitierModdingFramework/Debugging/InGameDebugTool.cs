using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugTool : MonoBehaviour
	{
		public InGameDebugTool(IntPtr ptr) : base(ptr){ }


		public static InGameDebugTool Spawn(Vector3 position)
		{
			var gameObject = CubeGenerator.GenerateCube(position, new Vector3(0.4f, 0.3f, 0.02f), Substance.AncientPlastic);

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = gameObject.transform;
			var text = textGameObject.AddComponent<TextMeshPro>();
			text.text = "DEBUG TOOL";
			text.fontSize = 0.4f;
			text.color = Color.white;
			text.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localPosition = new Vector3(0, 0.4f, -0.6f);

			var buttonGameObject = CubeGenerator.GenerateCube(position+new Vector3(0, 0, -0.6f), new Vector3(0.1f, 0.1f, 0.02f), Substance.AncientPlastic);
			buttonGameObject.GetComponent<CubeAppearance>().TintColor(Color.red, 1);
			buttonGameObject.GetComponent<CubeConnector>().Connect(gameObject.GetComponent<CubeConnector>());

			return gameObject.AddComponent<InGameDebugTool>();

			 
		}

		private void Start()
		{


		}


	}
}
