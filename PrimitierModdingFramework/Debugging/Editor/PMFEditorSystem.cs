using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.Debugging.Editor
{
	public class PMFEditorSystem : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}
	}
}
