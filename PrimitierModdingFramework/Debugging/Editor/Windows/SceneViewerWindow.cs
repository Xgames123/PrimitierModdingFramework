using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrimitierModdingFramework.Debugging.Editor.Windows
{
	/// <summary>
	/// A window to view the current scene hierarchy
	/// </summary>
	public class SceneViewerWindow : EditorWindow
	{
		private Rect _rect;

		private bool _shown = false;
		private int _id = PMFEditorLayout.NewWindowId();


		private GameObject[] _rootGameObjects;
		private Dictionary<int, bool> _IsToggled = new Dictionary<int, bool>();

		protected internal override void OnGlobalMenuBar()
		{
			if (PMFEditorLayout.GlobalMenuBarItem(200, "SceneViewer"))
			{
				_rect = new Rect(Event.current.mousePosition.x, PMFEditorLayout.MenuBarSize + PMFEditorLayout.WindowDragBarSize, 400, 1000);
				_shown = true;
			}

		}


		protected internal override void OnDraw()
		{
			if (_shown)
			{
				_rect = PMFEditorLayout.Window(_id, "SceneViewer", _rect, OnWindow, hasCloseButton: true);
			}
		}

		private void OnWindow(int id, bool closing)
		{
			if (closing)
			{
				_shown = false;
				return;
			}

			PMFEditorLayout.BeginVertical();

			

			_rootGameObjects = SceneManager.GetActiveScene().GetRootGameObjects();
			foreach (var gameobject in _rootGameObjects)
			{
				RenderGameObject(gameobject);

			}
			

			PMFEditorLayout.EndVertical();

		}


		private void RenderGameObject(GameObject gameObject, int inset=0)
		{
			var id = gameObject.GetInstanceID();

			if (!_IsToggled.ContainsKey(id))
			{
				_IsToggled[id] = false;
			}


			PMFEditorLayout.SetHorizontalOffset(inset*20);
			_IsToggled[id] = PMFEditorLayout.ToggleButton(_IsToggled[id], _rect.width, gameObject.name);
			PMFEditorLayout.SetHorizontalOffset(0);

			if (_IsToggled[id])
			{
				for (int i = 0; i < gameObject.transform.childCount; i++)
				{
					RenderGameObject(gameObject.transform.GetChild(i).gameObject, inset+1);

				}
			}
		}


	}
}
