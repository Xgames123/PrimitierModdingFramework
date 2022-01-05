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
	public static class GltfSerializer // TypeDefIndex: 5721
	{
		// Methods
		public static void Serialize(JsonFormatter f, glTF value); // 0x0000000180D1E410-0x0000000180D1E9A0
		public static void Serialize_gltf_asset(JsonFormatter f, glTFAssets value); // 0x0000000180D194F0-0x0000000180D196C0
		public static void Serialize_gltf_buffers(JsonFormatter f, List<glTFBuffer> value); // 0x0000000180D19BA0-0x0000000180D19D00
		public static void Serialize_gltf_buffers_ITEM(JsonFormatter f, glTFBuffer value); // 0x0000000180D19A10-0x0000000180D19BA0
		public static void Serialize_gltf_bufferViews(JsonFormatter f, List<glTFBufferView> value); // 0x0000000180D198B0-0x0000000180D19A10
		public static void Serialize_gltf_bufferViews_ITEM(JsonFormatter f, glTFBufferView value); // 0x0000000180D196C0-0x0000000180D198B0
		public static void Serialize_gltf_accessors(JsonFormatter f, List<glTFAccessor> value); // 0x0000000180D18660-0x0000000180D187C0
		public static void Serialize_gltf_accessors_ITEM(JsonFormatter f, glTFAccessor value); // 0x0000000180D17CA0-0x0000000180D180B0
		public static void Serialize_gltf_accessors__max(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_accessors__min(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_accessors__sparse(JsonFormatter f, glTFSparse value); // 0x0000000180D18280-0x0000000180D18520
		public static void Serialize_gltf_accessors__sparse_indices(JsonFormatter f, glTFSparseIndices value); // 0x0000000180D180B0-0x0000000180D18280
		public static void Serialize_gltf_accessors__sparse_values(JsonFormatter f, glTFSparseValues value); // 0x0000000180D18520-0x0000000180D18660
		public static void Serialize_gltf_textures(JsonFormatter f, List<glTFTexture> value); // 0x0000000180D1E090-0x0000000180D1E410
		public static void Serialize_gltf_textures_ITEM(JsonFormatter f, glTFTexture value); // 0x0000000180D1DF10-0x0000000180D1E090
		public static void Serialize_gltf_samplers(JsonFormatter f, List<glTFTextureSampler> value); // 0x0000000180D1D640-0x0000000180D1D7A0
		public static void Serialize_gltf_samplers_ITEM(JsonFormatter f, glTFTextureSampler value); // 0x0000000180D1D300-0x0000000180D1D640
		public static void Serialize_gltf_images(JsonFormatter f, List<glTFImage> value); // 0x0000000180D1A8B0-0x0000000180D1AA10
		public static void Serialize_gltf_images_ITEM(JsonFormatter f, glTFImage value); // 0x0000000180D1A6E0-0x0000000180D1A8B0
		public static void Serialize_gltf_materials(JsonFormatter f, List<glTFMaterial> value); // 0x0000000180D1BC70-0x0000000180D1BDD0
		public static void Serialize_gltf_materials_ITEM(JsonFormatter f, glTFMaterial value); // 0x0000000180D1AA10-0x0000000180D1B120
		public static void Serialize_gltf_materials__pbrMetallicRoughness(JsonFormatter f, glTFPbrMetallicRoughness value); // 0x0000000180D1B690-0x0000000180D1BB30
		public static void Serialize_gltf_materials__pbrMetallicRoughness_baseColorTexture(JsonFormatter f, glTFMaterialBaseColorTextureInfo value); // 0x0000000180D1B550-0x0000000180D1B690
		public static void Serialize_gltf_materials__pbrMetallicRoughness_baseColorFactor(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_materials__pbrMetallicRoughness_metallicRoughnessTexture(JsonFormatter f, glTFMaterialMetallicRoughnessTextureInfo value); // 0x0000000180D1BB30-0x0000000180D1BC70
		public static void Serialize_gltf_materials__normalTexture(JsonFormatter f, glTFMaterialNormalTextureInfo value); // 0x0000000180D1B260-0x0000000180D1B3D0
		public static void Serialize_gltf_materials__occlusionTexture(JsonFormatter f, glTFMaterialOcclusionTextureInfo value); // 0x0000000180D1B3D0-0x0000000180D1B550
		public static void Serialize_gltf_materials__emissiveTexture(JsonFormatter f, glTFMaterialEmissiveTextureInfo value); // 0x0000000180D1B120-0x0000000180D1B260
		public static void Serialize_gltf_materials__emissiveFactor(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_meshes(JsonFormatter f, List<glTFMesh> value); // 0x0000000180D1C9B0-0x0000000180D1CB10
		public static void Serialize_gltf_meshes_ITEM(JsonFormatter f, glTFMesh value); // 0x0000000180D1BDD0-0x0000000180D1BFE0
		public static void Serialize_gltf_meshes__primitives(JsonFormatter f, List<glTFPrimitives> value); // 0x0000000180D1C850-0x0000000180D1C9B0
		public static void Serialize_gltf_meshes__primitives_ITEM(JsonFormatter f, glTFPrimitives value); // 0x0000000180D1BFE0-0x0000000180D1C230
		public static void Serialize_gltf_meshes__primitives__attributes(JsonFormatter f, glTFAttributes value); // 0x0000000180D1C230-0x0000000180D1C420
		public static void Serialize_gltf_meshes__primitives__targets(JsonFormatter f, List<gltfMorphTarget> value); // 0x0000000180D1C510-0x0000000180D1C850
		public static void Serialize_gltf_meshes__primitives__targets_ITEM(JsonFormatter f, gltfMorphTarget value); // 0x0000000180D1C420-0x0000000180D1C510
		public static void Serialize_gltf_meshes__weights(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_nodes(JsonFormatter f, List<glTFNode> value); // 0x0000000180D1D1A0-0x0000000180D1D300
		public static void Serialize_gltf_nodes_ITEM(JsonFormatter f, glTFNode value); // 0x0000000180D1CB10-0x0000000180D1D0B0
		public static void Serialize_gltf_nodes__children(JsonFormatter f, int[] value); // 0x0000000180D1D0B0-0x0000000180D1D1A0
		public static void Serialize_gltf_nodes__matrix(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_nodes__translation(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_nodes__rotation(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_nodes__scale(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_nodes__weights(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_gltf_skins(JsonFormatter f, List<glTFSkin> value); // 0x0000000180D1DDB0-0x0000000180D1DF10
		public static void Serialize_gltf_skins_ITEM(JsonFormatter f, glTFSkin value); // 0x0000000180D1DB20-0x0000000180D1DDB0
		public static void Serialize_gltf_skins__joints(JsonFormatter f, int[] value); // 0x0000000180D1D0B0-0x0000000180D1D1A0
		public static void Serialize_gltf_scenes(JsonFormatter f, List<gltfScene> value); // 0x0000000180D1D9C0-0x0000000180D1DB20
		public static void Serialize_gltf_scenes_ITEM(JsonFormatter f, gltfScene value); // 0x0000000180D1D7A0-0x0000000180D1D9C0
		public static void Serialize_gltf_scenes__nodes(JsonFormatter f, int[] value); // 0x0000000180D1D0B0-0x0000000180D1D1A0
		public static void Serialize_gltf_animations(JsonFormatter f, List<glTFAnimation> value); // 0x0000000180D19390-0x0000000180D194F0
		public static void Serialize_gltf_animations_ITEM(JsonFormatter f, glTFAnimation value); // 0x0000000180D187C0-0x0000000180D18970
		public static void Serialize_gltf_animations__channels(JsonFormatter f, List<glTFAnimationChannel> value); // 0x0000000180D18D30-0x0000000180D18E90
		public static void Serialize_gltf_animations__channels_ITEM(JsonFormatter f, glTFAnimationChannel value); // 0x0000000180D18970-0x0000000180D18BE0
		public static void Serialize_gltf_animations__channels__target(JsonFormatter f, glTFAnimationTarget value); // 0x0000000180D18BE0-0x0000000180D18D30
		public static void Serialize_gltf_animations__samplers(JsonFormatter f, List<glTFAnimationSampler> value); // 0x0000000180D19010-0x0000000180D19390
		public static void Serialize_gltf_animations__samplers_ITEM(JsonFormatter f, glTFAnimationSampler value); // 0x0000000180D18E90-0x0000000180D19010
		public static void Serialize_gltf_cameras(JsonFormatter f, List<glTFCamera> value); // 0x0000000180D1A2C0-0x0000000180D1A420
		public static void Serialize_gltf_cameras_ITEM(JsonFormatter f, glTFCamera value); // 0x0000000180D19D00-0x0000000180D19F30
		public static void Serialize_gltf_cameras__orthographic(JsonFormatter f, glTFOrthographic value); // 0x0000000180D19F30-0x0000000180D1A0F0
		public static void Serialize_gltf_cameras__perspective(JsonFormatter f, glTFPerspective value); // 0x0000000180D1A0F0-0x0000000180D1A2C0
		public static void Serialize_gltf_extensionsUsed(JsonFormatter f, List<string> value); // 0x0000000180D1A580-0x0000000180D1A6E0
		public static void Serialize_gltf_extensionsRequired(JsonFormatter f, List<string> value); // 0x0000000180D1A420-0x0000000180D1A580
	}
}
