using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{
	/// <summary>
	/// A class for generating cubes and objects (some of the functions are wrappers of CubeGenerator to make pmf mods more upgradeable)
	/// </summary>
	public class ObjectGenerationSystem : PMFSystem
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
		/// Generates a tee in a random spot inside the space provided by spaceCenter and spaceLength
		/// </summary>
		/// <param name="spaceCenter">size of the space</param>
		/// <param name="spaceLength">center of the space</param>
		/// <param name="treeType">type of tree</param>
		public static void GenerateTree(Vector3 spaceCenter, float spaceLength, CubeGenerator.TreeType treeType)
		{
			CubeGenerator.GenerateTree(spaceCenter, spaceLength, treeType);
		}


		/// <summary>
		/// Creates a new cube
		/// </summary>
		/// <param name="position"></param>
		/// <param name="size"></param>
		/// <param name="substance"></param>
		/// <param name="uVOffset"></param>
		/// <returns></returns>
		public static GameObject GenerateCube(Vector3 position, Vector3 size, Substance substance, CubeAppearance.UVOffset uVOffset=null)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(ObjectGenerationSystem));

			return CubeGenerator.GenerateCube(position, size, substance, uvOffset: uVOffset);
		}

		/// <summary>
		/// Creates a new cube inside a group
		/// </summary>
		/// <param name="position"></param>
		/// <param name="size"></param>
		/// <param name="substance"></param>
		/// <param name="uVOffset"></param>
		/// <param name="group"></param>
		/// <returns></returns>
		public static GameObject GenerateCube(Vector3 position, Vector3 size, GameObject group, Substance substance, CubeAppearance.UVOffset uVOffset = null)
		{
			
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(ObjectGenerationSystem));

			var cube = GenerateCube(position, size, substance, uVOffset);
			cube.transform.parent = group.transform;
			return cube;
		}

	}
}
