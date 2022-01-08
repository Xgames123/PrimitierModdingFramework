using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using UnityEngine;

namespace DemoMod
{
	public static class DebugTools
	{

		public static void Update(MelonLogger.Instance logger)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				logger.Msg("Starting Dump");
				HierarchyXmlDumper.DumpCurrentScene(new ComponentDumperList(new TransformDumper(), new RectTransformDumper()));
				logger.Msg("Dump complete");

			}

		}

	}
}
