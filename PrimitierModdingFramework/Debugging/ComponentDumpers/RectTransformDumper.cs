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

		public override void OnDump(Component component, XmlElement xmlElement, ComponentDumperList dumperList)
		{
			var rectTransformComponent = component.Cast<RectTransform>();

			xmlElement.SetXmlElement("Position", rectTransformComponent.localPosition.ToString());
			xmlElement.SetXmlElement("Rotation", rectTransformComponent.localRotation.ToString());
			xmlElement.SetXmlElement("Scale", rectTransformComponent.localScale.ToString());


		}
	}
}
