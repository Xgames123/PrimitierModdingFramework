using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnhollowerBaseLib;

namespace PrimitierModdingFramework.Debugging.Editor
{
	public class PMFEditorSystem : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		private static Rect _windowRect = new Rect(20, 20, 500, 500);
		

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
			_windowRect = PMFEditorLayout.Window(0, "Test", _windowRect, OnWindow);
			

		}

		private static void OnWindow(int id)
		{
			GUILayout.Button("hi", PMFEditorLayout.EmptyLayout);
			GUILayout.Button("hi", PMFEditorLayout.EmptyLayout);

		}



	}
}
