using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace PrimitierModdingFramework.Debugging
{
	public static class ResourceXmlDumper
	{
		public static string FilePath = "ResourceDump.xml";

		public static void DumpAllToFile()
		{
			PMFLog.Message("Starting ResourceDump Dump");
			XmlDocument document = new XmlDocument();
			var rootElement = document.CreateElement("Resources");
			DumpMaterials(rootElement, document);
			DumpSubstances(rootElement, document);

			document.AppendChild(rootElement);

			document.Save(FilePath);
			PMFLog.Message($"Dump complete saved at '{Path.Combine(Environment.CurrentDirectory, FilePath)}'");

		}


		public static void DumpSubstances(XmlNode parentNode, XmlDocument document)
		{
			var substancesNode = document.CreateElement("Substances");

			var instance = SubstanceManager.instance;
			PMFLog.Message("instance " + instance == null);
			PMFLog.Message("instance param " + instance.param == null);

			for (int i = 0; i < instance.param.Count; i++)
			{
				var substance = instance.param[i];

				var substanceNode = document.CreateElement("Substance");
				substanceNode.SetAttribute("Name", substance.displayNameKey);
				substanceNode.SetAttribute("CollisionSound", substance.collisionSound);
				substanceNode.SetAttribute("Material", substance.material);
				substanceNode.SetAttribute("SectionMaterialH", substance.sectionMaterialH);
				substanceNode.SetAttribute("SectionMaterialV", substance.sectionMaterialV);

				substancesNode.AppendChild(substanceNode);
			}
		


		

			parentNode.AppendChild(substancesNode);

		}


		public static void DumpMaterials(XmlNode parentNode, XmlDocument document)
		{
			var materialsNode = document.CreateElement("Materials");


			var resources = Resources.LoadAll(SubstanceManager.materialDirectory);
			for (int i = 0; i < resources.Count; i++)
			{
				DumpMat(resources[i].Cast<Material>(), materialsNode, document);

			}

			parentNode.AppendChild(materialsNode);
		}

		public static void DumpMat(UnityEngine.Material mat, XmlNode parentNode, XmlDocument document)
		{
			var matNode = document.CreateElement("Material");
			matNode.SetAttribute("Name", mat.name);
			matNode.SetAttribute("Color", mat.color.ToString());
			matNode.SetAttribute("Shader", mat.shader.name);

			parentNode.AppendChild(matNode);
		}


	}
}
