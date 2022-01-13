using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class MeshFilterDumper : ComponentDumper
	{
		public override string TargetComponentFullName => nameof(MeshFilter);


		public override void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList)
		{
			var meshFitlerComponent = component.Cast<MeshFilter>();

			var sharedMeshValue = "null";
			if (meshFitlerComponent.sharedMesh != null)
			{
				sharedMeshValue = meshFitlerComponent.sharedMesh.ToString();
			}
			xmlElement.SetAttribute("SharedMesh", sharedMeshValue);


		}
	}
}
