/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.Util;

// Image 28: Unity.ResourceManager.dll - Assembly: Unity.ResourceManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4897-4994

internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks> // TypeDefIndex: 4902
{
	// Fields
	internal Action<float> m_OnUpdateDelegate; // 0x18

	// Events
	public event Action<float> OnUpdateDelegate {
		add; // 0x0000000180FAF6F0-0x0000000180FAF770
		remove; // 0x0000000180FAF770-0x0000000180FAF7F0
	}

	// Constructors
	public MonoBehaviourCallbackHooks(); // 0x0000000180FAF6B0-0x0000000180FAF6F0

	// Methods
	protected override string GetGameObjectName(); // 0x0000000180FAF620-0x0000000180FAF650
	internal void Update(); // 0x0000000180FAF650-0x0000000180FAF6B0
}

