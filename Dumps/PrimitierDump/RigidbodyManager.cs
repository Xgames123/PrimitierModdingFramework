/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class RigidbodyManager : MonoBehaviour, IGrabbable, IFixedUpdatable // TypeDefIndex: 8613
{
	// Fields
	public static readonly int[] distances; // 0x00
	private int activeDistance; // 0x18
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private bool _IsFixedToGround_k__BackingField; // 0x1C
	public static HashSet<RigidbodyManager> instances; // 0x08
	[NonSerialized]
	public Rigidbody rb; // 0x20
	[CompilerGenerated] // 0x000000018002D1F0-0x000000018002D2A0
	[TupleElementNames] // 0x000000018002D1F0-0x000000018002D2A0
	private Dictionary<ValueTuple<Collider, Collider>, ValueTuple<CubeBase, CubeBase>> _Contacts_k__BackingField; // 0x28
	private bool prevIsKinematic; // 0x30
	private Vector3 prevVelocity; // 0x34
	private Vector3 prevAngularVelocity; // 0x40

	// Properties
	public int ActiveDistance { get; set; } // 0x0000000180268FB0-0x0000000180268FC0 0x0000000180B4A0A0-0x0000000180B4A100
	public bool IsFixedToGround { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802AF8D0-0x00000001802AF8E0 0x00000001802AF8E0-0x00000001802AF8F0
	[TupleElementNames] // 0x000000018002D3D0-0x000000018002D470
	public Dictionary<ValueTuple<Collider, Collider>, ValueTuple<CubeBase, CubeBase>> Contacts { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0

	// Constructors
	public RigidbodyManager(); // 0x0000000180B4A030-0x0000000180B4A0A0
	static RigidbodyManager(); // 0x0000000180B49F70-0x0000000180B4A030

	// Methods
	private void OnEnable(); // 0x0000000180B49700-0x0000000180B49830
	private void OnDisable(); // 0x0000000180B49630-0x0000000180B49700
	private void OnDestroy(); // 0x0000000180B49530-0x0000000180B49630
	private void Start(); // 0x0000000180B49840-0x0000000180B499C0
	public void OnFixedUpdate(); // 0x0000000180B49830-0x0000000180B49840
	private void OnPlayerChunkChanged(object sender, EventArgs e); // 0x0000000180B49830-0x0000000180B49840
	private void UpdateActiveState(); // 0x0000000180B499C0-0x0000000180B49C40
	public void OnGrab(Grabber grabber); // 0x0000000180265310-0x0000000180265320
	public void OnRelease(Grabber grabber); // 0x0000000180265310-0x0000000180265320
	public void OnBond([TupleElementNames] /* 0x000000018002D340-0x000000018002D3D0 */ List<ValueTuple<Collider, Collider, Vector3>> contactPoints, Collider grabbedCollider); // 0x0000000180B48B80-0x0000000180B49220
	public void UpdateRigidbodyParam(); // 0x0000000180B49C40-0x0000000180B49F70
	private bool CheckFixedToGround(CubeBase[] cubes); // 0x0000000180B48B10-0x0000000180B48B80
	private void OnCollisionEnter(Collision collision); // 0x0000000180B49220-0x0000000180B492D0
	private void OnCollisionStay(Collision collision); // 0x0000000180B49320-0x0000000180B49530
	private void OnCollisionExit(Collision collision); // 0x0000000180B492D0-0x0000000180B49320
}

