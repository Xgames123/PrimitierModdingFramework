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

		private static List<EditorWindow> _editorWindows = new List<EditorWindow>() {new DebuggingWindow(), new SceneViewerWindow() };

		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}


		/// <summary>
		/// Gets a registered window
		/// </summary>
		/// <param name="window"></param>
		public static T GetWindow<T>() where T : EditorWindow
		{
			foreach (var window in _editorWindows)
			{
				var outWindow = window as T;
				if (outWindow != null)
				{
					return outWindow;
				}

			}

			return null;
		}



		/// <summary>
		/// Registers a new editor window
		/// </summary>
		/// <param name="window"></param>
		public static void RegisterWindow(EditorWindow window)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFEditorSystem));

			_editorWindows.Add(window);
		}

		/// <summary>
		/// UnRegisters a new editor window
		/// </summary>
		/// <param name="window"></param>
		public static void UnRegisterWindow(EditorWindow window)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFEditorSystem));

			
			_editorWindows.Remove(window);
		}
		/// <summary>
		/// UnRegisters a new editor window
		/// </summary>
		/// <param name="window"></param>
		public static void UnRegisterWindow<T>() where T : EditorWindow
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFEditorSystem));


			_editorWindows.Remove(GetWindow<T>());
		}


		public override void OnGUI()
		{
			PMFEditorLayout.BeginGlobalMenuBar();

			foreach (var window in _editorWindows)
			{
				window.OnGlobalMenuBar();
			}

			PMFEditorLayout.EndGlobalMenuBar();

			foreach (var window in _editorWindows)
			{
				window.OnDraw();
			}

		}



	}
}
