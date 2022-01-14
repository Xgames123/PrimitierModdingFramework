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
		public static InGameDebugTool DebugTool = null;

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


		public static InGameDebugTool Respawn(Vector3 position)
		{
			if (DebugTool != null)
			{
				GameObject.Destroy(DebugTool.gameObject);
			}

			var gameObject = new GameObject();
			gameObject.transform.parent = PMFHelper.SystemTransform;
			gameObject.name = "InGameDebugTool";
			gameObject.transform.position = position;
			gameObject.transform.localScale = new Vector3(1, 1, 1);
			gameObject.AddComponent<Rigidbody>();

			var pannel = CreatePannel(gameObject.transform);

			var button1 = CreateButton(gameObject.transform, new Vector2(-0.1f, 0));
			var button2 = CreateButton(gameObject.transform, new Vector2(0.1f, 0));

			DebugTool = gameObject.AddComponent<InGameDebugTool>();

			return DebugTool;
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

			var buttonGameObject = new GameObject();
			buttonGameObject.transform.parent = parent;
			buttonGameObject.name = "Button";
			buttonGameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.02f);
			buttonGameObject.transform.localPosition = new Vector3(pos.x, pos.y, -0.02f);
			
			buttonGameObject.AddComponent<BoxCollider>();
			var button = buttonGameObject.AddComponent<PMFButton>();


			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = buttonGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			cube.GetComponent<MeshRenderer>().material.color = Color.grey;
			Destroy(cube.GetComponent<BoxCollider>());

			button.CubeTransform = cube.transform;

			return buttonGameObject;
		}
	}
}
