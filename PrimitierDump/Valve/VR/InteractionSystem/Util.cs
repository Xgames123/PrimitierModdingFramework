/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	public static class Util // TypeDefIndex: 7453
	{
		// Fields
		public const float FeetToMeters = 0.3048f; // Metadata: 0x003A5A80
		public const float FeetToCentimeters = 30.48f; // Metadata: 0x003A5A84
		public const float InchesToMeters = 0.0254f; // Metadata: 0x003A5A88
		public const float InchesToCentimeters = 2.54f; // Metadata: 0x003A5A8C
		public const float MetersToFeet = 3.28084f; // Metadata: 0x003A5A90
		public const float MetersToInches = 39.3701f; // Metadata: 0x003A5A94
		public const float CentimetersToFeet = 0.0328084f; // Metadata: 0x003A5A98
		public const float CentimetersToInches = 0.393701f; // Metadata: 0x003A5A9C
		public const float KilometersToMiles = 0.621371f; // Metadata: 0x003A5AA0
		public const float MilesToKilometers = 1.60934f; // Metadata: 0x003A5AA4
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _WrapCoroutine_d__43 : IEnumerator<object> // TypeDefIndex: 7451
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public IEnumerator coroutine; // 0x20
			public System.Action onCoroutineFinished; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _WrapCoroutine_d__43(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x000000018029E990-0x000000018029EA30
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x000000018029EA30-0x000000018029EA70
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__47<T> // TypeDefIndex: 7452
		{
			// Fields
			public static readonly __c__47<T> __9;
			public static Func<T, T> __9__47_0;
	
			// Constructors
			static __c__47();
			public __c__47();
	
			// Methods
			internal T _Median_b__47_0(T x);
		}
	
		// Methods
		public static float RemapNumber(float num, float low1, float high1, float low2, float high2); // 0x00000001802A1020-0x00000001802A1040
		public static float RemapNumberClamped(float num, float low1, float high1, float low2, float high2); // 0x00000001802A0F60-0x00000001802A1020
		public static float Approach(float target, float value, float speed); // 0x000000018029F9E0-0x000000018029FA10
		public static Vector3 BezierInterpolate3(Vector3 p0, Vector3 c0, Vector3 p1, float t); // 0x000000018029FA10-0x000000018029FBB0
		public static Vector3 BezierInterpolate4(Vector3 p0, Vector3 c0, Vector3 c1, Vector3 p1, float t); // 0x000000018029FBB0-0x000000018029FE90
		public static Vector3 Vector3FromString(string szString); // 0x00000001802A1600-0x00000001802A1750
		public static Vector2 Vector2FromString(string szString); // 0x00000001802A14D0-0x00000001802A15D0
		public static float Normalize(float value, float min, float max); // 0x00000001802A0CD0-0x00000001802A0CE0
		public static Vector3 Vector2AsVector3(Vector2 v); // 0x00000001802A14A0-0x00000001802A14D0
		public static Vector2 Vector3AsVector2(Vector3 v); // 0x00000001802A15D0-0x00000001802A1600
		public static float AngleOf(Vector2 v); // 0x000000018029F980-0x000000018029F9E0
		public static float YawOf(Vector3 v); // 0x00000001802A17C0-0x00000001802A1820
		public static void Swap<T>(ref T lhs, ref T rhs);
		public static void Shuffle<T>(T[] array);
		public static void Shuffle<T>(List<T> list);
		public static int RandomWithLookback(int min, int max, List<int> history, int historyCount); // 0x00000001802A0E60-0x00000001802A0F60
		public static Transform FindChild(Transform parent, string name); // 0x00000001802A0540-0x00000001802A0790
		public static bool IsNullOrEmpty<T>(T[] array);
		public static bool IsValidIndex<T>(T[] array, int i);
		public static bool IsValidIndex<T>(List<T> list, int i);
		public static int FindOrAdd<T>(List<T> list, T item);
		public static List<T> FindAndRemove<T>(List<T> list, Predicate<T> match);
		public static T FindOrAddComponent<T>(GameObject gameObject)
			where T : Component;
		public static void FastRemove<T>(List<T> list, int index);
		public static void ReplaceGameObject<T, U>(T replace, U replaceWith)
			where T : MonoBehaviour
			where U : MonoBehaviour;
		public static void SwitchLayerRecursively(Transform transform, int fromLayer, int toLayer); // 0x00000001802A13D0-0x00000001802A14A0
		public static void DrawCross(Vector3 origin, Color crossColor, float size); // 0x00000001802A0190-0x00000001802A0540
		public static void ResetTransform(Transform t, bool resetScale = true /* Metadata: 0x003A5A7A */); // 0x00000001802A1040-0x00000001802A1100
		public static Vector3 ClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint); // 0x000000018029FE90-0x00000001802A0060
		public static void AfterTimer(GameObject go, float _time, System.Action callback, bool trigger_if_destroyed_early = false /* Metadata: 0x003A5A7B */); // 0x000000018029F8F0-0x000000018029F980
		public static void SendPhysicsMessage(Collider collider, string message, SendMessageOptions sendMessageOptions); // 0x00000001802A1100-0x00000001802A1210
		public static void SendPhysicsMessage(Collider collider, string message, object arg, SendMessageOptions sendMessageOptions); // 0x00000001802A1210-0x00000001802A1350
		public static void IgnoreCollisions(GameObject goA, GameObject goB); // 0x00000001802A0B70-0x00000001802A0CD0
		[IteratorStateMachine] // 0x0000000180025FD0-0x0000000180026020
		public static IEnumerator WrapCoroutine(IEnumerator coroutine, System.Action onCoroutineFinished); // 0x00000001802A1750-0x00000001802A17C0
		public static void Quit(); // 0x00000001802A0E30-0x00000001802A0E60
		public static decimal FloatToDecimal(float value, int decimalPlaces = 2 /* Metadata: 0x003A5A7C */); // 0x00000001802A0830-0x00000001802A0900
		public static string FixupNewlines(string text); // 0x00000001802A0790-0x00000001802A0830
		public static float PathLength(NavMeshPath path); // 0x00000001802A0CE0-0x00000001802A0E30
		public static bool HasCommandLineArgument(string argumentName); // 0x00000001802A0AE0-0x00000001802A0B70
		public static int GetCommandLineArgValue(string argumentName, int nDefaultValue); // 0x00000001802A0900-0x00000001802A09D0
		public static float GetCommandLineArgValue(string argumentName, float flDefaultValue); // 0x00000001802A09D0-0x00000001802A0AE0
		public static void SetActive(GameObject gameObject, bool active); // 0x00000001802A1350-0x00000001802A13D0
		public static string CombinePaths(params /* 0x0000000180014D50-0x0000000180014D60 */ string[] paths); // 0x00000001802A0080-0x00000001802A0190
	
		// Extension methods
		public static Color ColorWithAlpha(this Color color, float alpha); // 0x00000001802A0060-0x00000001802A0080
		public static T Median<T>(this IEnumerable<T> source);
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action);
	}
}
