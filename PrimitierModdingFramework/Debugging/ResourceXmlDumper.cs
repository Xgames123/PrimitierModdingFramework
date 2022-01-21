﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
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
			DumpMaterials(rootElement);
			DumpSubstances(rootElement);

			document.AppendChild(rootElement);

			document.Save(FilePath);
			PMFLog.Message($"Dump complete saved at '{Path.Combine(Environment.CurrentDirectory, FilePath)}'");

		}

		public static string DumpSubstance(SubstanceParameters.Param substance)
		{
			XmlDocument document = new XmlDocument();
			DumpSubstance(substance, document);
			return document.OuterXml;
		}

		public static void DumpSubstance(SubstanceParameters.Param substance, XmlNode parentNode)
		{
			var document = parentNode.OwnerDocument;

			if (substance == null)
			{
				var nullNode = document.CreateElement("Null");

				parentNode.AppendChild(nullNode);
				return;
			}

			var substanceNode = document.CreateElement("Substance");
			substanceNode.SetAttribute("Name", substance.displayNameKey);

			XmlHelper.DeserializeFieldsToXml(substance, substanceNode);

			parentNode.AppendChild(substanceNode);
		}


		public static void DumpSubstances(XmlNode parentNode)
		{
			var document = parentNode.OwnerDocument;
			var substancesNode = document.CreateElement("Substances");

			if (SubstanceManager.instance == null)
			{
				SubstanceManager.instance = Resources.Load<SubstanceParameters>(SubstanceManager.scriptableObjectPath);
			}

			for (int i = 0; i < SubstanceManager.instance.param.Count; i++)
			{
				DumpSubstance(SubstanceManager.instance.param[i], substancesNode);

			}
		

			parentNode.AppendChild(substancesNode);

		}


		public static void DumpMaterials(XmlNode parentNode)
		{
			var document = parentNode.OwnerDocument;
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
