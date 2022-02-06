using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModManager
{
	public static class PopupManager
	{
		public static void ShowUpdatePopup(string link)
		{
			throw new NotImplementedException("Update popup is not implemented");

		}


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
