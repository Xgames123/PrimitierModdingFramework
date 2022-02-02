using MaterialDesignThemes.Wpf;
using PrimitierModManager.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
	/// Interaction logic for MainMenu.xaml
	/// </summary>
	public partial class MainMenu : UserControl, IMenu
	{
		public MainMenu()
		{
			InitializeComponent();
			ModManager.OnModListsUpdate += OnModListsUpdate;
		}

		void IMenu.OnOpen()
		{
			ModManager.ReloadMods();
		}
		void IMenu.OnClose()
		{
			
		}


		private void OnModListsUpdate()
		{
			ModList.ItemsSource = null;
			ModList.ItemsSource = ModManager.LoadedMods;
			ActiveModList.ItemsSource = null;
			ActiveModList.ItemsSource = ModManager.ActiveMods;
		}

		private void ReloadModsButton_Click(object sender, RoutedEventArgs e)
		{
			ModManager.ReloadMods();
		}

		private void LaunchPrimitierButton_Click(object sender, RoutedEventArgs e)
		{
			ButtonProgressAssist.SetIsIndicatorVisible(LaunchPrimitierButton, true);

			ButtonProgressAssist.SetIsIndicatorVisible(LaunchPrimitierButton, true);
			Task.Factory.StartNew(() => PrimitierLauncher.LaunchWithSelectedMods())
			.ContinueWith(t =>
			{
				Dispatcher.Invoke(()=>
				{
					ButtonProgressAssist.SetIsIndicatorVisible(LaunchPrimitierButton, false);
				});
				Thread.Sleep(500);
				App.MainWindow.Close();
			});



		}

		private void OnFileDrop(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
				return;

			var fileDropData = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (fileDropData == null)
			{
				return;
			}
			for (int i = 0; i < fileDropData.Length; i++)
			{
				string filePath = fileDropData[i];
				if(filePath == null)
				{
					continue;
				}

				ModManager.AddMod(filePath);

			}


		


		}
	}
}
