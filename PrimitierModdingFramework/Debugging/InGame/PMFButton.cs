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
	


		private void Start()
		{
			
		}

		public void Press()
		{

			if (_IsPressed)
			{
				return;
			}

			_IsPressed = true;
			CubeTransform.localScale = new Vector3(1, 1, 0.3f);
			CubeTransform.localPosition = new Vector3(0, 0, 0.3f);
			CubeTransform.GetComponent<MeshRenderer>().material.color = new Color(0, 0.8f, 1);
		}

		public void Release()
		{
			
			if (!_IsPressed)
			{
				return;
			}

			_IsPressed = false;
			CubeTransform.localScale = new Vector3(1, 1, 1);
			CubeTransform.localPosition = new Vector3(0, 0, 0);
			CubeTransform.GetComponent<MeshRenderer>().material.color = Color.grey;

			
		}


	}
}
