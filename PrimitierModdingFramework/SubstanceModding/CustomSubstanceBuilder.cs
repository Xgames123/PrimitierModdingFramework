using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework.SubstanceModding
{
	/// <summary>
	/// Base class for all CustomSubstanceBuilders.
	/// CustomSubstanceBuilders are used to generate custom substances 
	/// </summary>
	public abstract class CustomSubstanceBuilder
	{
		private static List<CustomSubstanceBuilder> s_customSubstanceBuilders = new List<CustomSubstanceBuilder>();


		/// <summary>
		/// Is true when the build method is called
		/// </summary>
		public bool HasBuild { get; private set; } = false;


		/// <summary>
		/// Registers the customSubstanceBuilder to build on OnSceneWasLoaded
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public static void RegisterBuilder<T>() where T : CustomSubstanceBuilder, new()
		{
			s_customSubstanceBuilders.Add(new T());
		}

		/// <summary>
		/// Registers the customSubstanceBuilder to build on OnSceneWasLoaded
		/// </summary>
		/// <param name="builderType"></param>
		public static void RegisterBuilder(Type builderType)
		{
			var obj = Activator.CreateInstance(builderType);

			s_customSubstanceBuilders.Add((CustomSubstanceBuilder)obj);
		}

		internal static void BuildAll()
		{
			PMFSystem.EnableSystem<CustomSubstanceSystem>();

			foreach (var builder in s_customSubstanceBuilders)
			{
				builder.Build();
			}
		}



		/// <summary>
		/// Builds the substance
		/// </summary>
		public void Build()
		{
			if (HasBuild)
			{
				throw new InvalidOperationException("Can't build a substance twice");
			}

			OnBuild();
			HasBuild = true;
		}

		/// <summary>
		/// Called when the custom substance needs to be build (In OnSceneWasLoaded)
		/// </summary>
		public abstract void OnBuild();

	}
}
