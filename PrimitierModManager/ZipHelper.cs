using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager
{
	public static class ZipHelper
	{

		public static ZipArchiveEntry? FindEntryZip(string filePath, ZipArchive zip)
		{
			foreach (var entry in zip.Entries)
			{
				if (entry.FullName == filePath)
				{
					return entry;
				}

			}

			return null;
		}

		public static byte[] ReadEntryZipBytes(ZipArchiveEntry entry)
		{
			var stream = entry.Open();

			byte[] bytes = new byte[stream.Length];
			stream.Read(bytes, 0, bytes.Length);

			stream.Close();
			return bytes;
		}

	}
}
