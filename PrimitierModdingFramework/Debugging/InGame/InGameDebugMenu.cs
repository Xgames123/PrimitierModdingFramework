using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugMenu : MonoBehaviour
	{
		public InGameDebugMenu(System.IntPtr ptr) : base(ptr) { }

		private const float _buttonHeight = 0.05f;
		private const float _buttonWidth = 0.1f;
		private const float _buttonSpaceing = 0.01f;
		private const int _maxButtonsPerLine = 3;
		private const float _buttonZSize = 0.006f;
		private const float _buttonTextDepth = 0.011f;

		private int _buttonsOnCurrentLine = 0;
		private Vector2 _nextButtonPos = new Vector2(-0.1f, 0.05f);

		/// Vars to store Widget class objects and active type of widgets
		private List<Widget> activeWidgets = new List<Widget>();

		private byte buttonCount=0, toggleCount=0, labelCount=0;

		/// <summary>
		/// Create a default button from non-overloaded constructor
		/// </summary>
		public InGameDebugToolButton CreateButton(string text, Il2CppSystem.Action opPress)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			buttonCount++;
			var button = CreateButton(	new Vector2(_buttonWidth, _buttonHeight),
										new Vector2(_nextButtonPos.x, _nextButtonPos.y), 
										text, Color.grey, Color.black, 0.0f, buttonCount.ToString());
			button.AttachOnPressListener(opPress);
			AdvanceButtonPosition();
			return button;
		}
		/// <summary>
		/// Create a default label from non-overloaded constructor
		/// </summary>
		public GameObject CreateLabel(string text)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			labelCount++;
			var label = CreateLabel(	new Vector2(_buttonWidth, _buttonHeight),
										new Vector2(_nextButtonPos.x, _nextButtonPos.y), 
										text, Color.grey, Color.black, 0.0f, labelCount.ToString());
			AdvanceButtonPosition();
			return label;
		}
		/// <summary>
		/// Create a default toggle button from non-overloaded constructor
		/// </summary>
		public InGameDebugToolButton CreateToggle(string text, bool initialState, Il2CppSystem.Action opPress)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			toggleCount++;
			var button = CreateToggle(	new Vector2(_buttonWidth, _buttonHeight),
										new Vector2(_nextButtonPos.x, _nextButtonPos.y), 
										text, Color.black, 0.0f, initialState, toggleCount.ToString());
			button.AttachOnPressListener(opPress);
			AdvanceButtonPosition();
			return button;
		}

		/// <summary>
		/// Create a button where the location, size, and colors can be created.
		/// all variables are obvious, buttonSize is (width,height,depth) and set textSize to 0.0 for auto fontsize
		///
		/// button location is not reversed
		/// any buttonLocation should be 0 > buttonLocation.z
		/// </summary>
		public InGameDebugToolButton CreateButton(	Vector2 buttonSize,	Vector2 buttonLocation,	string buttonText,
													Color buttonColor, 	Color textColor, 		float textSize,
													string refName)
		{
			
			var buttonGameObject = CreateButtonBaseObject(buttonSize, buttonLocation, buttonText);

			buttonGameObject.AddComponent<BoxCollider>();
			var button = buttonGameObject.AddComponent<InGameDebugToolButton>();

			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = buttonGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			cube.GetComponent<MeshRenderer>().material.color = buttonColor;
			Destroy(cube.GetComponent<BoxCollider>());

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = CreateButtonTextObject(textGameObject, buttonText, textSize, textColor);

			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.BUTTON, refName, buttonGameObject, cube, textGameObject));

			button.CubeTransform = cube.transform;

			return button;
		}

		/// <summary>
		/// 
		/// </summary>
		public GameObject CreateLabel(	Vector2 buttonSize,	Vector2 buttonLocation,	string buttonText,
										Color buttonColor, 	Color textColor, 		float textSize,	
										string refName)
		{
			
			var labelGameObject = CreateButtonBaseObject(buttonSize, buttonLocation, buttonText);

			labelGameObject.AddComponent<BoxCollider>();

			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = labelGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);
			cube.GetComponent<MeshRenderer>().material.color = buttonColor;
			Destroy(cube.GetComponent<BoxCollider>());

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = CreateButtonTextObject(textGameObject, buttonText, textSize, textColor);

			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.LABEL, refName, labelGameObject, cube, textGameObject));

			return labelGameObject;
		}

		/// <summary>
		/// 
		/// </summary>
		public InGameDebugToolButton CreateToggle(	Vector2 buttonSize,	Vector2 buttonLocation,	string buttonText,
													Color textColor, 	float textSize, 		bool initialState,	
													string refName)
		{
			var buttonGameObject = CreateButtonBaseObject(buttonSize, buttonLocation, buttonText);

			buttonGameObject.AddComponent<BoxCollider>();
			var button = buttonGameObject.AddComponent<InGameDebugToolButton>();


			var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.parent = buttonGameObject.transform;
			cube.transform.localPosition = Vector3.zero;
			cube.transform.localScale = new Vector3(1, 1, 1);

			if(initialState)
			{ cube.GetComponent<MeshRenderer>().material.color = Color.green; }
			else
			{ cube.GetComponent<MeshRenderer>().material.color = Color.red; }

			Destroy(cube.GetComponent<BoxCollider>());

			GameObject textGameObject = new GameObject("Text");
			textGameObject.transform.parent = transform;

			var textMP = CreateButtonTextObject(textGameObject, buttonText, textSize, textColor);

			textGameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.TOGGLE, refName, buttonGameObject, cube, textGameObject));

			button.CubeTransform = cube.transform;

			return button;
		}
		
		/// <summary>
		/// Create a button text object to overlay text on a button. Positioning and scale is done in actual button 
		/// creation function
		/// </summary>
		private GameObject CreateButtonBaseObject(Vector2 buttonSize, Vector2 buttonLocation, string buttonText)
		{
			var baseObject = new GameObject();
			baseObject.transform.parent = transform;
			baseObject.name = "UK."+buttonText;
			baseObject.transform.localScale = new Vector3(buttonSize.x, buttonSize.y, _buttonZSize);
			baseObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -_buttonZSize);
			return baseObject;
		}

		/// <summary>
		/// Create a button text object to overlay text on a button. Positioning and scale is done in actual button 
		/// creation function
		/// </summary>
		private TextMeshPro CreateButtonTextObject(GameObject parentObj, string text, float textSize, Color textColor)
		{
			//override textSize if 0.0 value. Indicates text size should be calculated based on string length
			if(textSize.Equals(0.0f))
			{
				int offset = 3;
				float maxTextSize = 0.3f;
				if(text.Length > offset)
				{ textSize = (maxTextSize / ((float)(text.Length-offset))); }
				else
				{ textSize = maxTextSize; }
				
				/* if(text.Length > 5)
				{ textSize = 0.2f;}
				else if(text.Length > 7)
				{ textSize = 0.15f;}
				else if(text.Length > 10)
				{ textSize = 0.1f;}
				else if(text.Length > 15)
				{ textSize = 0.075f;}
				else if(text.Length > 20)
				{ textSize = 0.05f;}
				else
				{textSize = 0.3f;} */
			}
			
			var textObj = parentObj.AddComponent<TextMeshPro>();

			textObj.text = text;
			textObj.fontSize = textSize;//0.1f;
			textObj.color = textColor;
			textObj.alignment = TextAlignmentOptions.Center;

			return textObj;
		}

		/// <summary>
		/// Advance the basic button position by one position
		/// </summary>
		public void AdvanceButtonPosition()
		{
			_buttonsOnCurrentLine++;
			_nextButtonPos += new Vector2(_buttonWidth + _buttonSpaceing, 0);
			if (_buttonsOnCurrentLine >= _maxButtonsPerLine)
			{
				_buttonsOnCurrentLine = 0;
				_nextButtonPos.x = -0.1f;
				_nextButtonPos.y -= _buttonHeight + _buttonSpaceing;
			}
		}

		///// Vars for Overhead button /////
		private const float s_backButtonWidth = 0.4f;
		private const float s_backButtonHeight = 0.05f;
		private Vector2 _backButtonPos = new Vector2(0.0f, 0.15f+_buttonSpaceing+s_backButtonHeight);

		/// <summary>
		/// Create an overhead button to close or go back
		/// </summary>
		public InGameDebugToolButton CreateOverheadButton(string text, string refName, Il2CppSystem.Action opPress)
		{
			var overheadButton = CreateButton(	new Vector2(s_backButtonWidth, s_backButtonHeight),
												new Vector2(_backButtonPos.x, _backButtonPos.y),
												text, Color.grey, Color.black, 0.0f, refName);
			overheadButton.AttachOnPressListener(opPress);

			return overheadButton;
		}

		/// <summary>
		/// Create a back button for a menu page
		/// </summary>
		public InGameDebugToolButton CreateBackButton(Il2CppSystem.Action opPress)
		{
			var button = CreateOverheadButton("Back", "BACKBUTTON", opPress);
			button.AttachOnPressListener(opPress);
			return button;
		}

		/// <summary>
		/// Widget class to store relevant GameObjects
		/// </summary>
		public class Widget
		{
			/// <summary>
			/// Widget Type decleration
			/// </summary>
			public enum Type{
				NULL = 0,		/// <summary> Null (default)</summary>
				LABEL = 1,		/// <summary> Text label</summary>
				BUTTON = 2,		/// <summary> Regular PMF button</summary>
				TOGGLE = 3,		/// <summary> Toggle button</summary>
			}
			
			private Type _widgetType;
			private string _name;
			private GameObject _baseObject;
			private GameObject _cubeObject;
			private GameObject _textObject;

			private bool _state;

			/// <summary>
			/// Widget object constructor (menu.widget.Type type, name, parentGameObj)
			/// </summary>
			public Widget(Type type, string name, GameObject baseObject, GameObject cubeObject, GameObject textObject)
			{
				_widgetType = type;
				_name = name;
				_baseObject = baseObject;
				_cubeObject = cubeObject;
				_textObject = textObject;

				switch(_widgetType)
				{
					case Type.LABEL:
						baseObject.name = "LABEL."+name;
					break;
					case Type.BUTTON:
						baseObject.name = "BUTTON."+name;
					break;
					case Type.TOGGLE:
						baseObject.name = "TOGGLE."+name;
					break;
					default:
					 PMFLog.Message("Widget default case in constructor");
					break;
				}
			}
		/// Widget related functions

			/// Toggle Widget section

			/// <summary>
			/// Change the state of the toggle button by passing in the desired state
			/// </summary>
			public void ToggleUpdate(bool toggleState)
			{
				if(toggleState)
				{
					_cubeObject.GetComponent<MeshRenderer>().material.color = Color.green;
					_state = true;
				}
				else
				{
					_cubeObject.GetComponent<MeshRenderer>().material.color = Color.red;
					_state = false;
				}
			}

			/// <summary>
			/// Get access to check the widget state (if a toggle widget)
			/// </summary>
			public bool State
			{
				get { return _state; }
			}

			/// Label Widget section

			/// <summary>
			/// Get and set access to update the widget text
			/// </summary>
			public string Text
			{
				get { return _textObject.GetComponent<TextMeshPro>().text; }
				set { _textObject.GetComponent<TextMeshPro>().text = value; }
			}

			/// <summary>
			/// Get and set access to the widget text font size
			/// </summary>
			public float FontSize
			{
				get { return _textObject.GetComponent<TextMeshPro>().fontSize; }
				set { _textObject.GetComponent<TextMeshPro>().fontSize = value; }
			}

			/// General purpose Widget functions/getters/setters

			/// <summary>
			/// Get access the Widget Name 
			/// </summary>
			public string Name
			{
				get { return _name; }
			}
			
			/// <summary>
			/// Equals comparison to compare refNames
			/// </summary>
			public bool Equals(string eqname)
			{
				return _name.Equals(eqname);
			}

			/// <summary>
			/// Get and set color of underlying button GameObject stored in Widget
			/// </summary>
			public Color color
			{
				set { _cubeObject.GetComponent<MeshRenderer>().material.color = value; }
				get { return _cubeObject.GetComponent<MeshRenderer>().material.color; }
			}

			/// <summary>
			/// Get and set color of overlaid text on GameObject stored in Widget
			/// </summary>
			public Color textcolor
			{
				set { _textObject.GetComponent<TextMeshPro>().color = value; }
				get { return _textObject.GetComponent<TextMeshPro>().color; }
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public void AddWidget(Widget widgetObj)
		{
			activeWidgets.Add(widgetObj);
			//PMFLog.Message("Widget "+widgetObj.Name+" added to menu");
		}

		/// <summary>
		/// 
		/// </summary>
		public Widget GetWidget(string name)
		{
			foreach(var item in activeWidgets)
			{
				if(item.Equals(name))
				{
					PMFLog.Message("Found widget "+item.Name+" when looking for "+name);
					return item;
				}
			} 
			PMFLog.Message("No widget found when looking for "+name);
			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		public void UpdateLabel(string refName, string text)
		{
			Widget w = GetWidget(refName);
			if(w != null)
			{
				//PMFLog.Message(w);
				w.Text = text;
				PMFLog.Message("Text written to");
			}
			PMFLog.Message("No Label for "+refName+" found");
		}

		/// <summary>
		/// 
		/// </summary>
		public void UpdateToggle(string refName, bool state)
		{
			Widget w = GetWidget(refName);
			if(w != null)
			{
				PMFLog.Message(w);
				w.ToggleUpdate(state);
				PMFLog.Message("State written to");
			}
			PMFLog.Message("No Toggle for "+refName+" found");
		}

		//// Disabled until function added to destroy button object from menu
		//// (and maybe revert menu positions to prevent gaps)
		// public void RemoveWidget(string name)
		// {
		// 	Widget w = GetWidget(name);
		// 	if(w!=null)
		// 	{
		// 		activeWidgets.Remove(w);
		// 	}
		// }




		/// <summary>
		/// Compatability function for old modpack versions using new DLL
		/// </summary>
		public GameObject CreateLabelWidget(string labelName, string initialText)
		{
			labelCount++;
			var label = CreateLabel(	new Vector2(_buttonWidth, _buttonHeight),
										new Vector2(_nextButtonPos.x, _nextButtonPos.y), 
										initialText, Color.grey, Color.black, 0.0f, labelName);
			AdvanceButtonPosition();
			return label;
		}

		/// <summary>
		/// Compatability function for old modpack versions using new DLL
		/// </summary>
		public void SetLabelWidgetText(string refName, string newText)
		{
			UpdateLabel(refName, newText);
		}

		/// <summary>
		/// Compatability function for old modpack versions using new DLL, identical to CreateToggle but with labelName refname
		/// </summary>
		public InGameDebugToolButton CreateToggleWidget(string refName, string text, bool initialState, Il2CppSystem.Action opPress)
		{
			var button = CreateToggle(	new Vector2(_buttonWidth, _buttonHeight),
										new Vector2(_nextButtonPos.x, _nextButtonPos.y), 
										text, Color.black, 0.0f, initialState, refName);
			button.AttachOnPressListener(opPress);
			AdvanceButtonPosition();
			return button;
		}

		/// <summary>
		/// Compatability function for old modpack versions using new DLL
		/// </summary>
		public void UpdateToggleWidgetState(string refName, bool state)
		{
			UpdateToggle(refName, state);
		}

	}
}