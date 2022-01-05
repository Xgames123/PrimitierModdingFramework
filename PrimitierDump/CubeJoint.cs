/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeJoint : MonoBehaviour, ICubeBehavior, ISavable // TypeDefIndex: 8595
{
	// Fields
	private static readonly string jointTagName; // 0x00
	private static readonly string jointLayerName; // 0x08
	private static readonly string axisLayerName; // 0x10
	[NonSerialized]
	public Guid pairID; // 0x18
	private Joint joint; // 0x28
	private CubeConnector cubeConnector; // 0x30
	private Type type; // 0x38
	private bool isBase; // 0x3C

	// Nested types
	public enum Type // TypeDefIndex: 8593
	{
		Hinge = 0,
		Spring = 1
	}

	[Serializable]
	public class SaveData // TypeDefIndex: 8594
	{
		// Fields
		public string pairID; // 0x10
		public CubeJoint.Type type; // 0x18
		public bool isBase; // 0x1C

		// Constructors
		public SaveData(); // 0x00000001802650F0-0x0000000180265100
	}

	// Constructors
	public CubeJoint(); // 0x0000000180265240-0x0000000180265250
	static CubeJoint(); // 0x00000001805457A0-0x0000000180545840

	// Methods
	public void Initialize(Guid pairID, Type type, bool isBase); // 0x0000000180544F60-0x0000000180544F70
	private void Start(); // 0x0000000180545360-0x00000001805456C0
	private void InitializeTagAndLayer(); // 0x0000000180544E40-0x0000000180544F60
	private void TryJointWithPair(); // 0x00000001805456C0-0x00000001805457A0
	private CubeJoint SearchPair(); // 0x00000001805451B0-0x0000000180545360
	private void GenerateJoint(CubeJoint pair); // 0x0000000180544560-0x0000000180544E40
	private void OnConnectionChanged(); // 0x0000000180545030-0x00000001805450B0
	private void OnDestroy(); // 0x00000001805450B0-0x0000000180545110
	public void OnCollideWithCube(CubeBase colCubeBase); // 0x0000000180265310-0x0000000180265320
	public void OnFragmentInitialized(CubeBase fragmentCubeBase); // 0x0000000180265310-0x0000000180265320
	public string Save(); // 0x0000000180545110-0x00000001805451B0
	public void Load(string json); // 0x0000000180544F70-0x0000000180545030
}

