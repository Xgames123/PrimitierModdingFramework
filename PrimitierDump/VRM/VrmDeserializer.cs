/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniJSON;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public static class VrmDeserializer // TypeDefIndex: 8021
	{
		// Methods
		public static glTF_VRM_extensions Deserialize(JsonNode parsed); // 0x0000000180555760-0x0000000180555C10
		public static glTF_VRM_Meta Deserialize_vrm_meta(JsonNode parsed); // 0x000000018055BC20-0x000000018055C270
		public static glTF_VRM_Humanoid Deserialize_vrm_humanoid(JsonNode parsed); // 0x000000018055A0D0-0x000000018055A5B0
		public static List<glTF_VRM_HumanoidBone> Deserialize_vrm_humanoid_humanBones(JsonNode parsed); // 0x0000000180559EC0-0x000000018055A0D0
		public static glTF_VRM_HumanoidBone Deserialize_vrm_humanoid_humanBones_LIST(JsonNode parsed); // 0x0000000180559210-0x0000000180559680
		public static Vector3 Deserialize_vrm_humanoid_humanBones__min(JsonNode parsed); // 0x0000000180559C00-0x0000000180559EC0
		public static Vector3 Deserialize_vrm_humanoid_humanBones__max(JsonNode parsed); // 0x0000000180559940-0x0000000180559C00
		public static Vector3 Deserialize_vrm_humanoid_humanBones__center(JsonNode parsed); // 0x0000000180559680-0x0000000180559940
		public static glTF_VRM_Firstperson Deserialize_vrm_firstPerson(JsonNode parsed); // 0x0000000180558890-0x0000000180558D50
		public static Vector3 Deserialize_vrm_firstPerson_firstPersonBoneOffset(JsonNode parsed); // 0x00000001805570D0-0x0000000180557390
		public static List<glTF_VRM_MeshAnnotation> Deserialize_vrm_firstPerson_meshAnnotations(JsonNode parsed); // 0x0000000180559000-0x0000000180559210
		public static glTF_VRM_MeshAnnotation Deserialize_vrm_firstPerson_meshAnnotations_LIST(JsonNode parsed); // 0x0000000180558D50-0x0000000180559000
		public static glTF_VRM_DegreeMap Deserialize_vrm_firstPerson_lookAtHorizontalInner(JsonNode parsed); // 0x00000001805575D0-0x00000001805578D0
		public static float[] Deserialize_vrm_firstPerson_lookAtHorizontalInner_curve(JsonNode parsed); // 0x0000000180557390-0x00000001805575D0
		public static glTF_VRM_DegreeMap Deserialize_vrm_firstPerson_lookAtHorizontalOuter(JsonNode parsed); // 0x0000000180557B10-0x0000000180557E10
		public static float[] Deserialize_vrm_firstPerson_lookAtHorizontalOuter_curve(JsonNode parsed); // 0x00000001805578D0-0x0000000180557B10
		public static glTF_VRM_DegreeMap Deserialize_vrm_firstPerson_lookAtVerticalDown(JsonNode parsed); // 0x0000000180558050-0x0000000180558350
		public static float[] Deserialize_vrm_firstPerson_lookAtVerticalDown_curve(JsonNode parsed); // 0x0000000180557E10-0x0000000180558050
		public static glTF_VRM_DegreeMap Deserialize_vrm_firstPerson_lookAtVerticalUp(JsonNode parsed); // 0x0000000180558590-0x0000000180558890
		public static float[] Deserialize_vrm_firstPerson_lookAtVerticalUp_curve(JsonNode parsed); // 0x0000000180558350-0x0000000180558590
		public static glTF_VRM_BlendShapeMaster Deserialize_vrm_blendShapeMaster(JsonNode parsed); // 0x0000000180556E30-0x00000001805570D0
		public static List<glTF_VRM_BlendShapeGroup> Deserialize_vrm_blendShapeMaster_blendShapeGroups(JsonNode parsed); // 0x0000000180556C20-0x0000000180556E30
		public static glTF_VRM_BlendShapeGroup Deserialize_vrm_blendShapeMaster_blendShapeGroups_LIST(JsonNode parsed); // 0x0000000180555C10-0x0000000180555FC0
		public static List<glTF_VRM_BlendShapeBind> Deserialize_vrm_blendShapeMaster_blendShapeGroups__binds(JsonNode parsed); // 0x00000001805562C0-0x00000001805564D0
		public static glTF_VRM_BlendShapeBind Deserialize_vrm_blendShapeMaster_blendShapeGroups__binds_LIST(JsonNode parsed); // 0x0000000180555FC0-0x00000001805562C0
		public static List<glTF_VRM_MaterialValueBind> Deserialize_vrm_blendShapeMaster_blendShapeGroups__materialValues(JsonNode parsed); // 0x0000000180556A10-0x0000000180556C20
		public static glTF_VRM_MaterialValueBind Deserialize_vrm_blendShapeMaster_blendShapeGroups__materialValues_LIST(JsonNode parsed); // 0x00000001805564D0-0x00000001805567D0
		public static float[] Deserialize_vrm_blendShapeMaster_blendShapeGroups__materialValues__targetValue(JsonNode parsed); // 0x00000001805567D0-0x0000000180556A10
		public static glTF_VRM_SecondaryAnimation Deserialize_vrm_secondaryAnimation(JsonNode parsed); // 0x000000018055DD80-0x000000018055E030
		public static List<glTF_VRM_SecondaryAnimationGroup> Deserialize_vrm_secondaryAnimation_boneGroups(JsonNode parsed); // 0x000000018055CED0-0x000000018055D0E0
		public static glTF_VRM_SecondaryAnimationGroup Deserialize_vrm_secondaryAnimation_boneGroups_LIST(JsonNode parsed); // 0x000000018055C270-0x000000018055C790
		public static Vector3 Deserialize_vrm_secondaryAnimation_boneGroups__gravityDir(JsonNode parsed); // 0x000000018055CC10-0x000000018055CED0
		public static int[] Deserialize_vrm_secondaryAnimation_boneGroups__bones(JsonNode parsed); // 0x000000018055C790-0x000000018055C9D0
		public static int[] Deserialize_vrm_secondaryAnimation_boneGroups__colliderGroups(JsonNode parsed); // 0x000000018055C9D0-0x000000018055CC10
		public static List<glTF_VRM_SecondaryAnimationColliderGroup> Deserialize_vrm_secondaryAnimation_colliderGroups(JsonNode parsed); // 0x000000018055DB70-0x000000018055DD80
		public static glTF_VRM_SecondaryAnimationColliderGroup Deserialize_vrm_secondaryAnimation_colliderGroups_LIST(JsonNode parsed); // 0x000000018055D0E0-0x000000018055D3E0
		public static List<glTF_VRM_SecondaryAnimationCollider> Deserialize_vrm_secondaryAnimation_colliderGroups__colliders(JsonNode parsed); // 0x000000018055D960-0x000000018055DB70
		public static glTF_VRM_SecondaryAnimationCollider Deserialize_vrm_secondaryAnimation_colliderGroups__colliders_LIST(JsonNode parsed); // 0x000000018055D3E0-0x000000018055D6A0
		public static Vector3 Deserialize_vrm_secondaryAnimation_colliderGroups__colliders__offset(JsonNode parsed); // 0x000000018055D6A0-0x000000018055D960
		public static List<glTF_VRM_Material> Deserialize_vrm_materialProperties(JsonNode parsed); // 0x000000018055BA10-0x000000018055BC20
		public static glTF_VRM_Material Deserialize_vrm_materialProperties_LIST(JsonNode parsed); // 0x000000018055A5B0-0x000000018055ABA0
		public static Dictionary<string, float> Deserialize_vrm_materialProperties__floatProperties(JsonNode parsed); // 0x000000018055ABA0-0x000000018055AE10
		public static Dictionary<string, float[]> Deserialize_vrm_materialProperties__vectorProperties(JsonNode parsed); // 0x000000018055B7A0-0x000000018055BA10
		public static float[] Deserialize_vrm_materialProperties__vectorProperties_DICT(JsonNode parsed); // 0x000000018055B560-0x000000018055B7A0
		public static Dictionary<string, int> Deserialize_vrm_materialProperties__textureProperties(JsonNode parsed); // 0x000000018055B2F0-0x000000018055B560
		public static Dictionary<string, bool> Deserialize_vrm_materialProperties__keywordMap(JsonNode parsed); // 0x000000018055AE10-0x000000018055B080
		public static Dictionary<string, string> Deserialize_vrm_materialProperties__tagMap(JsonNode parsed); // 0x000000018055B080-0x000000018055B2F0
	}
}
