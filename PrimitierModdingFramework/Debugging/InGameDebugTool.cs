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

		public GameObject Button;
		public CameraGrip Grip;
		
		private void Start()
		{
			Button = transform.Find("Button").gameObject;
			Grip = gameObject.AddComponent<CameraGrip>();
		}

		private void FixedUpdate()
		{
			//Sometimes the camera grip changes the objects scale
			gameObject.transform.localScale = new Vector3(1, 1, 1);
		}


		public static InGameDebugTool Spawn(Vector3 position)
		{
			var gameObject = new GameObject();
			gameObject.transform.parent = PMFHelper.SystemTransform;
			gameObject.name = "InGameDebugTool";
			gameObject.transform.position = position;
			gameObject.transform.localScale = new Vector3(1, 1, 1);
			gameObject.AddComponent<Rigidbody>();

			var pannel = CreatePannel(gameObject.transform);

			var button = CreateButton(gameObject.transform, new Vector2(0, 0));


			return gameObject.AddComponent<InGameDebugTool>();


		}

		private static GameObject CreatePannel(Transform parent)
		{
			var Pannel = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Pannel.transform.parent = parent;
			Pannel.transform.localScale = new Vector3(0.4f, 0.3f, 0.02f);
			Pannel.transform.localPosition = new Vector3(0, 0, 0);
			Pannel.GetComponent<MeshRenderer>().material.color = Color.black;


			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = Pannel.transform;
			var text = textGameObject.AddComponent<TextMeshPro>();
			text.text = "DEBUG TOOL";
			text.fontSize = 1f;
			text.color = Color.white;
			text.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1, 1, 1);
			textGameObject.transform.localPosition = new Vector3(0, 0.4f, -0.6f);

			return Pannel;
		}

		private static GameObject CreateButton(Transform parent, Vector2 pos)
		{
			var buttonGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			buttonGameObject.transform.parent = parent;
			buttonGameObject.name = "Button";
			buttonGameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.02f);
			buttonGameObject.transform.localPosition = new Vector3(pos.x, pos.y, -0.02f);
			buttonGameObject.GetComponent<MeshRenderer>().material.color = Color.red;
			buttonGameObject.AddComponent<PMFButton>();
			return buttonGameObject;
		}
	}
}
