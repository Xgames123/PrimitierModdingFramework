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
	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 8389
	{
		// Fields
		[Range] // 0x000000018001D7D0-0x000000018001D830
		[Tooltip] // 0x000000018001D7D0-0x000000018001D830
		public float weight; // 0x18
		[Tooltip] // 0x000000018001D830-0x000000018001D860
		public Grounding solver; // 0x20
		public GrounderDelegate OnPreGrounder; // 0x28
		public GrounderDelegate OnPostGrounder; // 0x30
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private bool _initiated_k__BackingField; // 0x38
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ protected set; } // 0x000000018030F460-0x000000018030F470 0x000000018030F6E0-0x000000018030F6F0
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 8388; 0x000000018070FF10-0x0000000180710080
	
		// Constructors
		protected Grounder(); // 0x0000000180828700-0x0000000180828770
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget(); // 0x00000001808285C0-0x0000000180828700
		protected void LogWarning(string message); // 0x00000001807805A0-0x00000001807805D0
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg); // 0x0000000180828070-0x00000001808283E0
		private Vector3 GetLegSpineTangent(Grounding.Leg leg); // 0x00000001808283E0-0x00000001808285C0
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
