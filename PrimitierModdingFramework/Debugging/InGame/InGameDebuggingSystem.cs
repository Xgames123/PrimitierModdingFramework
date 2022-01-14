using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebuggingSystem : PMFSystem
	{


		public override void OnStart()
		{
			EnableSystem<PMFHelper>();

			ClassInjector.RegisterTypeInIl2Cpp<PMFButton>();
			ClassInjector.RegisterTypeInIl2Cpp<PMFButtonPusher>();
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<InGameDebugTool>(typeof(IGrabbable));

		}

		public override void OnSceneLoad()
		{
			var LButtonPusher = PMFHelper.LHand.GetComponent<PMFButtonPusher>();
			var RButtonPusher = PMFHelper.RHand.GetComponent<PMFButtonPusher>();

			if (LButtonPusher == null)
			{
				PMFHelper.LHand.gameObject.AddComponent<PMFButtonPusher>();
			}
			if (RButtonPusher == null)
			{
				PMFHelper.RHand.gameObject.AddComponent<PMFButtonPusher>();
			}

			InGameDebugTool.Respawn();
		}

		public override void OnUpdate()
		{
			if (Input.GetKeyUp(KeyCode.Space))
			{
				InGameDebugTool.Respawn();
			}

			base.OnUpdate();
		}


	}
}
