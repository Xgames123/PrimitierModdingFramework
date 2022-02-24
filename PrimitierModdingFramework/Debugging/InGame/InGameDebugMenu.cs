using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugMenu : MonoBehaviour
	{
		public InGameDebugMenu(System.IntPtr ptr) : base(ptr) { }

		private const float s_buttonZSize = 0.006f;
		private const float s_buttonHeight = 0.05f;
		private const float s_buttonWidth = 0.1f;
		private const float s_buttonSpaceing = 0.01f;
		private const int s_maxButtonsPerLine = 3;
		private const float s_buttonTextDepth = 0.011f;

		private int _buttonsOnCurrentLine = 0;
		private Vector2 _nextButtonPos = new Vector2(-0.1f, 0.05f);

		private const float s_backButtonWidth = 0.4f;
		private const float s_backButtonHeight = 0.05f;
		private Vector2 _backButtonPos = new Vector2(0.0f, 0.1f+s_buttonSpaceing+s_backButtonHeight);

		private List<LabelWidget> activeLabelWidgets = new List<LabelWidget>();
		private List<ToggleWidget> activeToggleWidgets = new List<ToggleWidget>();

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
			buttonGameObject.transform.localScale = new Vector3(s_buttonWidth, s_buttonHeight, s_buttonZSize);
			buttonGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonZSize);

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
			textMP.fontSize = 0.1f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonTextDepth);


			button.CubeTransform = cube.transform;

			_buttonsOnCurrentLine++;
			_nextButtonPos += new Vector2(s_buttonWidth + s_buttonSpaceing, 0);
			if (_buttonsOnCurrentLine >= s_maxButtonsPerLine)
			{
				_buttonsOnCurrentLine = 0;
				_nextButtonPos.x = -0.1f;
				_nextButtonPos.y -= s_buttonHeight + s_buttonSpaceing;
			}


			return button;
		}

		public InGameDebugToolButton CreateBackButton(Il2CppSystem.Action opPress)
		{
			
			var buttonGameObject = new GameObject();
			buttonGameObject.transform.parent = transform;
			buttonGameObject.name = "Button";
			buttonGameObject.transform.localScale = new Vector3(s_backButtonWidth, s_backButtonHeight, s_buttonZSize);
			buttonGameObject.transform.localPosition = new Vector3(_backButtonPos.x, _backButtonPos.y, -s_buttonZSize);

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
			textMP.text = "Back";
			textMP.fontSize = 0.1f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(_backButtonPos.x, _backButtonPos.y, -s_buttonTextDepth);

			button.CubeTransform = cube.transform;

			button.AttachOnPressListener(opPress);

			return button;
		}

		public class LabelWidget
		{
			private string widgetName;
			private TextMeshPro textMPObj;
			public LabelWidget(string widgetName, TextMeshPro widgetObj)
			{
				this.widgetName = widgetName;
				this.textMPObj = widgetObj;
			}

			public string Name
			{
				get { return widgetName; }
			}

			public bool Equals(string labelName)
			{
				return widgetName.Equals(labelName);
			}

			public string Text
			{
				get { return textMPObj.text; }
				set { textMPObj.text = value; }
			}
		}
		public GameObject CreateLabelWidget(string labelName, string initialText)
		{
			var labelGameObject = new GameObject();
			labelGameObject.transform.parent = transform;
			labelGameObject.name = "Label";
			labelGameObject.transform.localScale = new Vector3(s_buttonWidth, s_buttonHeight, s_buttonZSize);
			labelGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonZSize);

			labelGameObject.AddComponent<BoxCollider>();
			//var labelBase = labelGameObject.AddComponent<InGameDebugToolLabel>();


			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = labelGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			cube.GetComponent<MeshRenderer>().material.color = Color.grey;
			Destroy(cube.GetComponent<BoxCollider>());


			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = textGameObject.AddComponent<TextMeshPro>();
			textMP.text = initialText;
			textMP.fontSize = 0.1f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonTextDepth);

			activeLabelWidgets.Add(new LabelWidget(labelName,textMP));

			_buttonsOnCurrentLine++;
			_nextButtonPos += new Vector2(s_buttonWidth + s_buttonSpaceing, 0);
			if (_buttonsOnCurrentLine >= s_maxButtonsPerLine)
			{
				_buttonsOnCurrentLine = 0;
				_nextButtonPos.x = -0.1f;
				_nextButtonPos.y -= s_buttonHeight + s_buttonSpaceing;
			}

			return labelGameObject;
		}

		public void SetLabelWidgetText(string labelName, string newText)
		{
			//Console.WriteLine("Update method called with text " + newText + " for widget " + labelName);
			foreach(var item in activeLabelWidgets)
			{
				//Console.WriteLine("Widget " + item.Name);
				if(item.Equals(labelName))//labelName.Equals(item.GetName())
				{
					//Console.WriteLine("Update method sees an equivalent text name");
					item.Text = newText;
				}
			}
		}

		public class ToggleWidget
		{
			private string widgetName;
			private GameObject widgetObj;
			public ToggleWidget(string widgetName, GameObject widgetObj)
			{
				this.widgetName = widgetName;
				this.widgetObj = widgetObj;
			}

			public string Name
			{
				get { return widgetName; }
			}

			public bool Equals(string labelName)
			{
				return widgetName.Equals(labelName);
			}

			public void UpdateToggleState(bool toggleState)
			{
				if(toggleState)
				{
					widgetObj.GetComponent<MeshRenderer>().material.color = Color.green;
				}
				else
				{
					widgetObj.GetComponent<MeshRenderer>().material.color = Color.red;
				}
			}
		}

		public InGameDebugToolButton CreateToggleWidget(string labelName, string labelText, bool initialState, Il2CppSystem.Action opPress)
		{
			var buttonGameObject = new GameObject();
			buttonGameObject.transform.parent = transform;
			buttonGameObject.name = "Toggle";
			buttonGameObject.transform.localScale = new Vector3(s_buttonWidth, s_buttonHeight, s_buttonZSize);
			buttonGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonZSize);

			buttonGameObject.AddComponent<BoxCollider>();
			var button = buttonGameObject.AddComponent<InGameDebugToolButton>();


			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = buttonGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			if(initialState)
			{
				cube.GetComponent<MeshRenderer>().material.color = Color.green;
			}
			else
			{
				cube.GetComponent<MeshRenderer>().material.color = Color.red;
			}
			//var cube_before = cube;
			Destroy(cube.GetComponent<BoxCollider>());
			//console.WriteLine("Cube status after destroy: " + cube_before.Equals(cube));

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = textGameObject.AddComponent<TextMeshPro>();
			textMP.text = labelText;
			textMP.fontSize = 0.12f;
			textMP.color = Color.black;
			textMP.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(_nextButtonPos.x, _nextButtonPos.y, -s_buttonTextDepth);

			activeToggleWidgets.Add(new ToggleWidget(labelName, cube));

			button.CubeTransform = cube.transform;
			button.AttachOnPressListener(opPress);

			_buttonsOnCurrentLine++;
			_nextButtonPos += new Vector2(s_buttonWidth + s_buttonSpaceing, 0);
			if (_buttonsOnCurrentLine >= s_maxButtonsPerLine)
			{
				_buttonsOnCurrentLine = 0;
				_nextButtonPos.x = -0.1f;
				_nextButtonPos.y -= s_buttonHeight + s_buttonSpaceing;
			}
			return button;
		}

		public void UpdateToggleWidgetState(string labelName, bool state)
		{
			//Console.WriteLine("Update method called with text " + newText + " for widget " + labelName);
			foreach(var item in activeToggleWidgets)
			{
				//Console.WriteLine("Widget " + item.Name);
				if(item.Equals(labelName))//labelName.Equals(item.GetName())
				{
					//Console.WriteLine("Update method sees an equivalent text name");
					item.UpdateToggleState(state);
				}
			}
		}
	}
}
