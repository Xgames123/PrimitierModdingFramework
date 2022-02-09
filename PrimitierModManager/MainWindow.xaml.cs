using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public void SwitchMenu(int menuIndex)
		{
			var oldMenu = (IMenu)((TransitionerSlide)Transitioner.SelectedItem).Content;
			oldMenu?.OnClose();
			Transitioner.SelectedIndex = menuIndex;
			var newMenu = (IMenu)((TransitionerSlide)Transitioner.SelectedItem).Content;
			newMenu?.OnOpen();

		}

		public MainWindow()
		{
			App.MainWindow = this;
			InitializeComponent();

			SwitchMenu(0);

			var version = Assembly.GetEntryAssembly().GetName().Version;
			Title = "Primitier mod manager v"+version.ToString(3);

		}


		private void ErrorPopupOk(object sender, RoutedEventArgs e)
		{
			ErrorPopup.IsActive = false;
		}
	}
}
