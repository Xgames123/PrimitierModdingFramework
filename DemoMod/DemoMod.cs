using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

namespace DemoMod
{
    public class DemoMod : PrimitierMod
    {
		

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);

		}



		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();

		}
		public override void OnUpdate()
		{
			base.OnUpdate();

			if (Input.GetKeyDown(KeyCode.A))
			{
				PMFLog.Message("Starting Dump");
				HierarchyXmlDumper.DumpCurrentSceneToFile(HierarchyXmlDumper.DefaultDumperList);
				PMFLog.Message($"Dump complete saved at '{Path.Combine(Environment.CurrentDirectory, HierarchyXmlDumper.FilePath)}'");

			}

		}



	}
}
