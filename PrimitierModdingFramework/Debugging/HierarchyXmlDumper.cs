using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrimitierModdingFramework.Debugging
{
	public static class HierarchyXmlDumper
	{

		public static string FilePath = "HierarchyDump.xml";

		public static void DumpScene(Scene scene, ComponentDumperList dumperList)
		{
			XmlDocument document = new XmlDocument();
			var sceneElement = document.CreateElement("Scene");
			document.AppendChild(sceneElement);

			var rootGameobjects = scene.GetRootGameObjects();
			for (int i = 0; i < rootGameobjects.Count; i++)
			{
				DumpGameObject(rootGameobjects[i], sceneElement, document, dumperList);
			}

			document.Save(FilePath);
		}

		public static void DumpCurrentScene(ComponentDumperList dumperList)
		{
			DumpScene(SceneManager.GetActiveScene(), dumperList);
		}


		public static void DumpGameObject(GameObject gameObject, XmlNode parentNode, XmlDocument document, ComponentDumperList dumperList)
		{
			if (gameObject == null)
			{
				return;
			}

			var components = gameObject.GetComponents<Component>();

			string fullName = "null";
			if (gameObject.name != null)
			{
				fullName = gameObject.name;
				fullName = fullName.Replace("<", "[");
				fullName = fullName.Replace(">", "]");
			}
			StringBuilder nameBuilder = new StringBuilder();
			for (int i = 0; i < fullName.Length; i++)
			{
				if (char.IsLetterOrDigit(fullName[i]))
				{
					nameBuilder.Append(fullName[i]);
				}

			}


			var currentNode = document.CreateElement(nameBuilder.ToString());
			var nameNode = document.CreateElement("FullName");
			nameNode.InnerText = fullName;
			currentNode.AppendChild(nameNode);
			parentNode.AppendChild(currentNode);

			for (int i = 0; i < components.Count; i++)
			{
				var component = components[i];

				DumpComponent(component, currentNode, document, dumperList);

			}

		}

		public static void DumpComponent(Component component, XmlNode parentNode, XmlDocument document, ComponentDumperList dumperList)
		{
			var name = component.GetIl2CppType().FullName;

			var currentNode = document.CreateElement(name);

			if (dumperList == null)
			{
				dumperList = ComponentDumperList.Empty;
			}

			for (int i = 0; i < dumperList.Count; i++)
			{
				var dumper = dumperList.Get(i);
				if (name == dumper.TargetComponentFullName)
				{
					dumper.OnDump(component, currentNode, document, dumperList);
				}

			}

			if (name == "UnityEngine.Transform")
			{
				
			}
			else
			{
				
			}

			parentNode.AppendChild(currentNode);
		}



	}
}
