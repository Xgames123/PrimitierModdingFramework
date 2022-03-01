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

		/*
    Writen by Windexglow 11-13-10.  Use it, edit it, steal it I don't care.  
    Converted to C# 27-02-13 - no credit wanted.
    Simple flycam I made, since I couldn't find any others made public.  
    Made simple to use (drag and drop, done) for regular keyboard layout  
    wasd : basic movement
    shift : Makes camera accelerate
    space : Moves camera on X and Z axis only.  So camera doesn't gain any height*/


		public float mainSpeed = 10; //regular speed
		public float shiftAdd = 30.0f; //multiplied by how long shift is held.  Basically running
		public float maxShift = 1000.0f; //Maximum speed when holdin gshift
		public float camSens = 0.25f; //How sensitive it with mouse
		public bool rotateOnlyIfMousedown = true;
		public bool movementStaysFlat = true;

		private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
		private float totalRun = 1.0f;

		void Awake()
		{
			transform.position = new Vector3(0, 8, -32);
			transform.rotation = Quaternion.Euler(25, 0, 0);
		}


		void Update()
		{

			if (Input.GetMouseButtonDown(1))
			{
				lastMouse = Input.mousePosition; // $CTK reset when we begin
			}

			if (!rotateOnlyIfMousedown ||
				(rotateOnlyIfMousedown && Input.GetMouseButton(1)))
			{
				lastMouse = Input.mousePosition - lastMouse;
				lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
				lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
				transform.eulerAngles = lastMouse;
				lastMouse = Input.mousePosition;
				//Mouse  camera angle done.  
			}

			//Keyboard commands
			float f = 0.0f;
			Vector3 p = GetBaseInput();
			if (Input.GetKey(KeyCode.LeftShift))
			{
				totalRun += Time.deltaTime;
				p = p * totalRun * shiftAdd;
				p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
				p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
				p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
			}
			else
			{
				totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
				p = p * mainSpeed;
			}

			p = p * Time.deltaTime;
			Vector3 newPosition = transform.position;
			if (Input.GetKey(KeyCode.Space)
				|| (movementStaysFlat && !(rotateOnlyIfMousedown && Input.GetMouseButton(1))))
			{ //If player wants to move on X and Z axis only
				transform.Translate(p);
				newPosition.x = transform.position.x;
				newPosition.z = transform.position.z;
				transform.position = newPosition;
			}
			else
			{
				transform.Translate(p);
			}

		}

		private Vector3 GetBaseInput()
		{ //returns the basic values, if it's 0 than it's not active.
			Vector3 p_Velocity = new Vector3();
			if (Input.GetKey(KeyCode.W))
			{
				p_Velocity += new Vector3(0, 0, 1);
			}
			if (Input.GetKey(KeyCode.S))
			{
				p_Velocity += new Vector3(0, 0, -1);
			}
			if (Input.GetKey(KeyCode.A))
			{
				p_Velocity += new Vector3(-1, 0, 0);
			}
			if (Input.GetKey(KeyCode.D))
			{
				p_Velocity += new Vector3(1, 0, 0);
			}
			return p_Velocity;
		}


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

			Destroy(Current.gameObject);
			HandyCamera.Instance.transform.Find("ThirdPersonUICamera").GetComponent<Camera>().enabled = true;
			PMFHelper.PlayerMovement.cameraTransform.GetComponent<Camera>().enabled = true;
			HandyCamera.Instance.transform.Find("CameraBody/Lens").GetComponent<Camera>().enabled = true;

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


			var flyCamGameObject = new GameObject("FlyCam");
			Current = flyCamGameObject.AddComponent<FlyCam>();
			flyCamGameObject.AddComponent<Camera>().gameObject.tag = "MainCamera";

			PMFHelper.PlayerMovement.cameraTransform.GetComponent<Camera>().enabled = false;
			HandyCamera.Instance.transform.Find("ThirdPersonUICamera").GetComponent<Camera>().enabled = false;
			HandyCamera.Instance.transform.Find("CameraBody/Lens").GetComponent<Camera>().enabled = false;
		}


	}
}
