/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Newtonsoft.Json;

// Image 36: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed - Types 5284-5564

namespace Newtonsoft.Json.Bson
{
	[Obsolete] // 0x0000000180017070-0x00000001800170A0
	public class BsonWriter : JsonWriter // TypeDefIndex: 5554
	{
		// Fields
		private BsonToken _root; // 0x60
		private BsonToken _parent; // 0x68
		private string _propertyName; // 0x70
	
		// Methods
		private void AddValue(object value, BsonType type); // 0x00000001803C5F10-0x00000001803C5F90
		internal void AddToken(BsonToken token); // 0x00000001803C5BB0-0x00000001803C5F10
		public void WriteObjectId(byte[] value); // 0x00000001803C5F90-0x00000001803C6090
		public void WriteRegex(string pattern, string options); // 0x00000001803C6090-0x00000001803C61B0
	}
}
