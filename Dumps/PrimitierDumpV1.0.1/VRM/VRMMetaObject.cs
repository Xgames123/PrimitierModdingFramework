/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniGLTF;
using UnityEngine;

// Image 60: VRM.dll - Assembly: VRM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7960-8103

namespace VRM
{
	public class VRMMetaObject : ScriptableObject // TypeDefIndex: 8083
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string ExporterVersion; // 0x18
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Title; // 0x20
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Version; // 0x28
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Author; // 0x30
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string ContactInformation; // 0x38
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string Reference; // 0x40
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public Texture2D Thumbnail; // 0x48
		[SerializeField] // 0x0000000180037400-0x0000000180037440
		[Tooltip] // 0x0000000180037400-0x0000000180037440
		public AllowedUser AllowedUser; // 0x50
		[SerializeField] // 0x0000000180037440-0x0000000180037480
		[Tooltip] // 0x0000000180037440-0x0000000180037480
		public UssageLicense ViolentUssage; // 0x54
		[SerializeField] // 0x0000000180037480-0x00000001800374C0
		[Tooltip] // 0x0000000180037480-0x00000001800374C0
		public UssageLicense SexualUssage; // 0x58
		[SerializeField] // 0x00000001800374C0-0x0000000180037510
		[Tooltip] // 0x00000001800374C0-0x0000000180037510
		public UssageLicense CommercialUssage; // 0x5C
		[SerializeField] // 0x0000000180037510-0x0000000180037550
		[Tooltip] // 0x0000000180037510-0x0000000180037550
		public string OtherPermissionUrl; // 0x60
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public LicenseType LicenseType; // 0x68
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		public string OtherLicenseUrl; // 0x70
	
		// Nested types
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _Validate_d__14 : IEnumerable<UniGLTF.Validation>, IEnumerator<UniGLTF.Validation> // TypeDefIndex: 8082
		{
			// Fields
			private int __1__state; // 0x10
			private UniGLTF.Validation __2__current; // 0x18
			private int __l__initialThreadId; // 0x30
			public VRMMetaObject __4__this; // 0x38
	
			// Properties
			UniGLTF.Validation IEnumerator<UniGLTF.Validation>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x00000001805509E0-0x0000000180550A00 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180550A40-0x0000000180550A90 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _Validate_d__14(int __1__state); // 0x000000018054D600-0x000000018054D630
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001805507A0-0x0000000180550940
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180550A00-0x0000000180550A40
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator<UniGLTF.Validation> IEnumerable<Validation>.GetEnumerator(); // 0x0000000180550940-0x00000001805509E0
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180550940-0x00000001805509E0
		}
	
		// Constructors
		public VRMMetaObject(); // 0x000000018030DE80-0x000000018030DE90
	
		// Methods
		[IteratorStateMachine] // 0x0000000180037550-0x00000001800375A0
		public IEnumerable<UniGLTF.Validation> Validate(GameObject _); // 0x000000018034E680-0x000000018034E6F0
	}
}
