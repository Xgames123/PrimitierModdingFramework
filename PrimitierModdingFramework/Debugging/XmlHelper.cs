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


		public static void DeserializeFieldsToXml(Il2CppSystem.Object obj, XmlNode parentNode)
		{
			var document = parentNode.OwnerDocument;

			var fields = obj.GetIl2CppType().GetFields();

			for (int i = 0; i < fields.Length; i++)
			{
				var field = fields[i];
				if (field == null)
				{
					continue;
				}

				var node = document.CreateElement(field.Name);
				var value = field.GetValue(obj);
				if (value == null)
				{
					node.InnerText = "null";
				}
				else
				{
					node.InnerText = value.ToString();
				}

				parentNode.AppendChild(node);

			}



		}

	}
}
