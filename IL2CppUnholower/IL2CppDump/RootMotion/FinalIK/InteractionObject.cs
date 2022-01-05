/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180020A90-0x0000000180020AF0
	[HelpURL] // 0x0000000180020A90-0x0000000180020AF0
	public class InteractionObject : MonoBehaviour // TypeDefIndex: 8480
	{
		// Fields
		[Tooltip] // 0x0000000180020AF0-0x0000000180020B20
		public Transform otherLookAtTarget; // 0x18
		[Tooltip] // 0x0000000180020B20-0x0000000180020B50
		public Transform otherTargetsRoot; // 0x20
		[Tooltip] // 0x0000000180020B50-0x0000000180020B80
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private float _length_k__BackingField; // 0x48
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private InteractionSystem _lastUsedInteractionSystem_k__BackingField; // 0x50
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x000000018030F430-0x000000018030F440 0x000000018076A8F0-0x000000018076A900
		public InteractionSystem lastUsedInteractionSystem { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x00000001802BC110-0x00000001802BC120 0x00000001803DFE50-0x00000001803DFE60
		public Transform lookAtTarget { get; } // 0x000000018076A7F0-0x000000018076A870 
		public Transform targetsRoot { get; } // 0x000000018076A870-0x000000018076A8F0 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 8474
		{
			// Fields
			[Tooltip] // 0x0000000180020C40-0x0000000180020C70
			public float time; // 0x10
			[Tooltip] // 0x0000000180020C70-0x0000000180020CA0
			public bool pause; // 0x14
			[Tooltip] // 0x0000000180020CA0-0x0000000180020CD0
			public bool pickUp; // 0x15
			[Tooltip] // 0x0000000180020CD0-0x0000000180020D00
			public AnimatorEvent[] animations; // 0x18
			[Tooltip] // 0x0000000180020D00-0x0000000180020D30
			public Message[] messages; // 0x20
			[Tooltip] // 0x0000000180020D30-0x0000000180020D60
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Activate(Transform t); // 0x00000001808412E0-0x00000001808414A0
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 8475
		{
			// Fields
			[Tooltip] // 0x0000000180020D60-0x0000000180020D90
			public string function; // 0x10
			[Tooltip] // 0x0000000180020D90-0x0000000180020DC0
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x003A6BC2
	
			// Constructors
			public Message(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public void Send(Transform t); // 0x0000000180847D30-0x0000000180847E20
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 8476
		{
			// Fields
			[Tooltip] // 0x0000000180020DC0-0x0000000180020DF0
			public Animator animator; // 0x10
			[Tooltip] // 0x0000000180020DF0-0x0000000180020E20
			public Animation animation; // 0x18
			[Tooltip] // 0x0000000180020E20-0x0000000180020E50
			public string animationState; // 0x20
			[Tooltip] // 0x0000000180020E50-0x0000000180020E80
			public float crossfadeTime; // 0x28
			[Tooltip] // 0x0000000180020E80-0x0000000180020EB0
			public int layer; // 0x2C
			[Tooltip] // 0x0000000180020EB0-0x0000000180020EE0
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x003A6BC6
	
			// Constructors
			public AnimatorEvent(); // 0x000000018083C400-0x000000018083C410
	
			// Methods
			public void Activate(bool pickUp); // 0x000000018083C200-0x000000018083C400
			private void Activate(Animator animator); // 0x000000018083C0A0-0x000000018083C140
			private void Activate(Animation animation); // 0x000000018083C140-0x000000018083C200
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 8478
		{
			// Fields
			[Tooltip] // 0x0000000180020EE0-0x0000000180020F10
			public Type type; // 0x10
			[Tooltip] // 0x0000000180020F10-0x0000000180020F40
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 8477
			{
				PositionWeight = 0,
				RotationWeight = 1,
				PositionOffsetX = 2,
				PositionOffsetY = 3,
				PositionOffsetZ = 4,
				Pull = 5,
				Reach = 6,
				RotateBoneWeight = 7,
				Push = 8,
				PushParent = 9,
				PoserWeight = 10
			}
	
			// Constructors
			public WeightCurve(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			public float GetValue(float timer); // 0x0000000180852A70-0x0000000180852C10
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 8479
		{
			// Fields
			[Tooltip] // 0x0000000180020F40-0x0000000180020F70
			public WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x0000000180020F70-0x0000000180020FA0
			public float multiplier; // 0x14
			[Tooltip] // 0x0000000180020FA0-0x0000000180020FD0
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier(); // 0x0000000180717FE0-0x0000000180717FF0
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer); // 0x0000000180847E20-0x0000000180847E60
		}
	
		// Constructors
		public InteractionObject(); // 0x000000018076A7A0-0x000000018076A7F0
	
		// Methods
		[ContextMenu] // 0x0000000180020B80-0x0000000180020BB0
		private void OpenTutorial1(); // 0x000000018076A620-0x000000018076A660
		[ContextMenu] // 0x0000000180020BB0-0x0000000180020BE0
		private void OpenTutorial2(); // 0x000000018076A660-0x000000018076A6A0
		[ContextMenu] // 0x0000000180020BE0-0x0000000180020C10
		private void OpenTutorial3(); // 0x000000018076A6A0-0x000000018076A6E0
		[ContextMenu] // 0x0000000180020C10-0x0000000180020C40
		private void OpenTutorial4(); // 0x000000018076A6E0-0x000000018076A720
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x000000018076A760-0x000000018076A7A0
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x0000000180768EC0-0x0000000180768F00
		public void Initiate(); // 0x000000018076A320-0x000000018076A5E0
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem); // 0x0000000180769BE0-0x0000000180769D70
		public bool CurveUsed(WeightCurve.Type type); // 0x0000000180769AB0-0x0000000180769B70
		public InteractionTarget[] GetTargets(); // 0x00000001802BF820-0x00000001802BF890
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag); // 0x0000000180769E00-0x0000000180769FD0
		public void OnStartInteraction(InteractionSystem interactionSystem); // 0x00000001803DFE50-0x00000001803DFE60
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight); // 0x00000001807694E0-0x0000000180769AA0
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer); // 0x0000000180769FD0-0x000000018076A2B0
		private void Awake(); // 0x0000000180769AA0-0x0000000180769AB0
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight); // 0x0000000180768F00-0x00000001807694E0
		private Transform GetTarget(FullBodyBipedEffector effectorType); // 0x0000000180769D70-0x0000000180769E00
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType); // 0x000000018076A2B0-0x000000018076A320
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType); // 0x0000000180769B70-0x0000000180769BE0
		[ContextMenu] // 0x000000018001D4B0-0x000000018001D4E0
		private void OpenUserManual(); // 0x000000018076A720-0x000000018076A760
		[ContextMenu] // 0x000000018001D4E0-0x000000018001D510
		private void OpenScriptReference(); // 0x000000018076A5E0-0x000000018076A620
	}
}
