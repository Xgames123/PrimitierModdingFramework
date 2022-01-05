/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public class AxisTools // TypeDefIndex: 8274
	{
		// Constructors
		public AxisTools(); // 0x00000001802650F0-0x0000000180265100
	
		// Methods
		public static Vector3 ToVector3(Axis axis); // 0x00000001807C0300-0x00000001807C0350
		public static Axis ToAxis(Vector3 v); // 0x00000001807C0280-0x00000001807C0300
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition); // 0x00000001807BFE00-0x00000001807BFF40
		public static Axis GetAxisToDirection(Transform t, Vector3 direction); // 0x00000001807BFD10-0x00000001807BFE00
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition); // 0x00000001807C01B0-0x00000001807C0280
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction); // 0x00000001807BFF40-0x00000001807C01B0
	}
}
