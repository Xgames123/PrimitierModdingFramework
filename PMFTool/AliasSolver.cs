using PMFTool.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public static class AliasSolver
	{
		public static string Solve(string value, RunMode mode, ConfigFile config)
		{
			foreach (var alias in config.Aliases)
			{
				if (alias.RunMode != null)
				{
					if (mode != alias.RunMode)
					{
						continue;
					}
				}

				if (alias.Name.ToLower() == value.ToLower())
				{
					return alias.Value;
				}
			}

			return value;

		}

			
	}
}
