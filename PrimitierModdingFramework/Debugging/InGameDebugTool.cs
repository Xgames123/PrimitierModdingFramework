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

		public static InGameDebugTool Spawn(Vector3 position)
		{
			
			var gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			gameObject.transform.parent = PMFHelper.SystemTransform;
			gameObject.name = "DebugTool";
			gameObject.transform.localScale = new Vector3(0.4f, 0.3f, 0.02f);
			gameObject.transform.position = position;
			gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
			gameObject.AddComponent<Rigidbody>();

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = gameObject.transform;
			var text = textGameObject.AddComponent<TextMeshPro>();
			text.text = "DEBUG TOOL";
			text.fontSize = 0.4f;
			text.color = Color.white;
			text.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localPosition = new Vector3(0, 0.4f, -0.6f);

			var buttonGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			buttonGameObject.name = "Button";
			buttonGameObject.transform.parent = gameObject.transform;
			buttonGameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.02f);
			buttonGameObject.transform.localPosition = new Vector3(0, -0.02f, 0);
			buttonGameObject.GetComponent<MeshRenderer>().material.color = Color.red;

			var grip = gameObject.AddComponent<CameraGrip>();

			return gameObject.AddComponent<InGameDebugTool>();

			
		}

		private void Start()
		{
			Button = transform.Find("Button").gameObject;
			
		}

		private void FixedUpdate()
		{
			//Sometimes the camera grip changes the objects scale
			gameObject.transform.localScale = new Vector3(0.4f, 0.3f, 0.02f);

		}


	}
}
