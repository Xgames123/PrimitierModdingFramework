/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 65: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8269-8551

namespace RootMotion
{
	public static class BipedNaming // TypeDefIndex: 8279
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 8277
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 8278
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming(); // 0x00000001807C3B40-0x00000001807C6E30
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones); // 0x00000001807C3780-0x00000001807C3920
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones); // 0x00000001807C33F0-0x00000001807C3590
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x00000001807C3590-0x00000001807C3780
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x00000001807C3920-0x00000001807C39D0
		public static Transform GetNamingMatch(Transform[] transforms, params /* 0x0000000180014D50-0x0000000180014D60 */ string[][] namings); // 0x00000001807C39D0-0x00000001807C3B00
		public static BoneType GetBoneType(string boneName); // 0x00000001807C2E40-0x00000001807C3360
		public static BoneSide GetBoneSide(string boneName); // 0x00000001807C2AF0-0x00000001807C2E40
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x003A69CB */, params /* 0x0000000180014D50-0x0000000180014D60 */ string[][] namings); // 0x00000001807C3360-0x00000001807C33F0
		private static bool isLeft(string boneName); // 0x00000001807C7160-0x00000001807C72D0
		private static bool isRight(string boneName); // 0x00000001807C7390-0x00000001807C7500
		private static bool isSpine(string boneName); // 0x00000001807C7500-0x00000001807C75C0
		private static bool isHead(string boneName); // 0x00000001807C70A0-0x00000001807C7160
		private static bool isArm(string boneName); // 0x00000001807C6F20-0x00000001807C6FE0
		private static bool isLeg(string boneName); // 0x00000001807C72D0-0x00000001807C7390
		private static bool isTail(string boneName); // 0x00000001807C75C0-0x00000001807C7680
		private static bool isEye(string boneName); // 0x00000001807C6FE0-0x00000001807C70A0
		private static bool isTypeExclude(string boneName); // 0x00000001807C7680-0x00000001807C76F0
		private static bool matchesNaming(string boneName, string[] namingConvention); // 0x00000001807C7810-0x00000001807C7900
		private static bool excludesNaming(string boneName, string[] namingConvention); // 0x00000001807C6E30-0x00000001807C6EC0
		private static bool matchesLastLetter(string boneName, string[] namingConvention); // 0x00000001807C7750-0x00000001807C7810
		private static bool LastLetterIs(string boneName, string letter); // 0x00000001807C3B00-0x00000001807C3B40
		private static string firstLetter(string boneName); // 0x00000001807C6EC0-0x00000001807C6F20
		private static string lastLetter(string boneName); // 0x00000001807C76F0-0x00000001807C7750
	}
}
