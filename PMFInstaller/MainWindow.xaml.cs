using System;
using System.Collections.Generic;
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

namespace PMFInstaller
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public UserControl ActiveMenu { get; private set; }

		public void SwitchMenu(UserControl newMenu)
		{
			if (ActiveMenu != null)
			{
				Grid.Children.Remove(ActiveMenu);
			}
			ActiveMenu = newMenu;
			if (ActiveMenu != null)
			{
				Grid.Children.Add(ActiveMenu);
			}
			
		}

		public MainWindow()
		{
			InitializeComponent();

			SwitchMenu(new MainMenu());
		}




		private void ErrorPopupOk(object sender, RoutedEventArgs e)
		{
			ErrorPopup.IsActive = false;
		}
	}
}
