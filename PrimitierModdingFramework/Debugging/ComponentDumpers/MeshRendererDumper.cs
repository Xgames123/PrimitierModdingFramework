using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class MeshRendererDumper : ComponentDumper
	{
		public override string TargetComponentFullName => nameof(MeshRenderer);

		public override void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList)
		{
			var meshRendererComponent = component.Cast<MeshRenderer>();

			var matArray = meshRendererComponent.GetMaterialArray();
			var materialsNode = document.CreateElement("Materials");
			for (int i = 0; i < matArray.Length; i++)
			{
				var mat = matArray[i];

				var matNode = document.CreateElement("Material");
				matNode.SetAttribute("FullName", mat.name);

				var shaderValue = "null";
				if (mat.shader != null)
				{
					shaderValue = mat.shader.name;
				}
				matNode.SetAttribute("Shader", shaderValue);

				materialsNode.AppendChild(matNode);
			}
			xmlElement.AppendChild(materialsNode);

		}
	}
}
