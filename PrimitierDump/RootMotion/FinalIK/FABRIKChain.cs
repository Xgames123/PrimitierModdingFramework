/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[Serializable]
	public class FABRIKChain // TypeDefIndex: 8421
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float pull; // 0x18
		[Range] // 0x000000018001BE80-0x000000018001BEA0
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain(); // 0x0000000180817120-0x0000000180817180
	
		// Methods
		public bool IsValid(ref string message); // 0x0000000180816D70-0x0000000180816E40
		public void Initiate(); // 0x0000000180816D40-0x0000000180816D70
		public void Stage1(FABRIKChain[] chain); // 0x0000000180816E40-0x0000000180816F90
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain); // 0x0000000180816F90-0x0000000180817120
		private Vector3 GetCentroid(FABRIKChain[] chain); // 0x0000000180816A50-0x0000000180816D40
	}
}
