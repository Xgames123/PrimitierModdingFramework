using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugToolButton : MonoBehaviour
	{
		public InGameDebugToolButton(System.IntPtr ptr) : base(ptr) { }

		public Transform CubeTransform;

		private int PressCounter = -1;

		private Il2CppSystem.Action _OnPress = null;

		public void AttachOnPressListener(Il2CppSystem.Action onPress)
		{
			_OnPress = onPress;

		}


		public void OnPress()
		{

			CubeTransform.localScale = new Vector3(1, 1, 0.3f);
			CubeTransform.localPosition = new Vector3(0, 0, 0.3f);
			CubeTransform.GetComponent<MeshRenderer>().material.color = new Color(0, 0.8f, 1);

			PressCounter = 0;
		}

		private void FixedUpdate()
		{
			if (PressCounter != -1)
			{
				PressCounter++;
			}

			if (PressCounter == 10)
			{
				PressCounter = -1;
				CubeTransform.localScale = new Vector3(1, 1, 1);
				CubeTransform.localPosition = new Vector3(0, 0, 0);
				CubeTransform.GetComponent<MeshRenderer>().material.color = Color.grey;
				_OnPress?.Invoke();
			}
		}



	}
}
