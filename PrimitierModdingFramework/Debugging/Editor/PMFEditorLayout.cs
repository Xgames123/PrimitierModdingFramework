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
	public static partial class PMFEditorLayout
	{

		/// <summary>
		/// An empty GUILayoutOption array
		/// </summary>
		public static Il2CppReferenceArray<GUILayoutOption> EmptyLayout { get; private set; } = new Il2CppReferenceArray<GUILayoutOption>(0);


		public const int MenuBarSize = 30;
		public const int Spaceing = 5;
		public const int ButtonH = 30;

		private static Texture2D s_blueTexture;

		private static bool s_styleSetup = false;

		private static float s_horizontalOffset = 0;
		private static float s_verticalOffset = 0;

		private static bool s_moveHorizontal=false;
		private static bool s_moveVertical = false;

		/// <summary>
		/// creates a button
		/// </summary>
		/// <param name="w"></param>
		/// <param name="h"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool Button(float w, float h, string text)
		{
			TrySetupStyle();

			float x = s_horizontalOffset;
			float y = s_verticalOffset;

			if (s_moveHorizontal)
			{
				s_horizontalOffset += w+Spaceing;
			}
			if (s_moveVertical)
			{
				s_verticalOffset += h + Spaceing;
			}

			return GUI.Button(new Rect(x, y, w, h), text);
		}

		/// <summary>
		/// creates a button
		/// </summary>
		/// <param name="w"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool Button(float w, string text)
		{
			return Button(w, ButtonH, text);
		}


		/// <summary>
		/// creates a toggle button
		/// </summary>
		/// <param name="w"></param>
		/// <param name="h"></param>
		/// <param name="text"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool ToggleButton(bool value, float w, float h, string text)
		{
			TrySetupStyle();

			float x = s_horizontalOffset;
			float y = s_verticalOffset;

			if (s_moveHorizontal)
			{
				s_horizontalOffset += w + Spaceing;
			}
			if (s_moveVertical)
			{
				s_verticalOffset += h + Spaceing;
			}

			
			if (value)
			{
				GUI.skin.button.normal.background = s_blueTexture;
				GUI.skin.button.hover.background = s_blueTexture;
			}
			

			if (GUI.Button(new Rect(x, y, w, h), text))
			{
				if (value)
				{
					return false;
				}
				else
				{
					return true;
				}
			}

			GUI.skin.button.normal.background = Texture2D.grayTexture;
			GUI.skin.button.hover.background = Texture2D.grayTexture;
			return value;
		}

		/// <summary>
		/// creates a toggle button
		/// </summary>
		/// <param name="w"></param>
		/// <param name="text"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool ToggleButton(bool value, float w, string text)
		{
			return ToggleButton(value, w, ButtonH, text);
		}


		/// <summary>
		/// Sets the vertical offset for the next ui elements to be drawn
		/// </summary>
		/// <param name="offset"></param>
		public static void SetVerticalOffset(float offset)
		{
			TrySetupStyle();
			s_verticalOffset = offset;
		}
		/// <summary>
		/// Sets the horizontal offset for the next ui elements to be drawn
		/// </summary>
		/// <param name="offset"></param>
		public static void SetHorizontalOffset(float offset)
		{
			TrySetupStyle();
			s_horizontalOffset = offset;
		}

		/// <summary>
		/// draws the next ui elements horizontal until EndHorizontal is called
		/// </summary>
		public static void BeginHorizontal()
		{
			TrySetupStyle();
			s_moveVertical = false;
			s_moveHorizontal = true;

		}
		public static void EndHorizontal()
		{
			TrySetupStyle();
			s_moveHorizontal = false;
			s_horizontalOffset = 0;

		}

		/// <summary>
		/// draws the next ui elements vertical until EndVertical is called
		/// </summary>
		public static void BeginVertical()
		{
			TrySetupStyle();
			s_moveVertical = true;
			s_moveHorizontal = false;

		}
		public static void EndVertical()
		{
			TrySetupStyle();
			s_moveVertical = false;
			s_verticalOffset = 0;

		}


		/// <summary>
		/// Creates a menu bar at the top of the screen
		/// </summary>
		public static void BeginGlobalMenuBar()
		{
			TrySetupStyle();
			var oldColor = GUI.color;

			GUI.color = Color.grey;
			var bar = new Rect(0, 0, Screen.width, MenuBarSize);

			GUI.Box(bar, "");
			GUI.BeginGroup(bar);

			GUI.color = oldColor;
			s_verticalOffset = 0;
			s_horizontalOffset = 0;
			s_moveHorizontal = false;
			s_moveVertical = false;
		}

		/// <summary>
		/// Creates a menu item in a GlobalMenuBar
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool GlobalMenuBarItem(float w, string text)
		{
			TrySetupStyle();
			var x = s_horizontalOffset;
			s_horizontalOffset += w + Spaceing;

			return GUI.Button(new Rect(x, 0, w, MenuBarSize), text);
		}


		public static void EndGlobalMenuBar()
		{
			TrySetupStyle();
			s_verticalOffset = 0;
			s_horizontalOffset = 0;
			GUI.EndGroup();
		}

	


		
		private static void TrySetupStyle()
		{
			if (s_styleSetup)
			{
				return;
			}

			s_styleSetup = true;

			s_blueTexture = new Texture2D(1, 1);
			s_blueTexture.SetPixel(0, 0, new Color(0, 0.8f, 1));
			s_blueTexture.Apply();

			GUI.skin.box.normal.background = Texture2D.whiteTexture;
			GUI.skin.box.fontSize = 15;
			GUI.skin.box.normal.textColor = Color.white;


			GUI.skin.button.fontSize = 18;
			GUI.skin.button.padding.left = 7;
			GUI.skin.button.padding.right = 7;
			GUI.skin.button.padding.top = 7;
			GUI.skin.button.padding.bottom = 7;

			GUI.skin.button.normal.background = Texture2D.grayTexture;
			GUI.skin.button.normal.textColor = Color.white;
			GUI.skin.button.focused.background = Texture2D.grayTexture;
			GUI.skin.button.focused.textColor = Color.white;
			GUI.skin.button.hover.background = Texture2D.grayTexture;
			GUI.skin.button.hover.textColor = Color.white;
			GUI.skin.button.active.background = s_blueTexture;
			GUI.skin.button.active.textColor = Color.white;

			GUI.color = Color.grey;
			GUI.contentColor = Color.white;
		}

	}
}
