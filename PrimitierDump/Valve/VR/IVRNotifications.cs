/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public struct IVRNotifications // TypeDefIndex: 6540
	{
		// Fields
		internal _CreateNotification CreateNotification; // 0x00
		internal _RemoveNotification RemoveNotification; // 0x08
	
		// Nested types
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, IntPtr pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId); // TypeDefIndex: 6538; 0x0000000180920EA0-0x00000001809212A0
	
		[UnmanagedFunctionPointer] // 0x000000018003C610-0x000000018003C630
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId); // TypeDefIndex: 6539; 0x0000000180929E80-0x000000018092A010
	}
}
