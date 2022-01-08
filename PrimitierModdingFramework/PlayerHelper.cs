using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{
	public static class PlayerHelper
	{
		public static Transform LHand;
		public static Transform RHand;
		public static Transform CameraRig;
		public static PlayerMovement PlayerMovement;

		public static void OnSceneLoad()
		{
			CameraRig = GameObject.Find("[CameraRig]").transform;
			LHand = GameObject.Find("LeftHand").transform;
			RHand = GameObject.Find("RightHand").transform;

			PlayerMovement = 

		}

	}
}
