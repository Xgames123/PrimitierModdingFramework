using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.Editor.Windows
{
	/// <summary>
	/// A window for debugging stuff
	/// </summary>
	public static class DebuggingWindow
	{
		public static Rect Rect;

		public static bool Shown = false;

		public static int Id { get; private set; } = PMFEditorLayout.NewWindowId();

		private static bool flyCamEnabled = false;

		public static void Draw()
		{
			if (Shown)
			{
				Rect = PMFEditorLayout.Window(Id, "Debug", Rect, OnWindow, hasCloseButton: true);
			}

		}

		public static void MenuBar()
		{
			if (PMFEditorLayout.GlobalMenuBarItem(100, "Debug"))
			{
				Rect = new Rect(Event.current.mousePosition.x, PMFEditorLayout.MenuBarSize+PMFEditorLayout.WindowDragBarSize, 200, 200);
				Shown = true;
			}

		}

		private static void OnWindow(int id, bool closing)
		{
			if (closing)
			{
				Shown = false;
				return;
			}

			PMFEditorLayout.BeginVertical();

			if(PMFEditorLayout.Button(200, 30, "Dump Scene"))
			{
				HierarchyXmlDumper.DumpSceneToFile(HierarchyXmlDumper.DefaultDumperList);
			}
			if (PMFEditorLayout.Button(200, 30, "Dump Resources"))
			{
				ResourceXmlDumper.DumpAllToFile();
			}

			flyCamEnabled = PMFEditorLayout.ToggleButton(flyCamEnabled, 200, 30, "Fly cam");
			if (flyCamEnabled)
			{
				
			}

			PMFEditorLayout.EndVertical();
		}
	}
}
