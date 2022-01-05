/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class RuntimeBvhLoader : MonoBehaviour // TypeDefIndex: 5932
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Button m_openButton; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private HumanPoseTransfer m_dst; // 0x20
		private UnityAction m_onClick; // 0x28
		private static string m_lastDir; // 0x00
		private BvhImporterContext m_context; // 0x30
	
		// Constructors
		public RuntimeBvhLoader(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Awake(); // 0x00000001812B9620-0x00000001812B9690
		private void OnEnable(); // 0x00000001812B96E0-0x00000001812B9720
		private void OnDisable(); // 0x00000001812B96A0-0x00000001812B96E0
		public void OnClick(); // 0x00000001812B9690-0x00000001812B96A0
		private void Open(string path); // 0x00000001812B9720-0x00000001812B9A10
	}
}
