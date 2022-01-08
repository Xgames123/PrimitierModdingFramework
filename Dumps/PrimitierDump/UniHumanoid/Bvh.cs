/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 38: UniHumanoid.dll - Assembly: UniHumanoid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5924-5987

namespace UniHumanoid
{
	public class Bvh // TypeDefIndex: 5956
	{
		// Fields
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private BvhNode _Root_k__BackingField; // 0x10
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private TimeSpan _FrameTime_k__BackingField; // 0x18
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private ChannelCurve[] _Channels_k__BackingField; // 0x20
		private int m_frames; // 0x28
	
		// Properties
		public BvhNode Root { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
		public TimeSpan FrameTime { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
		public ChannelCurve[] Channels { [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ get; [CompilerGenerated] /* 0x0000000180014D50-0x0000000180014D60 */ private set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
		public int FrameCount { get; } // 0x00000001802B51E0-0x00000001802B51F0 
	
		// Nested types
		public struct PathWithProperty // TypeDefIndex: 5953
		{
			// Fields
			public string Path; // 0x00
			public string Property; // 0x08
			public bool IsLocation; // 0x10
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 5954
		{
			// Fields
			public int frames; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal ChannelCurve _.ctor_b__2(int x); // 0x00000001812BDA60-0x00000001812BDAF0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c // TypeDefIndex: 5955
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<BvhNode, bool> __9__21_0; // 0x08
			public static Func<BvhNode, int> __9__21_1; // 0x10
			public static Func<string, bool> __9__22_0; // 0x18
	
			// Constructors
			static __c(); // 0x00000001812BDE70-0x00000001812BDED0
			public __c(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal bool _.ctor_b__21_0(BvhNode x); // 0x00000001812BD7B0-0x00000001812BD7D0
			internal int _.ctor_b__21_1(BvhNode x); // 0x00000001812BD7D0-0x00000001812BD7F0
			internal bool _ParseFrame_b__22_0(string x); // 0x0000000180D56950-0x0000000180D56970
		}
	
		// Constructors
		public Bvh(BvhNode root, int frames, float seconds); // 0x00000001812B2C40-0x00000001812B2FF0
	
		// Methods
		public bool TryGetPathWithPropertyFromChannel(ChannelCurve channel, out PathWithProperty pathWithProp); // 0x00000001812B28B0-0x00000001812B2C40
		public string GetPath(BvhNode node); // 0x00000001812B1750-0x00000001812B1860
		private BvhNode GetParent(BvhNode node); // 0x00000001812B1530-0x00000001812B1750
		public ChannelCurve GetChannel(BvhNode target, Channel channel); // 0x00000001812B1260-0x00000001812B1530
		public override string ToString(); // 0x00000001812B25D0-0x00000001812B28B0
		public void ParseFrame(int frame, string line); // 0x00000001812B1860-0x00000001812B1B50
		public static Bvh Parse(string src); // 0x00000001812B20C0-0x00000001812B25D0
		private static BvhNode ParseNode(StringReader r, int level = 0 /* Metadata: 0x003A1C98 */); // 0x00000001812B1B50-0x00000001812B20C0
	}
}
