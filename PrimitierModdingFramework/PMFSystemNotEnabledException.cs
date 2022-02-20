using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	/// <summary>
	/// Thrown when a system is called that is not enabled
	/// </summary>
	public class PMFSystemNotEnabledException : Exception
	{

		public PMFSystemNotEnabledException(Type systemType) : this(systemType.FullName)
		{
			
		}
		public PMFSystemNotEnabledException(Type systemType, Exception innerException) : this(systemType.FullName, innerException)
		{

		}


		public PMFSystemNotEnabledException(string systemName) : base($"System '{systemName}' is not enabled")
		{

		}

		public PMFSystemNotEnabledException(string systemName, Exception innerException) : base($"System '{systemName}' is not enabled", innerException)
		{

		}

	}
}
