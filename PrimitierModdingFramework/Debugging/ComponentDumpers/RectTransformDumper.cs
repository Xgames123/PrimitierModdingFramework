using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class RectTransformDumper : ComponentDumper
	{
		public override string TargetComponentFullName => "UnityEngine.RectTransform";

		public override void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList)
		{
			var rectTransfromComp = component.TryCast<RectTransform>();

			var positionNode = document.CreateElement("Position");
			positionNode.InnerText = rectTransfromComp.position.ToString();
			xmlElement.AppendChild(positionNode);

			var rotationNode = document.CreateElement("Rotation");
			rotationNode.InnerText = rectTransfromComp.rotation.ToString();
			xmlElement.AppendChild(rotationNode);

			var scaleNode = document.CreateElement("Scale");
			scaleNode.InnerText = rectTransfromComp.localScale.ToString();
			xmlElement.AppendChild(scaleNode);

			var childrenNode = document.CreateElement("Children");

			for (int i = 0; i < rectTransfromComp.childCount; i++)
			{
				var child = rectTransfromComp.GetChild(i);

				HierarchyXmlDumper.DumpGameObject(child.gameObject, childrenNode, document, dumperList);
			}

			xmlElement.AppendChild(childrenNode);
		}
	}
}
