/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 41: Unity.XR.OpenVR.dll - Assembly: Unity.XR.OpenVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6242-6867

namespace Valve.VR
{
	public class CVRNotifications // TypeDefIndex: 6661
	{
		// Fields
		private IVRNotifications FnTable; // 0x10
	
		// Constructors
		internal CVRNotifications(IntPtr pInterface); // 0x000000018090AAE0-0x000000018090ABF0
	
		// Methods
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId); // 0x000000018090A9A0-0x000000018090AAC0
		public EVRNotificationError RemoveNotification(uint notificationId); // 0x000000018090AAC0-0x000000018090AAE0
	}
}
