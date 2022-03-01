using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugMenu : MonoBehaviour
	{
		public InGameDebugMenu(System.IntPtr ptr) : base(ptr) { }

		private const float s_buttonHeight = 0.05f;
		private const float s_buttonWidth = 0.1f;
		private const float s_buttonSpaceing = 0.01f;
		private const int s_maxButtonsPerLine = 3;
		private const float s_buttonZSize = 0.006f;
		private const float s_buttonTextDepth = 0.011f;

		private int _buttonsOnCurrentLine = 0;
		private Vector2 _nextButtonPos = new Vector2(-0.1f, 0.05f);

		//private List<LabelWidget> activeLabelWidgets = new List<LabelWidget>();
		//private List<ToggleWidget> activeToggleWidgets = new List<ToggleWidget>();
		private List<Widget> activeWidgets = new List<Widget>();

		private byte buttonCount=0, toggleCount=0, labelCount=0;

		/// <summary>
		/// Create a default button from non-overloaded constructor
		/// </summary>
		public InGameDebugToolButton CreateButton(string text, Il2CppSystem.Action opPress)
		{
			buttonCount++;
			var button = CreateButton(	new Vector2(s_buttonWidth, s_buttonHeight),
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
			labelCount++;
			var label = CreateLabel(	new Vector2(s_buttonWidth, s_buttonHeight),
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
			toggleCount++;
			var button = CreateToggle(	new Vector2(s_buttonWidth, s_buttonHeight),
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
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -s_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.BUTTON, refName, buttonGameObject));

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
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -s_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.LABEL, refName, labelGameObject));

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
			textGameObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -s_buttonTextDepth);

			AddWidget(new Widget(Widget.Type.TOGGLE, refName, buttonGameObject));

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
			baseObject.transform.localScale = new Vector3(buttonSize.x, buttonSize.y, s_buttonZSize);
			baseObject.transform.localPosition = new Vector3(buttonLocation.x, buttonLocation.y, -s_buttonZSize);
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
				if(text.Length > 5)
				{ textSize = 0.2f;}
				if(text.Length > 10)
				{ textSize = 0.1f;}
				else if(text.Length > 15)
				{ textSize = 0.075f;}
				else if(text.Length > 20)
				{ textSize = 0.05f;}
				else
				{textSize = 0.3f;}
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
			_nextButtonPos += new Vector2(s_buttonWidth + s_buttonSpaceing, 0);
			if (_buttonsOnCurrentLine >= s_maxButtonsPerLine)
			{
				_buttonsOnCurrentLine = 0;
				_nextButtonPos.x = -0.1f;
				_nextButtonPos.y -= s_buttonHeight + s_buttonSpaceing;
			}
		}

		///// Vars for Overhead button /////
		private const float s_backButtonWidth = 0.4f;
		private const float s_backButtonHeight = 0.05f;
		private Vector2 _backButtonPos = new Vector2(0.0f, 0.15f+s_buttonSpaceing+s_backButtonHeight);

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
			/// <summary>
			/// Object template and default Null type object
			/// </summary>
			public class NullObj
			{
				private GameObject _widgetObject;
				public NullObj(GameObject widgetObj)
				{
					_widgetObject = null;
				}
			}
			/// <summary>
			/// Label type object to access parent object and change/read text
			/// </summary>
			public class Label
			{
				private GameObject _widgetObject;
				public Label(GameObject widgetObj)
				{
					_widgetObject = widgetObj;
				}

				public string Text
				{
					get { return _widgetObject.GetComponent<TextMeshPro>().text; }
					set { _widgetObject.GetComponent<TextMeshPro>().text = value; }
				}
			}
			/// <summary>
			/// Button type object
			/// </summary>
			public class Button
			{
				private GameObject _widgetObject;
				public Button(GameObject widgetObj)
				{
					_widgetObject = widgetObj;
				}
			}
			/// <summary>
			/// Toggle type object to change/read toggle state
			/// </summary>
			public class Toggle
			{
				private GameObject _widgetObject;
				private bool _state;
				public Toggle(GameObject widgetObj, bool initialState)
				{
					_widgetObject = widgetObj;
					_state = initialState;
				}
				/// <summary>
				/// Change the state of the toggle button by passing in the desired state
				/// </summary>
				public void Update(bool toggleState)
				{
					if(toggleState)
					{
						_widgetObject.GetComponent<MeshRenderer>().material.color = Color.green;
						_state = true;
					}
					else
					{
						_widgetObject.GetComponent<MeshRenderer>().material.color = Color.red;
						_state = false;
					}
				}
				/// <summary>
				/// Get method to return toggle state
				/// Set method not active, use Update() instead
				/// </summary>
				bool State{
					get{ return _state; }
					//set{ _state = value; }
				}
			}

			private Type _widgetType;
			private string _name;
			public Button _buttonObj = null;
			public Label _labelObj = null;
			public Toggle _toggleObj = null;

			/// <summary>
			/// Widget object constructor (menu.widget.Type type, name, parentGameObj)
			/// </summary>
			public Widget(Type type, string name, GameObject parentObject)
			{
				_widgetType = type;
				_name = name;

				switch(_widgetType)
				{
					case Type.LABEL:
						parentObject.name = "LABEL."+name;
						_labelObj = new Label(parentObject);
					break;
					case Type.BUTTON:
					parentObject.name = "BUTTON."+name;
						_buttonObj = new Button(parentObject);
					break;
					case Type.TOGGLE:
					parentObject.name = "TOGGLE."+name;
						_toggleObj = new Toggle(parentObject, false);
					break;
					default:
					 PMFLog.Message("Widget default case in constructor");
					break;
				}
			}
			
			/// <summary>
			/// Get access the Widget Name 
			/// </summary>
			public string Name
			{
				get { return _name; }
			}
			
			/// <summary>
			/// Equals comparison to compare names
			/// </summary>
			public bool Equals(string eqname)
			{
				return _name.Equals(eqname);
			}

			/// <summary>
			/// Returns the null, label, toggle or button object stored in _widgetObject
			/// </summary>
			/* public dynamic Obj()
			{
				return _widgetObject;
			} */
			public Button button
			{
				get { return _buttonObj; }
			}
			public Label label
			{
				get { return _labelObj; }
			}
			public Toggle toggle
			{
				get { return _toggleObj; }
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
			if(w.label != null)
			{
				PMFLog.Message(w);
				w.label.Text = text;
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
			if(w.toggle != null)
			{
				PMFLog.Message(w);
				w.toggle.Update(state);
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
			var label = CreateLabel(	new Vector2(s_buttonWidth, s_buttonHeight),
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
			var button = CreateToggle(	new Vector2(s_buttonWidth, s_buttonHeight),
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