using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;

namespace PrimitierModdingFramework
{
	public class PMFButtonPusher : MonoBehaviour
	{
		public PMFButtonPusher(IntPtr ptr) : base(ptr) { }


		private void Start()
		{
			var collider = gameObject.AddComponent<SphereCollider>();
			collider.radius = 0.01f;

			
		}


		private void OnCollisionEnter(Collision collision)
		{
			PMFButton button = collision.collider.GetComponent<PMFButton>();

			if (button == null)
			{
				return;
			}


			button.Press();
		}

		private void OnCollisionExit(Collision collision)
		{
			PMFButton button = collision.collider.GetComponent<PMFButton>();

			if (button == null)
			{
				return;
			}

			button.Release();
		}

	}
}
