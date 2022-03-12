using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{
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
		/// Creates a new CubeGroup to store new cubes
		/// </summary>
		public static GameObject GenerateGroup(Vector3 position)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(ObjectGenerationSystem));
			

			var groupedCubePrefab = CubeGenerator.groupPrefab;

			return GameObject.Instantiate(groupedCubePrefab, position, Quaternion.identity);

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
