using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{

	/// <summary>
	/// A System for loading custom assets into Primitier
	/// </summary>
	public class CustomAssetSystem : PMFSystem
	{

        /// <summary>
        /// loads a image into Primitier from bytes
        /// </summary>
        /// <param name="bytes">the data of the image</param>
        /// <returns></returns>
        public static Texture2D LoadImageFromBytes(byte[] bytes)
        {

            var tex = PMFIL2CPPHelpers.AddCollectBlock(new Texture2D(0, 0));

            tex.LoadRawTextureData(bytes);

            return tex;
        }

        /// <summary>
        /// loads a image into Primitier from an EmbeddedResource
        /// </summary>
        /// <param name="assembly">The assembly were the image is located</param>
        /// <param name="resourceName">The full name of the resource (AssemblyName.fileStructure)</param>
        /// <returns></returns>
        public static Texture2D LoadImageFromEmbeddedResource(Assembly assembly, string resourceName)
		{
            if (assembly == null)
			{
                throw new ArgumentNullException(nameof(assembly));
			}

            var stream = assembly.GetManifestResourceStream(resourceName);

            if (stream == null)
			{
                throw new ArgumentException($"The resourceName '{resourceName}' doesn't exist");
			}

            var bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            stream.Close();

            return LoadImageFromBytes(bytes);
		}

        /// <summary>
        /// loads a image into Primitier from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The full name of the resource (AssemblyName.fileStructure)</param>
        /// <returns></returns>
        public static Texture2D LoadImageFromEmbeddedResource(string resourceName)
        {
            return LoadImageFromEmbeddedResource(Mod.Assembly, resourceName);
        }


    }
}
