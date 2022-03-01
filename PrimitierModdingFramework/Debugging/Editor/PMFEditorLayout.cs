using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnhollowerBaseLib;

namespace PrimitierModdingFramework.Debugging.Editor
{
	/// <summary>
	/// A class for drawing pmf editor stuff
	/// </summary>
	public static class PMFEditorLayout
	{

		/// <summary>
		/// An empty GUILayoutOption array
		/// </summary>
		public static Il2CppReferenceArray<GUILayoutOption> EmptyLayout { get; private set; } = new Il2CppReferenceArray<GUILayoutOption>(0);


		private const int c_windowDragBarSize = 30;

		private static int _currentlyDragging = -1;
		private static Vector2 _currentlyDraggingOffset = Vector2.zero;

		/// <summary>
		/// draws a draggable editor window 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="windowRect"></param>
		/// <param name="windowFunc"></param>
		/// <param name="title"></param>
		/// <returns></returns>
		public static Rect Window(int id, string title, Rect windowRect, Action<int> windowFunc)
		{
			GUI.skin.box.normal.background = Texture2D.whiteTexture;
			var oldColor = GUI.color;
			var oldContentColor = GUI.color;

	
			GUI.color = new Color(0f, 0.6f, 1f);
			GUI.contentColor = Color.black;
			var dragbar = new Rect(windowRect.position-new Vector2(0, c_windowDragBarSize), new Vector2(windowRect.width, c_windowDragBarSize));
			GUI.Box(dragbar, title);


			GUI.color = new Color(0.3f, 0.3f, 0.3f);
			GUI.Box(windowRect, "");


			GUI.color = oldColor;
			GUI.contentColor = oldContentColor;

			GUI.BeginGroup(windowRect);
			windowFunc?.Invoke(id);
			GUI.EndGroup();


			DoWindowDrag(id, dragbar);
			if (_currentlyDragging == id)
			{
				windowRect.position = Event.current.mousePosition+ _currentlyDraggingOffset;

				if (windowRect.x < 0)
				{
					windowRect.x = 0;
				}
				if (windowRect.y-dragbar.height < 0)
				{
					windowRect.y = dragbar.height;
				}

				if (windowRect.x+windowRect.width > Screen.width)
				{
					windowRect.x = Screen.width-windowRect.width;
				}
				if (windowRect.y + windowRect.height - dragbar.height > Screen.height)
				{
					windowRect.y = Screen.height- windowRect.height+dragbar.height;
				}

			}



			return windowRect;
		}



		private static void DoWindowDrag(int id, Rect dragbar)
		{
			if (dragbar.Contains(Event.current.mousePosition))
			{
				if (Event.current.type == EventType.MouseDown)
				{
					_currentlyDraggingOffset = dragbar.position - Event.current.mousePosition + new Vector2(0, c_windowDragBarSize);
					_currentlyDragging = id;
				}
				if (Event.current.type == EventType.MouseUp)
				{
					if (_currentlyDragging == id)
					{
						_currentlyDragging = -1;
					}

				}

			}
		}

	}
}
