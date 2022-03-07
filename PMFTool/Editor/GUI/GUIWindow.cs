using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Editor.GUI
{
	public enum GUIWindowType
	{
		Window,
		Popup,
		NoWindow,

	}
	
	public abstract class GUIWindow
	{
		private bool _isShown = false;

		public bool IsShown { get { return _isShown; } }

		public abstract string Name { get; }

		public virtual GUIWindowType Type { get; } = GUIWindowType.Window;
		
		public ImGuiWindowFlags WindowFlags { get; protected set; } = ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.DockNodeHost;
		public bool ShowInWindowMenu { get; protected set; } = true;

		protected abstract void OnGUI();

		public void Open()
		{
			if (Type == GUIWindowType.Window)
			{
				_isShown = true;
				ImGui.SetWindowFocus(Name);
			}
			else if (Type == GUIWindowType.Popup)
			{
				ImGui.OpenPopup(Name);
				_isShown = true;
			}
		}
		public void Close()
		{
			if (Type == GUIWindowType.Window)
			{
				_isShown = false;
			}
			else if (Type == GUIWindowType.Popup)
			{
				_isShown = false;
			}
		}


		public static void DrawAll()
		{
			foreach (GUIWindow window in GUIManager.Windows)
			{

				if (window.Type == GUIWindowType.Window)
				{
					ImGui.Begin(window.Name, ref window._isShown, window.WindowFlags);

					window.OnGUI();

					ImGui.End();
				}
				else if (window.Type == GUIWindowType.Popup)
				{
					if (ImGui.BeginPopupModal(window.Name, ref window._isShown, window.WindowFlags))
					{
						window.OnGUI();

						ImGui.EndPopup();
					}

				}
				else if (window.Type == GUIWindowType.NoWindow)
				{
					window.OnGUI();
				}


			}
		}

	}
}
