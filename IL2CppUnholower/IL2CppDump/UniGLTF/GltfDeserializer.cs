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
	public static class GltfDeserializer // TypeDefIndex: 5720
	{
		// Methods
		public static glTF Deserialize(JsonNode parsed); // 0x00000001810C2B10-0x00000001810C3390
		public static glTFAssets Deserialize_gltf_asset(JsonNode parsed); // 0x00000001810B9290-0x00000001810B96C0
		public static List<glTFBuffer> Deserialize_gltf_buffers(JsonNode parsed); // 0x00000001810BA190-0x00000001810BA3A0
		public static glTFBuffer Deserialize_gltf_buffers_LIST(JsonNode parsed); // 0x00000001810B9DB0-0x00000001810BA190
		public static List<glTFBufferView> Deserialize_gltf_bufferViews(JsonNode parsed); // 0x00000001810B9BA0-0x00000001810B9DB0
		public static glTFBufferView Deserialize_gltf_bufferViews_LIST(JsonNode parsed); // 0x00000001810B96C0-0x00000001810B9BA0
		public static List<glTFAccessor> Deserialize_gltf_accessors(JsonNode parsed); // 0x00000001810B7B60-0x00000001810B7D70
		public static glTFAccessor Deserialize_gltf_accessors_LIST(JsonNode parsed); // 0x00000001810B6560-0x00000001810B6B90
		public static float[] Deserialize_gltf_accessors__max(JsonNode parsed); // 0x00000001810B6B90-0x00000001810B6DD0
		public static float[] Deserialize_gltf_accessors__min(JsonNode parsed); // 0x00000001810B6DD0-0x00000001810B7010
		public static glTFSparse Deserialize_gltf_accessors__sparse(JsonNode parsed); // 0x00000001810B73F0-0x00000001810B77D0
		public static glTFSparseIndices Deserialize_gltf_accessors__sparse_indices(JsonNode parsed); // 0x00000001810B7010-0x00000001810B73F0
		public static glTFSparseValues Deserialize_gltf_accessors__sparse_values(JsonNode parsed); // 0x00000001810B77D0-0x00000001810B7B60
		public static List<glTFTexture> Deserialize_gltf_textures(JsonNode parsed); // 0x00000001810C2900-0x00000001810C2B10
		public static glTFTexture Deserialize_gltf_textures_LIST(JsonNode parsed); // 0x00000001810C2520-0x00000001810C2900
		public static List<glTFTextureSampler> Deserialize_gltf_samplers(JsonNode parsed); // 0x00000001810C12B0-0x00000001810C14C0
		public static glTFTextureSampler Deserialize_gltf_samplers_LIST(JsonNode parsed); // 0x00000001810C0E30-0x00000001810C12B0
		public static List<glTFImage> Deserialize_gltf_images(JsonNode parsed); // 0x00000001810BBAF0-0x00000001810BBD00
		public static glTFImage Deserialize_gltf_images_LIST(JsonNode parsed); // 0x00000001810BB6C0-0x00000001810BBAF0
		public static List<glTFMaterial> Deserialize_gltf_materials(JsonNode parsed); // 0x00000001810BDDE0-0x00000001810BDFF0
		public static glTFMaterial Deserialize_gltf_materials_LIST(JsonNode parsed); // 0x00000001810BBD00-0x00000001810BC2A0
		public static glTFPbrMetallicRoughness Deserialize_gltf_materials__pbrMetallicRoughness(JsonNode parsed); // 0x00000001810BD5E0-0x00000001810BDA50
		public static glTFMaterialBaseColorTextureInfo Deserialize_gltf_materials__pbrMetallicRoughness_baseColorTexture(JsonNode parsed); // 0x00000001810BD250-0x00000001810BD5E0
		public static float[] Deserialize_gltf_materials__pbrMetallicRoughness_baseColorFactor(JsonNode parsed); // 0x00000001810BD010-0x00000001810BD250
		public static glTFMaterialMetallicRoughnessTextureInfo Deserialize_gltf_materials__pbrMetallicRoughness_metallicRoughnessTexture(JsonNode parsed); // 0x00000001810BDA50-0x00000001810BDDE0
		public static glTFMaterialNormalTextureInfo Deserialize_gltf_materials__normalTexture(JsonNode parsed); // 0x00000001810BC870-0x00000001810BCC40
		public static glTFMaterialOcclusionTextureInfo Deserialize_gltf_materials__occlusionTexture(JsonNode parsed); // 0x00000001810BCC40-0x00000001810BD010
		public static glTFMaterialEmissiveTextureInfo Deserialize_gltf_materials__emissiveTexture(JsonNode parsed); // 0x00000001810BC4E0-0x00000001810BC870
		public static float[] Deserialize_gltf_materials__emissiveFactor(JsonNode parsed); // 0x00000001810BC2A0-0x00000001810BC4E0
		public static List<glTFMesh> Deserialize_gltf_meshes(JsonNode parsed); // 0x00000001810BF660-0x00000001810BF870
		public static glTFMesh Deserialize_gltf_meshes_LIST(JsonNode parsed); // 0x00000001810BDFF0-0x00000001810BE3E0
		public static List<glTFPrimitives> Deserialize_gltf_meshes__primitives(JsonNode parsed); // 0x00000001810BF210-0x00000001810BF420
		public static glTFPrimitives Deserialize_gltf_meshes__primitives_LIST(JsonNode parsed); // 0x00000001810BE3E0-0x00000001810BE860
		public static glTFAttributes Deserialize_gltf_meshes__primitives__attributes(JsonNode parsed); // 0x00000001810BE860-0x00000001810BED00
		public static List<gltfMorphTarget> Deserialize_gltf_meshes__primitives__targets(JsonNode parsed); // 0x00000001810BF000-0x00000001810BF210
		public static gltfMorphTarget Deserialize_gltf_meshes__primitives__targets_LIST(JsonNode parsed); // 0x00000001810BED00-0x00000001810BF000
		public static float[] Deserialize_gltf_meshes__weights(JsonNode parsed); // 0x00000001810BF420-0x00000001810BF660
		public static List<glTFNode> Deserialize_gltf_nodes(JsonNode parsed); // 0x00000001810C0C20-0x00000001810C0E30
		public static glTFNode Deserialize_gltf_nodes_LIST(JsonNode parsed); // 0x00000001810BF870-0x00000001810BFEA0
		public static int[] Deserialize_gltf_nodes__children(JsonNode parsed); // 0x00000001810BFEA0-0x00000001810C00E0
		public static float[] Deserialize_gltf_nodes__matrix(JsonNode parsed); // 0x00000001810C00E0-0x00000001810C0320
		public static float[] Deserialize_gltf_nodes__translation(JsonNode parsed); // 0x00000001810C07A0-0x00000001810C09E0
		public static float[] Deserialize_gltf_nodes__rotation(JsonNode parsed); // 0x00000001810C0320-0x00000001810C0560
		public static float[] Deserialize_gltf_nodes__scale(JsonNode parsed); // 0x00000001810C0560-0x00000001810C07A0
		public static float[] Deserialize_gltf_nodes__weights(JsonNode parsed); // 0x00000001810C09E0-0x00000001810C0C20
		public static List<glTFSkin> Deserialize_gltf_skins(JsonNode parsed); // 0x00000001810C2310-0x00000001810C2520
		public static glTFSkin Deserialize_gltf_skins_LIST(JsonNode parsed); // 0x00000001810C1CA0-0x00000001810C20D0
		public static int[] Deserialize_gltf_skins__joints(JsonNode parsed); // 0x00000001810C20D0-0x00000001810C2310
		public static List<gltfScene> Deserialize_gltf_scenes(JsonNode parsed); // 0x00000001810C1A90-0x00000001810C1CA0
		public static gltfScene Deserialize_gltf_scenes_LIST(JsonNode parsed); // 0x00000001810C14C0-0x00000001810C1850
		public static int[] Deserialize_gltf_scenes__nodes(JsonNode parsed); // 0x00000001810C1850-0x00000001810C1A90
		public static List<glTFAnimation> Deserialize_gltf_animations(JsonNode parsed); // 0x00000001810B9080-0x00000001810B9290
		public static glTFAnimation Deserialize_gltf_animations_LIST(JsonNode parsed); // 0x00000001810B7D70-0x00000001810B8160
		public static List<glTFAnimationChannel> Deserialize_gltf_animations__channels(JsonNode parsed); // 0x00000001810B8880-0x00000001810B8A90
		public static glTFAnimationChannel Deserialize_gltf_animations__channels_LIST(JsonNode parsed); // 0x00000001810B8160-0x00000001810B84F0
		public static glTFAnimationTarget Deserialize_gltf_animations__channels__target(JsonNode parsed); // 0x00000001810B84F0-0x00000001810B8880
		public static List<glTFAnimationSampler> Deserialize_gltf_animations__samplers(JsonNode parsed); // 0x00000001810B8E70-0x00000001810B9080
		public static glTFAnimationSampler Deserialize_gltf_animations__samplers_LIST(JsonNode parsed); // 0x00000001810B8A90-0x00000001810B8E70
		public static List<glTFCamera> Deserialize_gltf_cameras(JsonNode parsed); // 0x00000001810BB090-0x00000001810BB2A0
		public static glTFCamera Deserialize_gltf_cameras_LIST(JsonNode parsed); // 0x00000001810BA3A0-0x00000001810BA830
		public static glTFOrthographic Deserialize_gltf_cameras__orthographic(JsonNode parsed); // 0x00000001810BA830-0x00000001810BAC60
		public static glTFPerspective Deserialize_gltf_cameras__perspective(JsonNode parsed); // 0x00000001810BAC60-0x00000001810BB090
		public static List<string> Deserialize_gltf_extensionsUsed(JsonNode parsed); // 0x00000001810BB4B0-0x00000001810BB6C0
		public static List<string> Deserialize_gltf_extensionsRequired(JsonNode parsed); // 0x00000001810BB2A0-0x00000001810BB4B0
	}
}
