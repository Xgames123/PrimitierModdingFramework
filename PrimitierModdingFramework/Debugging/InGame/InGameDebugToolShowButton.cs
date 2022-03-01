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
			//For V0.2 or lower
			var textGameObjectTransform = PMFHelper.MenuWindowL.Find("Text");
			if (textGameObjectTransform != null)
			{
				return;
			}

			var buttonTransform = PMFHelper.MenuWindowL.Find("ShowDebugToolButton");
			if (buttonTransform != null)
			{
				return;
			}
			
			var button = GameObject.CreatePrimitive(PrimitiveType.Cube);
			button.name = "ShowDebugToolButton";
			button.transform.parent = PMFHelper.MenuWindowL;
			button.transform.localScale = new Vector3(0.3f, 0.05f, 0.01f);
			button.transform.localRotation = Quaternion.identity;
			button.transform.localPosition = new Vector3(0, -0.03f, 0);
			button.GetComponent<MeshRenderer>().material.color = Color.grey;
			button.AddComponent<InGameDebugToolShowButton>();

			var textGameObject = new GameObject("ShowDebugToolButtonText");
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
