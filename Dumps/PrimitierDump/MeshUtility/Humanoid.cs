/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: UniGLTF.dll - Assembly: UniGLTF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5565-5923

namespace MeshUtility
{
	[DisallowMultipleComponent] // 0x0000000180014D50-0x0000000180014D60
	public class Humanoid : MonoBehaviour // TypeDefIndex: 5655
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Hips; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftUpperLeg; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightUpperLeg; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftLowerLeg; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightLowerLeg; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftFoot; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightFoot; // 0x48
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftToes; // 0x50
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightToes; // 0x58
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Spine; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Chest; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_UpperChest; // 0x70
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Neck; // 0x78
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Head; // 0x80
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftEye; // 0x88
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightEye; // 0x90
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_Jaw; // 0x98
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftShoulder; // 0xA0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightShoulder; // 0xA8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftUpperArm; // 0xB0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightUpperArm; // 0xB8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftLowerArm; // 0xC0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightLowerArm; // 0xC8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftHand; // 0xD0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightHand; // 0xD8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftThumbProximal; // 0xE0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftThumbIntermediate; // 0xE8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftThumbDistal; // 0xF0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftIndexProximal; // 0xF8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftIndexIntermediate; // 0x100
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftIndexDistal; // 0x108
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftMiddleProximal; // 0x110
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftMiddleIntermediate; // 0x118
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftMiddleDistal; // 0x120
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftRingProximal; // 0x128
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftRingIntermediate; // 0x130
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftRingDistal; // 0x138
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftLittleProximal; // 0x140
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftLittleIntermediate; // 0x148
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_LeftLittleDistal; // 0x150
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightThumbProximal; // 0x158
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightThumbIntermediate; // 0x160
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightThumbDistal; // 0x168
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightIndexProximal; // 0x170
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightIndexIntermediate; // 0x178
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightIndexDistal; // 0x180
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightMiddleProximal; // 0x188
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightMiddleIntermediate; // 0x190
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightMiddleDistal; // 0x198
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightRingProximal; // 0x1A0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightRingIntermediate; // 0x1A8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightRingDistal; // 0x1B0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightLittleProximal; // 0x1B8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightLittleIntermediate; // 0x1C0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Transform m_RightLittleDistal; // 0x1C8
	
		// Properties
		public Transform Hips { get; } // 0x0000000180268C10-0x0000000180268C20 
		public Transform LeftUpperLeg { get; } // 0x0000000180268FF0-0x0000000180269000 
		public Transform RightUpperLeg { get; } // 0x0000000180268FD0-0x0000000180268FE0 
		public Transform LeftLowerLeg { get; } // 0x00000001802684F0-0x0000000180268500 
		public Transform RightLowerLeg { get; } // 0x0000000180268FE0-0x0000000180268FF0 
		public Transform LeftFoot { get; } // 0x0000000180268310-0x0000000180268320 
		public Transform RightFoot { get; } // 0x00000001802AF7E0-0x00000001802AF7F0 
		public Transform LeftToes { get; } // 0x00000001802BC110-0x00000001802BC120 
		public Transform RightToes { get; } // 0x00000001802BF820-0x00000001802BF890 
		public Transform Spine { get; } // 0x00000001802C6D20-0x00000001802C6D30 
		public Transform Chest { get; } // 0x00000001802C6D10-0x00000001802C6D20 
		public Transform UpperChest { get; } // 0x00000001802DC790-0x00000001802DC800 
		public Transform Neck { get; } // 0x00000001802C0E50-0x00000001802C0E60 
		public Transform Head { get; } // 0x00000001802C0E60-0x00000001802C0E70 
		public Transform LeftEye { get; } // 0x00000001802AFA70-0x00000001802AFA80 
		public Transform RightEye { get; } // 0x00000001802AFA60-0x00000001802AFA70 
		public Transform Jaw { get; } // 0x00000001802AFA90-0x00000001802AFAA0 
		public Transform LeftShoulder { get; } // 0x00000001803FD790-0x00000001803FD7A0 
		public Transform RightShoulder { get; } // 0x00000001802DC800-0x00000001802DC810 
		public Transform LeftUpperArm { get; } // 0x0000000180381510-0x0000000180381520 
		public Transform RightUpperArm { get; } // 0x00000001802DC810-0x00000001802DC820 
		public Transform LeftLowerArm { get; } // 0x0000000180268300-0x0000000180268310 
		public Transform RightLowerArm { get; } // 0x000000018031E0A0-0x000000018031E0B0 
		public Transform LeftHand { get; } // 0x000000018031EBF0-0x000000018031EC00 
		public Transform RightHand { get; } // 0x000000018026A2F0-0x000000018026A300 
		public Transform LeftThumbProximal { get; } // 0x000000018026A6D0-0x000000018026A6E0 
		public Transform LeftThumbIntermediate { get; } // 0x00000001802885C0-0x00000001802885D0 
		public Transform LeftThumbDistal { get; } // 0x00000001802696B0-0x00000001802696C0 
		public Transform LeftIndexProximal { get; } // 0x000000018026A2D0-0x000000018026A2E0 
		public Transform LeftIndexIntermediate { get; } // 0x000000018026A2E0-0x000000018026A2F0 
		public Transform LeftIndexDistal { get; } // 0x0000000180377500-0x0000000180377510 
		public Transform LeftMiddleProximal { get; } // 0x0000000180287BF0-0x0000000180287C00 
		public Transform LeftMiddleIntermediate { get; } // 0x0000000180377510-0x0000000180377520 
		public Transform LeftMiddleDistal { get; } // 0x00000001803138E0-0x00000001803138F0 
		public Transform LeftRingProximal { get; } // 0x00000001803814C0-0x00000001803814D0 
		public Transform LeftRingIntermediate { get; } // 0x000000018046A620-0x000000018046A630 
		public Transform LeftRingDistal { get; } // 0x0000000180377520-0x0000000180377530 
		public Transform LeftLittleProximal { get; } // 0x00000001803135E0-0x00000001803135F0 
		public Transform LeftLittleIntermediate { get; } // 0x000000018052C6F0-0x000000018052C700 
		public Transform LeftLittleDistal { get; } // 0x0000000180D216F0-0x0000000180D21700 
		public Transform RightThumbProximal { get; } // 0x0000000180D21750-0x0000000180D21760 
		public Transform RightThumbIntermediate { get; } // 0x0000000180D21740-0x0000000180D21750 
		public Transform RightThumbDistal { get; } // 0x0000000180313580-0x0000000180313590 
		public Transform RightIndexProximal { get; } // 0x000000018080E3D0-0x000000018080E3E0 
		public Transform RightIndexIntermediate { get; } // 0x0000000180D21710-0x0000000180D21720 
		public Transform RightIndexDistal { get; } // 0x0000000180D21700-0x0000000180D21710 
		public Transform RightMiddleProximal { get; } // 0x0000000180313360-0x0000000180313370 
		public Transform RightMiddleIntermediate { get; } // 0x0000000180D21720-0x0000000180D21730 
		public Transform RightMiddleDistal { get; } // 0x00000001803814D0-0x00000001803814E0 
		public Transform RightRingProximal { get; } // 0x0000000180D21730-0x0000000180D21740 
		public Transform RightRingIntermediate { get; } // 0x00000001802879C0-0x00000001802879D0 
		public Transform RightRingDistal { get; } // 0x0000000180288520-0x0000000180288530 
		public Transform RightLittleProximal { get; } // 0x00000001803E42C0-0x00000001803E42D0 
		public Transform RightLittleIntermediate { get; } // 0x0000000180288530-0x0000000180288540 
		public Transform RightLittleDistal { get; } // 0x00000001803EB1A0-0x00000001803EB1B0 
		private IEnumerable<ValueTuple<Transform, HumanBodyBones>> BoneMap { [IteratorStateMachine] /* 0x0000000180027060-0x00000001800270B0 */ get; } // 0x0000000180D21680-0x0000000180D216F0 
	
		// Nested types
		public struct Validation // TypeDefIndex: 5650
		{
			// Fields
			public readonly string Message; // 0x00
			public readonly bool IsError; // 0x08
	
			// Constructors
			public Validation(string message, bool isError); // 0x0000000180696000-0x0000000180696010
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Required_d__167 : IEnumerable<Validation>, IEnumerator<Validation> // TypeDefIndex: 5651
		{
			// Fields
			private int __1__state; // 0x10
			private Validation __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			private ValueTuple<string, Transform>[] props; // 0x30
			public ValueTuple<string, Transform>[] __3__props; // 0x38
			private ValueTuple<string, Transform>[] __7__wrap1; // 0x40
			private int __7__wrap2; // 0x48
	
			// Properties
			Validation IEnumerator<MeshUtility.Humanoid.Validation>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D55BC0-0x0000000180D55C10 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Required_d__167(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D55960-0x0000000180D55AE0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D55B80-0x0000000180D55BC0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Validation> System.Collections.Generic.IEnumerable<MeshUtility.Humanoid.Validation>.GetEnumerator(); // 0x0000000180D55AE0-0x0000000180D55B80
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D55AE0-0x0000000180D55B80
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Validate_d__170 : IEnumerable<Validation>, IEnumerator<Validation> // TypeDefIndex: 5652
		{
			// Fields
			private int __1__state; // 0x10
			private Validation __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			public Humanoid __4__this; // 0x30
			private IEnumerator<Validation> __7__wrap1; // 0x38
	
			// Properties
			Validation IEnumerator<MeshUtility.Humanoid.Validation>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D597A0-0x0000000180D597F0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Validate_d__170(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180D597F0-0x0000000180D59880
			private bool MoveNext(); // 0x0000000180D58EB0-0x0000000180D596C0
			private void __m__Finally1(); // 0x0000000180D59880-0x0000000180D598D0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D59760-0x0000000180D597A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<Validation> System.Collections.Generic.IEnumerable<MeshUtility.Humanoid.Validation>.GetEnumerator(); // 0x0000000180D596C0-0x0000000180D59760
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D596C0-0x0000000180D59760
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _get_BoneMap_d__174 : IEnumerable<ValueTuple<Transform, HumanBodyBones>>, IEnumerator<ValueTuple<Transform, HumanBodyBones>> // TypeDefIndex: 5653
		{
			// Fields
			private int __1__state; // 0x10
			private ValueTuple<Transform, HumanBodyBones> __2__current; // 0x18
			private int __l__initialThreadId; // 0x28
			public Humanoid __4__this; // 0x30
	
			// Properties
			ValueTuple<Transform, HumanBodyBones> IEnumerator<(UnityEngine.Transform,UnityEngine.HumanBodyBones)>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001802B78A0-0x00000001802B78B0 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180D5B680-0x0000000180D5B6D0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _get_BoneMap_d__174(int __1__state); // 0x00000001806E1690-0x00000001806E16C0
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180D598D0-0x0000000180D5B5A0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180D5B640-0x0000000180D5B680
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<ValueTuple<Transform, HumanBodyBones>> System.Collections.Generic.IEnumerable<(UnityEngine.Transform,UnityEngine.HumanBodyBones)>.GetEnumerator(); // 0x0000000180D5B5A0-0x0000000180D5B640
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180D5B5A0-0x0000000180D5B640
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass176_0 // TypeDefIndex: 5654
		{
			// Fields
			public Animator animator; // 0x10
	
			// Constructors
			public __c__DisplayClass176_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ValueTuple<HumanBodyBones, Transform> _AssignBonesFromAnimator_b__0(HumanBodyBones x); // 0x0000000180D57070-0x0000000180D57260
		}
	
		// Constructors
		public Humanoid(); // 0x0000000180265240-0x0000000180265250
	
		// Methods
		private void Reset(); // 0x0000000180D21600-0x0000000180D21610
		[IteratorStateMachine] // 0x0000000180026FC0-0x0000000180027010
		private IEnumerable<Validation> Required(params /* 0x0000000180014D50-0x0000000180014D60 */ ValueTuple<string, Transform>[] props); // 0x0000000180D21590-0x0000000180D21600
		private static Vector3 GetForward(Transform l, Transform r); // 0x0000000180D213C0-0x0000000180D21590
		public Vector3 GetForward(); // 0x0000000180D211E0-0x0000000180D213C0
		[IteratorStateMachine] // 0x0000000180027010-0x0000000180027060
		public IEnumerable<Validation> Validate(); // 0x0000000180D21610-0x0000000180D21680
		public Avatar CreateAvatar(); // 0x0000000180D20E90-0x0000000180D20F50
		public Transform GetBoneTransform(HumanBodyBones bone); // 0x0000000180D20F50-0x0000000180D211E0
		public void AssignBones(IEnumerable<ValueTuple<HumanBodyBones, Transform>> nodes); // 0x0000000180D20980-0x0000000180D20E90
		public bool AssignBonesFromAnimator(); // 0x0000000180D206D0-0x0000000180D20980
	}
}
