using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugMenu : MonoBehaviour
	{
		public InGameDebugMenu(System.IntPtr ptr) : base(ptr) { }

		private Vector2 _NextButtonPos = new Vector2(-0.1f, 0);
		

		public InGameDebugToolButton CreateButton(string text, Il2CppSystem.Action opPress)
		{
			var button = CreateButton(text);
			button.AttachOnPressListener(opPress);
			return button;
		}

		public InGameDebugToolButton CreateButton(string text)
		{

			var buttonGameObject = new GameObject();
			buttonGameObject.transform.parent = transform;
			buttonGameObject.name = "Button";
			buttonGameObject.transform.localScale = new Vector3(0.09f, 0.09f, 0.02f);
			buttonGameObject.transform.localPosition = new Vector3(_NextButtonPos.x, _NextButtonPos.y, -0.02f);

			buttonGameObject.AddComponent<BoxCollider>();
			var button = buttonGameObject.AddComponent<InGameDebugToolButton>();


			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = buttonGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			cube.GetComponent<MeshRenderer>().material.color = Color.grey;
			Destroy(cube.GetComponent<BoxCollider>());


			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = textGameObject.AddComponent<TextMeshPro>();
			textMP.text = text;
			textMP.fontSize = 0.2f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(_NextButtonPos.x, _NextButtonPos.y, -0.031f);


			button.CubeTransform = cube.transform;


			_NextButtonPos += new Vector2(0.1f, 0);

			return button;
		}



	}
}
