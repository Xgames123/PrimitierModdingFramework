/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Valve.Newtonsoft.Json;

// Image 49: Valve.Newtonsoft.Json.dll - Assembly: Valve.Newtonsoft.Json, Version=9.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6930-7132

namespace Valve.Newtonsoft.Json.Bson
{
	public class BsonWriter : JsonWriter // TypeDefIndex: 7127
	{
		// Fields
		private BsonToken _root; // 0x60
		private BsonToken _parent; // 0x68
		private string _propertyName; // 0x70
	
		// Methods
		private void AddValue(object value, BsonType type); // 0x0000000180383330-0x00000001803833B0
		internal void AddToken(BsonToken token); // 0x0000000180382F50-0x0000000180383330
		public void WriteObjectId(byte[] value); // 0x00000001803833B0-0x00000001803834B0
		public void WriteRegex(string pattern, string options); // 0x00000001803834B0-0x00000001803835E0
	}
}
