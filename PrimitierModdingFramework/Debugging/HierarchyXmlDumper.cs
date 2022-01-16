using Il2CppSystem;
using Il2CppSystem.Reflection;
using MelonLoader;
using PrimitierModdingFramework.Debugging.ComponentDumpers;
using System.IO;
using System.Text;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrimitierModdingFramework.Debugging
{
	public static class HierarchyXmlDumper
	{

		public static string FilePath = "HierarchyDump.xml";

		public static ComponentDumperList DefaultDumperList = new ComponentDumperList(
			new TransformDumper(), 
			new RectTransformDumper(),
			new MeshRendererDumper(),
			new MeshFilterDumper());


		public static void DumpSceneToFile(Scene scene, ComponentDumperList dumperList)
		{
			PMFLog.Message("Starting Dump");
			XmlDocument document = new XmlDocument();
			DumpScene(scene, document, dumperList);

			document.Save(FilePath);
			PMFLog.Message($"Dump complete saved at '{Path.Combine(Environment.CurrentDirectory, FilePath)}'");
		}

		public static void DumpCurrentSceneToFile(ComponentDumperList dumperList)
		{
			DumpSceneToFile(SceneManager.GetActiveScene(), dumperList);
			
		}
		public static void DumpCurrentSceneToFile()
		{
			DumpSceneToFile(SceneManager.GetActiveScene(), DefaultDumperList);

		}

		public static void DumpScene(Scene scene, XmlDocument document, ComponentDumperList dumperList)
		{
			var sceneElement = document.CreateElement("Scene");
			var primitierVersionAtribute = document.CreateAttribute("PrimitierVersion");
			primitierVersionAtribute.Value = Application.version;
			sceneElement.Attributes.Append(primitierVersionAtribute);
			document.AppendChild(sceneElement);

			var rootGameobjects = scene.GetRootGameObjects();
			for (int i = 0; i < rootGameobjects.Count; i++)
			{
				DumpGameObject(rootGameobjects[i], sceneElement, document, dumperList);
			}

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
				fullName = fullName.Replace("\"", " ");
			}


			var currentNode = document.CreateElement("GameObject");
			currentNode.SetAttribute("FullName", fullName);
			currentNode.SetAttribute("Active", gameObject.active.ToString());
			parentNode.AppendChild(currentNode);

			for (int i = 0; i < components.Count; i++)
			{
				var component = components[i];

				DumpComponent(component, currentNode, document, dumperList);

			}

			var childrenNode = document.CreateElement("Children");
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				var child = gameObject.transform.GetChild(i);

				DumpGameObject(child.gameObject, childrenNode, document, dumperList);
			}

			currentNode.AppendChild(childrenNode);
		}

		public static void DumpComponent(Component component, XmlNode parentNode, XmlDocument document, ComponentDumperList dumperList)
		{

			var name = component.GetIl2CppType().FullName;

			var currentNode = document.CreateElement(name);

			if (dumperList == null)
			{
				dumperList = ComponentDumperList.Empty;
			}

			var behaviour = component.TryCast<Behaviour>();
			if (behaviour != null)
			{
				currentNode.SetAttribute("Enabled", behaviour.enabled.ToString());
			}
			
	
			var dumper = dumperList.GetByTargetComponent(name);
			if (dumper != null)
			{
				dumper.OnDump(component, currentNode, document, dumperList);
			}
			else
			{
				DumpFields(component, currentNode, document);
			}

			parentNode.AppendChild(currentNode);
		}

		


		private static void DumpFields(Component component, XmlElement xmlElement, XmlDocument document)
		{

			var fields = component.GetIl2CppType().GetFields();

			for (int i = 0; i < fields.Length; i++)
			{
				var field = fields[i];
				if (field == null)
				{
					continue;
				}

				var node = document.CreateElement(field.Name);
				var value = field.GetValue(component);
				if (value == null)
				{
					node.InnerText = "null";
				}
				else
				{
					node.InnerText = value.ToString();
				}

				xmlElement.AppendChild(node);

			}
		}



	}
}
