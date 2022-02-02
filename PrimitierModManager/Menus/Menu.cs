using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PrimitierModManager
{
	public interface IMenu
	{
		public void OnOpen() { }
		public void OnClose() { }

	}
}
