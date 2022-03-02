using PrimitierModdingFramework.Debugging;
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
	public class DebuggingWindow : EditorWindow
	{
		private Rect _rect;

		private bool _shown = false;

		private int _id = PMFEditorLayout.NewWindowId();

		private bool _flyCamEnabled = false;

		protected internal override void OnDraw()
		{
			if (_shown)
			{
				_rect = PMFEditorLayout.Window(_id, "Debug", _rect, OnWindow, hasCloseButton: true);
			}

		}

		protected internal override void OnGlobalMenuBar()
		{
			if (PMFEditorLayout.GlobalMenuBarItem(100, "Debug"))
			{
				_rect = new Rect(Event.current.mousePosition.x, PMFEditorLayout.MenuBarSize+PMFEditorLayout.WindowDragBarSize, 200, 200);
				_shown = true;
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

			if(PMFEditorLayout.Button(_rect.width, "Dump Scene"))
			{
				HierarchyXmlDumper.DumpSceneToFile(HierarchyXmlDumper.DefaultDumperList);
			}
			if (PMFEditorLayout.Button(_rect.width, "Dump Resources"))
			{
				ResourceXmlDumper.DumpAllToFile();
			}

			var newValue = PMFEditorLayout.ToggleButton(_flyCamEnabled, _rect.width, "Fly cam");
			if (newValue != _flyCamEnabled)
			{
				if (newValue)
				{
					FlyCam.Create();
				}
				else
				{
					FlyCam.Remove();
				}

			}
			_flyCamEnabled = newValue;

			PMFEditorLayout.EndVertical();
		}
	}
}
