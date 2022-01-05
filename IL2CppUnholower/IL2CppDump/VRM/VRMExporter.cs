/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMExporter : gltfExporter // TypeDefIndex: 8052
	{
		// Fields
		public readonly glTF_VRM_extensions VRM; // 0x58
	
		// Constructors
		public VRMExporter(glTF gltf); // 0x0000000180342000-0x00000001803420B0
	
		// Methods
		protected override IMaterialExporter CreateMaterialExporter(); // 0x00000001803407B0-0x0000000180340800
		public static glTF Export(MeshExportSettings configuration, GameObject go, Func<Texture, bool> useAsset, Func<Texture2D, ValueTuple<byte[], string>> getTextureBytes); // 0x0000000180341C70-0x0000000180341E30
		public override void ExportExtensions(Func<Texture2D, ValueTuple<byte[], string>> getTextureBytes); // 0x0000000180340800-0x0000000180341C70
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private void _ExportExtensions_b__4_0(glTF_VRM_SecondaryAnimationColliderGroup x); // 0x0000000180341E30-0x0000000180341EA0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private void _ExportExtensions_b__4_1(glTF_VRM_SecondaryAnimationGroup x); // 0x0000000180341EA0-0x0000000180341F10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private glTF_VRM_MeshAnnotation _ExportExtensions_b__4_2(VRMFirstPerson.RendererFirstPersonFlags x); // 0x0000000180341F10-0x0000000180342000
	}
}
