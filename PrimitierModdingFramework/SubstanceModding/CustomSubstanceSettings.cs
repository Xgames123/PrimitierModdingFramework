using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.SubstanceModding
{
	/// <summary>
	/// Extra settings for a custom substance
	/// </summary>
	public class CustomSubstanceSettings
	{
		/// <summary>
		/// Called when the substance is initialized so when the world loads or a new instance of your substance it created.
		/// This is used to add components or do other things with the substance.
		/// </summary>
		public Action<CubeBase> OnSubstanceInitialize = null;

		/// <summary>
		/// Same as OnSubstanceInitialize except it is called before the game initializes the cube base
		/// </summary>
		public Action<CubeBase> OnEarlySubstanceInitialize = null;

		/// <summary>
		/// Function used to add a custom cube behaviour to the cubeBase
		/// </summary>
		public Func<CubeBase, ICustomCubeBehaviour> AddCustomCubeBehaviour;

		/// <summary>
		/// Japanese name of the substance
		/// </summary>
		public string JpName = "";
		/// <summary>
		/// English name of the substance
		/// </summary>
		public string EnName = "";

	}
}
