using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace PrimitierModdingFramework
{
	public class PMFButtonPusher : MonoBehaviour
	{
		public PMFButtonPusher(IntPtr ptr) : base(ptr) { }



		private void Start()
		{

			var collider = gameObject.AddComponent<SphereCollider>();
			collider.isTrigger = true;
			collider.radius = 0.05f;

			
		}


		private void OnTriggerEnter(Collider other)
		{
			PMFButton button = other.GetComponent<PMFButton>();

			if (button == null)
			{
				return;
			}


			button.Press();
		}

		private void OnTriggerExit(Collider other)
		{
			PMFButton button = other.GetComponent<PMFButton>();

			if (button == null)
			{
				return;
			}

			button.Release();
		}

	}
}
