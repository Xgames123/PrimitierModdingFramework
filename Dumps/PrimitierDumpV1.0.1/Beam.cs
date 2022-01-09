/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785
[assembly: CompilationRelaxations] // 0x000000018001BD60-0x000000018001BDC0
[assembly: Debuggable] // 0x000000018001BD60-0x000000018001BDC0
[assembly: RuntimeCompatibility] // 0x000000018001BD60-0x000000018001BDC0

public class Beam : MonoBehaviour // TypeDefIndex: 8575
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float destroyTime; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float targetSpeed; // 0x1C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float speedControlForce; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float damage; // 0x24
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float playerDamageMlp; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float temperature; // 0x2C
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private float heatQuantity; // 0x30
	private float sqrTargetSpeed; // 0x34
	private UnityEngine.SphereCollider col; // 0x38
	private Rigidbody rb; // 0x40

	// Constructors
	public Beam(); // 0x0000000180265240-0x0000000180265250

	// Methods
	private void Start(); // 0x0000000180532A10-0x0000000180532AA0
	private void FixedUpdate(); // 0x00000001805324E0-0x0000000180532670
	private void OnTriggerExit(Collider other); // 0x00000001805329E0-0x0000000180532A10
	private void OnCollisionEnter(Collision collision); // 0x0000000180532670-0x00000001805329E0
	private void DestroyThis(); // 0x0000000180532480-0x00000001805324E0
}

