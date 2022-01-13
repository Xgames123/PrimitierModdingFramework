using System.Xml;

namespace PrimitierModdingFramework.Debugging
{
	public static class XmlHelper
	{



		public static void SetXmlElement(this XmlElement parent, string name, string value)
		{
			var node = parent.OwnerDocument.CreateElement(name);
			node.InnerText = value;
			parent.AppendChild(node);

		}
	}
}
