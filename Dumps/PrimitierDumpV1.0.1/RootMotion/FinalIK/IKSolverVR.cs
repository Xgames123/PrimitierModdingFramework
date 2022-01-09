/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 8470
	{
		// Fields
		private Transform[] solverTransforms; // 0x58
		private bool hasChest; // 0x60
		private bool hasNeck; // 0x61
		private bool hasShoulders; // 0x62
		private bool hasToes; // 0x63
		private bool hasLegs; // 0x64
		private Vector3[] readPositions; // 0x68
		private Quaternion[] readRotations; // 0x70
		private Vector3[] solvedPositions; // 0x78
		private Quaternion[] solvedRotations; // 0x80
		private Quaternion[] defaultLocalRotations; // 0x88
		private Vector3[] defaultLocalPositions; // 0x90
		private Vector3 rootV; // 0x98
		private Vector3 rootVelocity; // 0xA4
		private Vector3 bodyOffset; // 0xB0
		private int supportLegIndex; // 0xBC
		[Tooltip] // 0x000000018001F770-0x000000018001F7A0
		public bool plantFeet; // 0xC0
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private VirtualBone _rootBone_k__BackingField; // 0xC8
		[Tooltip] // 0x000000018001F7A0-0x000000018001F7D0
		public Spine spine; // 0xD0
		[Tooltip] // 0x000000018001F7D0-0x000000018001F800
		public Arm leftArm; // 0xD8
		[Tooltip] // 0x000000018001F800-0x000000018001F830
		public Arm rightArm; // 0xE0
		[Tooltip] // 0x000000018001F830-0x000000018001F860
		public Leg leftLeg; // 0xE8
		[Tooltip] // 0x000000018001F860-0x000000018001F890
		public Leg rightLeg; // 0xF0
		[Tooltip] // 0x000000018001F890-0x000000018001F8C0
		public Locomotion locomotion; // 0xF8
		private Leg[] legs; // 0x100
		private Arm[] arms; // 0x108
		private Vector3 headPosition; // 0x110
		private Vector3 headDeltaPosition; // 0x11C
		private Vector3 raycastOriginPelvis; // 0x128
		private Vector3 lastOffset; // 0x134
		private Vector3 debugPos1; // 0x140
		private Vector3 debugPos2; // 0x14C
		private Vector3 debugPos3; // 0x158
		private Vector3 debugPos4; // 0x164
	
		// Properties
		[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
		public VirtualBone rootBone { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018031E0A0-0x000000018031E0B0 0x000000018031EC40-0x000000018031EC50
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 8461
		{
			// Fields
			[Tooltip] // 0x000000018001F8C0-0x000000018001F8F0
			public Transform target; // 0x48
			[Tooltip] // 0x000000018001F8F0-0x000000018001F920
			public Transform bendGoal; // 0x50
			[Range] // 0x000000018001F920-0x000000018001F970
			[Tooltip] // 0x000000018001F920-0x000000018001F970
			public float positionWeight; // 0x58
			[Range] // 0x000000018001F970-0x000000018001F9D0
			[Tooltip] // 0x000000018001F970-0x000000018001F9D0
			public float rotationWeight; // 0x5C
			[Tooltip] // 0x000000018001F9D0-0x000000018001FA00
			public ShoulderRotationMode shoulderRotationMode; // 0x60
			[Range] // 0x000000018001FA00-0x000000018001FA60
			[Tooltip] // 0x000000018001FA00-0x000000018001FA60
			public float shoulderRotationWeight; // 0x64
			[Range] // 0x000000018001FA60-0x000000018001FAB0
			[Tooltip] // 0x000000018001FA60-0x000000018001FAB0
			public float shoulderTwistWeight; // 0x68
			[Range] // 0x000000018001FAB0-0x000000018001FB00
			[Tooltip] // 0x000000018001FAB0-0x000000018001FB00
			public float bendGoalWeight; // 0x6C
			[Range] // 0x000000018001FB00-0x000000018001FB60
			[Tooltip] // 0x000000018001FB00-0x000000018001FB60
			public float swivelOffset; // 0x70
			[Tooltip] // 0x000000018001FB60-0x000000018001FB90
			public Vector3 wristToPalmAxis; // 0x74
			[Tooltip] // 0x000000018001FB90-0x000000018001FBC0
			public Vector3 palmToThumbAxis; // 0x80
			[Range] // 0x000000018001FBC0-0x000000018001FC10
			[Tooltip] // 0x000000018001FBC0-0x000000018001FC10
			public float armLengthMlp; // 0x8C
			[Tooltip] // 0x000000018001FC10-0x000000018001FC40
			public AnimationCurve stretchCurve; // 0x90
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 IKPosition; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion IKRotation; // 0xA4
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 bendDirection; // 0xB4
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 handPositionOffset; // 0xC0
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _position_k__BackingField; // 0xCC
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Quaternion _rotation_k__BackingField; // 0xD8
			private bool hasShoulder; // 0xE8
			private Vector3 chestForwardAxis; // 0xEC
			private Vector3 chestUpAxis; // 0xF8
			private Quaternion chestRotation; // 0x104
			private Vector3 chestForward; // 0x114
			private Vector3 chestUp; // 0x120
			private Quaternion forearmRelToUpperArm; // 0x12C
			private const float yawOffsetAngle = 45f; // Metadata: 0x003A6B76
			private const float pitchOffsetAngle = -30f; // Metadata: 0x003A6B7A
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018070CAC0-0x000000018070CAE0 0x000000018070CB90-0x000000018070CBB0
			public Quaternion rotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018070CAE0-0x000000018070CAF0 0x000000018070CBB0-0x000000018070CBC0
			private VirtualBone shoulder { get; } // 0x000000018070CAF0-0x000000018070CB30 
			private VirtualBone upperArm { get; } // 0x000000018070CB30-0x000000018070CB90 
			private VirtualBone forearm { get; } // 0x000000018070CA00-0x000000018070CA60 
			private VirtualBone hand { get; } // 0x000000018070CA60-0x000000018070CAC0 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 8460
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm(); // 0x000000018070C8D0-0x000000018070CA00
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x00000001807091A0-0x0000000180709C30
			public override void PreSolve(); // 0x0000000180709C30-0x000000018070A010
			public override void ApplyOffsets(); // 0x0000000180708A00-0x0000000180708A70
			private void Stretching(); // 0x000000018070BCA0-0x000000018070C300
			public void Solve(bool isLeft); // 0x000000018070A040-0x000000018070BCA0
			public override void ResetOffsets(); // 0x000000018070A010-0x000000018070A040
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018070C440-0x000000018070C8D0
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x003A6B72 */); // 0x0000000180708A70-0x0000000180708B00
			private Vector3 GetBendNormal(Vector3 dir); // 0x0000000180708B00-0x00000001807091A0
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color); // 0x000000018070C300-0x000000018070C440
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 8462
		{
			// Fields
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _sqrMag_k__BackingField; // 0x10
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _mag_k__BackingField; // 0x14
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
	
			// Properties
			public float sqrMag { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018036C100-0x000000018036C110 0x000000018036C190-0x000000018036C1A0
			public float mag { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018030D160-0x000000018030D170 0x000000018030D1B0-0x000000018030D1C0
	
			// Constructors
			protected BodyPart(); // 0x000000018083D630-0x000000018083D690
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve();
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets();
			public abstract void ResetOffsets();
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018083CE40-0x000000018083CF50
			public void MovePosition(Vector3 position); // 0x000000018083CC70-0x000000018083CD70
			public void MoveRotation(Quaternion rotation); // 0x000000018083CD70-0x000000018083CE40
			public void Translate(Vector3 position, Quaternion rotation); // 0x000000018083D230-0x000000018083D330
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot); // 0x000000018083D0B0-0x000000018083D230
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x003A6B86 */); // 0x000000018083CF50-0x000000018083D0B0
			public void Visualize(Color color); // 0x000000018083D330-0x000000018083D4A0
			public void Visualize(); // 0x000000018083D4A0-0x000000018083D630
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 8463
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private float _stepProgress_k__BackingField; // 0x50
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get; } // 0x0000000180840B80-0x0000000180840B90 
			public float stepProgress { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180461EB0-0x0000000180461EC0 0x0000000180461FA0-0x0000000180461FB0
	
			// Constructors
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset); // 0x0000000180840A30-0x0000000180840B80
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation); // 0x00000001808404B0-0x0000000180840500
			public void StepTo(Vector3 p, Quaternion rootRotation); // 0x0000000180840500-0x0000000180840580
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed); // 0x0000000180840700-0x0000000180840880
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed); // 0x0000000180840580-0x0000000180840700
			public void Update(InterpolationMode interpolation, UnityEvent onStep); // 0x0000000180840880-0x0000000180840A30
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 8464
		{
			// Fields
			[Tooltip] // 0x000000018001FC40-0x000000018001FC70
			public Transform target; // 0x48
			[Tooltip] // 0x000000018001FC70-0x000000018001FCA0
			public Transform bendGoal; // 0x50
			[Range] // 0x000000018001FCA0-0x000000018001FD00
			[Tooltip] // 0x000000018001FCA0-0x000000018001FD00
			public float positionWeight; // 0x58
			[Range] // 0x000000018001FD00-0x000000018001FD60
			[Tooltip] // 0x000000018001FD00-0x000000018001FD60
			public float rotationWeight; // 0x5C
			[Range] // 0x000000018001FD60-0x000000018001FDC0
			[Tooltip] // 0x000000018001FD60-0x000000018001FDC0
			public float bendGoalWeight; // 0x60
			[Range] // 0x000000018001FDC0-0x000000018001FE20
			[Tooltip] // 0x000000018001FDC0-0x000000018001FE20
			public float swivelOffset; // 0x64
			[Range] // 0x000000018001FE20-0x000000018001FE70
			[Tooltip] // 0x000000018001FE20-0x000000018001FE70
			public float bendToTargetWeight; // 0x68
			[Range] // 0x000000018001FE70-0x000000018001FED0
			[Tooltip] // 0x000000018001FE70-0x000000018001FED0
			public float legLengthMlp; // 0x6C
			[Tooltip] // 0x000000018001FED0-0x000000018001FF00
			public AnimationCurve stretchCurve; // 0x70
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 IKPosition; // 0x78
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion IKRotation; // 0x84
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 footPositionOffset; // 0x94
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 heelPositionOffset; // 0xA0
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion footRotationOffset; // 0xAC
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public float currentMag; // 0xBC
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _position_k__BackingField; // 0xC0
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Quaternion _rotation_k__BackingField; // 0xCC
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private bool _hasToes_k__BackingField; // 0xDC
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _thighRelativeToPelvis_k__BackingField; // 0xE0
			private Vector3 footPosition; // 0xEC
			private Quaternion footRotation; // 0xF8
			private Vector3 bendNormal; // 0x108
			private Quaternion calfRelToThigh; // 0x114
			private Quaternion thighRelToFoot; // 0x124
			private Vector3 bendNormalRelToPelvis; // 0x134
			private Vector3 bendNormalRelToTarget; // 0x140
	
			// Properties
			public Vector3 position { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180844400-0x0000000180844420 0x0000000180844490-0x00000001808444B0
			public Quaternion rotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180844420-0x0000000180844430 0x00000001808444B0-0x00000001808444C0
			public bool hasToes { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180313950-0x0000000180313960 0x00000001803141C0-0x00000001803141D0
			public VirtualBone thigh { get; } // 0x000000018070CAF0-0x000000018070CB30 
			private VirtualBone calf { get; } // 0x0000000180844340-0x0000000180844380 
			private VirtualBone foot { get; } // 0x0000000180844380-0x00000001808443C0 
			private VirtualBone toes { get; } // 0x0000000180844450-0x0000000180844490 
			public VirtualBone lastBone { get; } // 0x00000001808443C0-0x0000000180844400 
			public Vector3 thighRelativeToPelvis { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180844430-0x0000000180844450 0x00000001808444C0-0x00000001808444E0
	
			// Constructors
			public Leg(); // 0x0000000180844220-0x0000000180844340
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x0000000180841F40-0x00000001808429B0
			public override void PreSolve(); // 0x00000001808429B0-0x0000000180842FD0
			public override void ApplyOffsets(); // 0x00000001808414A0-0x0000000180841C50
			private void ApplyPositionOffset(Vector3 offset, float weight); // 0x0000000180841C50-0x0000000180841D30
			private void ApplyRotationOffset(Quaternion offset, float weight); // 0x0000000180841D30-0x0000000180841F40
			public void Solve(bool stretch); // 0x0000000180843040-0x0000000180843820
			private void Stretching(); // 0x0000000180843820-0x0000000180843E70
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x0000000180843E70-0x0000000180844220
			public override void ResetOffsets(); // 0x0000000180842FD0-0x0000000180843040
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 8465
		{
			// Fields
			[Range] // 0x000000018001FF00-0x000000018001FF60
			[Tooltip] // 0x000000018001FF00-0x000000018001FF60
			public float weight; // 0x10
			[Tooltip] // 0x000000018001FF60-0x000000018001FF90
			public float footDistance; // 0x14
			[Tooltip] // 0x000000018001FF90-0x000000018001FFC0
			public float stepThreshold; // 0x18
			[Tooltip] // 0x000000018001FFC0-0x000000018001FFF0
			public float angleThreshold; // 0x1C
			[Tooltip] // 0x000000018001FFF0-0x0000000180020020
			public float comAngleMlp; // 0x20
			[Tooltip] // 0x0000000180020020-0x0000000180020050
			public float maxVelocity; // 0x24
			[Tooltip] // 0x0000000180020050-0x0000000180020080
			public float velocityFactor; // 0x28
			[Range] // 0x0000000180020080-0x00000001800200D0
			[Tooltip] // 0x0000000180020080-0x00000001800200D0
			public float maxLegStretch; // 0x2C
			[Tooltip] // 0x00000001800200D0-0x0000000180020100
			public float rootSpeed; // 0x30
			[Tooltip] // 0x0000000180020100-0x0000000180020130
			public float stepSpeed; // 0x34
			[Tooltip] // 0x0000000180020130-0x0000000180020160
			public AnimationCurve stepHeight; // 0x38
			[Tooltip] // 0x0000000180020160-0x0000000180020190
			public AnimationCurve heelHeight; // 0x40
			[Range] // 0x0000000180020190-0x00000001800201F0
			[Tooltip] // 0x0000000180020190-0x00000001800201F0
			public float relaxLegTwistMinAngle; // 0x48
			[Tooltip] // 0x00000001800201F0-0x0000000180020220
			public float relaxLegTwistSpeed; // 0x4C
			[Tooltip] // 0x0000000180020220-0x0000000180020250
			public InterpolationMode stepInterpolation; // 0x50
			[Tooltip] // 0x0000000180020250-0x0000000180020280
			public Vector3 offset; // 0x54
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public bool blockingEnabled; // 0x60
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public LayerMask blockingLayers; // 0x64
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public float raycastRadius; // 0x68
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public float raycastHeight; // 0x6C
			[Tooltip] // 0x0000000180020280-0x00000001800202B0
			public UnityEvent onLeftFootstep; // 0x70
			[Tooltip] // 0x00000001800202B0-0x00000001800202E0
			public UnityEvent onRightFootstep; // 0x78
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Vector3 _centerOfMass_k__BackingField; // 0x80
			private Footstep[] footsteps; // 0x90
			private Vector3 lastComPosition; // 0x98
			private Vector3 comVelocity; // 0xA4
			private int leftFootIndex; // 0xB0
			private int rightFootIndex; // 0xB4
	
			// Properties
			public Vector3 centerOfMass { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180847720-0x0000000180847740 0x00000001808478A0-0x00000001808478C0
			public Vector3 leftFootstepPosition { get; } // 0x0000000180847740-0x00000001808477A0 
			public Vector3 rightFootstepPosition { get; } // 0x00000001808477F0-0x0000000180847850 
			public Quaternion leftFootstepRotation { get; } // 0x00000001808477A0-0x00000001808477F0 
			public Quaternion rightFootstepRotation { get; } // 0x0000000180847850-0x00000001808478A0 
	
			// Constructors
			public Locomotion(); // 0x0000000180847610-0x0000000180847720
	
			// Methods
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes); // 0x0000000180844DB0-0x0000000180845300
			public void Reset(Vector3[] positions, Quaternion[] rotations); // 0x0000000180845300-0x0000000180845690
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot); // 0x00000001808446E0-0x0000000180844B70
			public void AddDeltaPosition(Vector3 delta); // 0x0000000180844520-0x00000001808446E0
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset); // 0x0000000180845690-0x0000000180847420
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition); // 0x0000000180847420-0x0000000180847610
			private bool CanStep(); // 0x0000000180844B70-0x0000000180844BF0
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius); // 0x0000000180844BF0-0x0000000180844DB0
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 8466
		{
			// Fields
			[Tooltip] // 0x00000001800202E0-0x0000000180020310
			public Transform headTarget; // 0x48
			[Tooltip] // 0x0000000180020310-0x0000000180020340
			public Transform pelvisTarget; // 0x50
			[Range] // 0x0000000180020340-0x00000001800203A0
			[Tooltip] // 0x0000000180020340-0x00000001800203A0
			public float positionWeight; // 0x58
			[Range] // 0x00000001800203A0-0x00000001800203F0
			[Tooltip] // 0x00000001800203A0-0x00000001800203F0
			public float rotationWeight; // 0x5C
			[Range] // 0x00000001800203F0-0x0000000180020450
			[Tooltip] // 0x00000001800203F0-0x0000000180020450
			public float pelvisPositionWeight; // 0x60
			[Range] // 0x0000000180020450-0x00000001800204B0
			[Tooltip] // 0x0000000180020450-0x00000001800204B0
			public float pelvisRotationWeight; // 0x64
			[Tooltip] // 0x00000001800204B0-0x00000001800204E0
			public Transform chestGoal; // 0x68
			[Range] // 0x00000001800204E0-0x0000000180020540
			[Tooltip] // 0x00000001800204E0-0x0000000180020540
			public float chestGoalWeight; // 0x70
			[Tooltip] // 0x0000000180020540-0x0000000180020570
			public float minHeadHeight; // 0x74
			[Range] // 0x0000000180020570-0x00000001800205D0
			[Tooltip] // 0x0000000180020570-0x00000001800205D0
			public float bodyPosStiffness; // 0x78
			[Range] // 0x00000001800205D0-0x0000000180020630
			[Tooltip] // 0x00000001800205D0-0x0000000180020630
			public float bodyRotStiffness; // 0x7C
			[FormerlySerializedAs] // 0x0000000180020630-0x00000001800206B0
			[Range] // 0x0000000180020630-0x00000001800206B0
			[Tooltip] // 0x0000000180020630-0x00000001800206B0
			public float neckStiffness; // 0x80
			[Range] // 0x00000001800206B0-0x0000000180020710
			[Tooltip] // 0x00000001800206B0-0x0000000180020710
			public float rotateChestByHands; // 0x84
			[Range] // 0x0000000180020710-0x0000000180020760
			[Tooltip] // 0x0000000180020710-0x0000000180020760
			public float chestClampWeight; // 0x88
			[Range] // 0x0000000180020760-0x00000001800207B0
			[Tooltip] // 0x0000000180020760-0x00000001800207B0
			public float headClampWeight; // 0x8C
			[Tooltip] // 0x00000001800207B0-0x00000001800207E0
			public float moveBodyBackWhenCrouching; // 0x90
			[Range] // 0x00000001800207E0-0x0000000180020830
			[Tooltip] // 0x00000001800207E0-0x0000000180020830
			public float maintainPelvisPosition; // 0x94
			[Range] // 0x0000000180020830-0x0000000180020890
			[Tooltip] // 0x0000000180020830-0x0000000180020890
			public float maxRootAngle; // 0x98
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 IKPositionHead; // 0x9C
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion IKRotationHead; // 0xA8
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 IKPositionPelvis; // 0xB8
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion IKRotationPelvis; // 0xC4
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 goalPositionChest; // 0xD4
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 pelvisPositionOffset; // 0xE0
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 chestPositionOffset; // 0xEC
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 headPositionOffset; // 0xF8
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion pelvisRotationOffset; // 0x104
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion chestRotationOffset; // 0x114
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Quaternion headRotationOffset; // 0x124
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 faceDirection; // 0x134
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 locomotionHeadPositionOffset; // 0x140
			[NonSerialized]
			[HideInInspector] // 0x0000000180014D50-0x0000000180014D60
			public Vector3 headPosition; // 0x14C
			[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
			private Quaternion _anchorRotation_k__BackingField; // 0x158
			private Quaternion headRotation; // 0x168
			private Quaternion pelvisRotation; // 0x178
			private Quaternion anchorRelativeToHead; // 0x188
			private Quaternion anchorRelativeToPelvis; // 0x198
			private Quaternion pelvisRelativeRotation; // 0x1A8
			private Quaternion chestRelativeRotation; // 0x1B8
			private Vector3 headDeltaPosition; // 0x1C8
			private Quaternion pelvisDeltaRotation; // 0x1D4
			private Quaternion chestTargetRotation; // 0x1E4
			private int pelvisIndex; // 0x1F4
			private int spineIndex; // 0x1F8
			private int chestIndex; // 0x1FC
			private int neckIndex; // 0x200
			private int headIndex; // 0x204
			private float length; // 0x208
			private bool hasChest; // 0x20C
			private bool hasNeck; // 0x20D
			private bool hasLegs; // 0x20E
			private float headHeight; // 0x210
			private float sizeMlp; // 0x214
			private Vector3 chestForward; // 0x218
	
			// Properties
			public VirtualBone pelvis { get; } // 0x000000018084FA10-0x000000018084FA50 
			public VirtualBone firstSpineBone { get; } // 0x000000018084F950-0x000000018084F990 
			public VirtualBone chest { get; } // 0x000000018084F8E0-0x000000018084F950 
			private VirtualBone neck { get; } // 0x000000018084F9D0-0x000000018084FA10 
			public VirtualBone head { get; } // 0x000000018084F990-0x000000018084F9D0 
			public Quaternion anchorRotation { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018084F8D0-0x000000018084F8E0 0x000000018084FA50-0x000000018084FA60
	
			// Constructors
			public Spine(); // 0x000000018084F6C0-0x000000018084F8D0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018084D100-0x000000018084DED0
			public override void PreSolve(); // 0x000000018084DED0-0x000000018084E200
			public override void ApplyOffsets(); // 0x000000018084BB20-0x000000018084C110
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms); // 0x000000018084C700-0x000000018084C8E0
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms); // 0x000000018084E6B0-0x000000018084EEF0
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp); // 0x000000018084C8E0-0x000000018084CB90
			private void SolvePelvis(); // 0x000000018084E2B0-0x000000018084E6B0
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018084F3F0-0x000000018084F6C0
			public override void ResetOffsets(); // 0x000000018084E200-0x000000018084E2B0
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms); // 0x000000018084B690-0x000000018084BB20
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w); // 0x000000018084CB90-0x000000018084CD50
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation); // 0x000000018084EEF0-0x000000018084F3F0
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x003A6B8A */); // 0x000000018084CD50-0x000000018084D100
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w); // 0x000000018084C470-0x000000018084C700
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w); // 0x000000018084C110-0x000000018084C470
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 8467
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}
	
		[Serializable]
		public enum RotationOffset // TypeDefIndex: 8468
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 8469
		{
			// Fields
			public Vector3 readPosition; // 0x10
			public Quaternion readRotation; // 0x1C
			public Vector3 solverPosition; // 0x2C
			public Quaternion solverRotation; // 0x38
			public float length; // 0x48
			public float sqrMag; // 0x4C
			public Vector3 axis; // 0x50
	
			// Constructors
			public VirtualBone(Vector3 position, Quaternion rotation); // 0x0000000180852A10-0x0000000180852A70
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation); // 0x0000000180850FB0-0x0000000180850FE0
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x003A6BBE */); // 0x00000001808527F0-0x0000000180852A10
			public static float PreSolve(ref VirtualBone[] bones); // 0x0000000180850C80-0x0000000180850FB0
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation); // 0x0000000180850FE0-0x0000000180851190
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000180851380-0x0000000180851570
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation); // 0x0000000180851190-0x0000000180851380
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation); // 0x0000000180851570-0x0000000180851650
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x0000000180851F20-0x00000001808527F0
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x0000000180850AC0-0x0000000180850C80
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset); // 0x00000001808519A0-0x0000000180851F20
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x00000001808518A0-0x00000001808519A0
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations); // 0x0000000180851650-0x00000001808518A0
		}
	
		// Constructors
		public IKSolverVR(); // 0x00000001807FA210-0x00000001807FA440
	
		// Methods
		public void SetToReferences(VRIK.References references); // 0x00000001807F7B80-0x00000001807F8050
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero); // 0x00000001807F6620-0x00000001807F6950
		public void DefaultAnimationCurves(); // 0x00000001807F54D0-0x00000001807F5650
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value); // 0x00000001807F4F90-0x00000001807F5290
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value); // 0x00000001807F5290-0x00000001807F53D0
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value); // 0x00000001807F53D0-0x00000001807F54D0
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot); // 0x00000001807F4E20-0x00000001807F4F90
		public void Reset(); // 0x00000001807F7A30-0x00000001807F7B80
		public override void StoreDefaultLocalState(); // 0x00000001807F98D0-0x00000001807F9AB0
		public override void FixTransforms(); // 0x00000001807F5650-0x00000001807F5860
		public override Point[] GetPoints(); // 0x00000001807F63B0-0x00000001807F6410
		public override Point GetPoint(Transform transform); // 0x00000001807F6350-0x00000001807F63B0
		public override bool IsValid(ref string message); // 0x00000001807F7000-0x00000001807F7260
		private Vector3 GetNormal(Transform[] transforms); // 0x00000001807F5860-0x00000001807F5B80
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm); // 0x00000001807F6E20-0x00000001807F7000
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm); // 0x00000001807F6950-0x00000001807F6E20
		private static Keyframe[] GetSineKeyframes(float mag); // 0x00000001807F64B0-0x00000001807F6620
		private void UpdateSolverTransforms(); // 0x00000001807F9AB0-0x00000001807F9C70
		protected override void OnInitiate(); // 0x00000001807F7260-0x00000001807F72C0
		protected override void OnUpdate(); // 0x00000001807F72C0-0x00000001807F7350
		private void WriteTransforms(); // 0x00000001807F9C70-0x00000001807FA050
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs); // 0x00000001807F7350-0x00000001807F7A30
		private void Solve(); // 0x00000001807F8050-0x00000001807F98D0
		private Vector3 GetPosition(int index); // 0x00000001807F6410-0x00000001807F6460
		private Quaternion GetRotation(int index); // 0x00000001807F6460-0x00000001807F64B0
		private void Write(); // 0x00000001807FA050-0x00000001807FA210
		private Vector3 GetPelvisOffset(); // 0x00000001807F5B80-0x00000001807F6350
	}
}
