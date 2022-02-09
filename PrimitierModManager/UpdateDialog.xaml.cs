using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimitierModManager
{
	/// <summary>
	/// Interaction logic for UpdateDialog.xaml
	/// </summary>
	public partial class UpdateDialog : UserControl
	{


		public UpdateDialog(Uri link)
		{
			InitializeComponent();
			HyperLink.NavigateUri = link;
		}

		private void Hyperlink_Click(object sender, RequestNavigateEventArgs e)
		{
			var processInfo = new ProcessStartInfo(e.Uri.AbsoluteUri);
			processInfo.UseShellExecute = true;
			Process.Start(processInfo);
			e.Handled = true;
		}

		

	}
}
