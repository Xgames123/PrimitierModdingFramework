/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class Spark : MonoBehaviour // TypeDefIndex: 8616
{
	// Fields
	private static readonly float temperature; // 0x00
	private static readonly float heatQuantity; // 0x04
	private ParticleSystem particle; // 0x18
	private List<ParticleCollisionEvent> collisionEvents; // 0x20

	// Constructors
	public Spark(); // 0x0000000180265240-0x0000000180265250
	static Spark(); // 0x0000000180B541C0-0x0000000180B54210

	// Methods
	private void Start(); // 0x0000000180B54130-0x0000000180B541C0
	private void OnParticleCollision(GameObject other); // 0x0000000180B53F70-0x0000000180B54130
}

