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
	public static class JCommon // TypeDefIndex: 8721
	{
		// Fields
		public static string SUPPORT_EMAIL; // 0x00
		public static string BUSINESS_EMAIL; // 0x08
		public static string YOUTUBE_CHANNEL; // 0x10
		public static string ONLINE_MANUAL; // 0x18
		public static string FORUM; // 0x20
		public static string DISCORD; // 0x28
		public const int PREVIEW_TEXTURE_SIZE = 512; // Metadata: 0x003A6D3E
		public const int TEXTURE_SIZE_MIN = 1; // Metadata: 0x003A6D42
		public const int TEXTURE_SIZE_MAX = 8192; // Metadata: 0x003A6D46
		private static Vector2[] fullRectUvPoints; // 0x30
		private static Mesh emptyMesh; // 0x38
		private static Material[] emptyMaterials; // 0x40
	
		// Properties
		public static JRenderPipelineType CurrentRenderPipeline { get; } // 0x000000018030CC70-0x000000018030CD00 
		public static Vector2[] FullRectUvPoints { get; } // 0x000000018030CF20-0x000000018030D110 
		public static Mesh EmptyMesh { get; } // 0x000000018030CDF0-0x000000018030CF20 
		public static Material[] EmptyMaterials { get; } // 0x000000018030CD00-0x000000018030CDF0 
		public static Rect UnitRect { get; } // 0x000000018030D110-0x000000018030D150 
	
		// Constructors
		static JCommon(); // 0x000000018030CB60-0x000000018030CC70
	
		// Methods
		public static string GetUniqueID(); // 0x000000018030C960-0x000000018030CA50
		public static long GetTimeTick(); // 0x000000018030C8F0-0x000000018030C960
		public static string Reverse(string s); // 0x000000018030CAF0-0x000000018030CB30
		public static void SetDirty(UnityEngine.Object o); // 0x0000000180265310-0x0000000180265320
		public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object asset); // 0x0000000180265310-0x0000000180265320
		public static Texture2D CreateTexture(int resolution, Color fill, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x003A6D36 */); // 0x000000018030B820-0x000000018030B940
		public static void CopyToRT(Texture t, RenderTexture rt); // 0x000000018030B0E0-0x000000018030B160
		public static void CopyFromRT(Texture2D t, RenderTexture rt); // 0x000000018030AE70-0x000000018030AF50
		public static void CopyTexture(Texture2D src, Texture2D des); // 0x000000018030AF50-0x000000018030B0E0
		public static Texture2D CloneTexture(Texture2D t); // 0x000000018030A670-0x000000018030A860
		public static void FillTexture(Texture2D t, Color c); // 0x000000018030C1E0-0x000000018030C2E0
		public static void FillTexture(RenderTexture rt, Color c); // 0x000000018030C080-0x000000018030C1E0
		public static Texture2D CloneAndResizeTexture(Texture2D t, int width, int height); // 0x000000018030A4D0-0x000000018030A670
		public static RenderTexture CopyToRT(Texture src, int startX, int startY, int width, int height, Color defaultColor); // 0x000000018030B160-0x000000018030B590
		public static void DrawTexture(RenderTexture rt, Texture texture, Rect uvRect, Material mat, int pass = 0 /* Metadata: 0x003A6D3A */); // 0x000000018030BB40-0x000000018030BE90
		public static void DrawTriangle(RenderTexture rt, Vector2 v0, Vector2 v1, Vector2 v2, Color c); // 0x000000018030BE90-0x000000018030C080
		public static void DrawQuad(RenderTexture rt, Vector2[] quadCorners, Material mat, int pass); // 0x000000018030B940-0x000000018030BB40
		public static List<System.Type> GetAllLoadedTypes(); // 0x000000018030C2E0-0x000000018030C4F0
		public static IEnumerable<Rect> CompareHeightMap(int gridSize, Color[] oldValues, Color[] newValues); // 0x000000018030A860-0x000000018030AE70
		public static Rect GetUvRange(int gridSize, int x, int z); // 0x000000018030CA50-0x000000018030CAF0
		public static Texture2D CreateTextureFromCurve(AnimationCurve curve, int width, int height); // 0x000000018030B600-0x000000018030B820
		public static Vector3[] GetBrushQuadCorners(Vector3 center, float radius, float rotation); // 0x000000018030C4F0-0x000000018030C8F0
		public static void ClearRT(RenderTexture rt); // 0x000000018030A490-0x000000018030A4D0
		public static void SetMaterialKeywordActive(Material mat, string keyword, bool active); // 0x000000018030CB30-0x000000018030CB60
		public static void Editor_ProgressBar(string title, string detail, float percent); // 0x0000000180265310-0x0000000180265320
		public static void Editor_CancelableProgressBar(string title, string detail, float percent); // 0x0000000180265310-0x0000000180265320
		public static void Editor_ClearProgressBar(); // 0x0000000180265310-0x0000000180265320
		public static Camera CreateCamera(); // 0x000000018030B590-0x000000018030B600
	}
}
