using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PrimitierModdingFramework.Debugging;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging.ComponentDumpers
{
	public class StartButtonComponentDumper : ComponentDumper
	{
		public override string TargetComponentFullName => "StartButton";

		public override void OnDump(Component component, XmlElement xmlElement, ComponentDumperList dumperList)
		{
			var startButton = component.Cast<StartButton>();

			xmlElement.SetAttribute("col", startButton.col.ToString());
			xmlElement.SetAttribute("slot", startButton.slot.ToString());

			var destroyOnPressElement = xmlElement.OwnerDocument.CreateElement("destroyOnPress");
			xmlElement.AppendChild(destroyOnPressElement);
			foreach (var go in startButton.destroyOnPress)
			{
				var goElement = xmlElement.OwnerDocument.CreateElement(go.name);
				destroyOnPressElement.AppendChild(goElement);

			}
			var enableOnPressElement = xmlElement.OwnerDocument.CreateElement("enableOnPress");
			xmlElement.AppendChild(enableOnPressElement);
			foreach (var go in startButton.enableOnPress)
			{
				var goElement = xmlElement.OwnerDocument.CreateElement(go.name);
				enableOnPressElement.AppendChild(goElement);

			}

		}
	}
}
