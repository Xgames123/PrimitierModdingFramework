/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRDriverManager // TypeDefIndex: 6665
	{
		// Fields
		private IVRDriverManager FnTable; // 0x10
	
		// Constructors
		internal CVRDriverManager(IntPtr pInterface); // 0x0000000180909000-0x0000000180909110
	
		// Methods
		public uint GetDriverCount(); // 0x00000001809056A0-0x0000000180905830
		public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize); // 0x0000000180908FB0-0x0000000180908FE0
		public ulong GetDriverHandle(string pchDriverName); // 0x0000000180908EF0-0x0000000180908FB0
		public bool IsEnabled(uint nDriver); // 0x0000000180908FE0-0x0000000180909000
	}
}
