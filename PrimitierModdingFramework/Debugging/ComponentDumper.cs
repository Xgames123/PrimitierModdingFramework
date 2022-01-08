using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public abstract class ComponentDumper
	{
		public abstract string TargetComponentFullName { get; }

		public abstract void OnDump(Component component, XmlElement xmlElement, XmlDocument document, ComponentDumperList dumperList);
	}
}
