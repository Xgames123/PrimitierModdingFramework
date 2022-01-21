using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	/// <summary>
	/// used to modify generated xml tag of the TargetComponent
	/// </summary>
	public abstract class ComponentDumper
	{
		public abstract string TargetComponentFullName { get; }

		public abstract void OnDump(Component component, XmlElement xmlElement, ComponentDumperList dumperList);
	}
}
