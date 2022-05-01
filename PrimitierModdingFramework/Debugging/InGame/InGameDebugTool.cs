using System;
using System.IO;
using TMPro;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugTool : MonoBehaviour
	{
		public static InGameDebugTool DebugTool = null;

		public InGameDebugTool(System.IntPtr ptr) : base(ptr) { }


		private static InGameDebugMenu _CurrentMenu = null;
		private static Transform _Menus;

		public static InGameDebugMenu MainMenu = null;

		/// <summary>
		/// Is true when the debug tool is shown
		/// </summary>
		public static bool IsShown { get { return DebugTool != null && DebugTool.isActiveAndEnabled; } }

		public static void Hide()
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));
			if (DebugTool == null)
			{
				return;
			}

			DebugTool.gameObject.SetActive(false);

		}

		public static void Create()
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			if (DebugTool != null)
			{
				return;
			}

			var tool = GameObject.Find("InGameDebugTool");
			if (tool != null)
			{
				DebugTool = tool.GetComponent<InGameDebugTool>();
				return;
			}


			var gameObject = new GameObject();
			gameObject.transform.parent = PMFHelper.SystemTransform;
			gameObject.name = "InGameDebugTool";
			gameObject.transform.localScale = new Vector3(1, 1, 1);

			var pannel = CreatePannel(gameObject.transform);

			var menusGameObject = new GameObject();
			menusGameObject.transform.parent = gameObject.transform;
			menusGameObject.transform.localPosition = new Vector3(0, 0, 0);
			menusGameObject.transform.localRotation = Quaternion.identity;
			menusGameObject.transform.localScale = new Vector3(1, 1, 1);
			_Menus = menusGameObject.transform;


			MainMenu = CreateMenu("MainMenu", null, "MOD SETTINGS");
			var closeButton = MainMenu.CreateButton("Close");
			closeButton.AttachOnPressListener(new System.Action(() =>
			{
				Hide();
			}));


			OpenMenu("MainMenu");

			DebugTool = gameObject.AddComponent<InGameDebugTool>();

			DebugTool.gameObject.SetActive(false);
		}


		/// <summary>
		/// Moves the tool to the new position and rotation
		/// </summary>
		/// <param name="pos">new position</param>
		/// <param name="rot">new rotation</param>
		public static void UpdateToolPosRot(Vector3 pos, Quaternion rot)
		{
			if (DebugTool == null || !DebugTool.isActiveAndEnabled)
			{
				return;
			}

			DebugTool.transform.position = pos;
			DebugTool.transform.rotation = rot;
		}


		public static void Show()
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			if (DebugTool == null)
			{
				return;
			}

			DebugTool.gameObject.SetActive(true);
		}



		public static InGameDebugMenu CreateMenu(string name, string parentMenuName, string title=null)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			var existingMenu = GetMenu(name);
			if (existingMenu != null)
			{
				return existingMenu;
			}

			var menuGameObject = new GameObject();
			menuGameObject.name = name;
			menuGameObject.transform.parent = _Menus.transform;

			if (title == null)
			{
				title = name;
			}
			title = title.ToUpper();

			var menu = menuGameObject.AddComponent<InGameDebugMenu>();

			GameObject textGameObject = new GameObject("Title");
			textGameObject.transform.parent = menuGameObject.transform;
			var text = textGameObject.AddComponent<TextMeshPro>();
			text.text = title;
			text.fontSize = 0.5f;
			text.color = Color.white;
			text.alignment = TextAlignmentOptions.Center;
			textGameObject.transform.localScale = new Vector3(1, 1, 1);
			textGameObject.transform.localPosition = new Vector3(0, 0.1f, -0.011f);

			if (parentMenuName != null)
			{
				menu.CreateButton("Back", new System.Action(() => 
				{
					OpenMenu(parentMenuName);
				}));

				var parentMenu = GetMenu(parentMenuName);
				parentMenu.CreateButton(name, new System.Action(() =>
				{
					OpenMenu(name);
				}));
			}

			menuGameObject.SetActive(false);
			return menu;
		}

		public static InGameDebugMenu GetMenu(string name)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			return _Menus.Find(name)?.GetComponent<InGameDebugMenu>();
		}
		public static void OpenMenu(string name)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			if (_CurrentMenu != null)
			{
				_CurrentMenu.gameObject.SetActive(false);
			}
			_CurrentMenu = GetMenu(name);
			if (_CurrentMenu != null)
			{
				_CurrentMenu.gameObject.SetActive(true);
			}
		}

		
		private static GameObject CreatePannel(Transform parent)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			var Pannel = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Pannel.transform.parent = parent;
			Pannel.transform.localScale = new Vector3(0.4f, 0.3f, 0.02f);
			Pannel.transform.localPosition = new Vector3(0, 0, 0);
			Pannel.GetComponent<MeshRenderer>().material.color = Color.black;


			return Pannel;
		}


		
	}
}
