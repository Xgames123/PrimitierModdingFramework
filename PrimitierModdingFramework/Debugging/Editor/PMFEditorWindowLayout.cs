using System;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.Editor
{
	public partial class PMFEditorLayout
	{
		public const int WindowDragBarSize = 30;
		public const int WindowResizePointSize = 30;

		private static int s_currentlyDragging = -1;
		private static Vector2 s_currentlyDraggingOffset = Vector2.zero;

		private static int s_currentlyResizing = -1;
		private static Vector2 s_currentlyResizingOffset = Vector2.zero;

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

			GUI.color = Color.gray;
			var resizePoint = new Rect(
				windowRect.x + windowRect.width - WindowResizePointSize,
				windowRect.y + windowRect.height - WindowResizePointSize,
				WindowResizePointSize,
				WindowResizePointSize);
			GUI.Box(resizePoint, "");

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


			windowRect = DoWindowDrag(id, dragbar, windowRect);
			windowRect = DoWindowResize(id, resizePoint, windowRect);

			return windowRect;
		}


		private static Rect DoWindowResize(int id, Rect resizePoint, Rect window)
		{
			if (resizePoint.Contains(Event.current.mousePosition))
			{
				if (Event.current.type == EventType.mouseDown)
				{
					s_currentlyResizingOffset = resizePoint.position - Event.current.mousePosition;
					s_currentlyResizing = id;
				}

			}

			if (Event.current.type == EventType.mouseUp)
			{
				if (s_currentlyResizing == id)
				{
					s_currentlyResizing = -1;
				}
			}


			if(s_currentlyResizing == id)
			{
				window.width = Event.current.mousePosition.x - window.x - s_currentlyResizingOffset.x;
				window.height = Event.current.mousePosition.y - window.y - s_currentlyResizingOffset.y;

				if (window.width < 40)
				{
					window.width = 40;
				}
				if (window.height < 40)
				{
					window.height = 40;
				}

				if (window.y + window.height > Screen.height)
				{
					window.height = Screen.height - window.y;
				}
				if (window.x + window.width > Screen.width)
				{
					window.width = Screen.width - window.x;
				}

			}
			return window;

		}



		private static Rect DoWindowDrag(int id, Rect dragbar, Rect window)
		{
			if (dragbar.Contains(Event.current.mousePosition))
			{
				if (Event.current.type == EventType.MouseDown)
				{
					s_currentlyDraggingOffset = dragbar.position - Event.current.mousePosition + new Vector2(0, WindowDragBarSize);
					s_currentlyDragging = id;
				}
				
			}

			if (Event.current.type == EventType.MouseUp)
			{
				if (s_currentlyDragging == id)
				{
					s_currentlyDragging = -1;
				}

			}

			if (s_currentlyDragging == id)
			{
				window.position = Event.current.mousePosition + s_currentlyDraggingOffset;

				if (window.x < 0)
				{
					window.x = 0;
				}
				if (window.y - dragbar.height < 0)
				{
					window.y = dragbar.height;
				}

				if (window.x + window.width > Screen.width)
				{
					window.x = Screen.width - window.width;
				}
				if (window.y + window.height > Screen.height)
				{
					window.y = Screen.height - window.height;
				}

			}

			return window;
		}

	}
}
