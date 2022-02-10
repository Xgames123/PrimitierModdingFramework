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
	/// <summary>
	/// A class for dumping the current state of the scene to an xml file
	/// </summary>
	public static class HierarchyXmlDumper
	{
		/// <summary>
		/// Name of the file to dump to
		/// </summary>
		public static string FilePath = "HierarchyDump.xml";

		/// <summary>
		/// A list with the default ComponentDumper
		/// </summary>
		public static ComponentDumperList DefaultDumperList = new ComponentDumperList(
			new TransformDumper(), 
			new RectTransformDumper(),
			new MeshRendererDumper(),
			new MeshFilterDumper());

		/// <summary>
		/// Dumps the provided scene to HierarchyXmlDumper.FilePath using a provided ComponentDumperList.
		/// Note: there is only 1 scene in Primitier
		/// </summary>
		/// <param name="scene"></param>
		/// <param name="dumperList"></param>
		public static void DumpSceneToFile(Scene scene, ComponentDumperList dumperList)
		{
			PMFLog.Message("Starting HierarchyDump Dump");
			XmlDocument document = new XmlDocument();
			DumpScene(scene, document, dumperList);

			document.Save(FilePath);
			PMFLog.Message($"Dump complete saved at '{Path.Combine(Environment.CurrentDirectory, FilePath)}'");
		}

		/// <summary>
		/// Dumps the scene to HierarchyXmlDumper.FilePath using a provided ComponentDumperList
		/// </summary>
		/// <param name="dumperList"></param>
		public static void DumpSceneToFile(ComponentDumperList dumperList)
		{
			DumpSceneToFile(SceneManager.GetActiveScene(), dumperList);
			
		}
		/// <summary>
		/// Dumps the scene to HierarchyXmlDumper.FilePath using the default ComponentDumperList
		/// </summary>
		public static void DumpSceneToFile()
		{
			DumpSceneToFile(SceneManager.GetActiveScene(), DefaultDumperList);

		}

		private static void DumpScene(Scene scene, XmlDocument document, ComponentDumperList dumperList)
		{
			var sceneElement = document.CreateElement("Scene");
			var primitierVersionAtribute = document.CreateAttribute("PrimitierVersion");
			primitierVersionAtribute.Value = Application.version;
			sceneElement.Attributes.Append(primitierVersionAtribute);
			document.AppendChild(sceneElement);

			var rootGameobjects = scene.GetRootGameObjects();
			for (int i = 0; i < rootGameobjects.Count; i++)
			{
				DumpGameObject(rootGameobjects[i], sceneElement, dumperList);
			}

		}


		private static void DumpGameObject(GameObject gameObject, XmlNode parentNode, ComponentDumperList dumperList)
		{
			var document = parentNode.OwnerDocument;
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

				DumpComponent(component, currentNode, dumperList);

			}

			var childrenNode = document.CreateElement("Children");
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				var child = gameObject.transform.GetChild(i);

				DumpGameObject(child.gameObject, childrenNode, dumperList);
			}

			currentNode.AppendChild(childrenNode);
		}

		private static void DumpComponent(Component component, XmlNode parentNode, ComponentDumperList dumperList)
		{
			var document = parentNode.OwnerDocument;

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
				dumper.OnDump(component, currentNode, dumperList);
			}
			else
			{
				XmlHelper.DeserializeFieldsToXml(component, currentNode);
			}

			parentNode.AppendChild(currentNode);
		}

		



	}
}
