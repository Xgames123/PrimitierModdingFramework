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
			var errorPopup = App.MainWindow.ErrorPopup;
			errorPopup.Message.Content = error;
			errorPopup.IsActive = true;

		}

	}
}
