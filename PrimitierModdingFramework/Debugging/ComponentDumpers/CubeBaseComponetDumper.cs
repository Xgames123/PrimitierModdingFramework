using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class CubeBaseComponetDumper : ComponentDumper
	{
		public override string TargetComponentFullName => "CubeBase";

		public override void OnDump(Component component, XmlElement xmlElement, ComponentDumperList dumperList)
		{
			var cubeBase = component.Cast<CubeBase>();

			xmlElement.SetXmlElement("objectNameKey", cubeBase.objectNameKey.ToString());
			xmlElement.SetXmlElement("substance", cubeBase.substance.ToString());
			
			string substanceBehavior = "null";
			if (cubeBase.substanceBehavior != null)
			{
				substanceBehavior = cubeBase.substanceBehavior.name.ToString();
			}
			xmlElement.SetXmlElement("substanceBehavior", substanceBehavior);

			var spElement = xmlElement.OwnerDocument.CreateElement("sp");
			XmlHelper.DeserializeFieldsToXml(cubeBase.sp, spElement);
			xmlElement.AppendChild(spElement);

			xmlElement.SetXmlElement("splitType", cubeBase.splitType.ToString());

			xmlElement.SetXmlElement("SplitEvent", cubeBase.SplitEvent.ToString());
			xmlElement.SetXmlElement("FragmentInitializeEvent", cubeBase.FragmentInitializeEvent.ToString());
			xmlElement.SetXmlElement("CollideEvent", cubeBase.CollideEvent.ToString());
			xmlElement.SetXmlElement("DamageEvent", cubeBase.DamageEvent.ToString());

			

		}
	}
}
