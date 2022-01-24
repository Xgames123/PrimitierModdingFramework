using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFInstaller
{
	public static class ErrorHandeler
	{

		public static void ShowError(string error)
		{
			if (App.MainWindow == null)
			{
				return;
			}

			var errorPopup = App.MainWindow.ErrorPopup;
			errorPopup.Message.Content ="Error:"+error;
			errorPopup.IsActive = true;

		}

	}
}
