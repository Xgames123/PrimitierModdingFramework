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


		public Transform CubeTransform;



		public void Press()
		{
			PMFLog.Message("Press");
			if (_IsPressed)
			{
				return;
			}

			_IsPressed = true;
			CubeTransform.localScale = new Vector3(CubeTransform.localScale.x, CubeTransform.localScale.y, 0.01f);

			CubeTransform.localPosition += new Vector3(0, 0, 0.02f);
		}

		public void Release()
		{
			
			if (!_IsPressed)
			{
				return;
			}

			_IsPressed = false;
			CubeTransform.localScale = new Vector3(CubeTransform.localScale.x, CubeTransform.localScale.y, 0.03f);
			CubeTransform.localPosition -= new Vector3(0, 0, 0.02f);
		}


	}
}
