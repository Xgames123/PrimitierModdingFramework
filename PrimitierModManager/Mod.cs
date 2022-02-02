using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace PrimitierModManager
{



	[Serializable]
	public class Mod
	{
		[JsonProperty(Required = Required.Always)] public string DisplayName { get; set; }
		[JsonProperty(Required = Required.DisallowNull)] public string Authors { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)] public string Description { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)] public string Version { get; set; } = "v1.0";
		[JsonProperty(Required = Required.DisallowNull)] public bool IsGenerated { get; set; } = false;

		[JsonIgnore] public ICommand OnDisableCommand { get; set; }
		[JsonIgnore] public ICommand OnEnableCommand { get; set; }
		[JsonIgnore] public ICommand OnDeleteCommand { get; set; }
		[JsonIgnore] public string FileName;
		[JsonIgnore] public string Name;

		[JsonIgnore] public BitmapImage Image { get; set; }


		private void OnEnable(object? param)
		{
			ModManager.EnableMod(this);

		}
		private void OnDisable(object? param)
		{
			ModManager.DisableMod(this);
		}
		private void OnDelete(object? param)
		{

			ModManager.DeleteMod(this);
		}

		public void InitUI()
		{
			OnEnableCommand = new ActionCommand(OnEnable);
			OnDisableCommand = new ActionCommand(OnDisable);
			OnDeleteCommand = new ActionCommand(OnDelete);
		}



	}
}
