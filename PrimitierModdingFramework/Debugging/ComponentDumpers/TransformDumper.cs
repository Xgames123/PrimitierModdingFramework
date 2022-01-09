using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class TransformDumper : ComponentDumper
	{
		public override string TargetComponentFullName => "UnityEngine.Transform";

		public override void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList)
		{
			var transfromComp = component.TryCast<Transform>();

			var positionNode = document.CreateElement("Position");
			positionNode.InnerText = transfromComp.position.ToString();
			xmlElement.AppendChild(positionNode);

			var rotationNode = document.CreateElement("Rotation");
			rotationNode.InnerText = transfromComp.rotation.ToString();
			xmlElement.AppendChild(rotationNode);

			var scaleNode = document.CreateElement("Scale");
			scaleNode.InnerText = transfromComp.localScale.ToString();
			xmlElement.AppendChild(scaleNode);

			var childrenNode = document.CreateElement("Children");
			for (int i = 0; i < transfromComp.childCount; i++)
			{
				var child = transfromComp.GetChild(i);

				HierarchyXmlDumper.DumpGameObject(child.gameObject, childrenNode, document, dumperList);
			}

			xmlElement.AppendChild(childrenNode);
		}
	}
}
