using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PMFTool;
public static class DirectLinkCsProjFixer
{

	public static void LogWarning(ConfigFile config)
	{
		if (config.DirectDllLink)
			return;
		ConsoleWriter.WriteLineWarning("DirectDllLink is not enabled. you can enable this by adding DirectDllLink=true to your .pmftoolconfig and running pmftool update-dlls");
	}


	public static void Fix(string csprojFile, ConfigFile config)
	{
		var xmlDocument = new XmlDocument();
		try
		{
			xmlDocument.Load(csprojFile);
		}
		catch (Exception e)
		{
			ConsoleWriter.WriteLineError("Could not read .csproj file", e);
		}

		var proxyDllDir = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "Managed"));
		var melonloaderDll = new FileInfo(Path.Combine(Path.GetDirectoryName(config.PrimitierPath), "MelonLoader", "MelonLoader.dll"));

		bool hasChangedDoc = false;
		if (SetElement(xmlDocument, "UseDirectLink", "true"))
			hasChangedDoc = true;
		if(SetElement(xmlDocument, "ProxyDllsFolder", proxyDllDir.FullName))
			hasChangedDoc = true;
		if (SetElement(xmlDocument, "MelonloaderDll", melonloaderDll.FullName))
			hasChangedDoc = true;

		if (hasChangedDoc == false)
			return;

		try
		{
			xmlDocument.Save(csprojFile);
		}catch(Exception e)
		{
			ConsoleWriter.WriteLineError("Could not save modified .csproj file", e);
			return;
		}
		ConsoleWriter.WriteLineStatus("Saved new .csproj file");

	}

	private static bool SetElement(XmlDocument document, string elementName, string innerText)
	{
		var elements = document.GetElementsByTagName(elementName);
		if (elements.Count == 0)
		{
			var useDirectLinkElement = document.CreateElement(elementName);
			useDirectLinkElement.InnerText = innerText;
			AddAndWrapInPropGroup(useDirectLinkElement, document);
			return true;
		}
		bool hasChangedDoc = false;
		for (int i = 0; i < elements.Count; i++)
		{
			if (elements.Item(i).InnerText == innerText)
				continue;

			elements.Item(i).InnerText = innerText;
			hasChangedDoc = true;
		}

		return hasChangedDoc;

	}


	private static void AddAndWrapInPropGroup(XmlElement element, XmlDocument document)
	{
		var propGroup = document.CreateElement("PropertyGroup");
		propGroup.AppendChild(element);
		document.DocumentElement.AppendChild(propGroup);

	}

}
