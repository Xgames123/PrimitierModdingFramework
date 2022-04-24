using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnhollowerBaseLib;
using UnityEngine;

namespace PrimitierModdingFramework
{

    /// <summary>
    /// A System for loading custom assets into Primitier
    /// </summary>
    public class CustomAssetSystem : PMFSystem
	{
        public static bool IsEnabled { get; private set; } = false;


        public override void OnSystemEnabled()
        {
            IsEnabled = true;
        }
        public override void OnSystemDisabled()
        {
            IsEnabled = false;
        }


        /// <summary>
        /// Writes data to a Texture2D
        /// </summary>
        /// /// <param name="bytes">the data of the image</param>
        /// <param name="texture">the texture to write the data to</param>
        public static void LoadImageFromBytes(Il2CppStructArray<byte> bytes, ref Texture2D texture)
        {
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));


            ImageConversion.LoadImage(texture, bytes);
        }

        /// <summary>
        /// Writes data from an EmbeddedResource to a Texture2D
        /// </summary>
        /// <param name="assembly">The assembly were the image is located</param>
        /// <param name="resourceName">The full name of the resource (AssemblyName.Assets.MyImage.png)</param>
        /// <param name="texture">the texture to write the data to</param>
        public static void LoadImageFromEmbeddedResource(Assembly assembly, string resourceName, ref Texture2D texture)
		{
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));

            var bytes = LoadEmbeddedResource(assembly, resourceName);

            LoadImageFromBytes(bytes, ref texture);
		}


        /// <summary>
        /// Writes data from an EmbeddedResource to a Texture2D
        /// </summary>
        /// <param name="resourceName">The full name of the resource (AssemblyName.Assets.MyImage.png)</param>
        /// <param name="texture">the texture to write the data to</param>
        public static void LoadImageFromEmbeddedResource(string resourceName, ref Texture2D texture)
        {
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));

            LoadImageFromEmbeddedResource(Mod.Assembly, resourceName, ref texture);
        }




        /// <summary>
        /// Gets the stream from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The assembly were the resource is located</param>
        /// <returns></returns>
        public static Stream GetEmbeddedResourceStream(string resourceName) 
        {
            return GetEmbeddedResourceStream(Assembly.GetEntryAssembly(), resourceName);
        }

        /// <summary>
        /// Gets the stream from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The assembly were the resource is located</param>
        /// <param name="assembly">The full name of the resource (AssemblyName.Assets.MyImage.png)</param>
        /// <returns></returns>
        public static Stream GetEmbeddedResourceStream(Assembly assembly, string resourceName)
        {

            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));

            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var stream = assembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new ArgumentException($"The resourceName '{resourceName}' doesn't exist");
            }

            return stream;
        }

        /// <summary>
        /// Loads the bytes from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The assembly were the resource is located</param>
        /// <param name="assembly">The full name of the resource (AssemblyName.Assets.MyImage.png)</param>
        /// <returns></returns>
        public static byte[] LoadEmbeddedResource(Assembly assembly, string resourceName)
		{
            var stream = GetEmbeddedResourceStream(assembly, resourceName);
            var bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            stream.Close();

            return bytes;
        }

        /// <summary>
        /// Loads the bytes from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The assembly were the resource is located</param>
        /// <returns></returns>
        public static byte[] LoadEmbeddedResource(string resourceName)
		{
            return LoadEmbeddedResource(Mod.Assembly, resourceName);
        }




    }
}
