/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniJSON;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace UniGLTF
{
	public static class glTFExtensions // TypeDefIndex: 5709
	{
		// Fields
		private static Dictionary<System.Type, ComponentVec> ComponentTypeMap; // 0x00
		private static Utf8String s_extensions; // 0x08
	
		// Nested types
		private struct ComponentVec // TypeDefIndex: 5707
		{
			// Fields
			public glComponentType ComponentType; // 0x00
			public int ElementCount; // 0x04
	
			// Constructors
			public ComponentVec(glComponentType componentType, int elementCount); // 0x000000018036B690-0x000000018036B6A0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5708
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<byte, int> __9__14_0; // 0x08
			public static Func<ushort, int> __9__14_1; // 0x10
			public static Func<uint, int> __9__14_2; // 0x18
			public static Func<byte, int> __9__15_0; // 0x20
			public static Func<ushort, int> __9__15_1; // 0x28
			public static Func<uint, int> __9__15_2; // 0x30
	
			// Constructors
			static __c(); // 0x00000001806E6B50-0x00000001806E6BB0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal int __GetIndices_b__14_0(byte x); // 0x00000001806E4EE0-0x00000001806E4EF0
			internal int __GetIndices_b__14_1(ushort x); // 0x00000001806E4EF0-0x00000001806E4F00
			internal int __GetIndices_b__14_2(uint x); // 0x0000000180333550-0x0000000180333560
			internal int __GetIndices_b__15_0(byte x); // 0x00000001806E4EE0-0x00000001806E4EF0
			internal int __GetIndices_b__15_1(ushort x); // 0x00000001806E4EF0-0x00000001806E4F00
			internal int __GetIndices_b__15_2(uint x); // 0x0000000180333550-0x0000000180333560
		}
	
		// Constructors
		static glTFExtensions(); // 0x0000000180D5F930-0x0000000180D5FC40
	
		// Methods
		private static glComponentType GetComponentType<T>();
		private static string GetAccessorType<T>();
		private static int GetAccessorElementCount<T>();
		public static bool IsGeneratedUniGLTFAndOlderThan(string generatorVersion, int major, int minor); // 0x0000000180D5E180-0x0000000180D5E450
	
		// Extension methods
		public static int ExtendBufferAndGetAccessorIndex<T>(this glTF gltf, int bufferIndex, T[] array, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19B0 */)
			where T : struct;
		public static int ExtendBufferAndGetAccessorIndex<T>(this glTF gltf, int bufferIndex, ArraySegment<T> array, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19B4 */)
			where T : struct;
		public static int ExtendBufferAndGetViewIndex<T>(this glTF gltf, int bufferIndex, T[] array, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19B8 */)
			where T : struct;
		public static int ExtendBufferAndGetViewIndex<T>(this glTF gltf, int bufferIndex, ArraySegment<T> array, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19BC */)
			where T : struct;
		public static int ExtendSparseBufferAndGetAccessorIndex<T>(this glTF gltf, int bufferIndex, int accessorCount, T[] sparseValues, int[] sparseIndices, int sparseViewIndex, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19C0 */)
			where T : struct;
		public static int ExtendSparseBufferAndGetAccessorIndex<T>(this glTF gltf, int bufferIndex, int accessorCount, ArraySegment<T> sparseValues, int[] sparseIndices, int sparseIndicesViewIndex, glBufferTarget target = glBufferTarget.NONE /* Metadata: 0x003A19C4 */)
			where T : struct;
		public static int AddBuffer(this glTF self, IBytesBuffer bytesBuffer); // 0x0000000180D5D420-0x0000000180D5D4D0
		private static T[] GetAttrib<T>(this glTF self, int count, int byteOffset, glTFBufferView view)
			where T : struct;
		private static T[] GetAttrib<T>(this glTF self, glTFAccessor accessor, glTFBufferView view)
			where T : struct;
		private static IEnumerable<int> _GetIndices(this glTF self, glTFAccessor accessor, out int count); // 0x0000000180D5F420-0x0000000180D5F930
		private static IEnumerable<int> _GetIndices(this glTF self, glTFBufferView view, int count, int byteOffset, glComponentType componentType); // 0x0000000180D5EF70-0x0000000180D5F420
		public static int[] GetIndices(this glTF self, int accessorIndex); // 0x0000000180D5DCF0-0x0000000180D5E180
		public static T[] GetArrayFromAccessor<T>(this glTF self, int accessorIndex)
			where T : struct;
		public static float[] FlatternFloatArrayFromAccessor(this glTF self, int accessorIndex); // 0x0000000180D5D4D0-0x0000000180D5DA10
		public static ArraySegment<byte> GetImageBytesFromTextureIndex(this glTF self, IStorage storage, int textureIndex); // 0x0000000180D5DA10-0x0000000180D5DB00
		public static ArraySegment<byte> GetImageBytes(this glTF self, IStorage storage, int imageIndex); // 0x0000000180D5DB00-0x0000000180D5DCF0
		private static bool UsedExtension(this glTF self, string key); // 0x0000000180D5EF00-0x0000000180D5EF70
		private static void Traverse(this glTF self, JsonNode node, JsonFormatter f, Utf8String parentKey); // 0x0000000180D5E9F0-0x0000000180D5EF00
		private static string RemoveUnusedExtensions(this glTF self, string json); // 0x0000000180D5E4F0-0x0000000180D5E5F0
		public static byte[] ToGlbBytes(this glTF self); // 0x0000000180D5E5F0-0x0000000180D5E7A0
		public static ValueTuple<string, List<glTFBuffer>> ToGltf(this glTF self, string gltfPath); // 0x0000000180D5E7A0-0x0000000180D5E9F0
		public static bool IsGeneratedUniGLTFAndOlder(this glTF gltf, int major, int minor); // 0x0000000180D5E450-0x0000000180D5E4F0
	}
}
