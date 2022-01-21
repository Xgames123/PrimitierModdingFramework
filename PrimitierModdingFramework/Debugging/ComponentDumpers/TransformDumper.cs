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

		public override void OnDump(Component component, XmlElement xmlElement, ComponentDumperList dumperList)
		{
			var TransformComponent = component.Cast<Transform>();

			xmlElement.SetXmlElement("Position", TransformComponent.localPosition.ToString());
			xmlElement.SetXmlElement("Rotation", TransformComponent.localRotation.ToString());
			xmlElement.SetXmlElement("Scale", TransformComponent.localScale.ToString());

		}
	}
}
