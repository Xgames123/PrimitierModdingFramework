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
	public static class VRMSerializer // TypeDefIndex: 8023
	{
		// Methods
		public static void Serialize(JsonFormatter f, glTF_VRM_extensions value); // 0x000000018034E6F0-0x000000018034EA50
		public static void Serialize_vrm_meta(JsonFormatter f, glTF_VRM_Meta value); // 0x0000000180351F30-0x0000000180352290
		public static void Serialize_vrm_humanoid(JsonFormatter f, glTF_VRM_Humanoid value); // 0x00000001803510E0-0x00000001803512F0
		public static void Serialize_vrm_humanoid_humanBones(JsonFormatter f, List<glTF_VRM_HumanoidBone> value); // 0x0000000180350F80-0x00000001803510E0
		public static void Serialize_vrm_humanoid_humanBones_ITEM(JsonFormatter f, glTF_VRM_HumanoidBone value); // 0x00000001803507C0-0x0000000180350C80
		public static void Serialize_vrm_humanoid_humanBones__min(JsonFormatter f, Vector3 value); // 0x0000000180350E80-0x0000000180350F80
		public static void Serialize_vrm_humanoid_humanBones__max(JsonFormatter f, Vector3 value); // 0x0000000180350D80-0x0000000180350E80
		public static void Serialize_vrm_humanoid_humanBones__center(JsonFormatter f, Vector3 value); // 0x0000000180350C80-0x0000000180350D80
		public static void Serialize_vrm_firstPerson(JsonFormatter f, glTF_VRM_Firstperson value); // 0x000000018034FDC0-0x0000000180350500
		public static void Serialize_vrm_firstPerson_firstPersonBoneOffset(JsonFormatter f, Vector3 value); // 0x000000018034F740-0x000000018034F840
		public static void Serialize_vrm_firstPerson_meshAnnotations(JsonFormatter f, List<glTF_VRM_MeshAnnotation> value); // 0x00000001803505C0-0x00000001803507C0
		public static void Serialize_vrm_firstPerson_meshAnnotations_ITEM(JsonFormatter f, glTF_VRM_MeshAnnotation value); // 0x0000000180350500-0x00000001803505C0
		public static void Serialize_vrm_firstPerson_lookAtHorizontalInner(JsonFormatter f, glTF_VRM_DegreeMap value); // 0x000000018034F840-0x000000018034F9A0
		public static void Serialize_vrm_firstPerson_lookAtHorizontalInner_curve(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_firstPerson_lookAtHorizontalOuter(JsonFormatter f, glTF_VRM_DegreeMap value); // 0x000000018034F9A0-0x000000018034FB00
		public static void Serialize_vrm_firstPerson_lookAtHorizontalOuter_curve(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_firstPerson_lookAtVerticalDown(JsonFormatter f, glTF_VRM_DegreeMap value); // 0x000000018034FB00-0x000000018034FC60
		public static void Serialize_vrm_firstPerson_lookAtVerticalDown_curve(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_firstPerson_lookAtVerticalUp(JsonFormatter f, glTF_VRM_DegreeMap value); // 0x000000018034FC60-0x000000018034FDC0
		public static void Serialize_vrm_firstPerson_lookAtVerticalUp_curve(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_blendShapeMaster(JsonFormatter f, glTF_VRM_BlendShapeMaster value); // 0x000000018034F6A0-0x000000018034F740
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups(JsonFormatter f, List<glTF_VRM_BlendShapeGroup> value); // 0x000000018034F3E0-0x000000018034F6A0
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups_ITEM(JsonFormatter f, glTF_VRM_BlendShapeGroup value); // 0x000000018034EA50-0x000000018034EBE0
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups__binds(JsonFormatter f, List<glTF_VRM_BlendShapeBind> value); // 0x000000018034ECE0-0x000000018034EF10
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups__binds_ITEM(JsonFormatter f, glTF_VRM_BlendShapeBind value); // 0x000000018034EBE0-0x000000018034ECE0
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups__materialValues(JsonFormatter f, List<glTF_VRM_MaterialValueBind> value); // 0x000000018034F110-0x000000018034F3E0
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups__materialValues_ITEM(JsonFormatter f, glTF_VRM_MaterialValueBind value); // 0x000000018034EF10-0x000000018034F080
		public static void Serialize_vrm_blendShapeMaster_blendShapeGroups__materialValues__targetValue(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_secondaryAnimation(JsonFormatter f, glTF_VRM_SecondaryAnimation value); // 0x0000000180353110-0x00000001803532C0
		public static void Serialize_vrm_secondaryAnimation_boneGroups(JsonFormatter f, List<glTF_VRM_SecondaryAnimationGroup> value); // 0x00000001803527C0-0x0000000180352920
		public static void Serialize_vrm_secondaryAnimation_boneGroups_ITEM(JsonFormatter f, glTF_VRM_SecondaryAnimationGroup value); // 0x0000000180352290-0x0000000180352630
		public static void Serialize_vrm_secondaryAnimation_boneGroups__gravityDir(JsonFormatter f, Vector3 value); // 0x00000001803526C0-0x00000001803527C0
		public static void Serialize_vrm_secondaryAnimation_boneGroups__bones(JsonFormatter f, int[] value); // 0x0000000180352630-0x00000001803526C0
		public static void Serialize_vrm_secondaryAnimation_boneGroups__colliderGroups(JsonFormatter f, int[] value); // 0x0000000180352630-0x00000001803526C0
		public static void Serialize_vrm_secondaryAnimation_colliderGroups(JsonFormatter f, List<glTF_VRM_SecondaryAnimationColliderGroup> value); // 0x0000000180352F00-0x0000000180353110
		public static void Serialize_vrm_secondaryAnimation_colliderGroups_ITEM(JsonFormatter f, glTF_VRM_SecondaryAnimationColliderGroup value); // 0x0000000180352920-0x00000001803529F0
		public static void Serialize_vrm_secondaryAnimation_colliderGroups__colliders(JsonFormatter f, List<glTF_VRM_SecondaryAnimationCollider> value); // 0x0000000180352C60-0x0000000180352F00
		public static void Serialize_vrm_secondaryAnimation_colliderGroups__colliders_ITEM(JsonFormatter f, glTF_VRM_SecondaryAnimationCollider value); // 0x00000001803529F0-0x0000000180352B60
		public static void Serialize_vrm_secondaryAnimation_colliderGroups__colliders__offset(JsonFormatter f, Vector3 value); // 0x0000000180352B60-0x0000000180352C60
		public static void Serialize_vrm_materialProperties(JsonFormatter f, List<glTF_VRM_Material> value); // 0x0000000180351DD0-0x0000000180351F30
		public static void Serialize_vrm_materialProperties_ITEM(JsonFormatter f, glTF_VRM_Material value); // 0x00000001803512F0-0x0000000180351500
		public static void Serialize_vrm_materialProperties__floatProperties(JsonFormatter f, Dictionary<string, float> value); // 0x0000000180351500-0x00000001803516B0
		public static void Serialize_vrm_materialProperties__vectorProperties(JsonFormatter f, Dictionary<string, float[]> value); // 0x0000000180351BC0-0x0000000180351DD0
		public static void Serialize_vrm_materialProperties__vectorProperties_ITEM(JsonFormatter f, float[] value); // 0x000000018034F080-0x000000018034F110
		public static void Serialize_vrm_materialProperties__textureProperties(JsonFormatter f, Dictionary<string, int> value); // 0x0000000180351A10-0x0000000180351BC0
		public static void Serialize_vrm_materialProperties__keywordMap(JsonFormatter f, Dictionary<string, bool> value); // 0x00000001803516B0-0x0000000180351860
		public static void Serialize_vrm_materialProperties__tagMap(JsonFormatter f, Dictionary<string, string> value); // 0x0000000180351860-0x0000000180351A10
	}
}
