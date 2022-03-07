using Cocona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool.Commands
{
	public class EditorCommand
	{

		[PrimaryCommand()]
		public void Editor()
		{
#if INCLUDE_EDITOR
			//Start PMFEditor
#else
			ConsoleWriter.WriteLineError("PMF editor is not included in the current installation of PMFTool");
#endif

		}

	}
}