using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Xml;
using UnhollowerBaseLib;

namespace PrimitierModdingFramework.Debugging
{
	public static class XmlHelper
	{


		/// <summary>
		/// Creates a xml element and sets its InnerText
		/// </summary>
		/// <param name="parent">the parent of the xml element</param>
		/// <param name="name">the name of the xml element</param>
		/// <param name="value">the InnerText of the xml element</param>
		public static void SetXmlElement(this XmlElement parent, string name, string value)
		{
			var node = parent.OwnerDocument.CreateElement(name);
			node.InnerText = value;
			parent.AppendChild(node);

		}

		
	


		/// <summary>
		/// Deserialize fields to a the parentNode
		/// </summary>
		/// <param name="obj">the object to deserialize</param>
		/// <param name="parentNode">the parent node</param>
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
					node.InnerText = "Null";
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
