using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.Debugging.Editor
{
	/// <summary>
	/// base class for all the editor windows
	/// </summary>
	public abstract class EditorWindow
	{

		protected internal virtual void OnGlobalMenuBar() { }


		protected internal abstract void OnDraw();



	}
}
