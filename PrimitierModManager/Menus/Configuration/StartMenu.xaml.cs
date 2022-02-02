using MaterialDesignThemes.Wpf.Transitions;
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

namespace PrimitierModManager.Menus.Configuration
{
	/// <summary>
	/// Interaction logic for StartMenu.xaml
	/// </summary>
	public partial class StartMenu : UserControl
	{
		public StartMenu()
		{
			InitializeComponent();
		}

		private void NextButtonClick(object sender, RoutedEventArgs e)
		{
			Transitioner.MoveNextCommand.Execute(null, (IInputElement)sender);

		}

	}
}
