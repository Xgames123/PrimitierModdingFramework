using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.Editor
{
	public partial class PMFEditorLayout
	{
		public const int WindowDragBarSize = 30;

		private static int s_currentlyDragging = -1;
		private static Vector2 s_currentlyDraggingOffset = Vector2.zero;


		private static int s_windowIdCounter = 0;

		/// <summary>
		/// Returns a new window id
		/// </summary>
		/// <returns></returns>
		public static int NewWindowId()
		{
			s_windowIdCounter++;
			return s_windowIdCounter;
			
		}



		/// <summary>
		/// draws a draggable editor window 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="windowRect"></param>
		/// <param name="windowFunc"></param>
		/// <param name="title"></param>
		/// <returns></returns>
		public static Rect Window(int id, string title, Rect windowRect, Action<int, bool> windowFunc, bool hasCloseButton=false)
		{
			TrySetupStyle();

			var oldColor = GUI.color;
			

			GUI.color = Color.grey;

			var dragbar = new Rect(windowRect.position - new Vector2(0, WindowDragBarSize), new Vector2(windowRect.width, WindowDragBarSize));
			GUI.Box(dragbar, "");
			GUI.color = Color.white;

			var oldFontSize = GUI.skin.label.fontSize;
			GUI.skin.label.fontSize = 20;
			var titleRect = new Rect(dragbar.width, dragbar.height, dragbar.x, dragbar.y);
			GUI.Label(dragbar, title);
			GUI.skin.label.fontSize = oldFontSize;

			GUI.color = Color.black;
			GUI.Box(windowRect, "");

			var closing = false;
			if (hasCloseButton)
			{
				GUI.color = Color.white;
				var closeButton = new Rect(dragbar.x + dragbar.width - dragbar.height, dragbar.y, dragbar.height, dragbar.height);
				closing = GUI.Button(closeButton, "X");
			}
			

			GUI.color = oldColor;

			GUI.BeginGroup(windowRect);
			windowFunc?.Invoke(id, closing);
			GUI.EndGroup();


			DoWindowDrag(id, dragbar);
			if (s_currentlyDragging == id)
			{
				windowRect.position = Event.current.mousePosition + s_currentlyDraggingOffset;

				if (windowRect.x < 0)
				{
					windowRect.x = 0;
				}
				if (windowRect.y - dragbar.height < 0)
				{
					windowRect.y = dragbar.height;
				}

				if (windowRect.x + windowRect.width > Screen.width)
				{
					windowRect.x = Screen.width - windowRect.width;
				}
				if (windowRect.y + windowRect.height - dragbar.height > Screen.height)
				{
					windowRect.y = Screen.height - windowRect.height + dragbar.height;
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
					s_currentlyDraggingOffset = dragbar.position - Event.current.mousePosition + new Vector2(0, WindowDragBarSize);
					s_currentlyDragging = id;
				}
				if (Event.current.type == EventType.MouseUp)
				{
					if (s_currentlyDragging == id)
					{
						s_currentlyDragging = -1;
					}

				}

			}
		}

	}
}
