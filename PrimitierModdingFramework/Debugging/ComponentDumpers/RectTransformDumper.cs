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
		public override string TargetComponentFullName => nameof(RectTransform);

		public override void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList)
		{
			var rectTransformComponent = component.Cast<RectTransform>();

			xmlElement.SetXmlElement("Position", rectTransformComponent.localPosition.ToString());
			xmlElement.SetXmlElement("Rotation", rectTransformComponent.localRotation.ToString());
			xmlElement.SetXmlElement("Scale", rectTransformComponent.localScale.ToString());


			var childrenNode = document.CreateElement("Children");

			for (int i = 0; i < rectTransformComponent.childCount; i++)
			{
				var child = rectTransformComponent.GetChild(i);

				HierarchyXmlDumper.DumpGameObject(child.gameObject, childrenNode, document, dumperList);
			}

			xmlElement.AppendChild(childrenNode);
		}
	}
}
