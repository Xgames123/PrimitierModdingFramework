using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugToolShowButton : MonoBehaviour
	{
		public InGameDebugToolShowButton(IntPtr ptr) : base(ptr) { }



		public void OnPress()
		{
			InGameDebugTool.Show();

		}

		public static void Create()
		{
			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = PMFHelper.MenuWindowL;
			cube.transform.localScale = new Vector3(0.3f, 0.05f, 0.01f);
			cube.transform.localRotation = Quaternion.identity;
			cube.transform.localPosition = new Vector3(0, -0.03f, 0);
			cube.GetComponent<MeshRenderer>().material.color = Color.grey;
			cube.AddComponent<InGameDebugToolShowButton>();

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = PMFHelper.MenuWindowL;
			var textMP = textGameObject.AddComponent<TextMeshPro>();
			textMP.text = "Show Debug menu";
			textMP.fontSize = 0.3f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1, 1, 1);
			textGameObject.transform.localPosition = new Vector3(0, -0.03f, -0.006f);
			textGameObject.transform.localRotation = Quaternion.identity;
		}


	}
}
