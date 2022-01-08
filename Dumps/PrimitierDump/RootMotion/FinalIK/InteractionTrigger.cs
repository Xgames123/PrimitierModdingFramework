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
	[AddComponentMenu] // 0x0000000180021500-0x0000000180021560
	[HelpURL] // 0x0000000180021500-0x0000000180021560
	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 8490
	{
		// Fields
		[Tooltip] // 0x0000000180021560-0x0000000180021590
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 8486
		{
			// Fields
			[Tooltip] // 0x0000000180021590-0x00000001800215C0
			public bool use; // 0x10
			[Tooltip] // 0x00000001800215C0-0x00000001800215F0
			public Vector2 offset; // 0x14
			[Range] // 0x00000001800215F0-0x0000000180021640
			[Tooltip] // 0x00000001800215F0-0x0000000180021640
			public float angleOffset; // 0x1C
			[Range] // 0x0000000180021640-0x00000001800216A0
			[Tooltip] // 0x0000000180021640-0x00000001800216A0
			public float maxAngle; // 0x20
			[Tooltip] // 0x00000001800216A0-0x00000001800216D0
			public float radius; // 0x24
			[Tooltip] // 0x00000001800216D0-0x0000000180021700
			public bool orbit; // 0x28
			[Tooltip] // 0x0000000180021700-0x0000000180021730
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get; } // 0x000000018083EC30-0x000000018083EC50 
			public Vector3 direction3D { get; } // 0x000000018083EB90-0x000000018083EC30 
	
			// Constructors
			public CharacterPosition(); // 0x000000018083EB70-0x000000018083EB90
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error); // 0x000000018083E3D0-0x000000018083EB70
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 8487
		{
			// Fields
			[Tooltip] // 0x0000000180021730-0x0000000180021760
			public Collider lookAtTarget; // 0x10
			[Tooltip] // 0x0000000180021760-0x0000000180021790
			public Vector3 direction; // 0x18
			[Tooltip] // 0x0000000180021790-0x00000001800217C0
			public float maxDistance; // 0x24
			[Range] // 0x00000001800217C0-0x0000000180021810
			[Tooltip] // 0x00000001800217C0-0x0000000180021810
			public float maxAngle; // 0x28
			[Tooltip] // 0x0000000180021810-0x0000000180021840
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition(); // 0x000000018083E350-0x000000018083E3D0
	
			// Methods
			public Quaternion GetRotation(); // 0x000000018083DE10-0x000000018083DF80
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error); // 0x000000018083DF80-0x000000018083E350
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 8489
		{
			// Fields
			[HideInInspector] // 0x0000000180016550-0x0000000180016580
			[SerializeField] // 0x0000000180016550-0x0000000180016580
			public string name; // 0x10
			[HideInInspector] // 0x0000000180016550-0x0000000180016580
			[SerializeField] // 0x0000000180016550-0x0000000180016580
			public bool show; // 0x18
			[Tooltip] // 0x0000000180021840-0x0000000180021870
			public CharacterPosition characterPosition; // 0x20
			[Tooltip] // 0x0000000180021870-0x00000001800218A0
			public CameraPosition cameraPosition; // 0x28
			[Tooltip] // 0x00000001800218A0-0x00000001800218D0
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 8488
			{
				// Fields
				[Tooltip] // 0x00000001800218D0-0x0000000180021900
				public InteractionObject interactionObject; // 0x10
				[Tooltip] // 0x0000000180021900-0x0000000180021930
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction(); // 0x00000001802650F0-0x0000000180265100
			}
	
			// Constructors
			public Range(); // 0x00000001808490E0-0x00000001808490F0
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError); // 0x0000000180848FD0-0x00000001808490E0
		}
	
		// Constructors
		public InteractionTrigger(); // 0x00000001807702F0-0x0000000180770340
	
		// Methods
		[ContextMenu] // 0x000000018001D9E0-0x000000018001DA10
		private void OpenTutorial4(); // 0x0000000180770270-0x00000001807702B0
		[ContextMenu] // 0x000000018001D510-0x000000018001D540
		private void SupportGroup(); // 0x00000001807702B0-0x00000001807702F0
		[ContextMenu] // 0x000000018001D540-0x000000018001D570
		private void ASThread(); // 0x0000000180770030-0x0000000180770070
		private void Start(); // 0x0000000180265310-0x0000000180265320
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit); // 0x0000000180770070-0x0000000180770270
	}
}
