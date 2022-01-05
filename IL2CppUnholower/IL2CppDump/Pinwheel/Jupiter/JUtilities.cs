/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	public static class JUtilities // TypeDefIndex: 8742
	{
		// Fields
		public static float DELTA_TIME; // 0x00
		private static Mesh quadMesh; // 0x08
	
		// Properties
		public static Mesh QuadMesh { get; } // 0x00000001803192C0-0x00000001803194A0 
	
		// Constructors
		static JUtilities(); // 0x0000000180319280-0x00000001803192C0
	
		// Methods
		public static T[][] CreateJaggedArray<T>(int dimension1, int dimension2);
		public static T[] To1dArray<T>(T[][] jaggedArray);
		public static T[] To1dArray<T>(T[,] grid);
		public static void Fill<T>(T[] array, T value);
		public static void CopyTo<T>(T[] src, T[] des);
		public static int Sum(int[,] array); // 0x00000001803191C0-0x0000000180319270
		public static int To1DIndex(int x, int z, int width); // 0x0000000180319270-0x0000000180319280
		public static bool IsInRange(float number, float minValue, float maxValue); // 0x00000001803185E0-0x00000001803185F0
		public static bool IsInRangeExclusive(float number, float minValue, float maxValue); // 0x00000001803185D0-0x00000001803185E0
		public static float GetFraction(float value, float floor, float ceil); // 0x00000001802A0CD0-0x00000001802A0CE0
		public static void ClearChildren(Transform t); // 0x0000000180316150-0x0000000180316210
		public static Gradient CreateFullWhiteGradient(); // 0x0000000180316540-0x00000001803166A0
		public static Gradient CreateFullTransparentGradient(); // 0x00000001803163E0-0x0000000180316540
		public static void CalculateBarycentricCoord(Vector2 p, Vector2 p1, Vector2 p2, Vector2 p3, ref Vector3 bary); // 0x0000000180315FF0-0x0000000180316150
		public static void ExpandTrisUvCoord(Texture2D tex, Vector2[] trisUv); // 0x0000000180317080-0x0000000180317490
		public static bool ContainIdenticalElements<T>(T[] arr1, T[] arr2);
		public static float GetNearestMultiple(float number, float multipleOf); // 0x0000000180317CF0-0x0000000180317D60
		public static Transform GetChildrenWithName(Transform parent, string name); // 0x00000001803176B0-0x0000000180317880
		public static void ResetTransform(Transform t, Transform parent); // 0x0000000180318F40-0x0000000180318FF0
		public static void DestroyGameobject(GameObject g); // 0x0000000180316CB0-0x0000000180316D10
		public static void DestroyGameObjectWithUndo(GameObject g); // 0x0000000180316C20-0x0000000180316CB0
		public static void DestroyObject(UnityEngine.Object o); // 0x0000000180316E10-0x0000000180316E70
		public static string Repeat(char src, int count); // 0x0000000180318EB0-0x0000000180318F40
		public static void MarkCurrentSceneDirty(); // 0x0000000180265310-0x0000000180265320
		public static GameObject[] GetChildrenGameObjects(Transform parent); // 0x00000001803174C0-0x00000001803175C0
		public static Transform[] GetChildrenTransforms(Transform parent); // 0x00000001803175C0-0x00000001803176B0
		public static Vector3 RotateVectorAroundNormal(Vector3 vector, Vector3 normal, float angleDegree); // 0x0000000180318FF0-0x00000001803191C0
		public static Mesh GetPrimitiveMesh(PrimitiveType type); // 0x0000000180317D60-0x0000000180317E50
		public static void ShuffleList<T>(List<T> list);
		public static int[] GetShuffleIndicesArray(int length); // 0x0000000180317F30-0x0000000180318080
		public static int[] GetIndicesArray(int length); // 0x0000000180317C80-0x0000000180317CF0
		public static void ResetArray<T>(ref T[] array, int count, T defaultValue);
		public static bool EnsureArrayLength<T>(ref T[] array, int count);
		public static float GetValueBilinear(float[] data, int width, int height, Vector2 uv); // 0x00000001803183C0-0x00000001803185B0
		public static Color GetColorBilinear(Color[] textureData, int width, int height, Vector2 uv); // 0x0000000180317880-0x0000000180317C40
		public static GameObject CreatePreviewGameObject(Mesh m, Material mat, Vector3 position); // 0x0000000180316A60-0x0000000180316C20
		public static Camera CreatePreviewCamera(GameObject target, float distance, float padding); // 0x00000001803166A0-0x0000000180316A60
		public static void EnsureDirectoryExists(string dir); // 0x0000000180316EF0-0x0000000180316F20
		public static void SetStaticRecursively(GameObject g, bool isStatic); // 0x0000000180265310-0x0000000180265320
		public static void EnsureLengthSufficient<T>(List<T> list, int preferredLength)
			where T : UnityEngine.Object;
		public static void EnsureLengthSufficient(List<string> list, int preferredLength); // 0x0000000180316F20-0x0000000180316FE0
		public static void EnsureLengthSufficient(List<bool> list, int preferredLength); // 0x0000000180316FE0-0x0000000180317080
		public static string Ellipsis(string s, int length); // 0x0000000180316E70-0x0000000180316EF0
		public static bool IsRectContainPointExclusive(Rect r, Vector2 p); // 0x0000000180318D10-0x0000000180318DB0
		public static Color GetColor(Color baseColor, float alpha); // 0x0000000180317C40-0x0000000180317C80
		public static Rect GetRectContainsPoints(params /* 0x0000000180014D50-0x0000000180014D60 */ Vector2[] points); // 0x0000000180317E50-0x0000000180317F30
		public static float InverseLerpUnclamped(float a, float b, float value); // 0x00000001803185B0-0x00000001803185D0
		public static Vector2 PointToNormalizedUnclampled(Rect r, Vector2 point); // 0x0000000180318DB0-0x0000000180318EB0
		public static Rect GetUvRect(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000180318080-0x00000001803183C0
		public static Gradient Clone(Gradient src); // 0x0000000180316340-0x00000001803163E0
		public static AnimationCurve Clone(AnimationCurve src); // 0x0000000180316210-0x0000000180316340
		public static bool IsPointInsideQuadXZ(Vector3 point, Vector3[] quad); // 0x0000000180318A70-0x0000000180318D10
		public static void DestroyMeshArray(Mesh[] meshes); // 0x0000000180316D10-0x0000000180316E10
		public static Vector2 FlipY(Vector2 v); // 0x0000000180317490-0x00000001803174C0
		public static bool IsPointInCircumcircle(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 p); // 0x0000000180318890-0x0000000180318A70
		public static bool IsPointInCircumcircleXZ(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 p); // 0x00000001803185F0-0x0000000180318890
		public static bool AreSetEqual(ushort[] setA, ushort[] setB); // 0x0000000180315F30-0x0000000180315FF0
	
		// Extension methods
		public static string ListElementsToString<T>(this IEnumerable<T> list, string separator);
		public static void Distinct<T>(this List<T> list);
		public static void AddIfNotContains<T>(this IList<T> list, IEnumerable<T> items);
		public static void AddIfNotContains<T>(this IList<T> list, T item);
		public static Vector3 ToX0Y(this Vector2 v); // 0x00000001802A14A0-0x00000001802A14D0
	}
}
