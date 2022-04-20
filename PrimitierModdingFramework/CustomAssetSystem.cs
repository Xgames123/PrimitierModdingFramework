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

        private static Dictionary<Assembly, string> _modPrivateFolders = new Dictionary<Assembly, string>();

        public override void OnSystemEnabled()
        {
            IsEnabled = true;
        }
        public override void OnSystemDisabled()
        {
            IsEnabled = false;
        }


        /// <summary>
        /// Used to get the current AssetFolder of the mod
        /// </summary>
        public string GetAssetFolder(Assembly assembly)
		{
            return GetModPrivateFolder(assembly)+"__ASSETS";

        }
        private string GetModPrivateFolder(Assembly assembly)
		{
            if (_modPrivateFolders.TryGetValue(assembly, out string folder))
            {
                return folder;

            }

            var melonInfo = assembly.GetCustomAttribute<MelonLoader.MelonInfoAttribute>();

            if (melonInfo == null)
            {
                throw new ArgumentException("The assembly doesn't contain a MelonInfo attribute", "assembly");
            }

            StringBuilder newName = new StringBuilder();
            var invalidPathChars = Path.GetInvalidPathChars();
            foreach (var character in melonInfo.Name)
            {
                if (invalidPathChars.Contains(character))
                {
                    newName.Append('_');
                    continue;
                }
                newName.Append(character);

            }
            var newNameStr = newName.ToString();
            _modPrivateFolders.Add(assembly, newNameStr);

            return newNameStr;

        }



        /// <summary>
        /// Creates an empty 1x1 Texture2D and adds it to the CachedResources (so it can be used in a customSubstance)
        /// </summary>
        /// <param name="name">Name of the texture</param>
        /// <returns></returns>
        [Obsolete("This is going to be implemented in the future")]
        public static Texture2D CreateEmptyTexture(string name)
		{
            throw new NotImplementedException();
            CachedResources.caches[name] = new Texture2D(1, 1);
            return CachedResources.Load<Texture2D>(name);
        }



        /// <summary>
        /// Writes data to a Texture2D
        /// </summary>
        /// /// <param name="bytes">the data of the image</param>
        /// <param name="texture">the texture to write the data to</param>
        [Obsolete("This is going to be implemented in the future")]
        public static void LoadImageFromBytes(byte[] bytes, ref Texture2D texture)
        {
            throw new NotImplementedException();
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));


            texture.LoadRawTextureData(bytes);

        }

        /// <summary>
        /// Writes data from an EmbeddedResource to a Texture2D
        /// </summary>
        /// <param name="assembly">The assembly were the image is located</param>
        /// <param name="resourceName">The full name of the resource (AssemblyName.fileStructure)</param>
        /// <param name="texture">the texture to write the data to</param>
        [Obsolete("This is going to be implemented in the future")]
        public static void LoadImageFromEmbeddedResource(Assembly assembly, string resourceName, ref Texture2D texture)
		{
            throw new NotImplementedException();
            
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));

            var bytes = LoadEmbeddedResource(assembly, resourceName);

            LoadImageFromBytes(bytes, ref texture);
		}


        /// <summary>
        /// Writes data from an EmbeddedResource to a Texture2D
        /// </summary>
        /// <param name="resourceName">The full name of the resource (AssemblyName.fileStructure)</param>
        /// <param name="texture">the texture to write the data to</param>
        [Obsolete("This is going to be implemented in the future")]
        public static void LoadImageFromEmbeddedResource(string resourceName, ref Texture2D texture)
        {
            throw new NotImplementedException();
            if (!IsEnabled)
                throw new PMFSystemNotEnabledException(typeof(CustomAssetSystem));

            LoadImageFromEmbeddedResource(Mod.Assembly, resourceName, ref texture);
        }


        /// <summary>
        /// Loads the bytes from an EmbeddedResource
        /// </summary>
        /// <param name="resourceName">The assembly were the resource is located</param>
        /// <param name="assembly">The full name of the resource (AssemblyName.fileStructure)</param>
        /// <returns></returns>
        public static byte[] LoadEmbeddedResource(Assembly assembly, string resourceName)
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
