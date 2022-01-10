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


		public Vector3 PressDirection;

		private Vector3 _StartScale;
		private float _PushAmount = 0f;

		public void ChangeScale(Vector3 newScale)
		{
			_StartScale = newScale;
			transform.localScale = newScale;
			_PushAmount = 0f;
		}

		private void Start()
		{
			_StartScale = transform.localScale;
			
		}

		private void FixedUpdate()
		{
			if (transform.localScale.magnitude < _StartScale.magnitude)
			{
				transform.localScale += PressDirection * 0.001f;
				_PushAmount -= 0.001f;
			}

		}


		private void OnCollisionEnter(Collision collision)
		{
			PMFLog.Message("Collision ", collision.rigidbody.name);

			if (_PushAmount > 0.1f)
			{
				_PushAmount += 0.01f;
				transform.localScale -= PressDirection * 0.01f;
			}

		}


	}
}
