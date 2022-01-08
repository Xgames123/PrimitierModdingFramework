/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	[Serializable]
	public struct OffsetOnTransform // TypeDefIndex: 8074
	{
		// Fields
		public Transform Transform; // 0x00
		public Matrix4x4 OffsetRotation; // 0x08
		private Matrix4x4 m_initialLocalMatrix; // 0x48
	
		// Properties
		public Matrix4x4 WorldMatrix { get; } // 0x000000018033D3F0-0x000000018033D530 
		public Vector3 WorldForward { get; } // 0x000000018033D340-0x000000018033D3F0 
		public Matrix4x4 InitialWorldMatrix { get; } // 0x000000018033D250-0x000000018033D340 
	
		// Methods
		public void Setup(); // 0x000000018033D0D0-0x000000018033D250
		public static OffsetOnTransform Create(Transform transform); // 0x000000018033CD40-0x000000018033D0D0
	}
}
