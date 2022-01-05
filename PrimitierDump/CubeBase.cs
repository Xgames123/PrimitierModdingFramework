/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class CubeBase : MonoBehaviour // TypeDefIndex: 8589
{
	// Fields
	public Substance substance; // 0x18
	[NonSerialized]
	public SubstanceParameters.Param sp; // 0x20
	[NonSerialized]
	public Rigidbody rb; // 0x28
	public CubeConnector cubeConnector; // 0x30
	public Heat heat; // 0x38
	public FluidDynamics fluidDynamics; // 0x40
	public CubeAppearance cubeAppearance; // 0x48
	[NonSerialized]
	public float maxLife; // 0x50
	[NonSerialized]
	public float life; // 0x54
	[NonSerialized]
	public float defense; // 0x58
	[NonSerialized]
	public SplitType splitType; // 0x5C
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private System.EventHandler Splitted; // 0x60
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject sparkPrefab; // 0x68
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject firePrefab; // 0x70
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject fireNoLightPrefab; // 0x78
	private static float textScale; // 0x00
	private static float baseDamageThreshold; // 0x04
	private static float invincibleTime; // 0x08
	private static float fragmentMinVolume; // 0x0C
	private static float forgingMinThickness; // 0x10
	private static float cuttingMinThickness; // 0x14
	private static float maxLifeMlp; // 0x18
	private static float defenseMlp; // 0x1C
	public static float masterDamageMlp; // 0x20
	private static float bladeThreshold; // 0x24
	private static float sparkMinHardness; // 0x28
	public static float softDamageMlp; // 0x2C
	private static float bladeDamageToSoftMlp; // 0x30
	private static float forgeImpulseThreshold; // 0x34
	private static float forgeDeformationMlp; // 0x38
	private static float forgeMaxDeformationRatio; // 0x3C
	private static float volumeMlp; // 0x40
	private static float pitchMlp; // 0x44
	private static float soundHardnessRatio; // 0x48
	private bool isInitialized; // 0x80
	private StatusText statusText; // 0x88
	private GameObject fireEffect; // 0x90
	private Vector3 initialVelocity; // 0x98
	private string collisionSound; // 0xA8
	private float defaultPitch; // 0xB0
	private bool changePitch; // 0xB4
	private float thicknessThreshold; // 0xB8
	private bool isInvincible; // 0xBC
	private bool isDestroyed; // 0xBD
	private Component substanceBehavior; // 0xC0

	// Events
	public event System.EventHandler Splitted {
		add; // 0x000000018053BC70-0x000000018053BD10
		remove; // 0x000000018053BD10-0x000000018053BDB0
	}

	// Nested types
	public enum SplitType // TypeDefIndex: 8588
	{
		Normal = 0,
		Eight = 1,
		Four = 2,
		VerticalFour = 3,
		Eliminate = 4
	}

	// Constructors
	public CubeBase(); // 0x000000018053BC30-0x000000018053BC70
	static CubeBase(); // 0x000000018053BA70-0x000000018053BC30

	// Methods
	private void Start(); // 0x000000018053B7F0-0x000000018053B910
	public void Initialize(Substance substance, float temperature, bool isBurning = false /* Metadata: 0x003A6C0E */, float burnedRatio = 0f /* Metadata: 0x003A6C0F */, CubeAppearance.SectionState sectionState =  /* Metadata: 0x003A6C13 */, CubeAppearance.UVOffset uvOffset = null); // 0x0000000180537EF0-0x00000001805380F0
	private void UpdateSubstanceBehavior(); // 0x000000018053B9C0-0x000000018053BA70
	private T GetOrAddComponent<T>()
		where T : Component;
	public bool GetIsInvincible(); // 0x0000000180537DB0-0x0000000180537DC0
	public void OnCollisionEnterReceived(Collision collision); // 0x0000000180538490-0x0000000180538F20
	public void ReceiveDamage(float amount, Vector3 colPoint, bool showText, float damageMlp = 1f /* Metadata: 0x003A6C17 */); // 0x0000000180539120-0x0000000180539370
	public void Recover(float amount); // 0x0000000180539370-0x00000001805393B0
	private void OnConnectionChanged(); // 0x0000000180538F20-0x0000000180538F90
	private void ShowStatusText(); // 0x00000001805397E0-0x0000000180539B00
	private void ShowDamageText(float damage, float damageMlp); // 0x00000001805394E0-0x00000001805397E0
	private void SetSubstanceProperty(); // 0x00000001805393B0-0x00000001805394E0
	private float CalcMaxLife(); // 0x0000000180537050-0x00000001805371C0
	private float CalcDefense(); // 0x0000000180536FB0-0x0000000180537050
	private void ExpireInvincible(); // 0x0000000180537750-0x0000000180537760
	private void Split(Vector3 colPoint); // 0x000000018053B650-0x000000018053B7F0
	public void Eliminate(); // 0x00000001805376B0-0x0000000180537750
	private void OnDestroy(); // 0x0000000180537610-0x00000001805376B0
	private void SplitNormally(Vector3 colPoint); // 0x0000000180539B00-0x000000018053ACC0
	private float CalcCuttingPoint(float colPoint, float sideLength); // 0x0000000180536EA0-0x0000000180536FB0
	private static float CalcMinProjectedArea(Vector3 sideLength); // 0x00000001805371C0-0x00000001805372D0
	public static float CalcBladeDamageMlp(Collision collision, float hardness, float otherHardness); // 0x0000000180536C00-0x0000000180536EA0
	private void SplitToEight(); // 0x000000018053ACC0-0x000000018053B0A0
	private void SplitToFour(); // 0x000000018053B0A0-0x000000018053B380
	private void SplitToVerticalFour(); // 0x000000018053B380-0x000000018053B650
	private void InstantiateFragment(Vector3 pos, Vector3 scale, ICubeBehavior[] cubeBehaviors, CubeAppearance.SectionState sectionState =  /* Metadata: 0x003A6C1B */, CubeAppearance.UVOffset uvOffset = null); // 0x00000001805380F0-0x0000000180538490
	public float GetSurfaceArea(); // 0x0000000180537E30-0x0000000180537EA0
	public float GetVolume(); // 0x0000000180537EA0-0x0000000180537EF0
	public float GetMass(); // 0x0000000180537DC0-0x0000000180537E30
	private static float CalcRelativePitch(Vector3 scale); // 0x00000001805372D0-0x0000000180537480
	private Vector3 PressScale(Vector3 initialScale, float impulse); // 0x0000000180538F90-0x0000000180539120
	private void Forge(Vector3 impulse); // 0x0000000180537760-0x0000000180537BC0
	public void ChangeScale(Vector3 scale); // 0x0000000180537480-0x0000000180537550
	public void GenerateFireEffect(float size); // 0x0000000180537BC0-0x0000000180537DB0
	public void DestroyFireEffect(); // 0x0000000180537610-0x00000001805376B0
	public void ChangeSubstance(Substance substance); // 0x0000000180537550-0x0000000180537610
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	internal static float _CalcBladeDamageMlp_g__CalcFaceSharpness_69_0(float width, float height); // 0x000000018053B910-0x000000018053B9C0
}

