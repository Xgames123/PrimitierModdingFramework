using MaterialDesignThemes.Wpf;
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
	/// Interaction logic for MainMenu.xaml
	/// </summary>
	public partial class MainMenu : UserControl
	{
		public MainMenu()
		{
			InitializeComponent();
			ModManager.OnModsReloaded += OnModsReloaded;

			ModManager.ReloadMods();
		}

		private void OnModsReloaded()
		{
			ModList.ItemsSource = null;
			ModList.ItemsSource = ModManager.LoadedMods;
		}

		private void ReloadModsButton_Click(object sender, RoutedEventArgs e)
		{
			ModManager.ReloadMods();
		}

		private void LaunchPrimitierButton_Click(object sender, RoutedEventArgs e)
		{
			PrimitierLauncher.LaunchAndExit();
		}

		private void OnModEnableDisable(object sender, RoutedEventArgs e)
		{
			var button = sender as Button;

		}
	}
}
