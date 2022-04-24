using PrimitierModdingFramework.SubstanceModding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DemoMod.CustomObjects
{
	public static class CustomThreeGenerator
	{
		private const float c_treeThicness = 0.1f;
		private const float c_stemHeight = 1f;
		private const float c_leafSize = 0.5f;
		private const float c_leafHeight = 0.8f;


		public static void Generate(Vector3 spaceCenter, float spaceLength)
		{
			var margin = Mathf.Max(0, spaceLength - c_leafSize);
			var pos = spaceCenter + new Vector3((CubeGenerator.chunkRandom.Value - 0.5f) * margin, 0, (CubeGenerator.chunkRandom.Value - 0.5f) * margin);


			var stem = CubeGenerator.GenerateCube(new Vector3(pos.x, pos.y + (c_stemHeight / 2), pos.z), new Vector3(c_treeThicness, c_stemHeight, c_treeThicness), Substance.Wood, CubeAppearance.SectionState.Top | CubeAppearance.SectionState.Bottom);
			var leaf = CubeGenerator.GenerateCube(pos + new Vector3(0, c_stemHeight + c_leafHeight / 2, 0), new Vector3(c_leafSize, c_leafHeight, c_leafSize), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));


			leaf.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Free;
			stem.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Permanent;
			stem.GetComponent<CubeConnector>().Connect(leaf.GetComponent<CubeConnector>());
		}

	}
}
