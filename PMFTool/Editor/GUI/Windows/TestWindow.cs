using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Editor.GUI.Windows
{
	public class TestWindow : GUIWindow
	{
		public override string Name => "Test window";

		protected override void OnGUI()
		{
			ImGui.Button("test test");
		}
	}
}
