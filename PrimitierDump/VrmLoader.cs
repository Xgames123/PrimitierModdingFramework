/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UniGLTF;
using UnityEngine;
using VRM;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

public class VrmLoader : MonoBehaviour // TypeDefIndex: 8573
{
	// Fields
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private Transform gazeTarget; // 0x18
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private TextMeshPro infoText; // 0x20
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private AvatarVisibility avatarVisibility; // 0x28
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject avatarVisibilityButton; // 0x30
	[SerializeField] // 0x0000000180014D50-0x0000000180014D60
	private GameObject titleMenu; // 0x38
	private static readonly string defaultAvatarPath; // 0x00
	private static readonly float springBoneStiffnessMlp; // 0x08

	// Nested types
	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private struct _Load_d__8 : IAsyncStateMachine // TypeDefIndex: 8570
	{
		// Fields
		public int __1__state; // 0x00
		public AsyncTaskMethodBuilder __t__builder; // 0x08
		public VrmLoader __4__this; // 0x20
		private bool _vrmNotFound_5__2; // 0x28
		private int __7__wrap2; // 0x2C
		private TaskAwaiter<GameObject> __u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180887680-0x0000000180887FF0
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018054C340-0x000000018054C350
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private sealed class __c__DisplayClass9_0 // TypeDefIndex: 8571
	{
		// Fields
		public GltfParser parser; // 0x10
		public byte[] vrmFile; // 0x18

		// Constructors
		public __c__DisplayClass9_0(); // 0x00000001802650F0-0x0000000180265100

		// Methods
		internal void _LoadVrmAsync_b__0(); // 0x0000000180888830-0x0000000180888860
	}

	[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
	private struct _LoadVrmAsync_d__9 : IAsyncStateMachine // TypeDefIndex: 8572
	{
		// Fields
		public int __1__state; // 0x00
		public AsyncTaskMethodBuilder<GameObject> __t__builder; // 0x08
		public byte[] vrmFile; // 0x20
		private __c__DisplayClass9_0 __8__1; // 0x28
		public GameObject root; // 0x30
		private TaskAwaiter __u__1; // 0x38
		private VRMImporterContext _context_5__2; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180887FF0-0x0000000180888490
		[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180888490-0x00000001808884E0
	}

	// Constructors
	public VrmLoader(); // 0x0000000180265240-0x0000000180265250
	static VrmLoader(); // 0x0000000180B5DA10-0x0000000180B5DA70

	// Methods
	private static string GetAvatarDirectory(); // 0x0000000180B5D750-0x0000000180B5D7F0
	public async Task Load(); // 0x0000000180B5D920-0x0000000180B5DA10
	private async Task<GameObject> LoadVrmAsync(byte[] vrmFile, GameObject root); // 0x0000000180B5D7F0-0x0000000180B5D920
	private void ClearInfoText(); // 0x0000000180B5D6F0-0x0000000180B5D750
}

