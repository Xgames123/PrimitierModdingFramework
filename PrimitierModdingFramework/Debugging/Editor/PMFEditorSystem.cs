using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnhollowerBaseLib;
using PrimitierModdingFramework.Debugging.Editor.Windows;

namespace PrimitierModdingFramework.Debugging.Editor
{
	/// <summary>
	/// A system that creates a custom editor inside Primitier to debug your mods
	/// </summary>
	public class PMFEditorSystem : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;


		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}




		public override void OnGUI()
		{
			PMFEditorLayout.BeginGlobalMenuBar();

			DebuggingWindow.MenuBar();

			PMFEditorLayout.EndGlobalMenuBar();


			DebuggingWindow.Draw();

			

		}



	}
}
