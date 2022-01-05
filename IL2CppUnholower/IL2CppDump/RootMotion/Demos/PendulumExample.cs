/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.Demos
{
	[RequireComponent] // 0x000000018001C8D0-0x000000018001C920
	public class PendulumExample : MonoBehaviour // TypeDefIndex: 8336
	{
		// Fields
		[Range] // 0x000000018001C920-0x000000018001C980
		[Tooltip] // 0x000000018001C920-0x000000018001C980
		public float weight; // 0x18
		[Tooltip] // 0x000000018001C980-0x000000018001C9B0
		public float hangingDistanceMlp; // 0x1C
		[HideInInspector] // 0x000000018001C9B0-0x000000018001C9F0
		[Tooltip] // 0x000000018001C9B0-0x000000018001C9F0
		public Vector3 rootTargetPosition; // 0x20
		[HideInInspector] // 0x000000018001C9F0-0x000000018001CA40
		[Tooltip] // 0x000000018001C9F0-0x000000018001CA40
		public Quaternion rootTargetRotation; // 0x2C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform target; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform leftHandTarget; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform rightHandTarget; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform leftFootTarget; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform rightFootTarget; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform pelvisTarget; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform bodyTarget; // 0x70
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform headTarget; // 0x78
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Vector3 pelvisDownAxis; // 0x80
		private FullBodyBipedIK ik; // 0x90
		private Quaternion rootRelativeToPelvis; // 0x98
		private Vector3 pelvisToRoot; // 0xA8
		private float lastWeight; // 0xB4
	
		// Constructors
		public PendulumExample(); // 0x00000001807780B0-0x0000000180778100
	
		// Methods
		private void Start(); // 0x0000000180777D30-0x00000001807780B0
		private void LateUpdate(); // 0x0000000180777410-0x0000000180777D30
	}
}
