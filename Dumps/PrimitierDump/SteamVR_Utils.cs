/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

public static class SteamVR_Utils // TypeDefIndex: 7139
{
	// Fields
	private const string secretKey = "foobar"; // Metadata: 0x003A5261

	// Nested types
	public class Event // TypeDefIndex: 7136
	{
		// Fields
		private static Hashtable listeners; // 0x00

		// Nested types
		public delegate void Handler(params /* 0x0000000180014D50-0x0000000180014D60 */ object[] args); // TypeDefIndex: 7135; 0x00000001808478C0-0x0000000180847D30

		// Constructors
		public Event(); // 0x00000001802650F0-0x0000000180265100
		static Event(); // 0x000000018028D7A0-0x000000018028D800

		// Methods
		public static void Listen(string message, Handler action); // 0x000000018028D3B0-0x000000018028D560
		public static void Remove(string message, Handler action); // 0x000000018028D570-0x000000018028D6D0
		public static void Send(string message, params /* 0x0000000180014D50-0x0000000180014D60 */ object[] args); // 0x000000018028D6D0-0x000000018028D790
	}

	[Serializable]
	public struct RigidTransform // TypeDefIndex: 7137
	{
		// Fields
		public Vector3 pos; // 0x00
		public Quaternion rot; // 0x0C

		// Properties
		public static RigidTransform identity { get; } // 0x0000000180291840-0x00000001802918A0 

		// Constructors
		public RigidTransform(Vector3 pos, Quaternion rot); // 0x0000000180291050-0x0000000180291070
		public RigidTransform(Transform t); // 0x00000001802917E0-0x0000000180291840
		public RigidTransform(Transform from, Transform to); // 0x0000000180290EF0-0x0000000180291050
		public RigidTransform(HmdMatrix34_t pose); // 0x00000001802914C0-0x00000001802917E0
		public RigidTransform(HmdMatrix44_t pose); // 0x0000000180291070-0x00000001802914C0

		// Methods
		public static RigidTransform FromLocal(Transform t); // 0x00000001802900B0-0x0000000180290130
		public HmdMatrix44_t ToHmdMatrix44(); // 0x0000000180290AA0-0x0000000180290E40
		public HmdMatrix34_t ToHmdMatrix34(); // 0x00000001802907A0-0x0000000180290AA0
		public override bool Equals(object o); // 0x000000018028FF90-0x00000001802900B0
		public override int GetHashCode(); // 0x0000000180290130-0x0000000180290160
		public static bool operator ==(RigidTransform a, RigidTransform b); // 0x00000001802918A0-0x0000000180291990
		public static bool operator !=(RigidTransform a, RigidTransform b); // 0x0000000180291990-0x0000000180291A80
		public static RigidTransform operator *(RigidTransform a, RigidTransform b); // 0x0000000180291B30-0x0000000180291CA0
		public void Inverse(); // 0x00000001802905A0-0x0000000180290650
		public RigidTransform GetInverse(); // 0x0000000180290160-0x0000000180290250
		public void Multiply(RigidTransform a, RigidTransform b); // 0x0000000180290650-0x00000001802907A0
		public Vector3 InverseTransformPoint(Vector3 point); // 0x00000001802904C0-0x00000001802905A0
		public Vector3 TransformPoint(Vector3 point); // 0x0000000180290E40-0x0000000180290EF0
		public static Vector3 operator *(RigidTransform t, Vector3 v); // 0x0000000180291A80-0x0000000180291B30
		public static RigidTransform Interpolate(RigidTransform a, RigidTransform b, float t); // 0x0000000180290250-0x00000001802903D0
		public void Interpolate(RigidTransform to, float t); // 0x00000001802903D0-0x00000001802904C0
	}

	public delegate object SystemFn(CVRSystem system, params /* 0x0000000180014D50-0x0000000180014D60 */ object[] args); // TypeDefIndex: 7138; 0x0000000180292A20-0x0000000180292EC0

	// Methods
	public static bool IsValid(Vector3 vector); // 0x0000000180C76470-0x0000000180C764D0
	public static bool IsValid(Quaternion rotation); // 0x0000000180C764D0-0x0000000180C76560
	public static Quaternion Slerp(Quaternion A, Quaternion B, float t); // 0x0000000180C76790-0x0000000180C76970
	public static Vector3 Lerp(Vector3 A, Vector3 B, float t); // 0x0000000180C76560-0x0000000180C765E0
	public static float Lerp(float A, float B, float t); // 0x0000000180C765F0-0x0000000180C76600
	public static double Lerp(double A, double B, double t); // 0x0000000180C765E0-0x0000000180C765F0
	public static float InverseLerp(Vector3 A, Vector3 B, Vector3 result); // 0x0000000180C763D0-0x0000000180C76470
	public static float InverseLerp(float A, float B, float result); // 0x0000000180C763C0-0x0000000180C763D0
	public static double InverseLerp(double A, double B, double result); // 0x0000000180C763B0-0x0000000180C763C0
	public static float Saturate(float A); // 0x0000000180C76720-0x0000000180C76740
	public static Vector2 Saturate(Vector2 A); // 0x0000000180C76740-0x0000000180C76790
	public static float Abs(float A); // 0x0000000180C75880-0x0000000180C75890
	public static Vector2 Abs(Vector2 A); // 0x0000000180C75840-0x0000000180C75880
	private static float _copysign(float sizeval, float signval); // 0x0000000180C77EA0-0x0000000180C77EF0
	public static float GetLossyScale(Transform t); // 0x0000000180C75FE0-0x0000000180C76010
	public static string GetBadMD5Hash(string usedString); // 0x0000000180C75E60-0x0000000180C75FE0
	public static string GetBadMD5Hash(byte[] bytes); // 0x0000000180C75D40-0x0000000180C75E60
	public static string GetBadMD5HashFromFile(string filePath); // 0x0000000180C75B70-0x0000000180C75D40
	public static string SanitizePath(string path, bool allowLeadingSlash = true /* Metadata: 0x003A5260 */); // 0x0000000180C76600-0x0000000180C76720
	public static System.Type FindType(string typeName); // 0x0000000180C75A00-0x0000000180C75B70
	public static object CallSystemFn(SystemFn fn, params /* 0x0000000180014D50-0x0000000180014D60 */ object[] args); // 0x0000000180C75890-0x0000000180C75A00
	public static void TakeStereoScreenshot(uint screenshotHandle, GameObject target, int cellSize, float ipd, ref string previewFilename, ref string VRFilename); // 0x0000000180C76970-0x0000000180C77EA0

	// Extension methods
	public static Quaternion GetRotation(this Matrix4x4 matrix); // 0x0000000180C76040-0x0000000180C76250
	public static Vector3 GetPosition(this Matrix4x4 matrix); // 0x0000000180C76010-0x0000000180C76040
	public static Vector3 GetScale(this Matrix4x4 m); // 0x0000000180C76250-0x0000000180C763B0
}

