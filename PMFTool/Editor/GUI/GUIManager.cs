using PMFTool.Editor.GUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Editor.GUI
{
	public static class GUIManager
	{
		public static ImGuiManager ImGuiManager;


		public static void StartImGui()
		{
			ImGuiManager = new ImGuiManager(OnImgui, "PMF Editor");
		}
		

		private static void OnImgui()
		{

		}

	}
}
