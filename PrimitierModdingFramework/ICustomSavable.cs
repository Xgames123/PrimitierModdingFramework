using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public interface ICustomSavable
	{
		string Save();
	    void Load(string json);
	}
}
