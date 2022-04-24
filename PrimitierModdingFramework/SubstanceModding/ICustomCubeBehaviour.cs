using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.SubstanceModding
{
	/// <summary>
	/// Add this interface to a class to create a custom ICubeBehaviour
	/// </summary>
	public interface ICustomCubeBehaviour
	{

		void OnFragmentInitialized(CubeBase fragmentCubeBase);
		void OnCollideWithCube(CubeBase colCubeBase);
	}
}
