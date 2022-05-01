using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public static class PMFLocalizer
	{

		/// <summary>
		/// List that contains the English localizations
		/// </summary>
		public static Dictionary<string, string> EnLocalizations = new Dictionary<string, string>();
		/// <summary>
		/// List that contains the Japanese localizations
		/// </summary>
		public static Dictionary<string, string> JpLocalizations = new Dictionary<string, string>();


		/// <summary>
		/// Adds a new Japanese localization (This does not call ReloadLocalizations)
		/// </summary>
		/// <param name="key">key of the localization example "SUB_SUBSTANCE_NAME"</param>
		/// <param name="value">The Text what the user sees example "物質名"</param>
		public static void AddJpEntry(string key, string value)
		{
			if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
			{
				return;
			}

			JpLocalizations.Add(key, value);
		}

		/// <summary>
		/// Adds a new English localization (This does not call ReloadLocalizations)
		/// </summary>
		/// <param name="key">key of the localization example "SUB_SUBSTANCE_NAME"</param>
		/// <param name="value">The Text what the user sees example "substance name"</param>
		public static void AddEnEntry(string key, string value)
		{
			if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
			{
				return;
			}

			EnLocalizations.Add(key, value);
		}

		/// <summary>
		/// Reloads the Localizations (Happens automatically when the language is changed in the game)
		/// </summary>
		public static void ReloadLocalizations()
		{
			if (Localizer.table.name == "StringTable_en")
			{
				foreach (var keyValuePair in EnLocalizations)
				{
					Localizer.table.RemoveEntry(keyValuePair.Key);
					Localizer.table.AddEntry(keyValuePair.Key, keyValuePair.Value);
				}
			}
			else if (Localizer.table.name == "StringTable_ja")
			{
				foreach (var keyValuePair in JpLocalizations)
				{
					Localizer.table.RemoveEntry(keyValuePair.Key);
					Localizer.table.AddEntry(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

	}
}
