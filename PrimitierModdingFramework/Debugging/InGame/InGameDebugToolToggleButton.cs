using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class InGameDebugToolToggleButton : MonoBehaviour
	{
		private Il2CppSystem.Action _OnValueChanged = null;
		private bool _value = false;

		public InGameDebugToolToggleButton(System.IntPtr ptr) : base(ptr) { }


		/// <summary>
		/// If set to true the buttons value can't be changed by the user
		/// </summary>
		public bool Lock { get; set; } = false;
		/// <summary>
		/// Is true when the button is pressed else it is false
		/// </summary>
		public bool Value { get { return _value; } set { _value = value; UpdateButton(); } }
		public Transform CubeTransform;


		public void AttachOnValueChanged(Il2CppSystem.Action onPress)
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			_OnValueChanged = onPress;

		}


		public void OnPress()
		{
			if (Lock)
				return;

			if (Value)
				Value = false;
			else
				Value = true;

			_OnValueChanged?.Invoke();

			UpdateButton();
		}

		/// <summary>
		/// Updates the buttons UI
		/// </summary>
		public void UpdateButton()
		{
			if (Value)
			{
				CubeTransform.localScale = new Vector3(1, 1, 0.3f);
				CubeTransform.localPosition = new Vector3(0, 0, 0.3f);
				CubeTransform.GetComponent<MeshRenderer>().material.color = new Color(0, 0.8f, 1);
			}
			else
			{
				CubeTransform.localScale = new Vector3(1, 1, 1);
				CubeTransform.localPosition = new Vector3(0, 0, 0);
				CubeTransform.GetComponent<MeshRenderer>().material.color = Color.grey;
			}


			
		}
	}
}
