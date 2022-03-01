using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public class FlyCam : MonoBehaviour
	{
		public FlyCam(System.IntPtr ptr) : base(ptr) { }

		/// <summary>
		/// The current flycam
		/// </summary>
		public static FlyCam Current { get; private set; } = null;



		/// <summary>
		/// Removes the current FlyCam
		/// </summary>
		public static void Remove()
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			if (Current == null)
			{
				return;
			}

			Destroy(Current);
			HandyCamera.Instance.transform.Find("CameraGrip").gameObject.SetActive(true);
			HandyCamera.Instance.transform.Find("CameraBody").gameObject.SetActive(true);
			HandyCamera.Instance.enabled = true;

			Current = null;
		}


		/// <summary>
		/// Creates a new FlyCam if it doesn't exists
		/// </summary>
		public static void Create()
		{
			if (!InGameDebuggingSystem.IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(InGameDebuggingSystem));

			if (Current != null)
			{
				return;
			}

			Current = HandyCamera.Instance.transform.Find("ThirdPersonUICamera").gameObject.AddComponent<FlyCam>();
			HandyCamera.Instance.transform.Find("CameraGrip").gameObject.SetActive(false);
			HandyCamera.Instance.transform.Find("CameraBody").gameObject.SetActive(false);
			HandyCamera.Instance.enabled = false;
		}


	}
}
