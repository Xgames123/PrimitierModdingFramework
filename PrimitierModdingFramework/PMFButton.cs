using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace PrimitierModdingFramework
{

	public class PMFButton : MonoBehaviour
	{
		public PMFButton(IntPtr ptr) : base(ptr) { }



		private bool _IsPressed = false;

		private void Start()
		{

		}

		private void FixedUpdate()
		{

		}

		private void Press()
		{
			if (_IsPressed)
			{
				return;
			}

			_IsPressed = true;
			transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0.01f);
			transform.localPosition += new Vector3(0, 0, 0.02f);
		}

		private void Release()
		{
			
			if (!_IsPressed)
			{
				return;
			}

			_IsPressed = false;
			transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0.03f);
			transform.localPosition -= new Vector3(0, 0, 0.02f);
		}

		private void OnCollisionEnter(Collision collision)
		{
			PMFLog.Message("Press");
			Press();
		}

		private void OnCollisionExit(Collision other)
		{
			Release();
		}
	}
}
