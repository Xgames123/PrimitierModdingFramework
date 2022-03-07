using ImGuiNET;
using PMFTool.Editor.GUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Editor.GUI
{


	public static class GUIManager
	{
		public static GUIWindow[] Windows = new GUIWindow[] { };

		public static ImGuiManager? ImGuiManager = null;


		public static void StartImGui()
		{
			ImGuiManager = new ImGuiManager(OnImgui, "PMF Editor");
			SetStyle();
		}

		public static void StopImGui()
		{
			ImGuiManager?.Dispose();
			ImGuiManager = null;
		}


		private static void OnImgui()
		{
		
		}

		public static T GetWindow<T>() where T : GUIWindow
		{
			foreach (GUIWindow window in Windows)
			{
				if (window is T)
				{
					return window as T;
				}

			}
			return null;
		}



		private static void SetStyle()
		{
			ImGuiStylePtr style = ImGui.GetStyle();
			style.FrameRounding = 1;
			style.GrabRounding = 1;
			style.FrameBorderSize = 1;
			style.TabBorderSize = 1;

			style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.15f, 0.15f, 0.15f, 1);
			style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.3f, 0.3f, 0.3f, 1);
			style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.3f, 0.3f, 0.3f, 1);

			style.Colors[(int)ImGuiCol.Header] = new Vector4(0.3f, 0.3f, 0.3f, 1);
			style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.5f, 0.5f, 0.5f, 1);

			style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.3f, 0.3f, 0.3f, 1);
			style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.5f, 0.5f, 0.5f, 1);


			style.Colors[(int)ImGuiCol.Button] = new Vector4(0.3f, 0.3f, 0.3f, 1);
			style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.5f, 0.5f, 0.5f, 1);


			style.Colors[(int)ImGuiCol.Tab] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(0.5f, 0.5f, 0.5f, 1);
			style.Colors[(int)ImGuiCol.TabActive] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.TabUnfocused] = new Vector4(0.4f, 0.4f, 0.4f, 1);
			style.Colors[(int)ImGuiCol.TabUnfocusedActive] = new Vector4(0.4f, 0.4f, 0.4f, 1);

		}
	}
}
